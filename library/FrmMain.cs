using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using BLL;

namespace 简单图书馆系统
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲

            lbTitle.BackColor = Color.Transparent;
            pictureBoxExit.BackColor = Color.Transparent;

            category = new Category();

            cbCategory1.DataSource = category.category1;
        }

        public Admin admin = null;
        public Category category = null;

        BookInfo_BLL bfBLL = new BookInfo_BLL();
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }
        }

        private void cbCategory1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> c2 = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                c2.Add(category.category2[cbCategory1.SelectedIndex, i]);
            }
            cbCategory2.DataSource = c2;
        }

        private void pictureBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim() != "" && tbCount.Text.Trim() != "")
            {
                BookInfo newBf = new BookInfo();
                newBf.name = tbName.Text;
                newBf.count = Convert.ToInt32(tbCount.Text);
                newBf.category1 = cbCategory1.SelectedItem.ToString();
                newBf.category2 = cbCategory2.SelectedItem.ToString();
                newBf.category3 = cbCategory3.SelectedItem.ToString();
                newBf.addr = "未填写";
                int result = bfBLL.addInfo(newBf);

                MessageBox.Show("成功增加" + result.ToString() + "条信息！");
            }
            else
            {
                MessageBox.Show("请填写必要的内容");
            }
        }

        private void cbCategory2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> c3 = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                c3.Add(category.category3[cbCategory1.SelectedIndex, cbCategory2.SelectedIndex, i]);
            }
            cbCategory3.DataSource = c3;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    {
                        DataTable dt = bfBLL.getAllInfo();
                        dataGridViewDel.DataSource = dt;
                        if (dt != null)
                        {
                            dataGridViewDel.Columns[0].Width = 50;
                            dataGridViewDel.Columns[1].Width = 350;
                            dataGridViewDel.Columns[2].Width = 100;
                            dataGridViewDel.Columns[3].Width = 200;
                            dataGridViewDel.Columns[4].Width = 200;
                            dataGridViewDel.Columns[5].Width = 200;
                            dataGridViewDel.Columns[6].Width = 400;
                        }
                        break;
                    }
                case 2:
                    {
                        DataTable dt = bfBLL.getAllInfo();
                        dataGridViewChange.DataSource = dt;
                        if (dt != null)
                        {
                            dataGridViewChange.Columns[0].Width = 50;
                            dataGridViewChange.Columns[1].Width = 350;
                            dataGridViewChange.Columns[2].Width = 100;
                            dataGridViewChange.Columns[3].Width = 200;
                            dataGridViewChange.Columns[4].Width = 200;
                            dataGridViewChange.Columns[5].Width = 200;
                            dataGridViewChange.Columns[6].Width = 400;
                        }
                        break;
                    }
                case 3:
                    {
                        cbQCategory1.DataSource = category.category1;
                        break;
                    }
                case 4:
                    {
                        cbCountA1.DataSource = category.category1;
                        cbCountB1.DataSource = category.category1;
                        cbCountC1.DataSource = category.category1;
                        break;
                    }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult RSS = MessageBox.Show(this, "确定要删除选中行数据码？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (RSS)
            {
                case DialogResult.Yes:
                    for (int i = dataGridViewDel.SelectedRows.Count; i > 0; i--)
                    {
                        string strV1 = Convert.ToString(dataGridViewDel.SelectedRows[i - 1].Cells[0].Value);

                        dataGridViewDel.Rows.RemoveAt(dataGridViewDel.SelectedRows[i - 1].Index);
                        //使用获得的ID删除数据库的数据
                        int s = bfBLL.deleteBookInfo(strV1);  //cl是操作类的一个对像，Execute()是类中的一个方法
                        if (s != 0)
                        {
                            MessageBox.Show("成功删除选中行数据！");
                        }
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnQueryAll_Click(object sender, EventArgs e)
        {
            DataTable dt = bfBLL.getAllInfo();
            dataGridViewQuery.DataSource = dt;
            if (dt != null)
            {
                dataGridViewQuery.Columns[0].Width = 50;
                dataGridViewQuery.Columns[1].Width = 350;
                dataGridViewQuery.Columns[2].Width = 100;
                dataGridViewQuery.Columns[3].Width = 200;
                dataGridViewQuery.Columns[4].Width = 200;
                dataGridViewQuery.Columns[5].Width = 200;
                dataGridViewQuery.Columns[6].Width = 400;
            }
        }

        private void dataGridViewChange_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbChange.Text = dataGridViewChange.SelectedCells[0].Value.ToString();
        }

        private void tbChange_TextChanged(object sender, EventArgs e)
        {
            dataGridViewChange.SelectedCells[0].Value = tbChange.Text;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewChange.RowCount - 1; i++)
            {
                BookInfo updateInfo = new BookInfo();
                updateInfo.ID = Convert.ToInt32(dataGridViewChange.Rows[i].Cells[0].Value.ToString());
                updateInfo.name = dataGridViewChange.Rows[i].Cells[1].Value.ToString();
                updateInfo.count = Convert.ToInt32(dataGridViewChange.Rows[i].Cells[2].Value.ToString());
                updateInfo.category1 = dataGridViewChange.Rows[i].Cells[3].Value.ToString();
                updateInfo.category2 = dataGridViewChange.Rows[i].Cells[4].Value.ToString();
                updateInfo.category3 = dataGridViewChange.Rows[i].Cells[5].Value.ToString();
                updateInfo.addr = dataGridViewChange.Rows[i].Cells[6].Value.ToString();
                bfBLL.upadeBookInfo(updateInfo);
            }
            MessageBox.Show("修改完成!");
        }

        private void dataGridViewChange_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewChange_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewChange.Columns[dataGridViewChange.CurrentCell.ColumnIndex].HeaderText == "ID")
            {
                MessageBox.Show("ID不可以更改！");
                return;
            }

            tbChange.Text = dataGridViewChange.SelectedCells[0].Value.ToString();
        }

        private void cbQCategory1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> c2 = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                c2.Add(category.category2[cbCategory1.SelectedIndex, i]);
            }
            cbQCategory2.DataSource = c2;
        }

        private void cbQCategory2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> c3 = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                c3.Add(category.category3[cbCategory1.SelectedIndex, cbCategory2.SelectedIndex, i]);
            }
            cbQCategory3.DataSource = c3;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (tbQID.Text.Trim() != "" && tbQName.Text.Trim() != "" && cbQCategory1.Text.Trim() != "" && cbQCategory2.Text.Trim() != "" && cbQCategory3.Text.Trim() != "")
            {
                BookInfo qInfo = new BookInfo();
                qInfo.ID = Convert.ToInt32(tbQID.Text);
                qInfo.name = tbQName.Text.Trim();
                qInfo.category1 = cbQCategory1.Text.Trim();
                qInfo.category2 = cbQCategory2.Text.Trim();
                qInfo.category3 = cbQCategory3.Text.Trim();
                DataTable dt = bfBLL.queryInfo(qInfo);
                dataGridViewQuery.DataSource = dt;
                if (dt != null)
                {
                    dataGridViewQuery.Columns[0].Width = 50;
                    dataGridViewQuery.Columns[1].Width = 350;
                    dataGridViewQuery.Columns[2].Width = 100;
                    dataGridViewQuery.Columns[3].Width = 200;
                    dataGridViewQuery.Columns[4].Width = 200;
                    dataGridViewQuery.Columns[5].Width = 200;
                    dataGridViewQuery.Columns[6].Width = 400;
                    MessageBox.Show("查询完成！");
                }
            }
            else
            {
                MessageBox.Show("请填入所有查询条件!");
            }
        }

        private void tbQID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }
        }

        private void dataGridViewChange_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tbChange.Text = dataGridViewChange.SelectedCells[0].Value.ToString();
        }

        private void cbCountB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> c2 = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                c2.Add(category.category2[cbCategory1.SelectedIndex, i]);
            }
            cbCountB2.DataSource = c2;
        }

        private void cbCountC1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> c2 = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                c2.Add(category.category2[cbCategory1.SelectedIndex, i]);
            }
            cbCountC2.DataSource = c2;
        }

        private void cbCountC2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> c3 = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                c3.Add(category.category3[cbCategory1.SelectedIndex, cbCategory2.SelectedIndex, i]);
            }
            cbCountC3.DataSource = c3;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (cbCountA1.Text.Trim() != "" && cbCountB1.Text.Trim() != "" && cbCountC1.Text.Trim() != "" && cbCountB2.Text.Trim() != "" && cbCountC2.Text.Trim() != "" && cbCountC3.Text.Trim() != "")
            {
                lbTotal1.Text = "总数：" + bfBLL.getTotal1(cbCountA1.Text).ToString();
                lbTotal2.Text = "总数：" + bfBLL.getTotal2(cbCountB1.Text, cbCountB2.Text).ToString();
                lbTotal3.Text = "总数：" + bfBLL.getTotal3(cbCountC1.Text, cbCountC2.Text, cbCountC3.Text).ToString();
                MessageBox.Show("统计完成！");
            }
            else
            {
                MessageBox.Show("请填入正确的类别！");
            }
        }
    }

}

