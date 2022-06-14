
namespace SchoolManagement
{
    partial class StudentPerformanceForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleBarForResult = new System.Windows.Forms.Panel();
            this.lbtTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.std_id = new System.Windows.Forms.TextBox();
            this.std_name = new System.Windows.Forms.TextBox();
            this.std_class = new System.Windows.Forms.TextBox();
            this.cbExam = new System.Windows.Forms.ComboBox();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.dExamYear = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtTotalFee = new System.Windows.Forms.TextBox();
            this.txtPaymentFee = new System.Windows.Forms.TextBox();
            this.dPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.titleBarForResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBarForResult
            // 
            this.titleBarForResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBarForResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.titleBarForResult.Controls.Add(this.lbtTitle);
            this.titleBarForResult.Location = new System.Drawing.Point(16, 21);
            this.titleBarForResult.Name = "titleBarForResult";
            this.titleBarForResult.Size = new System.Drawing.Size(893, 44);
            this.titleBarForResult.TabIndex = 0;
            // 
            // lbtTitle
            // 
            this.lbtTitle.AutoSize = true;
            this.lbtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtTitle.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbtTitle.Location = new System.Drawing.Point(276, 4);
            this.lbtTitle.Name = "lbtTitle";
            this.lbtTitle.Size = new System.Drawing.Size(282, 31);
            this.lbtTitle.TabIndex = 0;
            this.lbtTitle.Text = "Student Result Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Student Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(550, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Exam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(501, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "GPA (grade)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(512, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Exam Year";
            // 
            // std_id
            // 
            this.std_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_id.Location = new System.Drawing.Point(184, 125);
            this.std_id.Multiline = true;
            this.std_id.Name = "std_id";
            this.std_id.Size = new System.Drawing.Size(212, 26);
            this.std_id.TabIndex = 3;
            this.std_id.TextChanged += new System.EventHandler(this.std_id_TextChanged);
            // 
            // std_name
            // 
            this.std_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_name.Location = new System.Drawing.Point(184, 179);
            this.std_name.Multiline = true;
            this.std_name.Name = "std_name";
            this.std_name.Size = new System.Drawing.Size(212, 26);
            this.std_name.TabIndex = 3;
            // 
            // std_class
            // 
            this.std_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_class.Location = new System.Drawing.Point(184, 233);
            this.std_class.Multiline = true;
            this.std_class.Name = "std_class";
            this.std_class.Size = new System.Drawing.Size(212, 26);
            this.std_class.TabIndex = 3;
            // 
            // cbExam
            // 
            this.cbExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExam.FormattingEnabled = true;
            this.cbExam.ItemHeight = 16;
            this.cbExam.Items.AddRange(new object[] {
            "First Semester",
            "Second Semester",
            "Third Semester",
            "Test Exam",
            "Model Test",
            "Others"});
            this.cbExam.Location = new System.Drawing.Point(601, 182);
            this.cbExam.Name = "cbExam";
            this.cbExam.Size = new System.Drawing.Size(200, 24);
            this.cbExam.TabIndex = 4;
            // 
            // cbGrade
            // 
            this.cbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Items.AddRange(new object[] {
            "A+",
            "A",
            "A-",
            "B",
            "C",
            "D",
            "F"});
            this.cbGrade.Location = new System.Drawing.Point(601, 236);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(200, 24);
            this.cbGrade.TabIndex = 4;
            // 
            // dExamYear
            // 
            this.dExamYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dExamYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dExamYear.Location = new System.Drawing.Point(601, 290);
            this.dExamYear.Name = "dExamYear";
            this.dExamYear.Size = new System.Drawing.Size(200, 23);
            this.dExamYear.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(7)))), ((int)(((byte)(20)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSubmit.Location = new System.Drawing.Point(368, 398);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Padding = new System.Windows.Forms.Padding(5);
            this.btnSubmit.Size = new System.Drawing.Size(124, 38);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtTotalFee
            // 
            this.txtTotalFee.Location = new System.Drawing.Point(184, 287);
            this.txtTotalFee.Multiline = true;
            this.txtTotalFee.Name = "txtTotalFee";
            this.txtTotalFee.Size = new System.Drawing.Size(212, 26);
            this.txtTotalFee.TabIndex = 7;
            // 
            // txtPaymentFee
            // 
            this.txtPaymentFee.Location = new System.Drawing.Point(184, 341);
            this.txtPaymentFee.Multiline = true;
            this.txtPaymentFee.Name = "txtPaymentFee";
            this.txtPaymentFee.Size = new System.Drawing.Size(212, 26);
            this.txtPaymentFee.TabIndex = 8;
            // 
            // dPaymentDate
            // 
            this.dPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dPaymentDate.Location = new System.Drawing.Point(601, 128);
            this.dPaymentDate.Name = "dPaymentDate";
            this.dPaymentDate.Size = new System.Drawing.Size(200, 23);
            this.dPaymentDate.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(103, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Fee";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total Payment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(489, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Payment Date";
            // 
            // StudentPerformanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dPaymentDate);
            this.Controls.Add(this.txtPaymentFee);
            this.Controls.Add(this.txtTotalFee);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dExamYear);
            this.Controls.Add(this.cbGrade);
            this.Controls.Add(this.cbExam);
            this.Controls.Add(this.std_class);
            this.Controls.Add(this.std_name);
            this.Controls.Add(this.std_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleBarForResult);
            this.Name = "StudentPerformanceForm";
            this.Size = new System.Drawing.Size(919, 541);
            this.titleBarForResult.ResumeLayout(false);
            this.titleBarForResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titleBarForResult;
        private System.Windows.Forms.Label lbtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox std_id;
        private System.Windows.Forms.TextBox std_name;
        private System.Windows.Forms.TextBox std_class;
        private System.Windows.Forms.ComboBox cbExam;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.DateTimePicker dExamYear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtTotalFee;
        private System.Windows.Forms.TextBox txtPaymentFee;
        private System.Windows.Forms.DateTimePicker dPaymentDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
