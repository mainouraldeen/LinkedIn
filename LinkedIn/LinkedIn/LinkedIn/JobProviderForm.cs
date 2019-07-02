using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace LinkedIn
{
    public partial class JobProviderForm : MaterialSkin.Controls.MaterialForm
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        string ordb = "Data source=ORCL;User Id=scott;Password=tiger;";
        string constr = "Data Source=orcl; User Id=scott;Password=tiger;";


        public JobProviderForm()
        {
            InitializeComponent();
        }

        private void companyProfiletabPage_Click(object sender, EventArgs e)
        {

        }

        private void JobProviderForm_Load(object sender, EventArgs e)
        {

            string cmdstr = "select * from post_jobprovider;";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            postsDataGridView.DataSource = ds.Tables[0];


            // connected mode  , select muliple rows with stored procedure
            OracleConnection con;
            con = new OracleConnection(ordb);
            con.Open();
            // get phone numbers to combobox
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "getProviderphone";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("providerid", LoginRegisterForm.outputID);
            cmd.Parameters.Add("phone", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                phoneCompanyComboBox1.Items.Add(reader[0].ToString());
               // experienceListView.Items.Add("Years of experience: " + reader[1].ToString() + "\n");
            }
            reader.Close();
            //get city and country
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = con;
            cmd2.CommandText = "getProvidercitycountry";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("providerid", LoginRegisterForm.outputID);
            cmd2.Parameters.Add("citycountry", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader readr = cmd2.ExecuteReader();
            while (readr.Read())
            {
                cityComboBox.Items.Add(readr[0].ToString());
                countryCompanycomboBox.Items.Add( readr[1].ToString());
                //projectsListView.Items.Add("End date: "+readr[2].ToString()+"\n");
            }
            readr.Close();


        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            OracleConnection con;
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "deletingAccount";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", LoginRegisterForm.outputID);
            cmd.ExecuteNonQuery();
            MessageBox.Show("account deleted");
            con.Dispose();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            
            LoginRegisterForm jpform = new LoginRegisterForm();
            this.Hide();
            jpform.ShowDialog();
            this.Close();

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void addVacancy_vacancy_button_Click(object sender, EventArgs e)
        {
            OracleConnection conn;
            conn = new OracleConnection(ordb);
            conn.Open();
            string vacancytitle = VacancyTitlecomboBox.Text; 
            int jpID = LoginRegisterForm.outputID;
            DateTime publishdate = DateTime.Now;
            string domain = vacancyDomain_txtBox.Text;
            string vacancytype = vacancyTypecomboBox.Text;
            int years = Convert.ToInt32(yearsOfExperience_vacancy_txtBox.Text);

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insertVacancyData";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("vacancyTitle", vacancytitle);
            cmd.Parameters.Add("jpid", jpID);
            cmd.Parameters.Add("date", publishdate);
            cmd.Parameters.Add("domain", domain);
            cmd.Parameters.Add("type", vacancytype);
            cmd.Parameters.Add("years", years);
            cmd.ExecuteNonQuery();

            MessageBox.Show("vacancy added.\n");

            vacancyDomain_txtBox.Text = "";
            VacancyTitlecomboBox.Text = "";
            vacancyTypecomboBox.Text = "";
            yearsOfExperience_vacancy_txtBox.Text = "";

        }

        private void posts_Click(object sender, EventArgs e)
        {
           
           
            string cmdstr = "select * from post_jobprovider where jobprovider_id=:id;";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("id", LoginRegisterForm.outputID);

            ds = new DataSet();
            adapter.Fill(ds);
            postsDataGridView.DataSource = ds.Tables[0];

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }
    }
}

    
