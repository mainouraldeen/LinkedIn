namespace LinkedIn
{
    partial class JobProviderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.companyProfiletabPage = new System.Windows.Forms.TabPage();
            this.cityComboBox = new MetroFramework.Controls.MetroComboBox();
            this.countryCompanycomboBox = new MetroFramework.Controls.MetroComboBox();
            this.phoneCompanyComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.companyPhoneNumber_label = new MaterialSkin.Controls.MaterialLabel();
            this.City_company_label = new MaterialSkin.Controls.MaterialLabel();
            this.country_company_label = new MaterialSkin.Controls.MaterialLabel();
            this.profileEditCompany_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ProfileAddVacancytabPage = new System.Windows.Forms.TabPage();
            this.vacancyDomain_txtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Finish_addVacancy_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addVacancy_vacancy_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.yearsOfExperience_vacancy_txtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.VacancyType_label = new MaterialSkin.Controls.MaterialLabel();
            this.vacancyTitle_label = new MaterialSkin.Controls.MaterialLabel();
            this.VacancyDomain_label = new MaterialSkin.Controls.MaterialLabel();
            this.YearsOfExperience_vacancy_label = new MaterialSkin.Controls.MaterialLabel();
            this.vacancyTypecomboBox = new System.Windows.Forms.ComboBox();
            this.VacancyTitlecomboBox = new System.Windows.Forms.ComboBox();
            this.setting = new System.Windows.Forms.TabPage();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.posts = new System.Windows.Forms.TabPage();
            this.savebutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.postsDataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.companyProfiletabPage.SuspendLayout();
            this.ProfileAddVacancytabPage.SuspendLayout();
            this.setting.SuspendLayout();
            this.posts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.companyProfiletabPage);
            this.materialTabControl1.Controls.Add(this.ProfileAddVacancytabPage);
            this.materialTabControl1.Controls.Add(this.setting);
            this.materialTabControl1.Controls.Add(this.posts);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(8, 118);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(785, 439);
            this.materialTabControl1.TabIndex = 3;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // companyProfiletabPage
            // 
            this.companyProfiletabPage.BackColor = System.Drawing.Color.White;
            this.companyProfiletabPage.Controls.Add(this.cityComboBox);
            this.companyProfiletabPage.Controls.Add(this.countryCompanycomboBox);
            this.companyProfiletabPage.Controls.Add(this.phoneCompanyComboBox1);
            this.companyProfiletabPage.Controls.Add(this.companyPhoneNumber_label);
            this.companyProfiletabPage.Controls.Add(this.City_company_label);
            this.companyProfiletabPage.Controls.Add(this.country_company_label);
            this.companyProfiletabPage.Controls.Add(this.profileEditCompany_button);
            this.companyProfiletabPage.Location = new System.Drawing.Point(4, 22);
            this.companyProfiletabPage.Name = "companyProfiletabPage";
            this.companyProfiletabPage.Size = new System.Drawing.Size(777, 413);
            this.companyProfiletabPage.TabIndex = 0;
            this.companyProfiletabPage.Text = "Company profile";
            this.companyProfiletabPage.Click += new System.EventHandler(this.companyProfiletabPage_Click);
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.ItemHeight = 23;
            this.cityComboBox.Location = new System.Drawing.Point(202, 131);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(233, 29);
            this.cityComboBox.TabIndex = 105;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            // 
            // countryCompanycomboBox
            // 
            this.countryCompanycomboBox.FormattingEnabled = true;
            this.countryCompanycomboBox.ItemHeight = 23;
            this.countryCompanycomboBox.Location = new System.Drawing.Point(202, 175);
            this.countryCompanycomboBox.Name = "countryCompanycomboBox";
            this.countryCompanycomboBox.Size = new System.Drawing.Size(233, 29);
            this.countryCompanycomboBox.TabIndex = 104;
            // 
            // phoneCompanyComboBox1
            // 
            this.phoneCompanyComboBox1.FormattingEnabled = true;
            this.phoneCompanyComboBox1.ItemHeight = 23;
            this.phoneCompanyComboBox1.Location = new System.Drawing.Point(202, 53);
            this.phoneCompanyComboBox1.Name = "phoneCompanyComboBox1";
            this.phoneCompanyComboBox1.Size = new System.Drawing.Size(233, 29);
            this.phoneCompanyComboBox1.TabIndex = 103;
            // 
            // companyPhoneNumber_label
            // 
            this.companyPhoneNumber_label.AutoSize = true;
            this.companyPhoneNumber_label.Depth = 0;
            this.companyPhoneNumber_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.companyPhoneNumber_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.companyPhoneNumber_label.Location = new System.Drawing.Point(21, 53);
            this.companyPhoneNumber_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.companyPhoneNumber_label.Name = "companyPhoneNumber_label";
            this.companyPhoneNumber_label.Size = new System.Drawing.Size(175, 19);
            this.companyPhoneNumber_label.TabIndex = 98;
            this.companyPhoneNumber_label.Text = "Company Phone Number";
            // 
            // City_company_label
            // 
            this.City_company_label.AutoSize = true;
            this.City_company_label.Depth = 0;
            this.City_company_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.City_company_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.City_company_label.Location = new System.Drawing.Point(147, 141);
            this.City_company_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.City_company_label.Name = "City_company_label";
            this.City_company_label.Size = new System.Drawing.Size(35, 19);
            this.City_company_label.TabIndex = 97;
            this.City_company_label.Text = "City";
            // 
            // country_company_label
            // 
            this.country_company_label.AutoSize = true;
            this.country_company_label.Depth = 0;
            this.country_company_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.country_company_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.country_company_label.Location = new System.Drawing.Point(121, 185);
            this.country_company_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.country_company_label.Name = "country_company_label";
            this.country_company_label.Size = new System.Drawing.Size(61, 19);
            this.country_company_label.TabIndex = 96;
            this.country_company_label.Text = "Country";
            // 
            // profileEditCompany_button
            // 
            this.profileEditCompany_button.Depth = 0;
            this.profileEditCompany_button.Location = new System.Drawing.Point(198, 304);
            this.profileEditCompany_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.profileEditCompany_button.Name = "profileEditCompany_button";
            this.profileEditCompany_button.Primary = true;
            this.profileEditCompany_button.Size = new System.Drawing.Size(237, 38);
            this.profileEditCompany_button.TabIndex = 90;
            this.profileEditCompany_button.Text = "EDIT";
            this.profileEditCompany_button.UseVisualStyleBackColor = true;
            // 
            // ProfileAddVacancytabPage
            // 
            this.ProfileAddVacancytabPage.BackColor = System.Drawing.Color.White;
            this.ProfileAddVacancytabPage.Controls.Add(this.vacancyDomain_txtBox);
            this.ProfileAddVacancytabPage.Controls.Add(this.Finish_addVacancy_button);
            this.ProfileAddVacancytabPage.Controls.Add(this.addVacancy_vacancy_button);
            this.ProfileAddVacancytabPage.Controls.Add(this.yearsOfExperience_vacancy_txtBox);
            this.ProfileAddVacancytabPage.Controls.Add(this.VacancyType_label);
            this.ProfileAddVacancytabPage.Controls.Add(this.vacancyTitle_label);
            this.ProfileAddVacancytabPage.Controls.Add(this.VacancyDomain_label);
            this.ProfileAddVacancytabPage.Controls.Add(this.YearsOfExperience_vacancy_label);
            this.ProfileAddVacancytabPage.Controls.Add(this.vacancyTypecomboBox);
            this.ProfileAddVacancytabPage.Controls.Add(this.VacancyTitlecomboBox);
            this.ProfileAddVacancytabPage.Location = new System.Drawing.Point(4, 22);
            this.ProfileAddVacancytabPage.Name = "ProfileAddVacancytabPage";
            this.ProfileAddVacancytabPage.Size = new System.Drawing.Size(777, 413);
            this.ProfileAddVacancytabPage.TabIndex = 1;
            this.ProfileAddVacancytabPage.Text = "Add Vacancy";
            // 
            // vacancyDomain_txtBox
            // 
            this.vacancyDomain_txtBox.BackColor = System.Drawing.Color.White;
            this.vacancyDomain_txtBox.Depth = 0;
            this.vacancyDomain_txtBox.ForeColor = System.Drawing.Color.LightCoral;
            this.vacancyDomain_txtBox.Hint = "";
            this.vacancyDomain_txtBox.Location = new System.Drawing.Point(182, 36);
            this.vacancyDomain_txtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.vacancyDomain_txtBox.Name = "vacancyDomain_txtBox";
            this.vacancyDomain_txtBox.PasswordChar = '\0';
            this.vacancyDomain_txtBox.SelectedText = "";
            this.vacancyDomain_txtBox.SelectionLength = 0;
            this.vacancyDomain_txtBox.SelectionStart = 0;
            this.vacancyDomain_txtBox.Size = new System.Drawing.Size(273, 23);
            this.vacancyDomain_txtBox.TabIndex = 90;
            this.vacancyDomain_txtBox.Text = "ENTER VACANCY DOMAIN";
            this.vacancyDomain_txtBox.UseSystemPasswordChar = false;
            // 
            // Finish_addVacancy_button
            // 
            this.Finish_addVacancy_button.Depth = 0;
            this.Finish_addVacancy_button.Location = new System.Drawing.Point(378, 317);
            this.Finish_addVacancy_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Finish_addVacancy_button.Name = "Finish_addVacancy_button";
            this.Finish_addVacancy_button.Primary = true;
            this.Finish_addVacancy_button.Size = new System.Drawing.Size(237, 38);
            this.Finish_addVacancy_button.TabIndex = 89;
            this.Finish_addVacancy_button.Text = "FINISH";
            this.Finish_addVacancy_button.UseVisualStyleBackColor = true;
            // 
            // addVacancy_vacancy_button
            // 
            this.addVacancy_vacancy_button.Depth = 0;
            this.addVacancy_vacancy_button.Location = new System.Drawing.Point(126, 317);
            this.addVacancy_vacancy_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.addVacancy_vacancy_button.Name = "addVacancy_vacancy_button";
            this.addVacancy_vacancy_button.Primary = true;
            this.addVacancy_vacancy_button.Size = new System.Drawing.Size(237, 38);
            this.addVacancy_vacancy_button.TabIndex = 88;
            this.addVacancy_vacancy_button.Text = "ADD VACANCY";
            this.addVacancy_vacancy_button.UseVisualStyleBackColor = true;
            this.addVacancy_vacancy_button.Click += new System.EventHandler(this.addVacancy_vacancy_button_Click);
            // 
            // yearsOfExperience_vacancy_txtBox
            // 
            this.yearsOfExperience_vacancy_txtBox.BackColor = System.Drawing.Color.White;
            this.yearsOfExperience_vacancy_txtBox.Depth = 0;
            this.yearsOfExperience_vacancy_txtBox.ForeColor = System.Drawing.Color.LightCoral;
            this.yearsOfExperience_vacancy_txtBox.Hint = "";
            this.yearsOfExperience_vacancy_txtBox.Location = new System.Drawing.Point(182, 266);
            this.yearsOfExperience_vacancy_txtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.yearsOfExperience_vacancy_txtBox.Name = "yearsOfExperience_vacancy_txtBox";
            this.yearsOfExperience_vacancy_txtBox.PasswordChar = '\0';
            this.yearsOfExperience_vacancy_txtBox.SelectedText = "";
            this.yearsOfExperience_vacancy_txtBox.SelectionLength = 0;
            this.yearsOfExperience_vacancy_txtBox.SelectionStart = 0;
            this.yearsOfExperience_vacancy_txtBox.Size = new System.Drawing.Size(273, 23);
            this.yearsOfExperience_vacancy_txtBox.TabIndex = 59;
            this.yearsOfExperience_vacancy_txtBox.Text = "ENTER YEARS OF EXPERIENCE";
            this.yearsOfExperience_vacancy_txtBox.UseSystemPasswordChar = false;
            // 
            // VacancyType_label
            // 
            this.VacancyType_label.AutoSize = true;
            this.VacancyType_label.Depth = 0;
            this.VacancyType_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.VacancyType_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.VacancyType_label.Location = new System.Drawing.Point(46, 135);
            this.VacancyType_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.VacancyType_label.Name = "VacancyType_label";
            this.VacancyType_label.Size = new System.Drawing.Size(102, 19);
            this.VacancyType_label.TabIndex = 58;
            this.VacancyType_label.Text = "Vacancy Type";
            // 
            // vacancyTitle_label
            // 
            this.vacancyTitle_label.AutoSize = true;
            this.vacancyTitle_label.Depth = 0;
            this.vacancyTitle_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.vacancyTitle_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vacancyTitle_label.Location = new System.Drawing.Point(48, 88);
            this.vacancyTitle_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.vacancyTitle_label.Name = "vacancyTitle_label";
            this.vacancyTitle_label.Size = new System.Drawing.Size(100, 19);
            this.vacancyTitle_label.TabIndex = 56;
            this.vacancyTitle_label.Text = "Vacancy Title";
            // 
            // VacancyDomain_label
            // 
            this.VacancyDomain_label.AutoSize = true;
            this.VacancyDomain_label.Depth = 0;
            this.VacancyDomain_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.VacancyDomain_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.VacancyDomain_label.Location = new System.Drawing.Point(48, 40);
            this.VacancyDomain_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.VacancyDomain_label.Name = "VacancyDomain_label";
            this.VacancyDomain_label.Size = new System.Drawing.Size(122, 19);
            this.VacancyDomain_label.TabIndex = 55;
            this.VacancyDomain_label.Text = "Vacancy Domain";
            // 
            // YearsOfExperience_vacancy_label
            // 
            this.YearsOfExperience_vacancy_label.AutoSize = true;
            this.YearsOfExperience_vacancy_label.Depth = 0;
            this.YearsOfExperience_vacancy_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.YearsOfExperience_vacancy_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.YearsOfExperience_vacancy_label.Location = new System.Drawing.Point(12, 266);
            this.YearsOfExperience_vacancy_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.YearsOfExperience_vacancy_label.Name = "YearsOfExperience_vacancy_label";
            this.YearsOfExperience_vacancy_label.Size = new System.Drawing.Size(143, 19);
            this.YearsOfExperience_vacancy_label.TabIndex = 54;
            this.YearsOfExperience_vacancy_label.Text = "Years Of Experience";
            // 
            // vacancyTypecomboBox
            // 
            this.vacancyTypecomboBox.FormattingEnabled = true;
            this.vacancyTypecomboBox.Items.AddRange(new object[] {
            "Part time",
            "Full time",
            "Night time",
            "Day time"});
            this.vacancyTypecomboBox.Location = new System.Drawing.Point(182, 133);
            this.vacancyTypecomboBox.Name = "vacancyTypecomboBox";
            this.vacancyTypecomboBox.Size = new System.Drawing.Size(273, 21);
            this.vacancyTypecomboBox.TabIndex = 37;
            // 
            // VacancyTitlecomboBox
            // 
            this.VacancyTitlecomboBox.FormattingEnabled = true;
            this.VacancyTitlecomboBox.Items.AddRange(new object[] {
            "software",
            "data science",
            "IT",
            "full stack",
            "front end",
            "back end",
            "android"});
            this.VacancyTitlecomboBox.Location = new System.Drawing.Point(182, 86);
            this.VacancyTitlecomboBox.Name = "VacancyTitlecomboBox";
            this.VacancyTitlecomboBox.Size = new System.Drawing.Size(273, 21);
            this.VacancyTitlecomboBox.TabIndex = 35;
            // 
            // setting
            // 
            this.setting.Controls.Add(this.materialRaisedButton2);
            this.setting.Controls.Add(this.materialRaisedButton1);
            this.setting.Location = new System.Drawing.Point(4, 22);
            this.setting.Name = "setting";
            this.setting.Padding = new System.Windows.Forms.Padding(3);
            this.setting.Size = new System.Drawing.Size(777, 413);
            this.setting.TabIndex = 2;
            this.setting.Text = "setting";
            this.setting.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(95, 245);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(532, 60);
            this.materialRaisedButton2.TabIndex = 1;
            this.materialRaisedButton2.Text = "LOG OUT";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(95, 152);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(532, 60);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "DELETE THIS ACCOUNT";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // posts
            // 
            this.posts.Controls.Add(this.savebutton);
            this.posts.Controls.Add(this.postsDataGridView);
            this.posts.Location = new System.Drawing.Point(4, 22);
            this.posts.Name = "posts";
            this.posts.Padding = new System.Windows.Forms.Padding(3);
            this.posts.Size = new System.Drawing.Size(777, 413);
            this.posts.TabIndex = 3;
            this.posts.Text = "POSTS";
            this.posts.UseVisualStyleBackColor = true;
            this.posts.Click += new System.EventHandler(this.posts_Click);
            // 
            // savebutton
            // 
            this.savebutton.Depth = 0;
            this.savebutton.Location = new System.Drawing.Point(261, 344);
            this.savebutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.savebutton.Name = "savebutton";
            this.savebutton.Primary = true;
            this.savebutton.Size = new System.Drawing.Size(237, 38);
            this.savebutton.TabIndex = 91;
            this.savebutton.Text = "Save Changes";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // postsDataGridView
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.postsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.postsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.postsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.postsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.postsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.postsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.postsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.postsDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.postsDataGridView.DoubleBuffered = true;
            this.postsDataGridView.EnableHeadersVisualStyles = false;
            this.postsDataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.postsDataGridView.HeaderBgColor = System.Drawing.Color.Azure;
            this.postsDataGridView.HeaderForeColor = System.Drawing.Color.Black;
            this.postsDataGridView.Location = new System.Drawing.Point(61, 25);
            this.postsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.postsDataGridView.Name = "postsDataGridView";
            this.postsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.postsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.postsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postsDataGridView.RowTemplate.Height = 28;
            this.postsDataGridView.Size = new System.Drawing.Size(653, 288);
            this.postsDataGridView.TabIndex = 7;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 58);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(808, 54);
            this.materialTabSelector1.TabIndex = 4;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // JobProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "JobProviderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  JobProviderForm";
            this.Load += new System.EventHandler(this.JobProviderForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.companyProfiletabPage.ResumeLayout(false);
            this.companyProfiletabPage.PerformLayout();
            this.ProfileAddVacancytabPage.ResumeLayout(false);
            this.ProfileAddVacancytabPage.PerformLayout();
            this.setting.ResumeLayout(false);
            this.posts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.postsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage companyProfiletabPage;
        private MaterialSkin.Controls.MaterialLabel companyPhoneNumber_label;
        private MaterialSkin.Controls.MaterialLabel City_company_label;
        private MaterialSkin.Controls.MaterialLabel country_company_label;
        private MaterialSkin.Controls.MaterialRaisedButton profileEditCompany_button;
        private System.Windows.Forms.TabPage ProfileAddVacancytabPage;
        private MaterialSkin.Controls.MaterialRaisedButton Finish_addVacancy_button;
        private MaterialSkin.Controls.MaterialRaisedButton addVacancy_vacancy_button;
        private MaterialSkin.Controls.MaterialSingleLineTextField yearsOfExperience_vacancy_txtBox;
        private MaterialSkin.Controls.MaterialLabel VacancyType_label;
        private MaterialSkin.Controls.MaterialLabel vacancyTitle_label;
        private MaterialSkin.Controls.MaterialLabel VacancyDomain_label;
        private MaterialSkin.Controls.MaterialLabel YearsOfExperience_vacancy_label;
        private System.Windows.Forms.ComboBox vacancyTypecomboBox;
        private System.Windows.Forms.ComboBox VacancyTitlecomboBox;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage setting;
        private System.Windows.Forms.TabPage posts;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MetroFramework.Controls.MetroComboBox phoneCompanyComboBox1;
        private MetroFramework.Controls.MetroComboBox cityComboBox;
        private MetroFramework.Controls.MetroComboBox countryCompanycomboBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField vacancyDomain_txtBox;
        private Bunifu.Framework.UI.BunifuCustomDataGrid postsDataGridView;
        private MaterialSkin.Controls.MaterialRaisedButton savebutton;
    }
}