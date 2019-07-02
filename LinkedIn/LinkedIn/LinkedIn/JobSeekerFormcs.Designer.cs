namespace LinkedIn
{
    partial class JobSeekerFormcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobSeekerFormcs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.followBunifuThinButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.seekerRichTextBox = new System.Windows.Forms.RichTextBox();
            this.seekerDataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.postsDataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.writePostBunifuMetroTextbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.writePostButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Search = new System.Windows.Forms.TabPage();
            this.postsListView = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.searchByTextBox = new System.Windows.Forms.TextBox();
            this.searchBySkillRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.searchByCompanyRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.Notification = new System.Windows.Forms.TabPage();
            this.applyButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.suitableVacanciesDataGridView = new System.Windows.Forms.DataGridView();
            this.Profile = new System.Windows.Forms.TabPage();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.educationLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.countryLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.cityLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.emailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.phoneLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.femaleORmaleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.projectsListView = new System.Windows.Forms.ListView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.experienceListView = new System.Windows.Forms.ListView();
            this.materialTabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seekerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsDataGridView)).BeginInit();
            this.Search.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Notification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suitableVacanciesDataGridView)).BeginInit();
            this.Profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 61);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(807, 53);
            this.materialTabSelector1.TabIndex = 3;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Home);
            this.materialTabControl1.Controls.Add(this.Search);
            this.materialTabControl1.Controls.Add(this.Notification);
            this.materialTabControl1.Controls.Add(this.Profile);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(9, 129);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(785, 429);
            this.materialTabControl1.TabIndex = 2;
            // 
            // Home
            // 
            this.Home.AutoScroll = true;
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.Controls.Add(this.followBunifuThinButton);
            this.Home.Controls.Add(this.seekerRichTextBox);
            this.Home.Controls.Add(this.seekerDataGridView);
            this.Home.Controls.Add(this.postsDataGridView);
            this.Home.Controls.Add(this.writePostBunifuMetroTextbox);
            this.Home.Controls.Add(this.writePostButton);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(777, 403);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // followBunifuThinButton
            // 
            this.followBunifuThinButton.ActiveBorderThickness = 1;
            this.followBunifuThinButton.ActiveCornerRadius = 20;
            this.followBunifuThinButton.ActiveFillColor = System.Drawing.Color.Transparent;
            this.followBunifuThinButton.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.followBunifuThinButton.ActiveLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.followBunifuThinButton.BackColor = System.Drawing.Color.White;
            this.followBunifuThinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("followBunifuThinButton.BackgroundImage")));
            this.followBunifuThinButton.ButtonText = "FOLLOW";
            this.followBunifuThinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.followBunifuThinButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followBunifuThinButton.ForeColor = System.Drawing.Color.Navy;
            this.followBunifuThinButton.IdleBorderThickness = 1;
            this.followBunifuThinButton.IdleCornerRadius = 15;
            this.followBunifuThinButton.IdleFillColor = System.Drawing.Color.LightSteelBlue;
            this.followBunifuThinButton.IdleForecolor = System.Drawing.Color.Navy;
            this.followBunifuThinButton.IdleLineColor = System.Drawing.Color.DarkBlue;
            this.followBunifuThinButton.Location = new System.Drawing.Point(633, 219);
            this.followBunifuThinButton.Margin = new System.Windows.Forms.Padding(5);
            this.followBunifuThinButton.Name = "followBunifuThinButton";
            this.followBunifuThinButton.Size = new System.Drawing.Size(75, 37);
            this.followBunifuThinButton.TabIndex = 9;
            this.followBunifuThinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.followBunifuThinButton.Visible = false;
            this.followBunifuThinButton.Click += new System.EventHandler(this.followBunifuThinButton_Click);
            // 
            // seekerRichTextBox
            // 
            this.seekerRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seekerRichTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.seekerRichTextBox.Location = new System.Drawing.Point(377, 87);
            this.seekerRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.seekerRichTextBox.Name = "seekerRichTextBox";
            this.seekerRichTextBox.Size = new System.Drawing.Size(332, 170);
            this.seekerRichTextBox.TabIndex = 8;
            this.seekerRichTextBox.Text = "";
            this.seekerRichTextBox.Visible = false;
            // 
            // seekerDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.seekerDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.seekerDataGridView.BackgroundColor = System.Drawing.Color.LightBlue;
            this.seekerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seekerDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.seekerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.seekerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seekerDataGridView.DoubleBuffered = true;
            this.seekerDataGridView.EnableHeadersVisualStyles = false;
            this.seekerDataGridView.HeaderBgColor = System.Drawing.Color.SkyBlue;
            this.seekerDataGridView.HeaderForeColor = System.Drawing.Color.Black;
            this.seekerDataGridView.Location = new System.Drawing.Point(377, 87);
            this.seekerDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.seekerDataGridView.Name = "seekerDataGridView";
            this.seekerDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.seekerDataGridView.RowTemplate.Height = 28;
            this.seekerDataGridView.Size = new System.Drawing.Size(331, 127);
            this.seekerDataGridView.TabIndex = 6;
            this.seekerDataGridView.Visible = false;
            // 
            // postsDataGridView
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.postsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.postsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.postsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.postsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.postsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.postsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.postsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.postsDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.postsDataGridView.DoubleBuffered = true;
            this.postsDataGridView.EnableHeadersVisualStyles = false;
            this.postsDataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.postsDataGridView.HeaderBgColor = System.Drawing.Color.Azure;
            this.postsDataGridView.HeaderForeColor = System.Drawing.Color.Black;
            this.postsDataGridView.Location = new System.Drawing.Point(16, 87);
            this.postsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.postsDataGridView.Name = "postsDataGridView";
            this.postsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.postsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.postsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postsDataGridView.RowTemplate.Height = 28;
            this.postsDataGridView.Size = new System.Drawing.Size(269, 315);
            this.postsDataGridView.TabIndex = 5;
            this.postsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.postsDataGridView_CellClick_1);
            // 
            // writePostBunifuMetroTextbox
            // 
            this.writePostBunifuMetroTextbox.BorderColorFocused = System.Drawing.Color.Blue;
            this.writePostBunifuMetroTextbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.writePostBunifuMetroTextbox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.writePostBunifuMetroTextbox.BorderThickness = 3;
            this.writePostBunifuMetroTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.writePostBunifuMetroTextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writePostBunifuMetroTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.writePostBunifuMetroTextbox.isPassword = false;
            this.writePostBunifuMetroTextbox.Location = new System.Drawing.Point(3, 27);
            this.writePostBunifuMetroTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.writePostBunifuMetroTextbox.Name = "writePostBunifuMetroTextbox";
            this.writePostBunifuMetroTextbox.Size = new System.Drawing.Size(357, 58);
            this.writePostBunifuMetroTextbox.TabIndex = 4;
            this.writePostBunifuMetroTextbox.Text = "What\'s on your mind?";
            this.writePostBunifuMetroTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // writePostButton
            // 
            this.writePostButton.BackColor = System.Drawing.Color.Transparent;
            this.writePostButton.Depth = 0;
            this.writePostButton.Location = new System.Drawing.Point(413, 27);
            this.writePostButton.Margin = new System.Windows.Forms.Padding(2);
            this.writePostButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.writePostButton.Name = "writePostButton";
            this.writePostButton.Primary = true;
            this.writePostButton.Size = new System.Drawing.Size(113, 34);
            this.writePostButton.TabIndex = 2;
            this.writePostButton.Text = "Write post";
            this.writePostButton.UseVisualStyleBackColor = false;
            this.writePostButton.Click += new System.EventHandler(this.writePostButton_Click);
            // 
            // Search
            // 
            this.Search.Controls.Add(this.postsListView);
            this.Search.Controls.Add(this.groupBox1);
            this.Search.Location = new System.Drawing.Point(4, 22);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(777, 403);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // postsListView
            // 
            this.postsListView.Location = new System.Drawing.Point(391, 66);
            this.postsListView.Name = "postsListView";
            this.postsListView.Size = new System.Drawing.Size(365, 270);
            this.postsListView.TabIndex = 3;
            this.postsListView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.searchByTextBox);
            this.groupBox1.Controls.Add(this.searchBySkillRadioButton);
            this.groupBox1.Controls.Add(this.searchByCompanyRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(21, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By:";
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchButton.Depth = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchButton.Location = new System.Drawing.Point(62, 149);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchButton.Name = "searchButton";
            this.searchButton.Primary = false;
            this.searchButton.Size = new System.Drawing.Size(64, 36);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchByTextBox
            // 
            this.searchByTextBox.Location = new System.Drawing.Point(6, 117);
            this.searchByTextBox.Name = "searchByTextBox";
            this.searchByTextBox.Size = new System.Drawing.Size(175, 20);
            this.searchByTextBox.TabIndex = 2;
            // 
            // searchBySkillRadioButton
            // 
            this.searchBySkillRadioButton.AutoSize = true;
            this.searchBySkillRadioButton.Depth = 0;
            this.searchBySkillRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchBySkillRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.searchBySkillRadioButton.Location = new System.Drawing.Point(3, 67);
            this.searchBySkillRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.searchBySkillRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.searchBySkillRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchBySkillRadioButton.Name = "searchBySkillRadioButton";
            this.searchBySkillRadioButton.Ripple = true;
            this.searchBySkillRadioButton.Size = new System.Drawing.Size(79, 30);
            this.searchBySkillRadioButton.TabIndex = 1;
            this.searchBySkillRadioButton.TabStop = true;
            this.searchBySkillRadioButton.Text = "Job title";
            this.searchBySkillRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchByCompanyRadioButton
            // 
            this.searchByCompanyRadioButton.AutoSize = true;
            this.searchByCompanyRadioButton.Depth = 0;
            this.searchByCompanyRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchByCompanyRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.searchByCompanyRadioButton.Location = new System.Drawing.Point(3, 25);
            this.searchByCompanyRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.searchByCompanyRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.searchByCompanyRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchByCompanyRadioButton.Name = "searchByCompanyRadioButton";
            this.searchByCompanyRadioButton.Ripple = true;
            this.searchByCompanyRadioButton.Size = new System.Drawing.Size(87, 30);
            this.searchByCompanyRadioButton.TabIndex = 0;
            this.searchByCompanyRadioButton.TabStop = true;
            this.searchByCompanyRadioButton.Text = "Company";
            this.searchByCompanyRadioButton.UseVisualStyleBackColor = true;
            // 
            // Notification
            // 
            this.Notification.Controls.Add(this.applyButton);
            this.Notification.Controls.Add(this.suitableVacanciesDataGridView);
            this.Notification.Location = new System.Drawing.Point(4, 22);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(777, 403);
            this.Notification.TabIndex = 2;
            this.Notification.Text = "Notification";
            this.Notification.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.Depth = 0;
            this.applyButton.Location = new System.Drawing.Point(158, 353);
            this.applyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.applyButton.Name = "applyButton";
            this.applyButton.Primary = true;
            this.applyButton.Size = new System.Drawing.Size(378, 46);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "APPLY";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // suitableVacanciesDataGridView
            // 
            this.suitableVacanciesDataGridView.AllowUserToAddRows = false;
            this.suitableVacanciesDataGridView.AllowUserToDeleteRows = false;
            this.suitableVacanciesDataGridView.AllowUserToOrderColumns = true;
            this.suitableVacanciesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suitableVacanciesDataGridView.Location = new System.Drawing.Point(22, 56);
            this.suitableVacanciesDataGridView.Name = "suitableVacanciesDataGridView";
            this.suitableVacanciesDataGridView.ReadOnly = true;
            this.suitableVacanciesDataGridView.Size = new System.Drawing.Size(733, 291);
            this.suitableVacanciesDataGridView.TabIndex = 1;
            this.suitableVacanciesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suitableVacanciesDataGridView_CellDoubleClick);
            this.suitableVacanciesDataGridView.Click += new System.EventHandler(this.suitableVacanciesDataGridView_Click);
            // 
            // Profile
            // 
            this.Profile.Controls.Add(this.materialRaisedButton1);
            this.Profile.Controls.Add(this.materialRaisedButton2);
            this.Profile.Controls.Add(this.educationLabel);
            this.Profile.Controls.Add(this.pictureBox1);
            this.Profile.Controls.Add(this.nameLabel);
            this.Profile.Controls.Add(this.materialLabel12);
            this.Profile.Controls.Add(this.countryLabel);
            this.Profile.Controls.Add(this.materialLabel11);
            this.Profile.Controls.Add(this.cityLabel);
            this.Profile.Controls.Add(this.materialLabel10);
            this.Profile.Controls.Add(this.emailLabel);
            this.Profile.Controls.Add(this.materialLabel9);
            this.Profile.Controls.Add(this.phoneLabel);
            this.Profile.Controls.Add(this.materialLabel6);
            this.Profile.Controls.Add(this.femaleORmaleLabel);
            this.Profile.Controls.Add(this.materialLabel5);
            this.Profile.Controls.Add(this.materialLabel4);
            this.Profile.Controls.Add(this.materialLabel3);
            this.Profile.Controls.Add(this.materialLabel2);
            this.Profile.Controls.Add(this.projectsListView);
            this.Profile.Controls.Add(this.materialLabel1);
            this.Profile.Controls.Add(this.experienceListView);
            this.Profile.Location = new System.Drawing.Point(4, 22);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(777, 403);
            this.Profile.TabIndex = 3;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(609, 306);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(152, 39);
            this.materialRaisedButton1.TabIndex = 26;
            this.materialRaisedButton1.Text = "EDIT PROFILE";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(609, 351);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(152, 39);
            this.materialRaisedButton2.TabIndex = 25;
            this.materialRaisedButton2.Text = "LOG OUT";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // educationLabel
            // 
            this.educationLabel.AutoSize = true;
            this.educationLabel.Depth = 0;
            this.educationLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.educationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.educationLabel.Location = new System.Drawing.Point(588, 123);
            this.educationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.educationLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.educationLabel.Name = "educationLabel";
            this.educationLabel.Size = new System.Drawing.Size(0, 19);
            this.educationLabel.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 44);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Depth = 0;
            this.nameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nameLabel.Location = new System.Drawing.Point(59, 40);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 19);
            this.nameLabel.TabIndex = 22;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(2, 40);
            this.materialLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(53, 19);
            this.materialLabel12.TabIndex = 21;
            this.materialLabel12.Text = "Name:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Depth = 0;
            this.countryLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.countryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.countryLabel.Location = new System.Drawing.Point(577, 92);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countryLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(0, 19);
            this.countryLabel.TabIndex = 20;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(497, 92);
            this.materialLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(65, 19);
            this.materialLabel11.TabIndex = 19;
            this.materialLabel11.Text = "Country:";
            this.materialLabel11.Click += new System.EventHandler(this.materialLabel11_Click);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Depth = 0;
            this.cityLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.cityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cityLabel.Location = new System.Drawing.Point(559, 67);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cityLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(0, 19);
            this.cityLabel.TabIndex = 18;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(497, 67);
            this.materialLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(39, 19);
            this.materialLabel10.TabIndex = 17;
            this.materialLabel10.Text = "City:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Depth = 0;
            this.emailLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emailLabel.Location = new System.Drawing.Point(315, 40);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(0, 19);
            this.emailLabel.TabIndex = 16;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(247, 40);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(51, 19);
            this.materialLabel9.TabIndex = 15;
            this.materialLabel9.Text = "Email:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Depth = 0;
            this.phoneLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.phoneLabel.Location = new System.Drawing.Point(304, 92);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(0, 19);
            this.phoneLabel.TabIndex = 14;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(247, 92);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(55, 19);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Phone:";
            // 
            // femaleORmaleLabel
            // 
            this.femaleORmaleLabel.AutoSize = true;
            this.femaleORmaleLabel.Depth = 0;
            this.femaleORmaleLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.femaleORmaleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.femaleORmaleLabel.Location = new System.Drawing.Point(315, 66);
            this.femaleORmaleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.femaleORmaleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.femaleORmaleLabel.Name = "femaleORmaleLabel";
            this.femaleORmaleLabel.Size = new System.Drawing.Size(0, 19);
            this.femaleORmaleLabel.TabIndex = 12;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(247, 66);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(60, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Gender:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(1, 6);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(46, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "INFO:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(497, 123);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(80, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Education:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(247, 123);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(65, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Projects";
            // 
            // projectsListView
            // 
            this.projectsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsListView.Location = new System.Drawing.Point(250, 143);
            this.projectsListView.Margin = new System.Windows.Forms.Padding(2);
            this.projectsListView.Name = "projectsListView";
            this.projectsListView.Size = new System.Drawing.Size(227, 256);
            this.projectsListView.TabIndex = 4;
            this.projectsListView.UseCompatibleStateImageBehavior = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(2, 123);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(90, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Experiences";
            // 
            // experienceListView
            // 
            this.experienceListView.Location = new System.Drawing.Point(2, 143);
            this.experienceListView.Margin = new System.Windows.Forms.Padding(2);
            this.experienceListView.Name = "experienceListView";
            this.experienceListView.Size = new System.Drawing.Size(227, 256);
            this.experienceListView.TabIndex = 0;
            this.experienceListView.UseCompatibleStateImageBehavior = false;
            // 
            // JobSeekerFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "JobSeekerFormcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobSeekerForm";
            this.Load += new System.EventHandler(this.JobSeekerFormcs_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seekerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsDataGridView)).EndInit();
            this.Search.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Notification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suitableVacanciesDataGridView)).EndInit();
            this.Profile.ResumeLayout(false);
            this.Profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.TabPage Notification;
        private System.Windows.Forms.TabPage Profile;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox writePostBunifuMetroTextbox;
        private MaterialSkin.Controls.MaterialRaisedButton writePostButton;
        private Bunifu.Framework.UI.BunifuCustomDataGrid seekerDataGridView;
        private System.Windows.Forms.RichTextBox seekerRichTextBox;
        private Bunifu.Framework.UI.BunifuCustomDataGrid postsDataGridView;
        private Bunifu.Framework.UI.BunifuThinButton2 followBunifuThinButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ListView projectsListView;
        private System.Windows.Forms.ListView experienceListView;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel emailLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel phoneLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel femaleORmaleLabel;
        private MaterialSkin.Controls.MaterialLabel cityLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel countryLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel nameLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel educationLabel;
        private System.Windows.Forms.ListView postsListView;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialFlatButton searchButton;
        private System.Windows.Forms.TextBox searchByTextBox;
        private MaterialSkin.Controls.MaterialRadioButton searchBySkillRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton searchByCompanyRadioButton;
        private System.Windows.Forms.DataGridView suitableVacanciesDataGridView;
        private MaterialSkin.Controls.MaterialRaisedButton applyButton;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}