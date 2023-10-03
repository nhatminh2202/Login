namespace WinFormsApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button3 = new Button();
            label7 = new Label();
            txtPass = new TextBox();
            txtConfirm = new TextBox();
            txtPhoneNum = new TextBox();
            txtGmail = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Tan;
            label1.Location = new Point(191, 66);
            label1.Name = "label1";
            label1.Size = new Size(314, 42);
            label1.TabIndex = 0;
            label1.Text = "Đăng ký tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.BurlyWood;
            label2.Location = new Point(61, 140);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(216, 149);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(398, 31);
            txtUsername.TabIndex = 2;
            txtUsername.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.BurlyWood;
            label3.Location = new Point(30, 156);
            label3.Name = "label3";
            label3.Size = new Size(92, 24);
            label3.TabIndex = 3;
            label3.Text = "Tài khoản";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.BurlyWood;
            label4.Location = new Point(30, 224);
            label4.Name = "label4";
            label4.Size = new Size(90, 24);
            label4.TabIndex = 4;
            label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.BurlyWood;
            label5.Location = new Point(30, 439);
            label5.Name = "label5";
            label5.Size = new Size(59, 24);
            label5.TabIndex = 6;
            label5.Text = "Gmail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.BurlyWood;
            label6.Location = new Point(30, 372);
            label6.Name = "label6";
            label6.Size = new Size(120, 24);
            label6.TabIndex = 7;
            label6.Text = "Số điện thoại";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.BurlyWood;
            button1.Location = new Point(216, 505);
            button1.Name = "button1";
            button1.Size = new Size(135, 55);
            button1.TabIndex = 10;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.BurlyWood;
            button3.Location = new Point(427, 505);
            button3.Name = "button3";
            button3.Size = new Size(135, 55);
            button3.TabIndex = 12;
            button3.Text = "Quay lại";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.BurlyWood;
            label7.Location = new Point(30, 303);
            label7.Name = "label7";
            label7.Size = new Size(172, 24);
            label7.TabIndex = 13;
            label7.Text = "Xác nhận mật khẩu";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(216, 224);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(398, 31);
            txtPass.TabIndex = 15;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(216, 303);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new Size(398, 31);
            txtConfirm.TabIndex = 16;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(216, 372);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(398, 31);
            txtPhoneNum.TabIndex = 17;
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(216, 439);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(398, 31);
            txtGmail.TabIndex = 18;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(632, 670);
            Controls.Add(txtGmail);
            Controls.Add(txtPhoneNum);
            Controls.Add(txtConfirm);
            Controls.Add(txtPass);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đăng ký";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button3;
        private Label label7;
        private TextBox txtPass;
        private TextBox txtConfirm;
        private TextBox txtPhoneNum;
        private TextBox txtGmail;
    }
}