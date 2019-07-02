using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Import the Material Skin
using MaterialSkin;
using MaterialSkin.Controls;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace LinkedIn
{
    public partial class JobSeekerRgisterForm :MaterialForm
    {
        string gender, city, country, edu;
        int phone;
        List<string> certificates = new List<string>();
        List<string> companyName = new List<string>(), yearsOfExp = new List<string>(), jobTitle = new List<string>();
        List<string> skills = new List<string>();
        List<string> interest = new List<string>();
        List<string> courses = new List<string>();
        List<DateTime> startDate = new List<DateTime>(), endDate = new List<DateTime>();
        List<string[]> technology = new List<string[]>();


        public JobSeekerRgisterForm()
        {
            InitializeComponent();
            PhoneNumber_txtBox.BackColor = Color.AliceBlue;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buildCVtabPage_Click(object sender, EventArgs e)
        {

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.AntiqueWhite;
        }

        private void PhoneNumber_txtBox_Click(object sender, EventArgs e)
        {
            
        }

        private void CityLabel_Click(object sender, EventArgs e)
        {

        }

        private void Next_buildCV_Button_Click(object sender, EventArgs e)
        {
            phone = Convert.ToInt32(PhoneNumber_txtBox.Text);
            if (femaleRadioButton.Checked)
                gender = "F";
            else gender = "M";
            city = cityComboBox.SelectedItem.ToString();
            country = countryCompanycomboBox.SelectedItem.ToString();
            edu = educationComboBox.SelectedItem.ToString();
            materialTabControl1.SelectTab("ExperiencetabPage");

        }

        private void Next_addExp_button_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab("ProjectstabPage");
        }

        private void addSkillButton_Click(object sender, EventArgs e)
        {
            skills.Add(Skills_txtBox.Text);
            MessageBox.Show("ADDED");
            Skills_txtBox.Text = "";
        }

        private void addInterestButton_Click(object sender, EventArgs e)
        {
            interest.Add(Interests_txtBox.Text);
            MessageBox.Show("ADDED");
            Interests_txtBox.Text = "";
        }

        private void back_addProjButton_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab("ExperiencetabPage");        
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            countryCompanycomboBox.Items.Clear();
            countryCompanycomboBox.Text = "";
            if (cityComboBox.Text == "Egypt")
            {
                countryCompanycomboBox.Items.Add("Cairo");
                countryCompanycomboBox.Items.Add("Alexandria");
                countryCompanycomboBox.Items.Add("Giza");
            }
            else if (cityComboBox.Text == "Dubai")
            {
                countryCompanycomboBox.Items.Add("Emirates");
                countryCompanycomboBox.Items.Add("Al-Ain");
            }
            else if (cityComboBox.Text == "Saudi Aribya")
            {
                countryCompanycomboBox.Items.Add("Al-Ryad");
                countryCompanycomboBox.Items.Add("Geddah");
                countryCompanycomboBox.Items.Add("Al-Damam");

            }
        }

        private void addProject_button_Click(object sender, EventArgs e)
        {
            technology.Add(tools_txtBox.Text.Split(','));
            startDate.Add(startdateTimePicker1.Value);
            endDate.Add(enddateTimePicker.Value);
            MessageBox.Show("ADDED");
            tools_txtBox.Text = "";
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            courses.Add(Courses_txtBox.Text);
            MessageBox.Show("ADDED");
            Courses_txtBox.Text = "";
        }

        private void AddCertificate_button_Click(object sender, EventArgs e)
        {
            certificates.Add(Certifacates_txtBox.Text);
            MessageBox.Show("ADDED");
            Certifacates_txtBox.Text = "";
        }

        private void finishCV_button_Click_1(object sender, EventArgs e)
        {
            string ordb = "Data source=ORCL;User Id=scott;Password=tiger;";
            OracleConnection con;
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            //A) 3- insert
            cmd.CommandText = @"insert into job_seeker (jobseeker_id ,seekername , seekerpassword, email , gender , phone , city , country , education)
                                                    values(:seekerId , :seekerName, :seekerPass, :seekerEmail , :seekerGender, :seekerPhone, :seekerCity, :seekerCountry, :seekerEdu)";
            cmd.Parameters.Add("seekerId", LoginRegisterForm.newId);
            cmd.Parameters.Add("seekerName", LoginRegisterForm.providerOrSeekerName);
            cmd.Parameters.Add("seekerPass", LoginRegisterForm.providerOrSeekerPassword);
            cmd.Parameters.Add("seekerEmail", LoginRegisterForm.providerOrSeekerEmail);
            cmd.Parameters.Add("seekerGender", gender);
            cmd.Parameters.Add("seekerPhone", phone);
            cmd.Parameters.Add("seekerCity", city);
            cmd.Parameters.Add("seekerCountry", country);
            cmd.Parameters.Add("seekerEdu", edu);
            cmd.ExecuteNonQuery();
            //adding experience
            int maxId, newId;
            for (int i = 0; i < companyName.Count; i++)
            {
                OracleCommand cmdID = new OracleCommand();
                cmdID.Connection = con;
                cmdID.CommandText = "getExpId";
                cmdID.CommandType = CommandType.StoredProcedure;
                cmdID.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
                cmdID.ExecuteNonQuery();
                try
                {
                    maxId = Convert.ToInt32(cmdID.Parameters["id"].Value.ToString());
                    newId = maxId + 1;
                }
                catch { newId = 1; }
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = con;
                //A) 3- insert
                cmd2.CommandText = @"insert into EXPERIENCE (EXPERIENCE_ID,COMPANY_NAME ,YEARS_OF_EXPERIENCE , JOBSEEKER_ID,JOB_TITLE)
                                                    values(:EXPERIENCE_ID, :companyName , :yearsOfExp, :JOBSEEKER_ID, :JOB_TITLE)";
                cmd2.Parameters.Add("EXPERIENCE_ID", newId);
                cmd2.Parameters.Add("companyName", companyName[i]);
                cmd2.Parameters.Add("yearsOfExp", yearsOfExp[i]);
                cmd2.Parameters.Add("JOBSEEKER_ID", LoginRegisterForm.newId);
                cmd2.Parameters.Add("JOB_TITLE", jobTitle[i]);
                cmd2.ExecuteNonQuery();
            }
            //adding skills
            for (int i = 0; i < skills.Count; i++)
            {
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = con;
                //A) 3- insert
                cmd2.CommandText = @"insert into JOB_SEEKER_SKILLS (SKILLS,JOBSEEKER_ID)
                                                    values(:skills, :seekerid)";
                cmd2.Parameters.Add("skills", skills[i]);
                cmd2.Parameters.Add("JOBSEEKER_ID", LoginRegisterForm.newId);
                cmd2.ExecuteNonQuery();
            }
            // adding interests
            for (int i = 0; i < interest.Count; i++)
            {
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = con;
                //A) 3- insert
                cmd2.CommandText = @"insert into JOB_SEEKER_INTERESTS (INTERESTS,JOBSEEKER_ID)
                                                    values(:INTERESTS, :JOBSEEKER_ID)";
                cmd2.Parameters.Add("INTERESTS", interest[i]);
                cmd2.Parameters.Add("JOBSEEKER_ID", LoginRegisterForm.newId);
                cmd2.ExecuteNonQuery();
            }
            //adding courses
            for (int i = 0; i < courses.Count; i++)
            {
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = con;
                //A) 3- insert
                cmd2.CommandText = @"insert into JOB_SEEKER_COURSES (COURSE,JOBSEEKER_ID)
                                                    values(:COURSE, :JOBSEEKER_ID)";
                cmd2.Parameters.Add("COURSE", courses[i]);
                cmd2.Parameters.Add("JOBSEEKER_ID", LoginRegisterForm.newId);
                cmd2.ExecuteNonQuery();
            }
            //adding certificates
            for (int i = 0; i < certificates.Count; i++)
            {
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = con;
                //A) 3- insert
                cmd2.CommandText = @"insert into JOB_SEEKER_CERTIFICATES (CERTIFICATE,JOBSEEKER_ID)
                                                    values(:CERTIFICATE, :JOBSEEKER_ID)";
                cmd2.Parameters.Add("CERTIFICATE", certificates[i]);
                cmd2.Parameters.Add("JOBSEEKER_ID", LoginRegisterForm.newId);
                cmd2.ExecuteNonQuery();
            }
            //adding projects
            for (int i = 0; i < startDate.Count; i++)
            {
                OracleCommand cmdIDProject = new OracleCommand();
                cmdIDProject.Connection = con;
                cmdIDProject.CommandText = "getProjectrId";
                cmdIDProject.CommandType = CommandType.StoredProcedure;
                cmdIDProject.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
                cmdIDProject.ExecuteNonQuery();
                try
                {
                    maxId = Convert.ToInt32(cmdIDProject.Parameters["id"].Value.ToString());
                    newId = maxId + 1;
                }
                catch { newId = 1; }
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = con;
                //A) 3- insert
                cmd2.CommandText = @"insert into PROJECT_JS (PROJECT_ID,START_DATE ,END_DATE , JOBSEEKER_ID)
                                                    values(:PROJECT_ID, :START_DATE , :END_DATE, :JOBSEEKER_ID)";
                cmd2.Parameters.Add("PROJECT_ID", newId);
                cmd2.Parameters.Add("START_DATE", startDate[i]);
                cmd2.Parameters.Add("END_DATE", endDate[i]);
                cmd2.Parameters.Add("JOBSEEKER_ID", LoginRegisterForm.newId);
                cmd2.ExecuteNonQuery();
                for (int j = 0; j < technology[i].Length; j++)
                {
                    OracleCommand cmd3 = new OracleCommand();
                    cmd3.Connection = con;
                    //A) 3- insert
                    cmd3.CommandText = @"insert into PROJECT_JS_TECHNOLOGY (TECHNOLOGY,PROJECT_ID )
                                                    values(:TECHNOLOGY, :PROJECT_ID)";
                    cmd3.Parameters.Add("TECHNOLOGY", technology[i][j]);
                    cmd3.Parameters.Add("PROJECT_ID", newId);
                    cmd3.ExecuteNonQuery();
                }
            }
            LoginRegisterForm loginform = new LoginRegisterForm();
            this.Hide();
            loginform.ShowDialog();
            this.Close();

        }

        private void addExperience_button_Click(object sender, EventArgs e)
        {
            companyName.Add(CompanyName_txtBox.Text);
            yearsOfExp.Add(yearsOfExperience_txtBox.Text);
            jobTitle.Add(jobTitle_txtBox.Text);
            MessageBox.Show("ADDED");
            CompanyName_txtBox.Text = "";
            jobTitle_txtBox.Text = "";
            yearsOfExperience_txtBox.Text = "";

        }

        private void next_addProject_button_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab("profilePictabPage");
        }

      

        

        private void JobSeekerRgisterForm_Load(object sender, EventArgs e)
        {

        }

        private void back_addexpButton_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab("buildCVtabPage");
        }
    }
}
