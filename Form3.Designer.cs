namespace WinFormsApp
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            button3 = new Button();
            button1 = new Button();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtCap = new Label();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            btnReset = new Button();
            colorDialog1 = new ColorDialog();
            txtGmail = new TextBox();
            txtInCap = new TextBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(361, 539);
            button3.Name = "button3";
            button3.Size = new Size(135, 55);
            button3.TabIndex = 26;
            button3.Text = "Quay lại";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(180, 539);
            button1.Name = "button1";
            button1.Size = new Size(135, 55);
            button1.TabIndex = 25;
            button1.Text = "Xác thực";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(103, 203);
            label3.Name = "label3";
            label3.Size = new Size(92, 24);
            label3.TabIndex = 18;
            label3.Text = "Tài khoản";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(225, 203);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(340, 31);
            txtUsername.TabIndex = 17;
            txtUsername.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 127);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(113, 74);
            label1.Name = "label1";
            label1.Size = new Size(283, 42);
            label1.TabIndex = 15;
            label1.Text = "Quên mật khẩu?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(113, 141);
            label4.Name = "label4";
            label4.Size = new Size(406, 23);
            label4.TabIndex = 27;
            label4.Text = "Điền thông tin để xác thực tài khoản";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(103, 275);
            label5.Name = "label5";
            label5.Size = new Size(59, 24);
            label5.TabIndex = 28;
            label5.Text = "Gmail";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(103, 352);
            label7.Name = "label7";
            label7.Size = new Size(108, 24);
            label7.TabIndex = 32;
            label7.Text = "Mã captcha";
            label7.Click += label7_Click;
            // 
            // txtCap
            // 
            txtCap.BackColor = Color.WhiteSmoke;
            txtCap.Font = new Font("Freestyle Script", 28F, FontStyle.Bold, GraphicsUnit.Point);
            txtCap.ForeColor = Color.Goldenrod;
            txtCap.Location = new Point(204, 426);
            txtCap.Name = "txtCap";
            txtCap.Size = new Size(201, 66);
            txtCap.TabIndex = 34;
            txtCap.Text = "Mã captcha";
            txtCap.Click += label8_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(433, 437);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(96, 37);
            btnReset.TabIndex = 35;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(225, 275);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(340, 31);
            txtGmail.TabIndex = 36;
            // 
            // txtInCap
            // 
            txtInCap.Location = new Point(225, 352);
            txtInCap.Name = "txtInCap";
            txtInCap.Size = new Size(340, 31);
            txtInCap.TabIndex = 37;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(667, 725);
            Controls.Add(txtInCap);
            Controls.Add(txtGmail);
            Controls.Add(btnReset);
            Controls.Add(txtCap);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lấy lại mật khẩu";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button1;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label txtCap;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button btnReset;
        private ColorDialog colorDialog1;
        private TextBox txtGmail;
        private TextBox txtInCap;
    }
}