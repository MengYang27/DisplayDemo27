namespace DisplayDemo27
{
    partial class S1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TvwList = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TpSummary = new System.Windows.Forms.TabPage();
            this.TpRef = new System.Windows.Forms.TabPage();
            this.PDFReader = new AxAcroPDFLib.AxAcroPDF();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TpRef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PDFReader)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(241, 1007);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mistral", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 1007);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Back";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TvwList);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(72, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 952);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REF LIST";
            // 
            // TvwList
            // 
            this.TvwList.BackColor = System.Drawing.Color.Black;
            this.TvwList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TvwList.ForeColor = System.Drawing.Color.White;
            this.TvwList.LineColor = System.Drawing.Color.Silver;
            this.TvwList.Location = new System.Drawing.Point(6, 35);
            this.TvwList.Name = "TvwList";
            this.TvwList.Size = new System.Drawing.Size(352, 911);
            this.TvwList.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TpSummary);
            this.tabControl1.Controls.Add(this.TpRef);
            this.tabControl1.Location = new System.Drawing.Point(474, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1438, 952);
            this.tabControl1.TabIndex = 4;
            // 
            // TpSummary
            // 
            this.TpSummary.ForeColor = System.Drawing.Color.White;
            this.TpSummary.Location = new System.Drawing.Point(4, 25);
            this.TpSummary.Name = "TpSummary";
            this.TpSummary.Padding = new System.Windows.Forms.Padding(3);
            this.TpSummary.Size = new System.Drawing.Size(1589, 1010);
            this.TpSummary.TabIndex = 0;
            this.TpSummary.Text = "Summary";
            this.TpSummary.UseVisualStyleBackColor = true;
            // 
            // TpRef
            // 
            this.TpRef.Controls.Add(this.PDFReader);
            this.TpRef.ForeColor = System.Drawing.Color.White;
            this.TpRef.Location = new System.Drawing.Point(4, 25);
            this.TpRef.Name = "TpRef";
            this.TpRef.Padding = new System.Windows.Forms.Padding(3);
            this.TpRef.Size = new System.Drawing.Size(1430, 923);
            this.TpRef.TabIndex = 1;
            this.TpRef.Text = "Ref File";
            this.TpRef.UseVisualStyleBackColor = true;
            // 
            // PDFReader
            // 
            this.PDFReader.Enabled = true;
            this.PDFReader.Location = new System.Drawing.Point(6, 6);
            this.PDFReader.Name = "PDFReader";
            this.PDFReader.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDFReader.OcxState")));
            this.PDFReader.Size = new System.Drawing.Size(1045, 911);
            this.PDFReader.TabIndex = 0;
            // 
            // S1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1924, 1084);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "S1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.S1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TpRef.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PDFReader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView TvwList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TpSummary;
        private System.Windows.Forms.TabPage TpRef;
        private AxAcroPDFLib.AxAcroPDF PDFReader;
    }
}