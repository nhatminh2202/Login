using System.Drawing.Text;
using DevExpress.XtraEditors;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string _username = textUsername.Text;
            string _pass = textPass.Text;
            Modify modify = new Modify();
            string query = "Select * from ACCOUNT where Username = '" + _username + "' and Pass = '" + _pass + "'";


            if (_username.Trim() == "" | _pass.Trim() == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống", "Lỗi");
                return;
            }
            if (modify.Accounts(query).Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
            }
            if (modify.Accounts(query).Count == 0)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            Hide();
            fm2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Returnbtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Form3 fm3 = new Form3();
            fm3.ShowDialog();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textPass.PasswordChar == '*')
            {
                Showbtn.BringToFront();
                textPass.PasswordChar = '\0';
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textPass.PasswordChar == '\0')
            {
                Hidebtn.BringToFront();
                textPass.PasswordChar = '*';
            }
        }
    }
}