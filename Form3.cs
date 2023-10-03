using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp
{
    public partial class Form3 : Form
    {

        Captcha cpt = new Captcha();

        public Form3()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtCap.Text = cpt.randomString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCap.Text = cpt.randomString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _txtUsername = txtUsername.Text;
            string _txtGmail = txtGmail.Text;
            string _captcha = txtInCap.Text;

            if (_txtUsername.Trim() == "" | _txtGmail.Trim() == "" | _captcha == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống", "Thông báo");
                return;
            }

            if (txtCap.Text != txtInCap.Text)
            {
                MessageBox.Show("Mã Captcha không đúng !", "Thông báo");
                txtInCap.Text = "";
                txtCap.Text = cpt.randomString();
                return;
            }

            // Truy vấn dữ liệu

            string query = "Select * from ACCOUNT where Username = '" + _txtUsername + "'and Gmail = '" + _txtGmail + "'";
            Modify modify = new Modify();

            if (modify.Accounts(query).Count() > 0)
            {
                var cmd = modify.Accounts(query)[0].Password;
                MessageBox.Show("Mật khẩu của bạn là: " + cmd, "Thông báo");
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai hoặc tài khoản không tồn tại!!", "Thông báo");
            }
        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
