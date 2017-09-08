using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DisplayDemo27
{
    public partial class FrmSetting : Form
    {
        DBClass dc = new DBClass();
        DataTable dt;
        string sql;
        public FrmSetting()
        {
            InitializeComponent();
        }
        private void FrmSetting_Load(object sender, EventArgs e)
        {
            BindDgvCate();
            BindDgvFile();
            CleanControls();
        }
        #region funcs
        private void BindDgvCate()
        {
            sql = "select * from tbcategory";
            dt = DBClass.Get_DataTable(sql);
            if (dt.Rows.Count != 0)
                DgvCategory.DataSource = dt;
            else
                DgvCategory.DataSource = null;
        }

        private void BindDgvFile()
        {
            sql = "select * from tbfile";
            dt = DBClass.Get_DataTable(sql);
            if (dt.Rows.Count != 0)
                DgvFilePath.DataSource = dt;
            else
                DgvFilePath.DataSource = null;
        }
        private void CleanControls()
        {
            TxbCategory.Text = "";
            TxbCID.Text = "";
            TxbFID.Text = "";
            TxbFName.Text = "";
            TxbFPath.Text = "";
        }
        #endregion
        #region cellClick
        private void DgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string cID = DgvCategory.SelectedRows[0].Cells[0].Value.ToString();
            sql = "select * from tbcategory where cID=" + cID;
            dt = DBClass.Get_DataTable(sql);
            if (dt.Rows.Count != 0)
            {
                TxbCID.Text = dt.Rows[0][0].ToString();
                TxbCategory.Text = dt.Rows[0][1].ToString();
            }
        }

        private void DgvFilePath_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string fID = DgvFilePath.SelectedRows[0].Cells[0].Value.ToString();
            sql = "select * from tbfile where fID=" + fID;
            dt = DBClass.Get_DataTable(sql);
            if (dt.Rows.Count != 0)
            {
                TxbFID.Text = dt.Rows[0][0].ToString();
                TxbFName.Text = dt.Rows[0][1].ToString();
                TxbFPath.Text = dt.Rows[0][2].ToString();
            }
        }
        #endregion
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
        private void BtnFAdd_Click(object sender, EventArgs e)
        {
            if (TxbFPath.Text != "" && TxbFName.Text != "")
            {
                sql = "select * from tbfile where filename='" + TxbFName.Text;
                dt = DBClass.Get_DataTable(sql);
                if (dt.Rows.Count != 0)
                {
                    MessageBox.Show("This file already existed!");
                    return;
                }
                else
                {
                    sql = "insert into tbfile values('" + TxbFName.Text + "','" + TxbFPath.Text + "')";
                    if (DBClass.Run_SQL(sql) > 0)
                    {
                        CleanControls();
                        BindDgvFile();
                        MessageBox.Show("record has been inserted!");
                    }
                    else
                        MessageBox.Show("failed!");
                }
            }
            else
            {
                MessageBox.Show("Fill txb first!");
                return;
            }
        }

        private void BtnFUpdate_Click(object sender, EventArgs e)
        {
            if (TxbFID.Text != "" && TxbFID.Text != null)
            {
                sql = "update tbfile set filename='" + TxbFName.Text + "',filepath='" + TxbFPath.Text + "' where fid=" + TxbFID.Text;
                if (DBClass.Run_SQL(sql) > 0)
                {
                    CleanControls();
                    BindDgvFile();
                    MessageBox.Show("record has been updated!");
                }
                else
                    MessageBox.Show("failed!");
            }
            else
            {
                MessageBox.Show("select record first!");
                return;
            }
        }

        private void BtnFDelete_Click(object sender, EventArgs e)
        {
            if (TxbFID.Text != "" && TxbFID.Text != null)
            {
                if (MessageBox.Show("delete double check？", "info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    sql = "delete from tbfile where fid=" + TxbFID.Text;
                    if (DBClass.Run_SQL(sql) > 0)
                    {
                        CleanControls();
                        BindDgvFile();
                        MessageBox.Show("record has been deleted!");
                    }
                    else
                        MessageBox.Show("failed!");
                }
            }
            else
                MessageBox.Show("select record first!");
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Title = "select file";
            ofd.Filter = "all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TxbFName.Text = ofd.FileName.Substring(ofd.FileName.LastIndexOf('\\') + 1);
                TxbFPath.Text = Path.GetDirectoryName(ofd.FileName) + "\\";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxbCategory.Text != "")
            {
                sql = "select * from tbcategory where category='" + TxbCategory.Text;
                dt = DBClass.Get_DataTable(sql);
                if (dt.Rows.Count != 0)
                {
                    MessageBox.Show("This category already existed!");
                    return;
                }
                else
                {
                    sql = "insert into tbcategory values('" + TxbCategory.Text + "')";
                    if (DBClass.Run_SQL(sql) > 0)
                    {
                        CleanControls();
                        BindDgvCate();
                        MessageBox.Show("record has been inserted!");
                    }
                    else
                        MessageBox.Show("failed!");
                }
            }
            else
            {
                MessageBox.Show("Fill txb first!");
                return;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxbCID.Text != "" && TxbCID.Text != null)
            {
                sql = "update tbcategory set category='" + TxbCategory.Text + "' where cid=" + TxbCID.Text;
                if (DBClass.Run_SQL(sql) > 0)
                {
                    CleanControls();
                    BindDgvCate();
                    MessageBox.Show("record has been updated!");
                }
                else
                    MessageBox.Show("failed!");
            }
            else
            {
                MessageBox.Show("select record first!");
                return;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxbCID.Text != "" && TxbCID.Text != null)
            {
                if (MessageBox.Show("delete double check", "info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    sql = "delete from tbcategory where cid=" + TxbCID.Text;
                    if (DBClass.Run_SQL(sql) > 0)
                    {
                        CleanControls();
                        BindDgvCate();
                        MessageBox.Show("record has been deleted!");
                    }
                    else
                        MessageBox.Show("failed!");
                }
            }
            else
                MessageBox.Show("select record first!");
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

        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            BtnAdd.ForeColor = Color.Gold;
        }

        private void BtnUpdate_MouseEnter(object sender, EventArgs e)
        {
            BtnUpdate.ForeColor = Color.Gold;
        }

        private void BtnDelete_MouseEnter(object sender, EventArgs e)
        {
            BtnDelete.ForeColor = Color.Gold;
        }

        private void label5_MouseEnter(object sender, EventArgs e) //add
        {
            BtnFAdd.ForeColor = Color.Gold;
        }

        private void label4_MouseEnter(object sender, EventArgs e) //update
        {
            BtnFUpdate.ForeColor = Color.Gold;
        }

        private void label3_MouseEnter(object sender, EventArgs e)  //delete
        {
            BtnFDelete.ForeColor = Color.Gold;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            BtnFDelete.ForeColor = Color.White;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            BtnFUpdate.ForeColor = Color.White;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            BtnFAdd.ForeColor = Color.White;
        }

        private void BtnDelete_MouseLeave(object sender, EventArgs e)
        {
            BtnDelete.ForeColor = Color.White;
        }

        private void BtnUpdate_MouseLeave(object sender, EventArgs e)
        {
            BtnUpdate.ForeColor = Color.White;
        }

        private void BtnAdd_MouseLeave(object sender, EventArgs e)
        {
            BtnAdd.ForeColor = Color.White;
        }

        private void BtnBrowse_MouseEnter(object sender, EventArgs e)
        {
            BtnBrowse.ForeColor = Color.Gold;
        }

        private void BtnBrowse_MouseLeave(object sender, EventArgs e)
        {
            BtnBrowse.ForeColor = Color.White;
        }
        #endregion
    }
}
