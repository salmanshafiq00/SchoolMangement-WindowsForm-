
namespace SchoolManagement
{
    partial class schoolManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(schoolManagement));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnStuPerform = new System.Windows.Forms.Button();
            this.btnStuProfile = new System.Windows.Forms.Button();
            this.infoSubPanel = new System.Windows.Forms.Panel();
            this.btnTeaInfo = new System.Windows.Forms.Button();
            this.btnStuInfo = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.regSubMenuPanel = new System.Windows.Forms.Panel();
            this.btnRegTea = new System.Windows.Forms.Button();
            this.btnRegStu = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.picBoxForLogo = new System.Windows.Forms.PictureBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.restoreApp = new System.Windows.Forms.Button();
            this.minimizeApp = new System.Windows.Forms.Button();
            this.maxApp = new System.Windows.Forms.Button();
            this.closeApp = new System.Windows.Forms.Button();
            this.HomeTitle = new System.Windows.Forms.Label();
            this.homePagePicBox = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teacherRegistrationForm = new SchoolManagement.teacherRegistrationForm();
            this.studentRegistrationForm = new SchoolManagement.studentRegistrationForm();
            this.studentInfo = new SchoolManagement.studentInfo();
            this.studentPerformanceForm = new SchoolManagement.StudentPerformanceForm();
            this.sidePanel.SuspendLayout();
            this.infoSubPanel.SuspendLayout();
            this.regSubMenuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxForLogo)).BeginInit();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePagePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.sidePanel.Controls.Add(this.btnReport);
            this.sidePanel.Controls.Add(this.btnStuPerform);
            this.sidePanel.Controls.Add(this.btnStuProfile);
            this.sidePanel.Controls.Add(this.infoSubPanel);
            this.sidePanel.Controls.Add(this.btnInfo);
            this.sidePanel.Controls.Add(this.regSubMenuPanel);
            this.sidePanel.Controls.Add(this.btnRegistration);
            this.sidePanel.Controls.Add(this.btnHome);
            this.sidePanel.Controls.Add(this.logoPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 588);
            this.sidePanel.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnReport.Image = global::SchoolManagement.Properties.Resources.business_report;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 514);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(200, 45);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Student Report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnStuPerform
            // 
            this.btnStuPerform.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStuPerform.FlatAppearance.BorderSize = 0;
            this.btnStuPerform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnStuPerform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStuPerform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuPerform.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnStuPerform.Image = global::SchoolManagement.Properties.Resources.bar_chart;
            this.btnStuPerform.Location = new System.Drawing.Point(0, 469);
            this.btnStuPerform.Name = "btnStuPerform";
            this.btnStuPerform.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStuPerform.Size = new System.Drawing.Size(200, 45);
            this.btnStuPerform.TabIndex = 9;
            this.btnStuPerform.Text = "Student Performance";
            this.btnStuPerform.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStuPerform.UseVisualStyleBackColor = true;
            this.btnStuPerform.Click += new System.EventHandler(this.btnStuPerform_Click);
            // 
            // btnStuProfile
            // 
            this.btnStuProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStuProfile.FlatAppearance.BorderSize = 0;
            this.btnStuProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnStuProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStuProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuProfile.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnStuProfile.Image = global::SchoolManagement.Properties.Resources.user1;
            this.btnStuProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStuProfile.Location = new System.Drawing.Point(0, 424);
            this.btnStuProfile.Name = "btnStuProfile";
            this.btnStuProfile.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStuProfile.Size = new System.Drawing.Size(200, 45);
            this.btnStuProfile.TabIndex = 8;
            this.btnStuProfile.Text = "Student Profile";
            this.btnStuProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStuProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStuProfile.UseVisualStyleBackColor = true;
            this.btnStuProfile.Click += new System.EventHandler(this.btnStuProfile_Click);
            // 
            // infoSubPanel
            // 
            this.infoSubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.infoSubPanel.Controls.Add(this.btnTeaInfo);
            this.infoSubPanel.Controls.Add(this.btnStuInfo);
            this.infoSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoSubPanel.Location = new System.Drawing.Point(0, 328);
            this.infoSubPanel.Name = "infoSubPanel";
            this.infoSubPanel.Size = new System.Drawing.Size(200, 96);
            this.infoSubPanel.TabIndex = 7;
            // 
            // btnTeaInfo
            // 
            this.btnTeaInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeaInfo.FlatAppearance.BorderSize = 0;
            this.btnTeaInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnTeaInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeaInfo.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnTeaInfo.Location = new System.Drawing.Point(0, 40);
            this.btnTeaInfo.Name = "btnTeaInfo";
            this.btnTeaInfo.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnTeaInfo.Size = new System.Drawing.Size(200, 40);
            this.btnTeaInfo.TabIndex = 1;
            this.btnTeaInfo.Text = "Teacher Info";
            this.btnTeaInfo.UseVisualStyleBackColor = true;
            this.btnTeaInfo.Click += new System.EventHandler(this.btnTeaInfo_Click);
            // 
            // btnStuInfo
            // 
            this.btnStuInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStuInfo.FlatAppearance.BorderSize = 0;
            this.btnStuInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnStuInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStuInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuInfo.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnStuInfo.Location = new System.Drawing.Point(0, 0);
            this.btnStuInfo.Name = "btnStuInfo";
            this.btnStuInfo.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnStuInfo.Size = new System.Drawing.Size(200, 40);
            this.btnStuInfo.TabIndex = 0;
            this.btnStuInfo.Text = "Student Info";
            this.btnStuInfo.UseVisualStyleBackColor = true;
            this.btnStuInfo.Click += new System.EventHandler(this.btnStuInfo_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnInfo.Image = global::SchoolManagement.Properties.Resources.information;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 283);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInfo.Size = new System.Drawing.Size(200, 45);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "Information";
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // regSubMenuPanel
            // 
            this.regSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.regSubMenuPanel.Controls.Add(this.btnRegTea);
            this.regSubMenuPanel.Controls.Add(this.btnRegStu);
            this.regSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.regSubMenuPanel.ForeColor = System.Drawing.Color.AliceBlue;
            this.regSubMenuPanel.Location = new System.Drawing.Point(0, 190);
            this.regSubMenuPanel.Name = "regSubMenuPanel";
            this.regSubMenuPanel.Size = new System.Drawing.Size(200, 93);
            this.regSubMenuPanel.TabIndex = 3;
            // 
            // btnRegTea
            // 
            this.btnRegTea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnRegTea.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegTea.FlatAppearance.BorderSize = 0;
            this.btnRegTea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnRegTea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegTea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegTea.Location = new System.Drawing.Point(0, 40);
            this.btnRegTea.Name = "btnRegTea";
            this.btnRegTea.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnRegTea.Size = new System.Drawing.Size(200, 40);
            this.btnRegTea.TabIndex = 1;
            this.btnRegTea.Text = "Teacher";
            this.btnRegTea.UseVisualStyleBackColor = false;
            this.btnRegTea.Click += new System.EventHandler(this.btnRegTea_Click);
            // 
            // btnRegStu
            // 
            this.btnRegStu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnRegStu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegStu.FlatAppearance.BorderSize = 0;
            this.btnRegStu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnRegStu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegStu.Location = new System.Drawing.Point(0, 0);
            this.btnRegStu.Name = "btnRegStu";
            this.btnRegStu.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnRegStu.Size = new System.Drawing.Size(200, 40);
            this.btnRegStu.TabIndex = 0;
            this.btnRegStu.Text = "Student";
            this.btnRegStu.UseVisualStyleBackColor = false;
            this.btnRegStu.Click += new System.EventHandler(this.btnRegStu_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistration.FlatAppearance.BorderSize = 0;
            this.btnRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnRegistration.Image = global::SchoolManagement.Properties.Resources.writing;
            this.btnRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistration.Location = new System.Drawing.Point(0, 145);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRegistration.Size = new System.Drawing.Size(200, 45);
            this.btnRegistration.TabIndex = 2;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnHome.Image = global::SchoolManagement.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 100);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(200, 45);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.picBoxForLogo);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 100);
            this.logoPanel.TabIndex = 0;
            // 
            // picBoxForLogo
            // 
            this.picBoxForLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxForLogo.Image")));
            this.picBoxForLogo.Location = new System.Drawing.Point(0, 3);
            this.picBoxForLogo.Name = "picBoxForLogo";
            this.picBoxForLogo.Size = new System.Drawing.Size(200, 85);
            this.picBoxForLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxForLogo.TabIndex = 0;
            this.picBoxForLogo.TabStop = false;
            // 
            // titlePanel
            // 
            this.titlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.titlePanel.Controls.Add(this.restoreApp);
            this.titlePanel.Controls.Add(this.minimizeApp);
            this.titlePanel.Controls.Add(this.maxApp);
            this.titlePanel.Controls.Add(this.closeApp);
            this.titlePanel.Controls.Add(this.HomeTitle);
            this.titlePanel.Location = new System.Drawing.Point(200, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(917, 47);
            this.titlePanel.TabIndex = 1;
            // 
            // restoreApp
            // 
            this.restoreApp.FlatAppearance.BorderSize = 0;
            this.restoreApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.restoreApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.restoreApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreApp.Image = ((System.Drawing.Image)(resources.GetObject("restoreApp.Image")));
            this.restoreApp.Location = new System.Drawing.Point(742, 6);
            this.restoreApp.Name = "restoreApp";
            this.restoreApp.Padding = new System.Windows.Forms.Padding(2);
            this.restoreApp.Size = new System.Drawing.Size(33, 33);
            this.restoreApp.TabIndex = 8;
            this.restoreApp.UseVisualStyleBackColor = true;
            this.restoreApp.Visible = false;
            this.restoreApp.Click += new System.EventHandler(this.restoreApp_Click);
            // 
            // minimizeApp
            // 
            this.minimizeApp.FlatAppearance.BorderSize = 0;
            this.minimizeApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.minimizeApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.minimizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeApp.Image = ((System.Drawing.Image)(resources.GetObject("minimizeApp.Image")));
            this.minimizeApp.Location = new System.Drawing.Point(781, 6);
            this.minimizeApp.Name = "minimizeApp";
            this.minimizeApp.Padding = new System.Windows.Forms.Padding(2);
            this.minimizeApp.Size = new System.Drawing.Size(33, 33);
            this.minimizeApp.TabIndex = 7;
            this.minimizeApp.UseVisualStyleBackColor = true;
            this.minimizeApp.Click += new System.EventHandler(this.minimizeApp_Click);
            // 
            // maxApp
            // 
            this.maxApp.FlatAppearance.BorderSize = 0;
            this.maxApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.maxApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.maxApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxApp.Image = ((System.Drawing.Image)(resources.GetObject("maxApp.Image")));
            this.maxApp.Location = new System.Drawing.Point(821, 6);
            this.maxApp.Name = "maxApp";
            this.maxApp.Padding = new System.Windows.Forms.Padding(2);
            this.maxApp.Size = new System.Drawing.Size(33, 33);
            this.maxApp.TabIndex = 6;
            this.maxApp.UseVisualStyleBackColor = true;
            this.maxApp.Click += new System.EventHandler(this.maxApp_Click);
            // 
            // closeApp
            // 
            this.closeApp.FlatAppearance.BorderSize = 0;
            this.closeApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.closeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeApp.Image = ((System.Drawing.Image)(resources.GetObject("closeApp.Image")));
            this.closeApp.Location = new System.Drawing.Point(860, 6);
            this.closeApp.Name = "closeApp";
            this.closeApp.Padding = new System.Windows.Forms.Padding(2);
            this.closeApp.Size = new System.Drawing.Size(33, 33);
            this.closeApp.TabIndex = 5;
            this.closeApp.Tag = "Close Application";
            this.closeApp.UseVisualStyleBackColor = true;
            this.closeApp.Click += new System.EventHandler(this.closeApp_Click);
            // 
            // HomeTitle
            // 
            this.HomeTitle.AutoSize = true;
            this.HomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTitle.ForeColor = System.Drawing.Color.SkyBlue;
            this.HomeTitle.Location = new System.Drawing.Point(239, 5);
            this.HomeTitle.Name = "HomeTitle";
            this.HomeTitle.Size = new System.Drawing.Size(374, 36);
            this.HomeTitle.TabIndex = 0;
            this.HomeTitle.Text = "SFS School Management";
            // 
            // homePagePicBox
            // 
            this.homePagePicBox.Image = ((System.Drawing.Image)(resources.GetObject("homePagePicBox.Image")));
            this.homePagePicBox.Location = new System.Drawing.Point(368, 100);
            this.homePagePicBox.Name = "homePagePicBox";
            this.homePagePicBox.Size = new System.Drawing.Size(512, 451);
            this.homePagePicBox.TabIndex = 2;
            this.homePagePicBox.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblWelcome.Location = new System.Drawing.Point(422, 102);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(389, 31);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome To School Dashboard!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(837, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Salman Farsy Shafiq";
            // 
            // teacherRegistrationForm
            // 
            this.teacherRegistrationForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teacherRegistrationForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.teacherRegistrationForm.Location = new System.Drawing.Point(200, 48);
            this.teacherRegistrationForm.Name = "teacherRegistrationForm";
            this.teacherRegistrationForm.Size = new System.Drawing.Size(919, 541);
            this.teacherRegistrationForm.TabIndex = 6;
            // 
            // studentRegistrationForm
            // 
            this.studentRegistrationForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentRegistrationForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.studentRegistrationForm.Location = new System.Drawing.Point(200, 47);
            this.studentRegistrationForm.Name = "studentRegistrationForm";
            this.studentRegistrationForm.Size = new System.Drawing.Size(917, 541);
            this.studentRegistrationForm.TabIndex = 5;
            // 
            // studentInfo
            // 
            this.studentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.studentInfo.Location = new System.Drawing.Point(200, 48);
            this.studentInfo.Name = "studentInfo";
            this.studentInfo.Size = new System.Drawing.Size(919, 541);
            this.studentInfo.TabIndex = 7;
            // 
            // studentPerformanceForm
            // 
            this.studentPerformanceForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentPerformanceForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.studentPerformanceForm.Location = new System.Drawing.Point(200, 48);
            this.studentPerformanceForm.Name = "studentPerformanceForm";
            this.studentPerformanceForm.Size = new System.Drawing.Size(917, 541);
            this.studentPerformanceForm.TabIndex = 8;
            // 
            // schoolManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1117, 588);
            this.Controls.Add(this.studentPerformanceForm);
            this.Controls.Add(this.studentInfo);
            this.Controls.Add(this.teacherRegistrationForm);
            this.Controls.Add(this.studentRegistrationForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.homePagePicBox);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.sidePanel);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "schoolManagement";
            this.Text = "schoolManagement";
            this.Load += new System.EventHandler(this.schoolManagement_Load_1);
            this.sidePanel.ResumeLayout(false);
            this.infoSubPanel.ResumeLayout(false);
            this.regSubMenuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxForLogo)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePagePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel regSubMenuPanel;
        private System.Windows.Forms.Button btnRegTea;
        private System.Windows.Forms.Button btnRegStu;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox homePagePicBox;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox picBoxForLogo;
        private System.Windows.Forms.Label label1;
        private studentRegistrationForm studentRegistrationForm;
        private teacherRegistrationForm teacherRegistrationForm;
        private System.Windows.Forms.Panel infoSubPanel;
        private System.Windows.Forms.Button btnTeaInfo;
        private System.Windows.Forms.Button btnStuInfo;
        private System.Windows.Forms.Button btnStuPerform;
        private System.Windows.Forms.Button btnStuProfile;
        private studentInfo studentInfo;
        private StudentPerformanceForm studentPerformanceForm;
        private System.Windows.Forms.Label HomeTitle;
        private System.Windows.Forms.Button restoreApp;
        private System.Windows.Forms.Button minimizeApp;
        private System.Windows.Forms.Button maxApp;
        private System.Windows.Forms.Button closeApp;
        private System.Windows.Forms.Button btnReport;
    }
}