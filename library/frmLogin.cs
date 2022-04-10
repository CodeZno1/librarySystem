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
using DAL;

namespace 简单图书馆系统
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        Admin_BLL aa = new Admin_BLL();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定取消吗！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.username = tbUser.Text.Trim();
            a.password = tbPwd.Text.Trim();
           
            if (aa.Scalar(a) > 0)
            {
                FrmMain f = new FrmMain();
                f.admin = a;
                f.Show();
                this.Hide();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }
    }
}
