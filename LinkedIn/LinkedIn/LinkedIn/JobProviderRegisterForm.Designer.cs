namespace LinkedIn
{
    partial class JobProviderRegisterForm
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.addCompanytabPage = new System.Windows.Forms.TabPage();
            this.AddphoneButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addLocation_company_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.companyPhoneNumber_label = new MaterialSkin.Controls.MaterialLabel();
            this.City_company_label = new MaterialSkin.Controls.MaterialLabel();
            this.country_company_label = new MaterialSkin.Controls.MaterialLabel();
            this.phoneNumber_company_txtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.addVacancy_company_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Finish_addCompany_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.citycompanyComboBox = new System.Windows.Forms.ComboBox();
            this.countryCompanycomboBox = new System.Windows.Forms.ComboBox();
            this.addVacancytabPage = new System.Windows.Forms.TabPage();
            this.Finish_addVacancy_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addVacancy_vacancy_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.vacancyDomain_txtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.yearsOfExperience_vacancy_txtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.VacancyType_label = new MaterialSkin.Controls.MaterialLabel();
            this.vacancyTitle_label = new MaterialSkin.Controls.MaterialLabel();
            this.VacancyDomain_label = new MaterialSkin.Controls.MaterialLabel();
            this.YearsOfExperience_vacancy_label = new MaterialSkin.Controls.MaterialLabel();
            this.vacancyTypecomboBox = new System.Windows.Forms.ComboBox();
            this.VacancyTitlecomboBox = new System.Windows.Forms.ComboBox();
            this.materialTabControl1.SuspendLayout();
            this.addCompanytabPage.SuspendLayout();
            this.addVacancytabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-2, 62);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(808, 54);
            this.materialTabSelector1.TabIndex = 3;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.addCompanytabPage);
            this.materialTabControl1.Controls.Add(this.addVacancytabPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 140);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(785, 418);
            this.materialTabControl1.TabIndex = 2;
            // 
            // addCompanytabPage
            // 
            this.addCompanytabPage.BackColor = System.Drawing.Color.White;
            this.addCompanytabPage.Controls.Add(this.AddphoneButton);
            this.addCompanytabPage.Controls.Add(this.addLocation_company_button);
            this.addCompanytabPage.Controls.Add(this.companyPhoneNumber_label);
            this.addCompanytabPage.Controls.Add(this.City_company_label);
            this.addCompanytabPage.Controls.Add(this.country_company_label);
            this.addCompanytabPage.Controls.Add(this.phoneNumber_company_txtBox);
            this.addCompanytabPage.Controls.Add(this.addVacancy_company_button);
            this.addCompanytabPage.Controls.Add(this.Finish_addCompany_button);
            this.addCompanytabPage.Controls.Add(this.citycompanyComboBox);
            this.addCompanytabPage.Controls.Add(this.countryCompanycomboBox);
            this.addCompanytabPage.Location = new System.Drawing.Point(4, 22);
            this.addCompanytabPage.Name = "addCompanytabPage";
            this.addCompanytabPage.Size = new System.Drawing.Size(777, 392);
            this.addCompanytabPage.TabIndex = 0;
            this.addCompanytabPage.Text = "Add Company";
            // 
            // AddphoneButton
            // 
            this.AddphoneButton.Depth = 0;
            this.AddphoneButton.Location = new System.Drawing.Point(498, 44);
            this.AddphoneButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddphoneButton.Name = "AddphoneButton";
            this.AddphoneButton.Primary = true;
            this.AddphoneButton.Size = new System.Drawing.Size(176, 38);
            this.AddphoneButton.TabIndex = 102;
            this.AddphoneButton.Text = "ADD Phone";
            this.AddphoneButton.UseVisualStyleBackColor = true;
            this.AddphoneButton.Click += new System.EventHandler(this.AddphoneButton_Click);
            // 
            // addLocation_company_button
            // 
            this.addLocation_company_button.Depth = 0;
            this.addLocation_company_button.Location = new System.Drawing.Point(485, 173);
            this.addLocation_company_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.addLocation_company_button.Name = "addLocation_company_button";
            this.addLocation_company_button.Primary = true;
            this.addLocation_company_button.Size = new System.Drawing.Size(237, 38);
            this.addLocation_company_button.TabIndex = 99;
            this.addLocation_company_button.Text = "ADD LOCATION";
            this.addLocation_company_button.UseVisualStyleBackColor = true;
            this.addLocation_company_button.Click += new System.EventHandler(this.addLocation_company_button_Click);
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
            this.City_company_label.Location = new System.Drawing.Point(147, 130);
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
            this.country_company_label.Location = new System.Drawing.Point(121, 175);
            this.country_company_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.country_company_label.Name = "country_company_label";
            this.country_company_label.Size = new System.Drawing.Size(61, 19);
            this.country_company_label.TabIndex = 96;
            this.country_company_label.Text = "Country";
            // 
            // phoneNumber_company_txtBox
            // 
            this.phoneNumber_company_txtBox.BackColor = System.Drawing.Color.White;
            this.phoneNumber_company_txtBox.Depth = 0;
            this.phoneNumber_company_txtBox.ForeColor = System.Drawing.Color.LightCoral;
            this.phoneNumber_company_txtBox.Hint = "ENTER PHONE NUMBERS";
            this.phoneNumber_company_txtBox.Location = new System.Drawing.Point(206, 53);
            this.phoneNumber_company_txtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.phoneNumber_company_txtBox.Name = "phoneNumber_company_txtBox";
            this.phoneNumber_company_txtBox.PasswordChar = '\0';
            this.phoneNumber_company_txtBox.SelectedText = "";
            this.phoneNumber_company_txtBox.SelectionLength = 0;
            this.phoneNumber_company_txtBox.SelectionStart = 0;
            this.phoneNumber_company_txtBox.Size = new System.Drawing.Size(273, 23);
            this.phoneNumber_company_txtBox.TabIndex = 92;
            this.phoneNumber_company_txtBox.UseSystemPasswordChar = false;
            // 
            // addVacancy_company_button
            // 
            this.addVacancy_company_button.Depth = 0;
            this.addVacancy_company_button.Location = new System.Drawing.Point(340, 309);
            this.addVacancy_company_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.addVacancy_company_button.Name = "addVacancy_company_button";
            this.addVacancy_company_button.Primary = true;
            this.addVacancy_company_button.Size = new System.Drawing.Size(237, 38);
            this.addVacancy_company_button.TabIndex = 91;
            this.addVacancy_company_button.Text = "NEXT";
            this.addVacancy_company_button.UseVisualStyleBackColor = true;
            this.addVacancy_company_button.Click += new System.EventHandler(this.addVacancy_company_button_Click);
            // 
            // Finish_addCompany_button
            // 
            this.Finish_addCompany_button.Depth = 0;
            this.Finish_addCompany_button.Location = new System.Drawing.Point(97, 309);
            this.Finish_addCompany_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.Finish_addCompany_button.Name = "Finish_addCompany_button";
            this.Finish_addCompany_button.Primary = true;
            this.Finish_addCompany_button.Size = new System.Drawing.Size(237, 38);
            this.Finish_addCompany_button.TabIndex = 90;
            this.Finish_addCompany_button.Text = "FINISH";
            this.Finish_addCompany_button.UseVisualStyleBackColor = true;
            this.Finish_addCompany_button.Click += new System.EventHandler(this.Finish_addCompany_button_Click);
            // 
            // citycompanyComboBox
            // 
            this.citycompanyComboBox.FormattingEnabled = true;
            this.citycompanyComboBox.Items.AddRange(new object[] {
            "Egypt",
            "Saudi Aribya",
            "Dubai"});
            this.citycompanyComboBox.Location = new System.Drawing.Point(206, 131);
            this.citycompanyComboBox.Name = "citycompanyComboBox";
            this.citycompanyComboBox.Size = new System.Drawing.Size(273, 21);
            this.citycompanyComboBox.TabIndex = 37;
            this.citycompanyComboBox.SelectedIndexChanged += new System.EventHandler(this.citycompanyComboBox_SelectedIndexChanged);
            // 
            // countryCompanycomboBox
            // 
            this.countryCompanycomboBox.FormattingEnabled = true;
            this.countryCompanycomboBox.Location = new System.Drawing.Point(206, 173);
            this.countryCompanycomboBox.Name = "countryCompanycomboBox";
            this.countryCompanycomboBox.Size = new System.Drawing.Size(273, 21);
            this.countryCompanycomboBox.TabIndex = 36;
            // 
            // addVacancytabPage
            // 
            this.addVacancytabPage.BackColor = System.Drawing.Color.White;
            this.addVacancytabPage.Controls.Add(this.Finish_addVacancy_button);
            this.addVacancytabPage.Controls.Add(this.addVacancy_vacancy_button);
            this.addVacancytabPage.Controls.Add(this.vacancyDomain_txtBox);
            this.addVacancytabPage.Controls.Add(this.yearsOfExperience_vacancy_txtBox);
            this.addVacancytabPage.Controls.Add(this.VacancyType_label);
            this.addVacancytabPage.Controls.Add(this.vacancyTitle_label);
            this.addVacancytabPage.Controls.Add(this.VacancyDomain_label);
            this.addVacancytabPage.Controls.Add(this.YearsOfExperience_vacancy_label);
            this.addVacancytabPage.Controls.Add(this.vacancyTypecomboBox);
            this.addVacancytabPage.Controls.Add(this.VacancyTitlecomboBox);
            this.addVacancytabPage.Location = new System.Drawing.Point(4, 22);
            this.addVacancytabPage.Name = "addVacancytabPage";
            this.addVacancytabPage.Size = new System.Drawing.Size(777, 392);
            this.addVacancytabPage.TabIndex = 1;
            this.addVacancytabPage.Text = "Add Vacancy";
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
            this.Finish_addVacancy_button.Click += new System.EventHandler(this.Finish_addVacancy_button_Click);
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
            // vacancyDomain_txtBox
            // 
            this.vacancyDomain_txtBox.BackColor = System.Drawing.Color.White;
            this.vacancyDomain_txtBox.Depth = 0;
            this.vacancyDomain_txtBox.ForeColor = System.Drawing.Color.LightCoral;
            this.vacancyDomain_txtBox.Hint = "ENTER VACANCY TITLE";
            this.vacancyDomain_txtBox.Location = new System.Drawing.Point(182, 36);
            this.vacancyDomain_txtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.vacancyDomain_txtBox.Name = "vacancyDomain_txtBox";
            this.vacancyDomain_txtBox.PasswordChar = '\0';
            this.vacancyDomain_txtBox.SelectedText = "";
            this.vacancyDomain_txtBox.SelectionLength = 0;
            this.vacancyDomain_txtBox.SelectionStart = 0;
            this.vacancyDomain_txtBox.Size = new System.Drawing.Size(273, 23);
            this.vacancyDomain_txtBox.TabIndex = 61;
            this.vacancyDomain_txtBox.UseSystemPasswordChar = false;
            // 
            // yearsOfExperience_vacancy_txtBox
            // 
            this.yearsOfExperience_vacancy_txtBox.BackColor = System.Drawing.Color.White;
            this.yearsOfExperience_vacancy_txtBox.Depth = 0;
            this.yearsOfExperience_vacancy_txtBox.ForeColor = System.Drawing.Color.LightCoral;
            this.yearsOfExperience_vacancy_txtBox.Hint = "ENTER YEARS OF EXPERIENCE";
            this.yearsOfExperience_vacancy_txtBox.Location = new System.Drawing.Point(182, 266);
            this.yearsOfExperience_vacancy_txtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.yearsOfExperience_vacancy_txtBox.Name = "yearsOfExperience_vacancy_txtBox";
            this.yearsOfExperience_vacancy_txtBox.PasswordChar = '\0';
            this.yearsOfExperience_vacancy_txtBox.SelectedText = "";
            this.yearsOfExperience_vacancy_txtBox.SelectionLength = 0;
            this.yearsOfExperience_vacancy_txtBox.SelectionStart = 0;
            this.yearsOfExperience_vacancy_txtBox.Size = new System.Drawing.Size(273, 23);
            this.yearsOfExperience_vacancy_txtBox.TabIndex = 59;
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
            this.vacancyTitle_label.Location = new System.Drawing.Point(55, 88);
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
            this.VacancyDomain_label.Location = new System.Drawing.Point(46, 40);
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
            // JobProviderRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(801, 574);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "JobProviderRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobProviderRegisterForm";
            this.Load += new System.EventHandler(this.JobProviderRegisterForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.addCompanytabPage.ResumeLayout(false);
            this.addCompanytabPage.PerformLayout();
            this.addVacancytabPage.ResumeLayout(false);
            this.addVacancytabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage addCompanytabPage;
        private System.Windows.Forms.TabPage addVacancytabPage;
        private System.Windows.Forms.ComboBox vacancyTypecomboBox;
        private System.Windows.Forms.ComboBox VacancyTitlecomboBox;
        private System.Windows.Forms.ComboBox citycompanyComboBox;
        private System.Windows.Forms.ComboBox countryCompanycomboBox;
        private MaterialSkin.Controls.MaterialLabel VacancyType_label;
        private MaterialSkin.Controls.MaterialLabel vacancyTitle_label;
        private MaterialSkin.Controls.MaterialLabel VacancyDomain_label;
        private MaterialSkin.Controls.MaterialLabel YearsOfExperience_vacancy_label;
        private MaterialSkin.Controls.MaterialSingleLineTextField vacancyDomain_txtBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField yearsOfExperience_vacancy_txtBox;
        private MaterialSkin.Controls.MaterialRaisedButton Finish_addVacancy_button;
        private MaterialSkin.Controls.MaterialRaisedButton addVacancy_vacancy_button;
        private MaterialSkin.Controls.MaterialRaisedButton addVacancy_company_button;
        private MaterialSkin.Controls.MaterialRaisedButton Finish_addCompany_button;
        private MaterialSkin.Controls.MaterialSingleLineTextField phoneNumber_company_txtBox;
        private MaterialSkin.Controls.MaterialLabel companyPhoneNumber_label;
        private MaterialSkin.Controls.MaterialLabel City_company_label;
        private MaterialSkin.Controls.MaterialLabel country_company_label;
        private MaterialSkin.Controls.MaterialRaisedButton addLocation_company_button;
        private MaterialSkin.Controls.MaterialRaisedButton AddphoneButton;
    }
}