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
    public partial class JobProviderRegisterForm : MaterialSkin.Controls.MaterialForm
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public JobProviderRegisterForm()
        {
            InitializeComponent();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void citycompanyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            countryCompanycomboBox.Items.Clear();
            countryCompanycomboBox.Text = "";
            if (citycompanyComboBox.Text == "Egypt")
            {
                countryCompanycomboBox.Items.Add("Cairo");
                countryCompanycomboBox.Items.Add("Alexandria");
                countryCompanycomboBox.Items.Add("Giza");
            }
            else if (citycompanyComboBox.Text == "Dubai")
            {
                countryCompanycomboBox.Items.Add("Emirates");
                countryCompanycomboBox.Items.Add("Al-Ain");
            }
            else if (citycompanyComboBox.Text == "Saudi Aribya")
            {
                countryCompanycomboBox.Items.Add("Al-Ryad");
                countryCompanycomboBox.Items.Add("Geddah");
                countryCompanycomboBox.Items.Add("Al-Damam");

            }
        }

        private void JobProviderRegisterForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void addLocation_company_button_Click(object sender, EventArgs e)
        {
            string city = citycompanyComboBox.Text;
            string country = countryCompanycomboBox.Text;
            int jpID = LoginRegisterForm.newId;
            //string title = LoginRegisterForm.providerOrSeekerName;


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insertJPLocation";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("jpID", jpID);
            cmd.Parameters.Add("city", city.ToString());
            cmd.Parameters.Add("country", country.ToString());
            cmd.ExecuteNonQuery();
            
            //int r = cmd.ExecuteNonQuery();
            //if (r != -1)
            //{
                MessageBox.Show("Location Added\n");
            //}

            citycompanyComboBox.Text = "";
            countryCompanycomboBox.Text = "";
        }

        private void AddphoneButton_Click(object sender, EventArgs e)
        {
            int PhoneNum = Convert.ToInt32(phoneNumber_company_txtBox.Text);
            int jpID = LoginRegisterForm.newId;
            // string title = LoginRegisterForm.providerOrSeekerName;
            phoneNumber_company_txtBox.Text = "";
            //
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insertProviderPhoneNumber";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("phonenum", PhoneNum);
            cmd.Parameters.Add("jpID", jpID);
            //cmd.Parameters.Add("title", title);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("phone Added\n");
            }

        }


        private void Finish_addCompany_button_Click(object sender, EventArgs e)
        {
            saveJPdata();
        }
        private void saveJPdata()
        {

            int jpID = LoginRegisterForm.newId;
            string name = LoginRegisterForm.providerOrSeekerName;
            string email = LoginRegisterForm.providerOrSeekerEmail;
            string pass = LoginRegisterForm.providerOrSeekerPassword;
            //string logoPath = picturePath_company_txtBox.Text;
            //
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insertProviderData";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("jpID", jpID);
            cmd.Parameters.Add("name", name);
            cmd.Parameters.Add("email", email);
            cmd.Parameters.Add("pass", pass);

            cmd.ExecuteNonQuery();
            //int r = cmd.ExecuteNonQuery();
            //if (r != -1)
            //{
                MessageBox.Show("All Data has been Added successfully.\n");
            //}

        }

        private void addVacancy_company_button_Click(object sender, EventArgs e)
        {
            //saveJPdata();

            materialTabControl1.SelectTab("addVacancytabPage");

        }

        private void addVacancy_vacancy_button_Click(object sender, EventArgs e)
        {
            string vacancytitle = VacancyTitlecomboBox.Text;
            int jpID = LoginRegisterForm.newId;
            DateTime publishdate = DateTime.Now;
            string domain =  vacancyDomain_txtBox.Text;
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

        private void Finish_addVacancy_button_Click(object sender, EventArgs e)
        {
            LoginRegisterForm jpform = new LoginRegisterForm();
            this.Hide();
            jpform.ShowDialog();
            this.Close();
        }
    }
}
