namespace ProjectCSharp
{
    partial class member_regisFm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.memberGb = new System.Windows.Forms.GroupBox();
            this.showsectionBt = new System.Windows.Forms.Button();
            this.searchBt = new System.Windows.Forms.Button();
            this.commentTb = new System.Windows.Forms.TextBox();
            this.statusCb = new System.Windows.Forms.ComboBox();
            this.sectionCb = new System.Windows.Forms.ComboBox();
            this.sexCb = new System.Windows.Forms.ComboBox();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.employeeTb = new System.Windows.Forms.TextBox();
            this.commentLb = new System.Windows.Forms.Label();
            this.statusLb = new System.Windows.Forms.Label();
            this.secctionLb = new System.Windows.Forms.Label();
            this.sexLb = new System.Windows.Forms.Label();
            this.surnameLb = new System.Windows.Forms.Label();
            this.nameLb = new System.Windows.Forms.Label();
            this.employeeLb = new System.Windows.Forms.Label();
            this.downloadGb = new System.Windows.Forms.GroupBox();
            this.deletedbBt = new System.Windows.Forms.Button();
            this.clearBt = new System.Windows.Forms.Button();
            this.sheetLb = new System.Windows.Forms.Label();
            this.importBt = new System.Windows.Forms.Button();
            this.sheetCb = new System.Windows.Forms.ComboBox();
            this.filenameLb = new System.Windows.Forms.Label();
            this.filenameTb = new System.Windows.Forms.TextBox();
            this.downloaddataBt = new System.Windows.Forms.Button();
            this.buttonGb = new System.Windows.Forms.GroupBox();
            this.cancelBt = new System.Windows.Forms.Button();
            this.deleteBt = new System.Windows.Forms.Button();
            this.updateBt = new System.Windows.Forms.Button();
            this.addBt = new System.Windows.Forms.Button();
            this.showdataGb = new System.Windows.Forms.GroupBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label8 = new System.Windows.Forms.Label();
            this.Search_TB = new System.Windows.Forms.TextBox();
            this.refreshBt = new System.Windows.Forms.Button();
            this.memberGb.SuspendLayout();
            this.downloadGb.SuspendLayout();
            this.buttonGb.SuspendLayout();
            this.showdataGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // memberGb
            // 
            this.memberGb.Controls.Add(this.showsectionBt);
            this.memberGb.Controls.Add(this.searchBt);
            this.memberGb.Controls.Add(this.commentTb);
            this.memberGb.Controls.Add(this.statusCb);
            this.memberGb.Controls.Add(this.sectionCb);
            this.memberGb.Controls.Add(this.sexCb);
            this.memberGb.Controls.Add(this.surnameTb);
            this.memberGb.Controls.Add(this.nameTb);
            this.memberGb.Controls.Add(this.employeeTb);
            this.memberGb.Controls.Add(this.commentLb);
            this.memberGb.Controls.Add(this.statusLb);
            this.memberGb.Controls.Add(this.secctionLb);
            this.memberGb.Controls.Add(this.sexLb);
            this.memberGb.Controls.Add(this.surnameLb);
            this.memberGb.Controls.Add(this.nameLb);
            this.memberGb.Controls.Add(this.employeeLb);
            this.memberGb.Controls.Add(this.downloadGb);
            this.memberGb.Location = new System.Drawing.Point(12, 12);
            this.memberGb.Name = "memberGb";
            this.memberGb.Size = new System.Drawing.Size(750, 368);
            this.memberGb.TabIndex = 1;
            this.memberGb.TabStop = false;
            this.memberGb.Text = "Member (สมาชิก)";
            // 
            // showsectionBt
            // 
            this.showsectionBt.Location = new System.Drawing.Point(357, 208);
            this.showsectionBt.Name = "showsectionBt";
            this.showsectionBt.Size = new System.Drawing.Size(81, 24);
            this.showsectionBt.TabIndex = 17;
            this.showsectionBt.Text = "Show Section ";
            this.showsectionBt.UseVisualStyleBackColor = true;
            // 
            // searchBt
            // 
            this.searchBt.Location = new System.Drawing.Point(313, 59);
            this.searchBt.Name = "searchBt";
            this.searchBt.Size = new System.Drawing.Size(63, 20);
            this.searchBt.TabIndex = 16;
            this.searchBt.Text = "Search";
            this.searchBt.UseVisualStyleBackColor = true;
            this.searchBt.Click += new System.EventHandler(this.searchBt_Click);
            // 
            // commentTb
            // 
            this.commentTb.Location = new System.Drawing.Point(197, 300);
            this.commentTb.Name = "commentTb";
            this.commentTb.Size = new System.Drawing.Size(433, 20);
            this.commentTb.TabIndex = 15;
            // 
            // statusCb
            // 
            this.statusCb.FormattingEnabled = true;
            this.statusCb.Items.AddRange(new object[] {
            "Active (เป็นสมาชิกอยู่)",
            "Deactive(ไม่ได้เป็นสมาชิกแล้ว)"});
            this.statusCb.Location = new System.Drawing.Point(197, 257);
            this.statusCb.Name = "statusCb";
            this.statusCb.Size = new System.Drawing.Size(154, 21);
            this.statusCb.TabIndex = 14;
            // 
            // sectionCb
            // 
            this.sectionCb.FormattingEnabled = true;
            this.sectionCb.Location = new System.Drawing.Point(197, 211);
            this.sectionCb.Name = "sectionCb";
            this.sectionCb.Size = new System.Drawing.Size(154, 21);
            this.sectionCb.TabIndex = 13;
            // 
            // sexCb
            // 
            this.sexCb.FormattingEnabled = true;
            this.sexCb.Items.AddRange(new object[] {
            "Men (ผู้ชาย)",
            "Woman (ผู้หญิง)"});
            this.sexCb.Location = new System.Drawing.Point(197, 169);
            this.sexCb.Name = "sexCb";
            this.sexCb.Size = new System.Drawing.Size(95, 21);
            this.sexCb.TabIndex = 12;
            // 
            // surnameTb
            // 
            this.surnameTb.Location = new System.Drawing.Point(197, 133);
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.Size = new System.Drawing.Size(154, 20);
            this.surnameTb.TabIndex = 11;
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(197, 97);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(154, 20);
            this.nameTb.TabIndex = 10;
            // 
            // employeeTb
            // 
            this.employeeTb.Location = new System.Drawing.Point(197, 59);
            this.employeeTb.Name = "employeeTb";
            this.employeeTb.Size = new System.Drawing.Size(110, 20);
            this.employeeTb.TabIndex = 9;
            // 
            // commentLb
            // 
            this.commentLb.AutoSize = true;
            this.commentLb.Location = new System.Drawing.Point(29, 307);
            this.commentLb.Name = "commentLb";
            this.commentLb.Size = new System.Drawing.Size(86, 13);
            this.commentLb.TabIndex = 8;
            this.commentLb.Text = "Comment (อื่นๆ) :";
            // 
            // statusLb
            // 
            this.statusLb.AutoSize = true;
            this.statusLb.Location = new System.Drawing.Point(29, 265);
            this.statusLb.Name = "statusLb";
            this.statusLb.Size = new System.Drawing.Size(83, 13);
            this.statusLb.TabIndex = 7;
            this.statusLb.Text = "Status (สถานะ) :";
            // 
            // secctionLb
            // 
            this.secctionLb.AutoSize = true;
            this.secctionLb.Location = new System.Drawing.Point(29, 219);
            this.secctionLb.Name = "secctionLb";
            this.secctionLb.Size = new System.Drawing.Size(88, 13);
            this.secctionLb.TabIndex = 6;
            this.secctionLb.Text = "Section (แผนก) :";
            // 
            // sexLb
            // 
            this.sexLb.AutoSize = true;
            this.sexLb.Location = new System.Drawing.Point(29, 177);
            this.sexLb.Name = "sexLb";
            this.sexLb.Size = new System.Drawing.Size(61, 13);
            this.sexLb.TabIndex = 5;
            this.sexLb.Text = "Sex (เพศ) :";
            // 
            // surnameLb
            // 
            this.surnameLb.AutoSize = true;
            this.surnameLb.Location = new System.Drawing.Point(29, 136);
            this.surnameLb.Name = "surnameLb";
            this.surnameLb.Size = new System.Drawing.Size(103, 13);
            this.surnameLb.TabIndex = 4;
            this.surnameLb.Text = "Surname (นามสกุล) :";
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Location = new System.Drawing.Point(29, 97);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(63, 13);
            this.nameLb.TabIndex = 3;
            this.nameLb.Text = "Name (ชื่อ) :";
            // 
            // employeeLb
            // 
            this.employeeLb.AutoSize = true;
            this.employeeLb.Location = new System.Drawing.Point(29, 59);
            this.employeeLb.Name = "employeeLb";
            this.employeeLb.Size = new System.Drawing.Size(148, 13);
            this.employeeLb.TabIndex = 2;
            this.employeeLb.Text = "Employee No. (รหัสพนักงาน) :";
            // 
            // downloadGb
            // 
            this.downloadGb.Controls.Add(this.deletedbBt);
            this.downloadGb.Controls.Add(this.clearBt);
            this.downloadGb.Controls.Add(this.sheetLb);
            this.downloadGb.Controls.Add(this.importBt);
            this.downloadGb.Controls.Add(this.sheetCb);
            this.downloadGb.Controls.Add(this.filenameLb);
            this.downloadGb.Controls.Add(this.filenameTb);
            this.downloadGb.Controls.Add(this.downloaddataBt);
            this.downloadGb.Location = new System.Drawing.Point(429, 19);
            this.downloadGb.Name = "downloadGb";
            this.downloadGb.Size = new System.Drawing.Size(315, 183);
            this.downloadGb.TabIndex = 1;
            this.downloadGb.TabStop = false;
            this.downloadGb.Text = "Download (ดึงข้อมูล)";
            // 
            // deletedbBt
            // 
            this.deletedbBt.BackColor = System.Drawing.Color.DarkRed;
            this.deletedbBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletedbBt.Location = new System.Drawing.Point(212, 28);
            this.deletedbBt.Name = "deletedbBt";
            this.deletedbBt.Size = new System.Drawing.Size(94, 36);
            this.deletedbBt.TabIndex = 4;
            this.deletedbBt.Text = "Delete all data in Database";
            this.deletedbBt.UseVisualStyleBackColor = false;
            // 
            // clearBt
            // 
            this.clearBt.Location = new System.Drawing.Point(112, 28);
            this.clearBt.Name = "clearBt";
            this.clearBt.Size = new System.Drawing.Size(94, 36);
            this.clearBt.TabIndex = 20;
            this.clearBt.Text = "Clear Data";
            this.clearBt.UseVisualStyleBackColor = true;
            this.clearBt.Click += new System.EventHandler(this.clearBt_Click);
            // 
            // sheetLb
            // 
            this.sheetLb.AutoSize = true;
            this.sheetLb.Location = new System.Drawing.Point(6, 134);
            this.sheetLb.Name = "sheetLb";
            this.sheetLb.Size = new System.Drawing.Size(119, 13);
            this.sheetLb.TabIndex = 18;
            this.sheetLb.Text = "Select sheet (เลือกชีท) :";
            // 
            // importBt
            // 
            this.importBt.Location = new System.Drawing.Point(183, 150);
            this.importBt.Name = "importBt";
            this.importBt.Size = new System.Drawing.Size(63, 21);
            this.importBt.TabIndex = 19;
            this.importBt.Text = "Import";
            this.importBt.UseVisualStyleBackColor = true;
            this.importBt.Click += new System.EventHandler(this.importBt_Click);
            // 
            // sheetCb
            // 
            this.sheetCb.FormattingEnabled = true;
            this.sheetCb.Location = new System.Drawing.Point(9, 150);
            this.sheetCb.Name = "sheetCb";
            this.sheetCb.Size = new System.Drawing.Size(168, 21);
            this.sheetCb.TabIndex = 18;
            this.sheetCb.SelectedIndexChanged += new System.EventHandler(this.sheetCb_SelectedIndexChanged);
            // 
            // filenameLb
            // 
            this.filenameLb.AutoSize = true;
            this.filenameLb.Location = new System.Drawing.Point(6, 92);
            this.filenameLb.Name = "filenameLb";
            this.filenameLb.Size = new System.Drawing.Size(97, 13);
            this.filenameLb.TabIndex = 17;
            this.filenameLb.Text = "Filename (ชื่อไฟล์) :";
            // 
            // filenameTb
            // 
            this.filenameTb.Enabled = false;
            this.filenameTb.Location = new System.Drawing.Point(9, 108);
            this.filenameTb.Name = "filenameTb";
            this.filenameTb.Size = new System.Drawing.Size(300, 20);
            this.filenameTb.TabIndex = 17;
            // 
            // downloaddataBt
            // 
            this.downloaddataBt.Location = new System.Drawing.Point(12, 28);
            this.downloaddataBt.Name = "downloaddataBt";
            this.downloaddataBt.Size = new System.Drawing.Size(94, 36);
            this.downloaddataBt.TabIndex = 0;
            this.downloaddataBt.Text = "Download Data";
            this.downloaddataBt.UseVisualStyleBackColor = true;
            this.downloaddataBt.Click += new System.EventHandler(this.downloaddataBt_Click);
            // 
            // buttonGb
            // 
            this.buttonGb.Controls.Add(this.cancelBt);
            this.buttonGb.Controls.Add(this.deleteBt);
            this.buttonGb.Controls.Add(this.updateBt);
            this.buttonGb.Controls.Add(this.addBt);
            this.buttonGb.Location = new System.Drawing.Point(12, 381);
            this.buttonGb.Name = "buttonGb";
            this.buttonGb.Size = new System.Drawing.Size(750, 73);
            this.buttonGb.TabIndex = 2;
            this.buttonGb.TabStop = false;
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(298, 25);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(79, 30);
            this.cancelBt.TabIndex = 3;
            this.cancelBt.Text = "Cancel";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // deleteBt
            // 
            this.deleteBt.Location = new System.Drawing.Point(213, 25);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(79, 30);
            this.deleteBt.TabIndex = 2;
            this.deleteBt.Text = "Delete";
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // updateBt
            // 
            this.updateBt.Location = new System.Drawing.Point(128, 25);
            this.updateBt.Name = "updateBt";
            this.updateBt.Size = new System.Drawing.Size(79, 30);
            this.updateBt.TabIndex = 1;
            this.updateBt.Text = "Update";
            this.updateBt.UseVisualStyleBackColor = true;
            this.updateBt.Click += new System.EventHandler(this.updateBt_Click);
            // 
            // addBt
            // 
            this.addBt.Location = new System.Drawing.Point(43, 25);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(79, 30);
            this.addBt.TabIndex = 0;
            this.addBt.Text = "Add";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // showdataGb
            // 
            this.showdataGb.Controls.Add(this.DataGridView1);
            this.showdataGb.Controls.Add(this.Label8);
            this.showdataGb.Controls.Add(this.Search_TB);
            this.showdataGb.Controls.Add(this.refreshBt);
            this.showdataGb.Location = new System.Drawing.Point(12, 457);
            this.showdataGb.Name = "showdataGb";
            this.showdataGb.Size = new System.Drawing.Size(750, 322);
            this.showdataGb.TabIndex = 4;
            this.showdataGb.TabStop = false;
            this.showdataGb.Text = "Show Data (แสดงข้อมูล)";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(18, 42);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.Size = new System.Drawing.Size(720, 266);
            this.DataGridView1.TabIndex = 37;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label8.Location = new System.Drawing.Point(395, 19);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(47, 13);
            this.Label8.TabIndex = 36;
            this.Label8.Text = "Search :";
            // 
            // Search_TB
            // 
            this.Search_TB.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.Search_TB.Location = new System.Drawing.Point(444, 14);
            this.Search_TB.Name = "Search_TB";
            this.Search_TB.Size = new System.Drawing.Size(209, 22);
            this.Search_TB.TabIndex = 35;
            // 
            // refreshBt
            // 
            this.refreshBt.Location = new System.Drawing.Point(658, 13);
            this.refreshBt.Name = "refreshBt";
            this.refreshBt.Size = new System.Drawing.Size(81, 24);
            this.refreshBt.TabIndex = 18;
            this.refreshBt.Text = "Refresh";
            this.refreshBt.UseVisualStyleBackColor = true;
            this.refreshBt.Click += new System.EventHandler(this.refreshBt_Click);
            // 
            // member_regisFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 811);
            this.Controls.Add(this.showdataGb);
            this.Controls.Add(this.buttonGb);
            this.Controls.Add(this.memberGb);
            this.Name = "member_regisFm";
            this.Text = "Member Registration (ระบบสมาชิก)";
            this.Load += new System.EventHandler(this.member_regisFm_Load);
            this.memberGb.ResumeLayout(false);
            this.memberGb.PerformLayout();
            this.downloadGb.ResumeLayout(false);
            this.downloadGb.PerformLayout();
            this.buttonGb.ResumeLayout(false);
            this.showdataGb.ResumeLayout(false);
            this.showdataGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox memberGb;
        internal System.Windows.Forms.Button showsectionBt;
        internal System.Windows.Forms.Button searchBt;
        internal System.Windows.Forms.TextBox commentTb;
        internal System.Windows.Forms.ComboBox statusCb;
        internal System.Windows.Forms.ComboBox sectionCb;
        internal System.Windows.Forms.ComboBox sexCb;
        internal System.Windows.Forms.TextBox surnameTb;
        internal System.Windows.Forms.TextBox nameTb;
        internal System.Windows.Forms.TextBox employeeTb;
        internal System.Windows.Forms.Label commentLb;
        internal System.Windows.Forms.Label statusLb;
        internal System.Windows.Forms.Label secctionLb;
        internal System.Windows.Forms.Label sexLb;
        internal System.Windows.Forms.Label surnameLb;
        internal System.Windows.Forms.Label nameLb;
        internal System.Windows.Forms.Label employeeLb;
        internal System.Windows.Forms.GroupBox downloadGb;
        internal System.Windows.Forms.Button deletedbBt;
        internal System.Windows.Forms.Button clearBt;
        internal System.Windows.Forms.Label sheetLb;
        internal System.Windows.Forms.Button importBt;
        internal System.Windows.Forms.ComboBox sheetCb;
        internal System.Windows.Forms.Label filenameLb;
        internal System.Windows.Forms.TextBox filenameTb;
        internal System.Windows.Forms.Button downloaddataBt;
        internal System.Windows.Forms.GroupBox buttonGb;
        internal System.Windows.Forms.Button cancelBt;
        internal System.Windows.Forms.Button deleteBt;
        internal System.Windows.Forms.Button updateBt;
        internal System.Windows.Forms.Button addBt;
        internal System.Windows.Forms.GroupBox showdataGb;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox Search_TB;
        internal System.Windows.Forms.Button refreshBt;
        internal System.Windows.Forms.DataGridView DataGridView1;
    }
}

