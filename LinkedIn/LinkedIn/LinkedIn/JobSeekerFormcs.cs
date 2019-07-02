using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace LinkedIn
{
    public partial class JobSeekerFormcs : MaterialSkin.Controls.MaterialForm
    {
        string ordb = "Data source=ORCL;User Id=scott;Password=tiger;";
        public JobSeekerFormcs()
        {
            InitializeComponent();
        }

        private void JobSeekerFormcs_Load(object sender, EventArgs e)
        {
            // loading profile
            // connected mode  , select muliple rows with stored procedure
            OracleConnection con;
            con = new OracleConnection(ordb);
            con.Open();
            // get experience
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "getSeekerExperience";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("seekerId", LoginRegisterForm.outputID);
            cmd.Parameters.Add("exp", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                experienceListView.Items.Add("Company name: " + reader[0].ToString() + "\n");
                experienceListView.Items.Add("Years of experience: " + reader[1].ToString() + "\n");
            }
            reader.Close();
            //get projects
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = con;
            cmd2.CommandText = "getSeekerProjects";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("seekerId", LoginRegisterForm.outputID);
            cmd2.Parameters.Add("proj", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader readr = cmd2.ExecuteReader();
            while (readr.Read())
            {
                projectsListView.Items.Add("Project ID: " + readr[0].ToString() + "\n");
                projectsListView.Items.Add("Start date: " + readr[1].ToString() + "\n");
                //projectsListView.Items.Add("End date: "+readr[2].ToString()+"\n");
            }
            readr.Close();

            //-------------------------------------------------------------
            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = con;
            cmd3.CommandText = @"select seekername , email , gender , city , country , phone, EDUCATION
                                 from job_seeker where jobseeker_id = :outputid";
            cmd3.Parameters.Add("outputid", LoginRegisterForm.outputID);
            OracleDataReader r = cmd3.ExecuteReader();
            while (r.Read())
            {
                nameLabel.Text = r[0].ToString();
                emailLabel.Text = r[1].ToString();
                femaleORmaleLabel.Text = r[2].ToString();
                cityLabel.Text = r[3].ToString();
                countryLabel.Text = r[4].ToString();
                phoneLabel.Text = r[5].ToString();
                educationLabel.Text = r[6].ToString();
            }
            r.Close();

            if (femaleORmaleLabel.Text == "F")
                femaleORmaleLabel.Text = "Female";
            else if (femaleORmaleLabel.Text == "M")
                femaleORmaleLabel.Text = "Male";


            //------------------------------
            //nada
            //loading notifications
            List<string> suitableVacancies = new List<string>();
            OracleCommand cmd4 = new OracleCommand();
            cmd4.Connection = con;
            cmd4.CommandText = "getSeekerInterests";
            cmd4.CommandType = CommandType.StoredProcedure;
            cmd4.Parameters.Add("seekerId", LoginRegisterForm.outputID);
            cmd4.Parameters.Add("interests", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader reader2 = cmd4.ExecuteReader();
            DataTable dtable = new DataTable();
            DataRow data;

            BindingSource source = new BindingSource();


            dtable.Columns.Add("Job Provider Name");
            dtable.Columns.Add("Vacancy Title");
            dtable.Columns.Add("Published Data");
            dtable.Columns.Add("Domain");
            dtable.Columns.Add("Type");
            dtable.Columns.Add("Years");
            dtable.Columns.Add("jobprovider id");
            while (reader2.Read())
            {
                string x = reader2[0].ToString();
                OracleCommand cmd5 = new OracleCommand();
                cmd5.Connection = con;
                cmd5.CommandText = "displaySuitableVacancies";
                cmd5.CommandType = CommandType.StoredProcedure;
                cmd5.Parameters.Add("seekerInterest", reader2[0].ToString());
                cmd5.Parameters.Add("vacancies", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader reader3 = cmd5.ExecuteReader();
     
                while (reader3.Read())
                {
                    string y = reader2[0].ToString();

                    data = dtable.NewRow();
                    
                    data["Job Provider Name"] = reader3[0];
                    data["Vacancy title"] = reader3[1];
                    data["Published Data"] = reader3[2];
                    data["Domain"] = reader3[3];
                    data["Type"] = reader3[4];
                    data["Years"] = reader3[5];
                    data["jobprovider id"] = reader3[6];
                    dtable.Rows.Add(data);
                }
                source.DataSource = dtable;
                //suitableVacanciesDataGridView.DataSource = dtable;
                suitableVacanciesDataGridView.DataSource = source;
                suitableVacanciesDataGridView.Refresh();
                reader3.Close();
            }
            reader2.Close();

            con.Dispose();


            //filling dataGridView with suitableVacancies and adding a button to apply
            //msh sha8alaaaaa lsa
            int index = 0;
            //while(index * 6 < suitableVacancies.Count)
            //{
            //    dtable.Columns.Add(suitableVacancies[0]);
            //    dtable.Columns.Add(suitableVacancies[1]);
            //    dtable.Columns.Add(suitableVacancies[2]);
            //    dtable.Columns.Add(suitableVacancies[3]);
            //    dtable.Columns.Add(suitableVacancies[4]);
            //    dtable.Columns.Add(suitableVacancies[5]);

            //    ++index;
            //}
            ////suitableVacancies.Count.ToString() = 0 mada2yn
            //MessageBox.Show(suitableVacancies.Count.ToString());
            ////suitableVacanciesDataGridView.Colu
            //------------------------------------------------------------------------------------------------
            //disconnected mode , master detail

            DataSet ds = new DataSet();

            OracleDataAdapter adapter1 = new OracleDataAdapter("select JOBSEEKER_ID, SEEKERNAME, CITY, COUNTRY, PHONE, GENDER, EMAIL, EDUCATION from JOB_SEEKER", ordb);
            adapter1.Fill(ds, "seeker");

            string cmdstr = @"select jobseeker_id , description
                                from post           
             where jobseeker_id in (select js_follow_jsjobseeker_id_2 from JS_FOLLOW_JS where jobseeker_id_1 = :outputid)";
            OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("outputid", LoginRegisterForm.outputID);
            adapter.Fill(ds, "Post");


            DataRelation relation = new DataRelation("fk", ds.Tables[1].Columns["JOBSEEKER_ID"],
                                                            ds.Tables[0].Columns["JOBSEEKER_ID"], false);
            ds.Relations.Add(relation);
            BindingSource bindingSourceParent = new BindingSource(ds, "post");
            BindingSource bindingSourceChild = new BindingSource(bindingSourceParent, "fk");
            postsDataGridView.DataSource = bindingSourceParent;
            seekerDataGridView.DataSource = bindingSourceChild;

        }

        private void Home_Click(object sender, EventArgs e)
        {

        }



        private void postsDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //seekerDataGridView.Show();
            String seekerString = "";
            for (int i = 0; i < seekerDataGridView.RowCount - 1; i++)
            {
                seekerString += "Name: " + seekerDataGridView.Rows[i].Cells[1].Value + "\n";
                seekerString += "Email: " + seekerDataGridView.Rows[i].Cells[6].Value + "\n";
                seekerString += "Phone: " + seekerDataGridView.Rows[i].Cells[4].Value + "\n";
                seekerString += "City: " + seekerDataGridView.Rows[i].Cells[2].Value + "\n";
                seekerString += "Country: " + seekerDataGridView.Rows[i].Cells[3].Value + "\n";
                seekerString += "Education: " + seekerDataGridView.Rows[i].Cells[7].Value + "\n";
            }
            seekerRichTextBox.Text = seekerString;
            seekerRichTextBox.Show();
            followBunifuThinButton.Show();
        }

        private void writePostButton_Click(object sender, EventArgs e)
        {
            if (writePostBunifuMetroTextbox.Text != "" && writePostBunifuMetroTextbox.Text != "What's on your mind?")
            {
                int maxId, newId;
                OracleConnection con;
                con = new OracleConnection(ordb);
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "getPostID";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
                cmd.ExecuteNonQuery();
                try
                {
                    maxId = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                    newId = maxId + 1;
                }
                catch { newId = 1; }
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = con;
                cmd2.CommandText = "writePost";
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add("postId", newId);
                cmd2.Parameters.Add("postDescription", writePostBunifuMetroTextbox.Text.ToString());
                cmd2.Parameters.Add("seekerId", LoginRegisterForm.outputID);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Post Shared.");
                con.Dispose();
            }

        }

        private void followBunifuThinButton_Click(object sender, EventArgs e)
        {
            string followingSeekerId = seekerDataGridView.Rows[0].Cells[0].Value.ToString();
            OracleConnection con;
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = @"insert into js_follow_js (jobseeker_id_1 , js_follow_jsjobseeker_id_2) 
                                values (:outputid , :followingSeekerId)";
            cmd.Parameters.Add("outputid", LoginRegisterForm.outputID);
            cmd.Parameters.Add("followingSeekerId", followingSeekerId);
            cmd.ExecuteNonQuery();
            MessageBox.Show("DONE");

        }

        private void Profile_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel11_Click(object sender, EventArgs e)
        {

        }
        

        //nada
        //search button
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel12_Click(object sender, EventArgs e)
        {

        }

        private void countryLabel_Click(object sender, EventArgs e)
        {

        }

        private void cityLabel_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel10_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel9_Click(object sender, EventArgs e)
        {

        }

        private void phoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void femaleORmaleLabel_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void educationLabel_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        //suitableVacanciesDataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = new DataGridViewRow();
            //int selectedRowIndex = suitableVacanciesDataGridView.SelectedRows.
            //e.RowIndex
        }

        private void suitableVacanciesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OracleConnection con;
            con = new OracleConnection(ordb);
            con.Open();
            int rowIndex = e.RowIndex;
            DataGridViewRow row = suitableVacanciesDataGridView.Rows[rowIndex];
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = @"select jobprovider_ID from job_provider 
                                where providername = :providerName";
            //MessageBox.Show
            cmd.Parameters.Add("providerName", row.Cells[0].Value.ToString());
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = con;
                cmd2.CommandText = @"insert into apply_vacancy 
                        values(:seekerId, :vacancyTitle, :jobProviderId)";
                cmd2.Parameters.Add("sID",  LoginRegisterForm.outputID);
                cmd2.Parameters.Add("vTitle", row.Cells[1].Value.ToString());
                cmd2.Parameters.Add("jpID", reader[0].ToString());
                cmd2.ExecuteNonQuery();
            }
            reader.Close();
            con.Dispose();
            MessageBox.Show("Applied");


        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            OracleConnection con;
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            if (searchByCompanyRadioButton.Checked)
            {
                cmd.CommandText = "displayProviderPosts";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("providerTitle", searchByTextBox.Text);
                cmd.Parameters.Add("posts", OracleDbType.RefCursor, ParameterDirection.Output);
            }
            else if (searchBySkillRadioButton.Checked)
            {
                cmd.CommandText = "displayCompaniesByJobTitle";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("jobTitle", searchByTextBox.Text);
                cmd.Parameters.Add("companies", OracleDbType.RefCursor, ParameterDirection.Output);
            }
            OracleDataReader reader = cmd.ExecuteReader();
            postsListView.Clear();
            while (reader.Read())
            {
                postsListView.Items.Add(reader[0].ToString() + "\n");
            }
            reader.Close();
        }
        string selectedProviderId;
        string selectedVacancyTitle;
        private void applyButton_Click(object sender, EventArgs e)
        {
            OracleConnection con;
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into APPLY_VACANCY values(:seekerID, :vacancy_title, :providerId)";
            cmd.Parameters.Add("sID", LoginRegisterForm.outputID);
            cmd.Parameters.Add("vTitle", selectedVacancyTitle);
            cmd.Parameters.Add("pID",selectedProviderId);

            cmd.ExecuteNonQuery();
            con.Dispose();

        }


        private void suitableVacanciesDataGridView_Click(object sender, EventArgs e)
        {
             selectedProviderId = suitableVacanciesDataGridView.CurrentRow.Cells[6].Value.ToString();
             selectedVacancyTitle = suitableVacanciesDataGridView.CurrentRow.Cells[1].Value.ToString();


            //OracleConnection con;
            //con = new OracleConnection(ordb);
            //con.Open();
            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = con;
            //cmd.CommandText ="select from";

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            LoginRegisterForm jpform = new LoginRegisterForm();
            this.Hide();
            jpform.ShowDialog();
            this.Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
//LoginRegisterForm.outputID