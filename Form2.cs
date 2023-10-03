using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 fm1 = new Form1();
            fm1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _username = txtUsername.Text;
            string _pass = txtPass.Text;
            string _cfpass = txtConfirm.Text;
            string _gmail = txtGmail.Text;
            string _phone = txtPhoneNum.Text.ToString();

            if (_username.Trim() == "" | _pass.Trim() == "" | _cfpass.Trim() == "" | _gmail.Trim() == "" | _phone.Trim() == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống", "Lỗi");
                return;
            }
            if (_pass != _cfpass)
            {
                MessageBox.Show("Vui lòng xác nhận lại mật khẩu", "Thông báo");
                return;
            }
            try
            {
                Modify modify = new Modify();
                string sql = "Insert into ACCOUNT values ('" + _username + "', '" + _pass + "', '" + _gmail + "', '" + _phone + "')";
                modify.Command(sql);
                MessageBox.Show("Đăng ký thành công !!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản này đã được đăng ký !!", "Thông báo");
            }
        }
    }
}
