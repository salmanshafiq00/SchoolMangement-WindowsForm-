
namespace SchoolManagement
{
    partial class studentInfo
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
            this.actionPanel = new System.Windows.Forms.Panel();
            this.headlines = new System.Windows.Forms.Label();
            this.btnStuUpdate = new System.Windows.Forms.Button();
            this.btnStuDelete = new System.Windows.Forms.Button();
            this.btnPrintStuInfo = new System.Windows.Forms.Button();
            this.stuInfoMainPanel = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbtSearch = new System.Windows.Forms.Label();
            this.dgvForStuInfo = new System.Windows.Forms.DataGridView();
            this.linePanel = new System.Windows.Forms.Panel();
            this.actionPanel.SuspendLayout();
            this.stuInfoMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForStuInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // actionPanel
            // 
            this.actionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.actionPanel.Controls.Add(this.headlines);
            this.actionPanel.Controls.Add(this.btnStuUpdate);
            this.actionPanel.Controls.Add(this.btnStuDelete);
            this.actionPanel.Controls.Add(this.btnPrintStuInfo);
            this.actionPanel.Location = new System.Drawing.Point(6, 7);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(939, 53);
            this.actionPanel.TabIndex = 0;
            // 
            // headlines
            // 
            this.headlines.AutoSize = true;
            this.headlines.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headlines.ForeColor = System.Drawing.Color.AliceBlue;
            this.headlines.Location = new System.Drawing.Point(220, 6);
            this.headlines.Name = "headlines";
            this.headlines.Size = new System.Drawing.Size(332, 39);
            this.headlines.TabIndex = 3;
            this.headlines.Text = "Student Information";
            // 
            // btnStuUpdate
            // 
            this.btnStuUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuUpdate.Location = new System.Drawing.Point(630, 14);
            this.btnStuUpdate.Name = "btnStuUpdate";
            this.btnStuUpdate.Size = new System.Drawing.Size(75, 26);
            this.btnStuUpdate.TabIndex = 2;
            this.btnStuUpdate.Text = "Update";
            this.btnStuUpdate.UseVisualStyleBackColor = true;
            this.btnStuUpdate.Click += new System.EventHandler(this.btnStuUpdate_Click);
            // 
            // btnStuDelete
            // 
            this.btnStuDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnStuDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStuDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuDelete.Location = new System.Drawing.Point(726, 14);
            this.btnStuDelete.Name = "btnStuDelete";
            this.btnStuDelete.Size = new System.Drawing.Size(75, 26);
            this.btnStuDelete.TabIndex = 1;
            this.btnStuDelete.Text = "Delete";
            this.btnStuDelete.UseVisualStyleBackColor = false;
            this.btnStuDelete.Click += new System.EventHandler(this.btnStuDelete_Click);
            // 
            // btnPrintStuInfo
            // 
            this.btnPrintStuInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintStuInfo.Location = new System.Drawing.Point(816, 14);
            this.btnPrintStuInfo.Name = "btnPrintStuInfo";
            this.btnPrintStuInfo.Size = new System.Drawing.Size(75, 26);
            this.btnPrintStuInfo.TabIndex = 0;
            this.btnPrintStuInfo.Text = "Print";
            this.btnPrintStuInfo.UseVisualStyleBackColor = true;
            // 
            // stuInfoMainPanel
            // 
            this.stuInfoMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stuInfoMainPanel.Controls.Add(this.txtSearch);
            this.stuInfoMainPanel.Controls.Add(this.lbtSearch);
            this.stuInfoMainPanel.Controls.Add(this.dgvForStuInfo);
            this.stuInfoMainPanel.Controls.Add(this.linePanel);
            this.stuInfoMainPanel.Location = new System.Drawing.Point(6, 66);
            this.stuInfoMainPanel.Name = "stuInfoMainPanel";
            this.stuInfoMainPanel.Size = new System.Drawing.Size(939, 515);
            this.stuInfoMainPanel.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(71, 8);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(239, 25);
            this.txtSearch.TabIndex = 5;
            // 
            // lbtSearch
            // 
            this.lbtSearch.AutoSize = true;
            this.lbtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtSearch.Location = new System.Drawing.Point(15, 12);
            this.lbtSearch.Name = "lbtSearch";
            this.lbtSearch.Size = new System.Drawing.Size(53, 17);
            this.lbtSearch.TabIndex = 4;
            this.lbtSearch.Text = "Search";
            // 
            // dgvForStuInfo
            // 
            this.dgvForStuInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvForStuInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvForStuInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvForStuInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForStuInfo.Location = new System.Drawing.Point(0, 50);
            this.dgvForStuInfo.Name = "dgvForStuInfo";
            this.dgvForStuInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvForStuInfo.Size = new System.Drawing.Size(939, 465);
            this.dgvForStuInfo.TabIndex = 3;
            this.dgvForStuInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForStuInfo_CellDoubleClick);
            this.dgvForStuInfo.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvForStuInfo_RowHeaderMouseClick);
            // 
            // linePanel
            // 
            this.linePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.linePanel.Location = new System.Drawing.Point(0, 39);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(939, 5);
            this.linePanel.TabIndex = 2;
            // 
            // studentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stuInfoMainPanel);
            this.Controls.Add(this.actionPanel);
            this.Name = "studentInfo";
            this.Size = new System.Drawing.Size(955, 584);
            this.Load += new System.EventHandler(this.studentInfo_Load);
            this.actionPanel.ResumeLayout(false);
            this.actionPanel.PerformLayout();
            this.stuInfoMainPanel.ResumeLayout(false);
            this.stuInfoMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForStuInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Panel stuInfoMainPanel;
        private System.Windows.Forms.DataGridView dgvForStuInfo;
        private System.Windows.Forms.Panel linePanel;
        private System.Windows.Forms.Button btnStuUpdate;
        private System.Windows.Forms.Button btnStuDelete;
        private System.Windows.Forms.Button btnPrintStuInfo;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbtSearch;
        private System.Windows.Forms.Label headlines;
    }
}
