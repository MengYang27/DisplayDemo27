using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisplayDemo27
{
    public partial class S2 : Form
    {
        public S2()
        {
            InitializeComponent();
        }
        #region Btn
        private void label2_Click(object sender, EventArgs e)
        {
            FrmMain fm = new FrmMain();
            fm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("exit？", "info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                return;
        }
        #endregion
        #region style
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Gold;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.OrangeRed;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }
        #endregion
    }
}
