
namespace SchoolManagement
{
    partial class StudentProfile
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
            this.titlePanelStuPro = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStuProTitle = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.placeClass = new System.Windows.Forms.Label();
            this.placeSection = new System.Windows.Forms.Label();
            this.placeId = new System.Windows.Forms.Label();
            this.gbGuardian = new System.Windows.Forms.GroupBox();
            this.placeContact = new System.Windows.Forms.Label();
            this.placeFather = new System.Windows.Forms.Label();
            this.lblfathCont = new System.Windows.Forms.Label();
            this.lblfather = new System.Windows.Forms.Label();
            this.gbStuProfile = new System.Windows.Forms.GroupBox();
            this.placeAddress = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.placeGender = new System.Windows.Forms.Label();
            this.placeGroup = new System.Windows.Forms.Label();
            this.placeBdate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.placeGpa = new System.Windows.Forms.Label();
            this.lblGpa = new System.Windows.Forms.Label();
            this.placeExmYear = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.placeExam = new System.Windows.Forms.Label();
            this.lblExam = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.titlePanelStuPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbGuardian.SuspendLayout();
            this.gbStuProfile.SuspendLayout();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePanelStuPro
            // 
            this.titlePanelStuPro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePanelStuPro.AutoScroll = true;
            this.titlePanelStuPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.titlePanelStuPro.Controls.Add(this.pictureBox1);
            this.titlePanelStuPro.Controls.Add(this.btnSearch);
            this.titlePanelStuPro.Controls.Add(this.lblStuProTitle);
            this.titlePanelStuPro.Controls.Add(this.search);
            this.titlePanelStuPro.Location = new System.Drawing.Point(3, 4);
            this.titlePanelStuPro.Name = "titlePanelStuPro";
            this.titlePanelStuPro.Size = new System.Drawing.Size(962, 107);
            this.titlePanelStuPro.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolManagement.Properties.Resources.graduated;
            this.pictureBox1.Location = new System.Drawing.Point(308, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(300, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search By ID";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStuProTitle
            // 
            this.lblStuProTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStuProTitle.AutoSize = true;
            this.lblStuProTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuProTitle.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblStuProTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStuProTitle.Location = new System.Drawing.Point(359, 10);
            this.lblStuProTitle.Name = "lblStuProTitle";
            this.lblStuProTitle.Size = new System.Drawing.Size(211, 36);
            this.lblStuProTitle.TabIndex = 1;
            this.lblStuProTitle.Text = "Student Profile";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(21, 66);
            this.search.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.search.MaximumSize = new System.Drawing.Size(300, 30);
            this.search.MinimumSize = new System.Drawing.Size(260, 26);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(260, 26);
            this.search.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(188, 135);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(43, 20);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID : ";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(188, 191);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(104, 20);
            this.firstName.TabIndex = 3;
            this.firstName.Text = "lblfirstName";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(298, 191);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(108, 20);
            this.lastName.TabIndex = 3;
            this.lastName.Text = "lblLastName";
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.Location = new System.Drawing.Point(188, 251);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(68, 20);
            this.Class.TabIndex = 3;
            this.Class.Text = "Class : ";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(371, 251);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(85, 20);
            this.lblSection.TabIndex = 3;
            this.lblSection.Text = "Section : ";
            // 
            // placeClass
            // 
            this.placeClass.AutoSize = true;
            this.placeClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeClass.Location = new System.Drawing.Point(254, 251);
            this.placeClass.Name = "placeClass";
            this.placeClass.Size = new System.Drawing.Size(86, 20);
            this.placeClass.TabIndex = 3;
            this.placeClass.Text = "placeClass";
            // 
            // placeSection
            // 
            this.placeSection.AutoSize = true;
            this.placeSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeSection.Location = new System.Drawing.Point(452, 251);
            this.placeSection.Name = "placeSection";
            this.placeSection.Size = new System.Drawing.Size(101, 20);
            this.placeSection.TabIndex = 3;
            this.placeSection.Text = "placeSection";
            // 
            // placeId
            // 
            this.placeId.AutoSize = true;
            this.placeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeId.Location = new System.Drawing.Point(232, 135);
            this.placeId.Name = "placeId";
            this.placeId.Size = new System.Drawing.Size(61, 20);
            this.placeId.TabIndex = 3;
            this.placeId.Text = "placeId";
            // 
            // gbGuardian
            // 
            this.gbGuardian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGuardian.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbGuardian.Controls.Add(this.placeContact);
            this.gbGuardian.Controls.Add(this.placeFather);
            this.gbGuardian.Controls.Add(this.lblfathCont);
            this.gbGuardian.Controls.Add(this.lblfather);
            this.gbGuardian.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGuardian.Location = new System.Drawing.Point(488, 297);
            this.gbGuardian.Name = "gbGuardian";
            this.gbGuardian.Size = new System.Drawing.Size(431, 144);
            this.gbGuardian.TabIndex = 4;
            this.gbGuardian.TabStop = false;
            this.gbGuardian.Text = "Guardian Info";
            // 
            // placeContact
            // 
            this.placeContact.AutoSize = true;
            this.placeContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeContact.Location = new System.Drawing.Point(139, 81);
            this.placeContact.Name = "placeContact";
            this.placeContact.Size = new System.Drawing.Size(103, 20);
            this.placeContact.TabIndex = 1;
            this.placeContact.Text = "placeContact";
            // 
            // placeFather
            // 
            this.placeFather.AutoSize = true;
            this.placeFather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeFather.Location = new System.Drawing.Point(139, 34);
            this.placeFather.Name = "placeFather";
            this.placeFather.Size = new System.Drawing.Size(94, 20);
            this.placeFather.TabIndex = 1;
            this.placeFather.Text = "placeFather";
            // 
            // lblfathCont
            // 
            this.lblfathCont.AutoSize = true;
            this.lblfathCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfathCont.Location = new System.Drawing.Point(9, 81);
            this.lblfathCont.Name = "lblfathCont";
            this.lblfathCont.Size = new System.Drawing.Size(140, 20);
            this.lblfathCont.TabIndex = 0;
            this.lblfathCont.Text = "Father Contact :";
            // 
            // lblfather
            // 
            this.lblfather.AutoSize = true;
            this.lblfather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfather.Location = new System.Drawing.Point(9, 34);
            this.lblfather.Name = "lblfather";
            this.lblfather.Size = new System.Drawing.Size(138, 20);
            this.lblfather.TabIndex = 0;
            this.lblfather.Text = "Father Name    :";
            // 
            // gbStuProfile
            // 
            this.gbStuProfile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbStuProfile.Controls.Add(this.placeAddress);
            this.gbStuProfile.Controls.Add(this.address);
            this.gbStuProfile.Controls.Add(this.placeGender);
            this.gbStuProfile.Controls.Add(this.placeGroup);
            this.gbStuProfile.Controls.Add(this.placeBdate);
            this.gbStuProfile.Controls.Add(this.label4);
            this.gbStuProfile.Controls.Add(this.Gender);
            this.gbStuProfile.Controls.Add(this.label3);
            this.gbStuProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStuProfile.Location = new System.Drawing.Point(23, 296);
            this.gbStuProfile.Name = "gbStuProfile";
            this.gbStuProfile.Size = new System.Drawing.Size(436, 144);
            this.gbStuProfile.TabIndex = 5;
            this.gbStuProfile.TabStop = false;
            this.gbStuProfile.Text = "Student Profile";
            // 
            // placeAddress
            // 
            this.placeAddress.AutoSize = true;
            this.placeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeAddress.Location = new System.Drawing.Point(100, 105);
            this.placeAddress.Name = "placeAddress";
            this.placeAddress.Size = new System.Drawing.Size(106, 20);
            this.placeAddress.TabIndex = 6;
            this.placeAddress.Text = "placeAddress";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(14, 105);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(90, 20);
            this.address.TabIndex = 5;
            this.address.Text = "Address  :";
            // 
            // placeGender
            // 
            this.placeGender.AutoSize = true;
            this.placeGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeGender.Location = new System.Drawing.Point(328, 19);
            this.placeGender.Name = "placeGender";
            this.placeGender.Size = new System.Drawing.Size(101, 20);
            this.placeGender.TabIndex = 3;
            this.placeGender.Text = "placeGender";
            // 
            // placeGroup
            // 
            this.placeGroup.AutoSize = true;
            this.placeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeGroup.Location = new System.Drawing.Point(100, 19);
            this.placeGroup.Name = "placeGroup";
            this.placeGroup.Size = new System.Drawing.Size(92, 20);
            this.placeGroup.TabIndex = 3;
            this.placeGroup.Text = "placeGroup";
            // 
            // placeBdate
            // 
            this.placeBdate.AutoSize = true;
            this.placeBdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeBdate.Location = new System.Drawing.Point(100, 62);
            this.placeBdate.Name = "placeBdate";
            this.placeBdate.Size = new System.Drawing.Size(82, 20);
            this.placeBdate.TabIndex = 2;
            this.placeBdate.Text = "placeDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "BirthDay  :";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(244, 19);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(94, 20);
            this.Gender.TabIndex = 0;
            this.Gender.Text = "Gender   : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Group      : ";
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbResult.Controls.Add(this.lblPaymentDate);
            this.gbResult.Controls.Add(this.lblTotalPayment);
            this.gbResult.Controls.Add(this.lblTotalFee);
            this.gbResult.Controls.Add(this.label5);
            this.gbResult.Controls.Add(this.label2);
            this.gbResult.Controls.Add(this.label1);
            this.gbResult.Controls.Add(this.placeGpa);
            this.gbResult.Controls.Add(this.lblGpa);
            this.gbResult.Controls.Add(this.placeExmYear);
            this.gbResult.Controls.Add(this.label10);
            this.gbResult.Controls.Add(this.placeExam);
            this.gbResult.Controls.Add(this.lblExam);
            this.gbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResult.Location = new System.Drawing.Point(23, 459);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(896, 121);
            this.gbResult.TabIndex = 6;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result and Payment";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(612, 89);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(127, 17);
            this.lblPaymentDate.TabIndex = 6;
            this.lblPaymentDate.Text = "placePaymentDate";
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayment.Location = new System.Drawing.Point(612, 55);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(129, 17);
            this.lblTotalPayment.TabIndex = 5;
            this.lblTotalPayment.Text = "placeTotalPayment";
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFee.Location = new System.Drawing.Point(612, 21);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(98, 17);
            this.lblTotalFee.TabIndex = 4;
            this.lblTotalFee.Text = "placeTotalFee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Payment Date   :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Payment   :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Fee          :";
            // 
            // placeGpa
            // 
            this.placeGpa.AutoSize = true;
            this.placeGpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeGpa.Location = new System.Drawing.Point(136, 89);
            this.placeGpa.Name = "placeGpa";
            this.placeGpa.Size = new System.Drawing.Size(77, 17);
            this.placeGpa.TabIndex = 0;
            this.placeGpa.Text = "placeGpa";
            // 
            // lblGpa
            // 
            this.lblGpa.AutoSize = true;
            this.lblGpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGpa.Location = new System.Drawing.Point(17, 89);
            this.lblGpa.Name = "lblGpa";
            this.lblGpa.Size = new System.Drawing.Size(103, 17);
            this.lblGpa.TabIndex = 0;
            this.lblGpa.Text = "Gpa            :";
            // 
            // placeExmYear
            // 
            this.placeExmYear.AutoSize = true;
            this.placeExmYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeExmYear.Location = new System.Drawing.Point(136, 55);
            this.placeExmYear.Name = "placeExmYear";
            this.placeExmYear.Size = new System.Drawing.Size(98, 17);
            this.placeExmYear.TabIndex = 0;
            this.placeExmYear.Text = "placeExmYear";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Exam Year   :  ";
            // 
            // placeExam
            // 
            this.placeExam.AutoSize = true;
            this.placeExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeExam.Location = new System.Drawing.Point(136, 21);
            this.placeExam.Name = "placeExam";
            this.placeExam.Size = new System.Drawing.Size(76, 17);
            this.placeExam.TabIndex = 0;
            this.placeExam.Text = "placeExam";
            // 
            // lblExam
            // 
            this.lblExam.AutoSize = true;
            this.lblExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExam.Location = new System.Drawing.Point(17, 21);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(101, 17);
            this.lblExam.TabIndex = 0;
            this.lblExam.Text = "Exam          :";
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(23, 126);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(129, 147);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // StudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(968, 607);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbStuProfile);
            this.Controls.Add(this.gbGuardian);
            this.Controls.Add(this.placeSection);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.placeClass);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.placeId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.titlePanelStuPro);
            this.MaximumSize = new System.Drawing.Size(1050, 700);
            this.MinimumSize = new System.Drawing.Size(900, 630);
            this.Name = "StudentProfile";
            this.Text = "Student Profile";
            this.titlePanelStuPro.ResumeLayout(false);
            this.titlePanelStuPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbGuardian.ResumeLayout(false);
            this.gbGuardian.PerformLayout();
            this.gbStuProfile.ResumeLayout(false);
            this.gbStuProfile.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlePanelStuPro;
        private System.Windows.Forms.Label lblStuProTitle;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label placeClass;
        private System.Windows.Forms.Label placeSection;
        private System.Windows.Forms.Label placeId;
        private System.Windows.Forms.GroupBox gbGuardian;
        private System.Windows.Forms.Label placeContact;
        private System.Windows.Forms.Label placeFather;
        private System.Windows.Forms.Label lblfathCont;
        private System.Windows.Forms.Label lblfather;
        private System.Windows.Forms.GroupBox gbStuProfile;
        private System.Windows.Forms.Label placeGroup;
        private System.Windows.Forms.Label placeBdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label placeAddress;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Label placeGpa;
        private System.Windows.Forms.Label lblGpa;
        private System.Windows.Forms.Label placeExmYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label placeExam;
        private System.Windows.Forms.Label lblExam;
        private System.Windows.Forms.Label placeGender;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label lblTotalFee;
    }
}