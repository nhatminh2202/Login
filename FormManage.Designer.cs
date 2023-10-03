namespace WinFormsApp;

partial class FormManage
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManage));
        panel1 = new Panel();
        button3 = new Button();
        button2 = new Button();
        button1 = new Button();
        panel3 = new Panel();
        panel2 = new Panel();
        comboBox1 = new ComboBox();
        dateTimePicker1 = new DateTimePicker();
        label9 = new Label();
        label8 = new Label();
        label7 = new Label();
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        button8 = new Button();
        button7 = new Button();
        button6 = new Button();
        button5 = new Button();
        btnHienThi = new Button();
        panel4 = new Panel();
        button9 = new Button();
        button10 = new Button();
        button11 = new Button();
        dtnGridView = new DataGridView();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dtnGridView).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Controls.Add(button3);
        panel1.Controls.Add(button2);
        panel1.Controls.Add(button1);
        panel1.Location = new Point(-328, -254);
        panel1.Name = "panel1";
        panel1.Size = new Size(1458, 92);
        panel1.TabIndex = 3;
        // 
        // button3
        // 
        button3.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
        button3.Image = (Image)resources.GetObject("button3.Image");
        button3.Location = new Point(177, 7);
        button3.Name = "button3";
        button3.Size = new Size(79, 73);
        button3.TabIndex = 2;
        button3.Text = "Thoát";
        button3.TextAlign = ContentAlignment.BottomCenter;
        button3.TextImageRelation = TextImageRelation.ImageAboveText;
        button3.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
        button2.Image = (Image)resources.GetObject("button2.Image");
        button2.Location = new Point(91, 5);
        button2.Name = "button2";
        button2.Size = new Size(79, 73);
        button2.TabIndex = 1;
        button2.Text = "Tính tồn";
        button2.TextAlign = ContentAlignment.BottomCenter;
        button2.TextImageRelation = TextImageRelation.ImageAboveText;
        button2.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
        button1.Image = (Image)resources.GetObject("button1.Image");
        button1.Location = new Point(7, 7);
        button1.Name = "button1";
        button1.Size = new Size(79, 73);
        button1.TabIndex = 0;
        button1.Text = "Báo cáo";
        button1.TextImageRelation = TextImageRelation.ImageAboveText;
        button1.UseVisualStyleBackColor = true;
        // 
        // panel3
        // 
        panel3.BorderStyle = BorderStyle.FixedSingle;
        panel3.Location = new Point(-4, 104);
        panel3.Name = "panel3";
        panel3.Size = new Size(393, 860);
        panel3.TabIndex = 6;
        // 
        // panel2
        // 
        panel2.BorderStyle = BorderStyle.FixedSingle;
        panel2.Controls.Add(dtnGridView);
        panel2.Controls.Add(comboBox1);
        panel2.Controls.Add(dateTimePicker1);
        panel2.Controls.Add(label9);
        panel2.Controls.Add(label8);
        panel2.Controls.Add(label7);
        panel2.Controls.Add(label6);
        panel2.Controls.Add(label5);
        panel2.Controls.Add(label4);
        panel2.Controls.Add(label3);
        panel2.Controls.Add(label2);
        panel2.Controls.Add(label1);
        panel2.Controls.Add(button8);
        panel2.Controls.Add(button7);
        panel2.Controls.Add(button6);
        panel2.Controls.Add(button5);
        panel2.Controls.Add(btnHienThi);
        panel2.Location = new Point(396, 104);
        panel2.Name = "panel2";
        panel2.Size = new Size(1059, 860);
        panel2.TabIndex = 5;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(889, 744);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(147, 33);
        comboBox1.TabIndex = 20;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Location = new Point(606, 808);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(298, 31);
        dateTimePicker1.TabIndex = 19;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label9.Location = new Point(785, 747);
        label9.Name = "label9";
        label9.Size = new Size(98, 25);
        label9.TabIndex = 13;
        label9.Text = "Tình trạng";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label8.Location = new Point(6, 808);
        label8.Name = "label8";
        label8.Size = new Size(87, 25);
        label8.TabIndex = 12;
        label8.Text = "Loại hình";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label7.Location = new Point(454, 808);
        label7.Name = "label7";
        label7.Size = new Size(146, 25);
        label7.TabIndex = 11;
        label7.Text = "Ngày hoạt động";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label6.Location = new Point(429, 747);
        label6.Name = "label6";
        label6.Size = new Size(98, 25);
        label6.TabIndex = 10;
        label6.Text = "Điện thoại";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label5.Location = new Point(6, 687);
        label5.Name = "label5";
        label5.Size = new Size(105, 25);
        label5.TabIndex = 9;
        label5.Text = "Mã số thuế";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label4.Location = new Point(415, 687);
        label4.Name = "label4";
        label4.Size = new Size(67, 25);
        label4.TabIndex = 8;
        label4.Text = "Địa chỉ";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label3.Location = new Point(6, 747);
        label3.Name = "label3";
        label3.Size = new Size(136, 25);
        label3.TabIndex = 7;
        label3.Text = "Người đại diện";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label2.Location = new Point(11, 628);
        label2.Name = "label2";
        label2.Size = new Size(105, 25);
        label2.TabIndex = 6;
        label2.Text = "Mã công ty";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(400, 628);
        label1.Name = "label1";
        label1.Size = new Size(108, 25);
        label1.TabIndex = 2;
        label1.Text = "Tên công ty";
        // 
        // button8
        // 
        button8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        button8.Location = new Point(479, 13);
        button8.Name = "button8";
        button8.Size = new Size(94, 55);
        button8.TabIndex = 5;
        button8.Text = "Lưu";
        button8.UseVisualStyleBackColor = true;
        // 
        // button7
        // 
        button7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        button7.Location = new Point(354, 13);
        button7.Name = "button7";
        button7.Size = new Size(94, 55);
        button7.TabIndex = 4;
        button7.Text = "Xóa";
        button7.UseVisualStyleBackColor = true;
        // 
        // button6
        // 
        button6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        button6.Location = new Point(236, 13);
        button6.Name = "button6";
        button6.Size = new Size(94, 55);
        button6.TabIndex = 3;
        button6.Text = "Sửa";
        button6.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        button5.Location = new Point(121, 13);
        button5.Name = "button5";
        button5.Size = new Size(94, 55);
        button5.TabIndex = 2;
        button5.Text = "Thêm";
        button5.UseVisualStyleBackColor = true;
        // 
        // btnHienThi
        // 
        btnHienThi.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnHienThi.Location = new Point(6, 13);
        btnHienThi.Name = "btnHienThi";
        btnHienThi.Size = new Size(94, 55);
        btnHienThi.TabIndex = 1;
        btnHienThi.Text = "Hiển thị";
        btnHienThi.UseVisualStyleBackColor = true;
        btnHienThi.Click += btnHienThi_Click;
        // 
        // panel4
        // 
        panel4.BorderStyle = BorderStyle.FixedSingle;
        panel4.Controls.Add(button9);
        panel4.Controls.Add(button10);
        panel4.Controls.Add(button11);
        panel4.Location = new Point(-2, 6);
        panel4.Name = "panel4";
        panel4.Size = new Size(1458, 92);
        panel4.TabIndex = 4;
        // 
        // button9
        // 
        button9.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
        button9.Image = (Image)resources.GetObject("button9.Image");
        button9.Location = new Point(177, 7);
        button9.Name = "button9";
        button9.Size = new Size(79, 73);
        button9.TabIndex = 2;
        button9.Text = "Thoát";
        button9.TextAlign = ContentAlignment.BottomCenter;
        button9.TextImageRelation = TextImageRelation.ImageAboveText;
        button9.UseVisualStyleBackColor = true;
        // 
        // button10
        // 
        button10.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
        button10.Image = (Image)resources.GetObject("button10.Image");
        button10.Location = new Point(91, 5);
        button10.Name = "button10";
        button10.Size = new Size(79, 73);
        button10.TabIndex = 1;
        button10.Text = "Tính tồn";
        button10.TextAlign = ContentAlignment.BottomCenter;
        button10.TextImageRelation = TextImageRelation.ImageAboveText;
        button10.UseVisualStyleBackColor = true;
        // 
        // button11
        // 
        button11.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
        button11.Image = (Image)resources.GetObject("button11.Image");
        button11.Location = new Point(7, 7);
        button11.Name = "button11";
        button11.Size = new Size(79, 73);
        button11.TabIndex = 0;
        button11.Text = "Báo cáo";
        button11.TextImageRelation = TextImageRelation.ImageAboveText;
        button11.UseVisualStyleBackColor = true;
        // 
        // dtnGridView
        // 
        dtnGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtnGridView.Location = new Point(11, 74);
        dtnGridView.Name = "dtnGridView";
        dtnGridView.RowHeadersWidth = 62;
        dtnGridView.RowTemplate.Height = 33;
        dtnGridView.Size = new Size(1033, 537);
        dtnGridView.TabIndex = 21;
        // 
        // FormManage
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1453, 971);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(panel4);
        Controls.Add(panel1);
        Name = "FormManage";
        Text = "FormManage";
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel4.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dtnGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private Panel panel1;
    private Button button3;
    private Button button2;
    private Button button1;
    private Panel panel3;
    private Panel panel2;
    private ComboBox comboBox1;
    private DateTimePicker dateTimePicker1;
    private Label label9;
    private Label label8;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private Button button8;
    private Button button7;
    private Button button6;
    private Button button5;
    private Button btnHienThi;
    private Panel panel4;
    private Button button9;
    private Button button10;
    private Button button11;
    private DataGridView dtnGridView;
}