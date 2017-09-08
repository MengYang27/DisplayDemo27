namespace DisplayDemo27
{
    partial class FrmSetting
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvCategory = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxbCategory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxbCID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DgvFilePath = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnBrowse = new System.Windows.Forms.Label();
            this.TxbFPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxbFName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxbFID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnFDelete = new System.Windows.Forms.Label();
            this.BtnFUpdate = new System.Windows.Forms.Label();
            this.BtnFAdd = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFilePath)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mistral", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(949, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "Back";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(949, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Exit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(33, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 712);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 683);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Category Setting";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvCategory);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(31, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 392);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // DgvCategory
            // 
            this.DgvCategory.AllowUserToAddRows = false;
            this.DgvCategory.AllowUserToDeleteRows = false;
            this.DgvCategory.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCategory.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvCategory.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DgvCategory.Location = new System.Drawing.Point(17, 22);
            this.DgvCategory.Name = "DgvCategory";
            this.DgvCategory.ReadOnly = true;
            this.DgvCategory.RowHeadersVisible = false;
            this.DgvCategory.RowTemplate.Height = 24;
            this.DgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCategory.Size = new System.Drawing.Size(797, 353);
            this.DgvCategory.TabIndex = 0;
            this.DgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCategory_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxbCategory);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxbCID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.BtnUpdate);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(31, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conditions";
            // 
            // TxbCategory
            // 
            this.TxbCategory.Location = new System.Drawing.Point(304, 91);
            this.TxbCategory.Name = "TxbCategory";
            this.TxbCategory.Size = new System.Drawing.Size(188, 22);
            this.TxbCategory.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Category:";
            // 
            // TxbCID
            // 
            this.TxbCID.Location = new System.Drawing.Point(64, 91);
            this.TxbCID.Name = "TxbCID";
            this.TxbCID.ReadOnly = true;
            this.TxbCID.Size = new System.Drawing.Size(100, 22);
            this.TxbCID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID:";
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSize = true;
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(661, 159);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(114, 35);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            this.BtnDelete.MouseEnter += new System.EventHandler(this.BtnDelete_MouseEnter);
            this.BtnDelete.MouseLeave += new System.EventHandler(this.BtnDelete_MouseLeave);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.AutoSize = true;
            this.BtnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(661, 94);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(121, 35);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            this.BtnUpdate.MouseEnter += new System.EventHandler(this.BtnUpdate_MouseEnter);
            this.BtnUpdate.MouseLeave += new System.EventHandler(this.BtnUpdate_MouseLeave);
            // 
            // BtnAdd
            // 
            this.BtnAdd.AutoSize = true;
            this.BtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdd.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(682, 31);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(71, 35);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            this.BtnAdd.MouseEnter += new System.EventHandler(this.BtnAdd_MouseEnter);
            this.BtnAdd.MouseLeave += new System.EventHandler(this.BtnAdd_MouseLeave);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 683);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FilePath Setting";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DgvFilePath);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(26, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(830, 419);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data";
            // 
            // DgvFilePath
            // 
            this.DgvFilePath.AllowUserToAddRows = false;
            this.DgvFilePath.AllowUserToDeleteRows = false;
            this.DgvFilePath.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvFilePath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvFilePath.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvFilePath.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DgvFilePath.Location = new System.Drawing.Point(17, 22);
            this.DgvFilePath.Name = "DgvFilePath";
            this.DgvFilePath.ReadOnly = true;
            this.DgvFilePath.RowHeadersVisible = false;
            this.DgvFilePath.RowTemplate.Height = 24;
            this.DgvFilePath.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFilePath.Size = new System.Drawing.Size(797, 377);
            this.DgvFilePath.TabIndex = 0;
            this.DgvFilePath.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFilePath_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnBrowse);
            this.groupBox3.Controls.Add(this.TxbFPath);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TxbFName);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxbFID);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.BtnFDelete);
            this.groupBox3.Controls.Add(this.BtnFUpdate);
            this.groupBox3.Controls.Add(this.BtnFAdd);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(25, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(830, 224);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conditions";
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.AutoSize = true;
            this.BtnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.BtnBrowse.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowse.ForeColor = System.Drawing.Color.White;
            this.BtnBrowse.Location = new System.Drawing.Point(76, 148);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(91, 26);
            this.BtnBrowse.TabIndex = 13;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            this.BtnBrowse.MouseEnter += new System.EventHandler(this.BtnBrowse_MouseEnter);
            this.BtnBrowse.MouseLeave += new System.EventHandler(this.BtnBrowse_MouseLeave);
            // 
            // TxbFPath
            // 
            this.TxbFPath.Location = new System.Drawing.Point(82, 106);
            this.TxbFPath.Name = "TxbFPath";
            this.TxbFPath.Size = new System.Drawing.Size(537, 22);
            this.TxbFPath.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "File Path:";
            // 
            // TxbFName
            // 
            this.TxbFName.Location = new System.Drawing.Point(306, 43);
            this.TxbFName.Name = "TxbFName";
            this.TxbFName.Size = new System.Drawing.Size(313, 22);
            this.TxbFName.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "File Name:";
            // 
            // TxbFID
            // 
            this.TxbFID.Location = new System.Drawing.Point(82, 43);
            this.TxbFID.Name = "TxbFID";
            this.TxbFID.ReadOnly = true;
            this.TxbFID.Size = new System.Drawing.Size(100, 22);
            this.TxbFID.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "ID:";
            // 
            // BtnFDelete
            // 
            this.BtnFDelete.AutoSize = true;
            this.BtnFDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnFDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFDelete.ForeColor = System.Drawing.Color.White;
            this.BtnFDelete.Location = new System.Drawing.Point(661, 159);
            this.BtnFDelete.Name = "BtnFDelete";
            this.BtnFDelete.Size = new System.Drawing.Size(114, 35);
            this.BtnFDelete.TabIndex = 4;
            this.BtnFDelete.Text = "Delete";
            this.BtnFDelete.Click += new System.EventHandler(this.BtnFDelete_Click);
            this.BtnFDelete.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.BtnFDelete.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // BtnFUpdate
            // 
            this.BtnFUpdate.AutoSize = true;
            this.BtnFUpdate.BackColor = System.Drawing.Color.Transparent;
            this.BtnFUpdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnFUpdate.Location = new System.Drawing.Point(661, 94);
            this.BtnFUpdate.Name = "BtnFUpdate";
            this.BtnFUpdate.Size = new System.Drawing.Size(121, 35);
            this.BtnFUpdate.TabIndex = 3;
            this.BtnFUpdate.Text = "Update";
            this.BtnFUpdate.Click += new System.EventHandler(this.BtnFUpdate_Click);
            this.BtnFUpdate.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.BtnFUpdate.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // BtnFAdd
            // 
            this.BtnFAdd.AutoSize = true;
            this.BtnFAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtnFAdd.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFAdd.ForeColor = System.Drawing.Color.White;
            this.BtnFAdd.Location = new System.Drawing.Point(682, 31);
            this.BtnFAdd.Name = "BtnFAdd";
            this.BtnFAdd.Size = new System.Drawing.Size(71, 35);
            this.BtnFAdd.TabIndex = 2;
            this.BtnFAdd.Text = "Add";
            this.BtnFAdd.Click += new System.EventHandler(this.BtnFAdd_Click);
            this.BtnFAdd.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            this.BtnFAdd.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1083, 781);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSetting";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFilePath)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label BtnAdd;
        private System.Windows.Forms.Label BtnDelete;
        private System.Windows.Forms.Label BtnUpdate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DgvFilePath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label BtnFDelete;
        private System.Windows.Forms.Label BtnFUpdate;
        private System.Windows.Forms.Label BtnFAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxbCID;
        private System.Windows.Forms.TextBox TxbFPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxbFName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxbFID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label BtnBrowse;
    }
}