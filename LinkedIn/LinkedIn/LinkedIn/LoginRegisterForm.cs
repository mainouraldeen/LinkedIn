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
    public partial class LoginRegisterForm : MaterialSkin.Controls.MaterialForm
    {
        string ordb = "Data source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection con;
        public LoginRegisterForm()
        {
            InitializeComponent();
        }

        private void registerTab_Click(object sender, EventArgs e)
        {

        }
        public static string providerOrSeekerName = "";
        public static string providerOrSeekerEmail = "";
        public static string providerOrSeekerPassword = "";
        public static int newId;

        private bool checkEmailRedundancy()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            string email = providerOrSeekerEmail;
            string password = providerOrSeekerEmail;

            if (email.Contains("@provider"))
            {
                cmd.CommandText = @"select jobprovider_id from job_provider where email = :email";
                cmd.Parameters.Add("email", email);
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reader.Close();
                    return false;
                }
                reader.Close();
                return true;    
            }
            else if (email.Contains("@seeker"))
            {
                cmd.CommandText = @"select JOBSEEKER_ID from job_seeker where email = :email";
                cmd.Parameters.Add("email", email);
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reader.Close();
                    return false;
                }
                reader.Close();
                return true;
            }
            else
                return false;
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
            cmd.Connection = con;
            cmd.CommandText = "insertProviderData";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("jpID", jpID);
            cmd.Parameters.Add("name", name);
            cmd.Parameters.Add("email", email);
            cmd.Parameters.Add("pass", pass);
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("All Data has been Added successfully.\n");
            
        }
        public bool check_user()//Check if the required user's data is written in the textboxes while registering or not.
        {
           
            if (name_txtBox.Text == "")
            {
                MessageBox.Show("You must write a username", "linked in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errn.Visible = true;
            }
            else
                errn.Visible = false;

            if (email_txtBox.Text == "")
            {
                MessageBox.Show("You must write an E-mail", "linked in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errm.Visible = true;
            }
            
            if (Password_txtBox.Text == "")
            {
                MessageBox.Show("You must write a password", "linke in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errp.Visible = true;
            }
            else if (Password_txtBox.Text.Length < 8)
            {
                MessageBox.Show(@"Password is too short Make it at least 8 characters or more", "linked in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errp.Visible = true;
            }
            else
                errp.Visible = false;

            //if all Error labels are hidden   
            if (!errp.Visible && !errm.Visible && !errn.Visible)
                return true;//no errors
            else
                return false;
        }

        private void ContinueRegister_button_Click(object sender, EventArgs e)
        {
           
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            int maxId;
            providerOrSeekerName = name_txtBox.Text;
            providerOrSeekerEmail = email_txtBox.Text;
            providerOrSeekerPassword = Password_txtBox.Text;
            string providerOrSeekerConfirmPassword = confirmPassword_txtBox.Text;
            if (check_user())
            {
                if (checkEmailRedundancy())
                {
                    if (providerOrSeekerPassword != providerOrSeekerConfirmPassword)
                    {
                        MessageBox.Show("Password not match");
                        errc.Visible = true;
                    }
                    else
                    {
                        errc.Visible = false;
                    }
                    if (!providerOrSeekerEmail.Contains("@provider") && !providerOrSeekerEmail.Contains("@seeker"))
                    {
                        MessageBox.Show("Incorrect email format");
                        errm.Visible = true;
                    }
                    else
                    {
                        if (jobSeeker_RadioButton.Checked && providerOrSeekerEmail.Contains("@seeker"))
                        {
                            cmd.CommandText = "getSeekerId";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
                            cmd.ExecuteNonQuery();
                            try
                            {
                                maxId = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                                newId = maxId + 1;
                            }
                            catch { newId = 1; }

                            JobSeekerRgisterForm jsform = new JobSeekerRgisterForm();
                            this.Hide();
                            jsform.ShowDialog();
                            this.Close();
                        }

                        else if (jobProvider_RadioButton.Checked && providerOrSeekerEmail.Contains("@provider"))
                        {
                            cmd.CommandText = "getproviderId";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
                            cmd.ExecuteNonQuery();
                            try
                            {
                                maxId = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                                newId = maxId + 1;
                            }
                            catch { newId = 1; }

                            saveJPdata();
                            JobProviderRegisterForm jpform = new JobProviderRegisterForm();
                            this.Hide();
                            jpform.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("WRONG RADIO BUTTON CHOICE");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("this email already taken please try another one");
                }
            }
            con.Dispose();
        }

        private void LoginRegisterForm_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
        }
        public static int outputID;
        private void login_button_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            string email = loginEmailTextBox.Text;
            string password = loginPasswordTextBox.Text;

            if (email.Contains("@provider"))
            {
                cmd.CommandText = "checkValidityEmailProvider";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("email",email);
                cmd.Parameters.Add("passowrd",password);
                cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
                cmd.ExecuteNonQuery();
                try
                {
                    outputID = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                }
                catch
                {
                    MessageBox.Show("Invalid Email or Password!");
                }
                JobProviderForm jpform = new JobProviderForm();
                this.Hide();
                jpform.ShowDialog();
                con.Dispose();
                this.Close();
            }
            else if (email.Contains("@seeker"))
            {
                cmd.CommandText = "checkValidityEmail";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("email", email);
                cmd.Parameters.Add("passowrd", password);
                cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
                cmd.ExecuteNonQuery();
                try
                {
                    outputID = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                }
                catch
                {
                    MessageBox.Show("Invalid Email or Password!");
                    login_button_Click(sender,e);
                }
                JobSeekerFormcs jpform = new JobSeekerFormcs();
                this.Hide();
                jpform.ShowDialog();
                con.Dispose();
                this.Close();
            }
        }
    }
}
