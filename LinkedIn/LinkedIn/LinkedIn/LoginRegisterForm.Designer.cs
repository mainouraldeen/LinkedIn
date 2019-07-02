namespace LinkedIn
{
    partial class LoginRegisterForm
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.registerTab = new System.Windows.Forms.TabPage();
            this.ContinueRegister_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.jobProvider_RadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.jobSeeker_RadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.confirmPassword_txtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.confirmPassword_label = new MaterialSkin.Controls.MaterialLabel();
            this.Password_txtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.email_txtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.name_txtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password_Label = new MaterialSkin.Controls.MaterialLabel();
            this.email_Label = new MaterialSkin.Controls.MaterialLabel();
            this.Name_label = new MaterialSkin.Controls.MaterialLabel();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.login_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.loginPasswordTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginEmailTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.errn = new System.Windows.Forms.Label();
            this.errm = new System.Windows.Forms.Label();
            this.errp = new System.Windows.Forms.Label();
            this.errc = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.registerTab.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.registerTab);
            this.materialTabControl1.Controls.Add(this.loginTab);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 118);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(538, 395);
            this.materialTabControl1.TabIndex = 0;
            // 
            // registerTab
            // 
            this.registerTab.BackColor = System.Drawing.Color.White;
            this.registerTab.Controls.Add(this.errc);
            this.registerTab.Controls.Add(this.errn);
            this.registerTab.Controls.Add(this.errm);
            this.registerTab.Controls.Add(this.errp);
            this.registerTab.Controls.Add(this.ContinueRegister_button);
            this.registerTab.Controls.Add(this.jobProvider_RadioButton);
            this.registerTab.Controls.Add(this.jobSeeker_RadioButton);
            this.registerTab.Controls.Add(this.confirmPassword_txtBox);
            this.registerTab.Controls.Add(this.confirmPassword_label);
            this.registerTab.Controls.Add(this.Password_txtBox);
            this.registerTab.Controls.Add(this.email_txtBox);
            this.registerTab.Controls.Add(this.name_txtBox);
            this.registerTab.Controls.Add(this.password_Label);
            this.registerTab.Controls.Add(this.email_Label);
            this.registerTab.Controls.Add(this.Name_label);
            this.registerTab.Location = new System.Drawing.Point(4, 22);
            this.registerTab.Name = "registerTab";
            this.registerTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.registerTab.Size = new System.Drawing.Size(530, 369);
            this.registerTab.TabIndex = 0;
            this.registerTab.Text = "Register";
            this.registerTab.Click += new System.EventHandler(this.registerTab_Click);
            // 
            // ContinueRegister_button
            // 
            this.ContinueRegister_button.Depth = 0;
            this.ContinueRegister_button.Location = new System.Drawing.Point(50, 311);
            this.ContinueRegister_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.ContinueRegister_button.Name = "ContinueRegister_button";
            this.ContinueRegister_button.Primary = true;
            this.ContinueRegister_button.Size = new System.Drawing.Size(439, 38);
            this.ContinueRegister_button.TabIndex = 82;
            this.ContinueRegister_button.Text = "CONTINUE";
            this.ContinueRegister_button.UseVisualStyleBackColor = true;
            this.ContinueRegister_button.Click += new System.EventHandler(this.ContinueRegister_button_Click);
            // 
            // jobProvider_RadioButton
            // 
            this.jobProvider_RadioButton.AutoSize = true;
            this.jobProvider_RadioButton.Depth = 0;
            this.jobProvider_RadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.jobProvider_RadioButton.Location = new System.Drawing.Point(241, 249);
            this.jobProvider_RadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.jobProvider_RadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.jobProvider_RadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.jobProvider_RadioButton.Name = "jobProvider_RadioButton";
            this.jobProvider_RadioButton.Ripple = true;
            this.jobProvider_RadioButton.Size = new System.Drawing.Size(107, 30);
            this.jobProvider_RadioButton.TabIndex = 81;
            this.jobProvider_RadioButton.TabStop = true;
            this.jobProvider_RadioButton.Text = "Job Provider";
            this.jobProvider_RadioButton.UseVisualStyleBackColor = true;
            // 
            // jobSeeker_RadioButton
            // 
            this.jobSeeker_RadioButton.AutoSize = true;
            this.jobSeeker_RadioButton.Depth = 0;
            this.jobSeeker_RadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.jobSeeker_RadioButton.Location = new System.Drawing.Point(107, 249);
            this.jobSeeker_RadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.jobSeeker_RadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.jobSeeker_RadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.jobSeeker_RadioButton.Name = "jobSeeker_RadioButton";
            this.jobSeeker_RadioButton.Ripple = true;
            this.jobSeeker_RadioButton.Size = new System.Drawing.Size(98, 30);
            this.jobSeeker_RadioButton.TabIndex = 80;
            this.jobSeeker_RadioButton.TabStop = true;
            this.jobSeeker_RadioButton.Text = "Job Seeker";
            this.jobSeeker_RadioButton.UseVisualStyleBackColor = true;
            // 
            // confirmPassword_txtBox
            // 
            this.confirmPassword_txtBox.BackColor = System.Drawing.Color.White;
            this.confirmPassword_txtBox.Depth = 0;
            this.confirmPassword_txtBox.ForeColor = System.Drawing.Color.LightCoral;
            this.confirmPassword_txtBox.Hint = "ENTER YOUR PASSWORD AGAIN";
            this.confirmPassword_txtBox.Location = new System.Drawing.Point(216, 180);
            this.confirmPassword_txtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirmPassword_txtBox.Name = "confirmPassword_txtBox";
            this.confirmPassword_txtBox.PasswordChar = '\0';
            this.confirmPassword_txtBox.SelectedText = "";
            this.confirmPassword_txtBox.SelectionLength = 0;
            this.confirmPassword_txtBox.SelectionStart = 0;
            this.confirmPassword_txtBox.Size = new System.Drawing.Size(273, 23);
            this.confirmPassword_txtBox.TabIndex = 79;
            this.confirmPassword_txtBox.UseSystemPasswordChar = true;
            // 
            // confirmPassword_label
            // 
            this.confirmPassword_label.AutoSize = true;
            this.confirmPassword_label.Depth = 0;
            this.confirmPassword_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.confirmPassword_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.confirmPassword_label.Location = new System.Drawing.Point(46, 180);
            this.confirmPassword_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirmPassword_label.Name = "confirmPassword_label";
            this.confirmPassword_label.Size = new System.Drawing.Size(133, 19);
            this.confirmPassword_label.TabIndex = 78;
            this.confirmPassword_label.Text = "Confirm Password";
            // 
            // Password_txtBox
            // 
            this.Password_txtBox.BackColor = System.Drawing.Color.White;
            this.Password_txtBox.Depth = 0;
            this.Password_txtBox.ForeColor = System.Drawing.Color.LightCoral;
            this.Password_txtBox.Hint = "ENTER YOUR PASSWORD";
            this.Password_txtBox.Location = new System.Drawing.Point(216, 136);
            this.Password_txtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.Password_txtBox.Name = "Password_txtBox";
            this.Password_txtBox.PasswordChar = '\0';
            this.Password_txtBox.SelectedText = "";
            this.Password_txtBox.SelectionLength = 0;
            this.Password_txtBox.SelectionStart = 0;
            this.Password_txtBox.Size = new System.Drawing.Size(273, 23);
            this.Password_txtBox.TabIndex = 77;
            this.Password_txtBox.UseSystemPasswordChar = true;
            // 
            // email_txtBox
            // 
            this.email_txtBox.BackColor = System.Drawing.Color.White;
            this.email_txtBox.Depth = 0;
            this.email_txtBox.ForeColor = System.Drawing.Color.LightCoral;
            this.email_txtBox.Hint = "ENTER YOUR E-MAIL";
            this.email_txtBox.Location = new System.Drawing.Point(216, 95);
            this.email_txtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.email_txtBox.Name = "email_txtBox";
            this.email_txtBox.PasswordChar = '\0';
            this.email_txtBox.SelectedText = "";
            this.email_txtBox.SelectionLength = 0;
            this.email_txtBox.SelectionStart = 0;
            this.email_txtBox.Size = new System.Drawing.Size(273, 23);
            this.email_txtBox.TabIndex = 76;
            this.email_txtBox.UseSystemPasswordChar = false;
            // 
            // name_txtBox
            // 
            this.name_txtBox.BackColor = System.Drawing.Color.White;
            this.name_txtBox.Depth = 0;
            this.name_txtBox.ForeColor = System.Drawing.Color.LightCoral;
            this.name_txtBox.Hint = "ENTER YOUR NAME";
            this.name_txtBox.Location = new System.Drawing.Point(216, 50);
            this.name_txtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.name_txtBox.Name = "name_txtBox";
            this.name_txtBox.PasswordChar = '\0';
            this.name_txtBox.SelectedText = "";
            this.name_txtBox.SelectionLength = 0;
            this.name_txtBox.SelectionStart = 0;
            this.name_txtBox.Size = new System.Drawing.Size(273, 23);
            this.name_txtBox.TabIndex = 75;
            this.name_txtBox.UseSystemPasswordChar = false;
            // 
            // password_Label
            // 
            this.password_Label.AutoSize = true;
            this.password_Label.Depth = 0;
            this.password_Label.Font = new System.Drawing.Font("Roboto", 11F);
            this.password_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.password_Label.Location = new System.Drawing.Point(104, 136);
            this.password_Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.password_Label.Name = "password_Label";
            this.password_Label.Size = new System.Drawing.Size(75, 19);
            this.password_Label.TabIndex = 74;
            this.password_Label.Text = "Password";
            // 
            // email_Label
            // 
            this.email_Label.AutoSize = true;
            this.email_Label.Depth = 0;
            this.email_Label.Font = new System.Drawing.Font("Roboto", 11F);
            this.email_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.email_Label.Location = new System.Drawing.Point(128, 95);
            this.email_Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.email_Label.Name = "email_Label";
            this.email_Label.Size = new System.Drawing.Size(51, 19);
            this.email_Label.TabIndex = 73;
            this.email_Label.Text = "E-mail";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Depth = 0;
            this.Name_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.Name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name_label.Location = new System.Drawing.Point(130, 50);
            this.Name_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(49, 19);
            this.Name_label.TabIndex = 72;
            this.Name_label.Text = "Name";
            // 
            // loginTab
            // 
            this.loginTab.BackColor = System.Drawing.Color.White;
            this.loginTab.Controls.Add(this.login_button);
            this.loginTab.Controls.Add(this.loginPasswordTextBox);
            this.loginTab.Controls.Add(this.loginEmailTextBox);
            this.loginTab.Controls.Add(this.materialLabel1);
            this.loginTab.Controls.Add(this.materialLabel2);
            this.loginTab.Location = new System.Drawing.Point(4, 22);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.loginTab.Size = new System.Drawing.Size(530, 369);
            this.loginTab.TabIndex = 1;
            this.loginTab.Text = "Log in";
            // 
            // login_button
            // 
            this.login_button.Depth = 0;
            this.login_button.Location = new System.Drawing.Point(44, 272);
            this.login_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_button.Name = "login_button";
            this.login_button.Primary = true;
            this.login_button.Size = new System.Drawing.Size(439, 38);
            this.login_button.TabIndex = 83;
            this.login_button.Text = "LOG IN";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.BackColor = System.Drawing.Color.White;
            this.loginPasswordTextBox.Depth = 0;
            this.loginPasswordTextBox.ForeColor = System.Drawing.Color.LightCoral;
            this.loginPasswordTextBox.Hint = "ENTER YOUR PASSWORD";
            this.loginPasswordTextBox.Location = new System.Drawing.Point(209, 164);
            this.loginPasswordTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '\0';
            this.loginPasswordTextBox.SelectedText = "";
            this.loginPasswordTextBox.SelectionLength = 0;
            this.loginPasswordTextBox.SelectionStart = 0;
            this.loginPasswordTextBox.Size = new System.Drawing.Size(273, 23);
            this.loginPasswordTextBox.TabIndex = 81;
            this.loginPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // loginEmailTextBox
            // 
            this.loginEmailTextBox.BackColor = System.Drawing.Color.White;
            this.loginEmailTextBox.Depth = 0;
            this.loginEmailTextBox.ForeColor = System.Drawing.Color.LightCoral;
            this.loginEmailTextBox.Hint = "ENTER YOUR E-MAIL";
            this.loginEmailTextBox.Location = new System.Drawing.Point(209, 123);
            this.loginEmailTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginEmailTextBox.Name = "loginEmailTextBox";
            this.loginEmailTextBox.PasswordChar = '\0';
            this.loginEmailTextBox.SelectedText = "";
            this.loginEmailTextBox.SelectionLength = 0;
            this.loginEmailTextBox.SelectionStart = 0;
            this.loginEmailTextBox.Size = new System.Drawing.Size(273, 23);
            this.loginEmailTextBox.TabIndex = 80;
            this.loginEmailTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(97, 164);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 79;
            this.materialLabel1.Text = "Password";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(121, 123);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(51, 19);
            this.materialLabel2.TabIndex = 78;
            this.materialLabel2.Text = "E-mail";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(561, 54);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // errn
            // 
            this.errn.AutoSize = true;
            this.errn.ForeColor = System.Drawing.Color.Red;
            this.errn.Location = new System.Drawing.Point(396, 60);
            this.errn.Name = "errn";
            this.errn.Size = new System.Drawing.Size(46, 13);
            this.errn.TabIndex = 83;
            this.errn.Text = "ERROR";
            this.errn.Visible = false;
            // 
            // errm
            // 
            this.errm.AutoSize = true;
            this.errm.ForeColor = System.Drawing.Color.Red;
            this.errm.Location = new System.Drawing.Point(396, 105);
            this.errm.Name = "errm";
            this.errm.Size = new System.Drawing.Size(46, 13);
            this.errm.TabIndex = 84;
            this.errm.Text = "ERROR";
            this.errm.Visible = false;
            // 
            // errp
            // 
            this.errp.AutoSize = true;
            this.errp.ForeColor = System.Drawing.Color.Red;
            this.errp.Location = new System.Drawing.Point(396, 146);
            this.errp.Name = "errp";
            this.errp.Size = new System.Drawing.Size(46, 13);
            this.errp.TabIndex = 85;
            this.errp.Text = "ERROR";
            this.errp.Visible = false;
            // 
            // errc
            // 
            this.errc.AutoSize = true;
            this.errc.ForeColor = System.Drawing.Color.Red;
            this.errc.Location = new System.Drawing.Point(396, 190);
            this.errc.Name = "errc";
            this.errc.Size = new System.Drawing.Size(46, 13);
            this.errc.TabIndex = 86;
            this.errc.Text = "ERROR";
            this.errc.Visible = false;
            // 
            // LoginRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(555, 512);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "LoginRegisterForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinkedIn";
            this.Load += new System.EventHandler(this.LoginRegisterForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.registerTab.ResumeLayout(false);
            this.registerTab.PerformLayout();
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage registerTab;
        private System.Windows.Forms.TabPage loginTab;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialSingleLineTextField confirmPassword_txtBox;
        private MaterialSkin.Controls.MaterialLabel confirmPassword_label;
        private MaterialSkin.Controls.MaterialSingleLineTextField Password_txtBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField email_txtBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField name_txtBox;
        private MaterialSkin.Controls.MaterialLabel password_Label;
        private MaterialSkin.Controls.MaterialLabel email_Label;
        private MaterialSkin.Controls.MaterialLabel Name_label;
        private MaterialSkin.Controls.MaterialRadioButton jobProvider_RadioButton;
        private MaterialSkin.Controls.MaterialRadioButton jobSeeker_RadioButton;
        private MaterialSkin.Controls.MaterialRaisedButton ContinueRegister_button;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginPasswordTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginEmailTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton login_button;
        private System.Windows.Forms.Label errc;
        private System.Windows.Forms.Label errn;
        private System.Windows.Forms.Label errm;
        private System.Windows.Forms.Label errp;
    }
}

