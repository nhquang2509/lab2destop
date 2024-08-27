namespace lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            rdNu = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            txtHoTen = new TextBox();
            label4 = new Label();
            dtpNgayDangKy = new DateTimePicker();
            chkTinHocA = new CheckBox();
            chkTinHocB = new CheckBox();
            chkTiengAnhA = new CheckBox();
            chkTiengAnhB = new CheckBox();
            label5 = new Label();
            txtTongTien = new TextBox();
            btnTinhTien = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            lblTHA = new Label();
            lblTHB = new Label();
            lblTAA = new Label();
            lblTAB = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(144, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = " ";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Click += cboMaHV;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 80);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã Học Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 83);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Giới tính";
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(498, 79);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(41, 19);
            rdNu.TabIndex = 3;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            rdNu.Click += this.rdNu;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(441, 80);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += rdNam;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 126);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(143, 126);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(396, 23);
            txtHoTen.TabIndex = 5;
            txtHoTen.Click += this.txtHoTen;
            txtHoTen.TextChanged += this.txtHoTen;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 175);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 6;
            label4.Text = "Ngày đăng ký";
            // 
            // dtpNgayDangKy
            // 
            dtpNgayDangKy.Location = new Point(143, 167);
            dtpNgayDangKy.Name = "dtpNgayDangKy";
            dtpNgayDangKy.Size = new Size(200, 23);
            dtpNgayDangKy.TabIndex = 7;
            dtpNgayDangKy.CloseUp += dpNgayDangKy;
            // 
            // chkTinHocA
            // 
            chkTinHocA.AutoSize = true;
            chkTinHocA.Location = new Point(74, 208);
            chkTinHocA.Name = "chkTinHocA";
            chkTinHocA.Size = new Size(76, 19);
            chkTinHocA.TabIndex = 8;
            chkTinHocA.Text = "Tin học A";
            chkTinHocA.UseVisualStyleBackColor = true;
            chkTinHocA.Click += this.chkTinHocA;
            // 
            // chkTinHocB
            // 
            chkTinHocB.AutoSize = true;
            chkTinHocB.Location = new Point(74, 233);
            chkTinHocB.Name = "chkTinHocB";
            chkTinHocB.Size = new Size(75, 19);
            chkTinHocB.TabIndex = 8;
            chkTinHocB.Text = "Tin học B";
            chkTinHocB.UseVisualStyleBackColor = true;
            chkTinHocB.Click += this.chkTinHocB;
            // 
            // chkTiengAnhA
            // 
            chkTiengAnhA.AutoSize = true;
            chkTiengAnhA.Location = new Point(74, 258);
            chkTiengAnhA.Name = "chkTiengAnhA";
            chkTiengAnhA.Size = new Size(89, 19);
            chkTiengAnhA.TabIndex = 8;
            chkTiengAnhA.Text = "Tiếng anh A";
            chkTiengAnhA.UseVisualStyleBackColor = true;
            chkTiengAnhA.Click += cktTiengAnhA;
            // 
            // chkTiengAnhB
            // 
            chkTiengAnhB.AutoSize = true;
            chkTiengAnhB.Location = new Point(74, 283);
            chkTiengAnhB.Name = "chkTiengAnhB";
            chkTiengAnhB.Size = new Size(88, 19);
            chkTiengAnhB.TabIndex = 8;
            chkTiengAnhB.Text = "Tiếng anh B";
            chkTiengAnhB.UseVisualStyleBackColor = true;
            chkTiengAnhB.Click += this.chkTiengAnhB;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 338);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 9;
            label5.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(213, 335);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(230, 23);
            txtTongTien.TabIndex = 10;
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(121, 398);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(75, 23);
            btnTinhTien.TabIndex = 11;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(244, 398);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(368, 398);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblTHA
            // 
            lblTHA.AutoSize = true;
            lblTHA.Location = new Point(368, 209);
            lblTHA.Name = "lblTHA";
            lblTHA.Size = new Size(74, 15);
            lblTHA.TabIndex = 12;
            lblTHA.Text = "300000 đồng";
            // 
            // lblTHB
            // 
            lblTHB.AutoSize = true;
            lblTHB.Location = new Point(368, 237);
            lblTHB.Name = "lblTHB";
            lblTHB.Size = new Size(74, 15);
            lblTHB.TabIndex = 12;
            lblTHB.Text = "500000 đồng";
            // 
            // lblTAA
            // 
            lblTAA.AutoSize = true;
            lblTAA.Location = new Point(368, 262);
            lblTAA.Name = "lblTAA";
            lblTAA.Size = new Size(74, 15);
            lblTAA.TabIndex = 12;
            lblTAA.Text = "400000 đồng";
            // 
            // lblTAB
            // 
            lblTAB.AutoSize = true;
            lblTAB.Location = new Point(368, 287);
            lblTAB.Name = "lblTAB";
            lblTAB.Size = new Size(74, 15);
            lblTAB.TabIndex = 12;
            lblTAB.Text = "600000 đồng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTAB);
            Controls.Add(lblTAA);
            Controls.Add(lblTHB);
            Controls.Add(lblTHA);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnTinhTien);
            Controls.Add(txtTongTien);
            Controls.Add(label5);
            Controls.Add(chkTiengAnhB);
            Controls.Add(chkTiengAnhA);
            Controls.Add(chkTinHocB);
            Controls.Add(chkTinHocA);
            Controls.Add(dtpNgayDangKy);
            Controls.Add(label4);
            Controls.Add(txtHoTen);
            Controls.Add(label3);
            Controls.Add(radioButton1);
            Controls.Add(rdNu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpNgayDangKy;
        private CheckBox chkTiengAnhA;
        private Label label5;
        private TextBox txtTongTien;
        private Button btnTinhTien;
        private Button btnCancel;
        private Button btnExit;
        private Label lblTHA;
        private Label lblTHB;
        private Label lblTAA;
        private Label lblTAB;
        private CheckBox chkTinHocB;
        private CheckBox chkTiengAnhB;
        private TextBox txtHoTen;
        private CheckBox chkTinHocA;
        private CheckBox chkTiengAnhB;
        private RadioButton rdNu;
        private TextBox txtHoTen;
        private CheckBox chkTinHocA;
        private CheckBox chkTinHocB;
        private TextBox txtHoTen;
        private CheckBox chkTinHocA;
        private CheckBox chkTinHocB;
        private RadioButton rdNu;
        private RadioButton rdNu;
        private CheckBox chkTinHocA;
        private TextBox txtHoTen;
        private RadioButton rdNu;
        private TextBox txtHoTen;
        private RadioButton rdNu;
    }
}
