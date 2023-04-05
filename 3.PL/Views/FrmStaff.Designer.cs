namespace _3.PL.Views;

partial class FrmStaff
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
        panel2 = new Panel();
        rbtn_nu = new RadioButton();
        rbtn_nam = new RadioButton();
        panel1 = new Panel();
        rbtn_khonghoatdong = new RadioButton();
        rbtn_hoatdong = new RadioButton();
        lbl_tenAnh = new Label();
        btn_chonAnh = new Button();
        picBox_anhNhanvien = new PictureBox();
        txt_email = new TextBox();
        label11 = new Label();
        txt_timkiem = new TextBox();
        dgrid_nhanvien = new DataGridView();
        btn_clear = new Button();
        btn_sua = new Button();
        btn_them = new Button();
        label14 = new Label();
        dtpicker_ngaysinh = new DateTimePicker();
        txt_matkhau = new TextBox();
        txt_sdt = new TextBox();
        txt_diachi = new TextBox();
        txt_ten = new TextBox();
        txt_tendem = new TextBox();
        txt_ho = new TextBox();
        txt_ma = new TextBox();
        label12 = new Label();
        label9 = new Label();
        label8 = new Label();
        label7 = new Label();
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        panel2.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picBox_anhNhanvien).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgrid_nhanvien).BeginInit();
        SuspendLayout();
        // 
        // panel2
        // 
        panel2.Controls.Add(rbtn_nu);
        panel2.Controls.Add(rbtn_nam);
        panel2.Location = new Point(187, 181);
        panel2.Name = "panel2";
        panel2.Size = new Size(245, 25);
        panel2.TabIndex = 185;
        // 
        // rbtn_nu
        // 
        rbtn_nu.AutoSize = true;
        rbtn_nu.ForeColor = Color.FromArgb(0, 126, 249);
        rbtn_nu.Location = new Point(75, 2);
        rbtn_nu.Name = "rbtn_nu";
        rbtn_nu.Size = new Size(41, 19);
        rbtn_nu.TabIndex = 123;
        rbtn_nu.TabStop = true;
        rbtn_nu.Text = "Nữ";
        rbtn_nu.UseVisualStyleBackColor = true;
        // 
        // rbtn_nam
        // 
        rbtn_nam.AutoSize = true;
        rbtn_nam.ForeColor = Color.FromArgb(0, 126, 249);
        rbtn_nam.Location = new Point(5, 2);
        rbtn_nam.Name = "rbtn_nam";
        rbtn_nam.Size = new Size(51, 19);
        rbtn_nam.TabIndex = 122;
        rbtn_nam.TabStop = true;
        rbtn_nam.Text = "Nam";
        rbtn_nam.UseVisualStyleBackColor = true;
        // 
        // panel1
        // 
        panel1.Controls.Add(rbtn_khonghoatdong);
        panel1.Controls.Add(rbtn_hoatdong);
        panel1.Location = new Point(552, 181);
        panel1.Name = "panel1";
        panel1.Size = new Size(245, 25);
        panel1.TabIndex = 184;
        // 
        // rbtn_khonghoatdong
        // 
        rbtn_khonghoatdong.AutoSize = true;
        rbtn_khonghoatdong.ForeColor = Color.FromArgb(0, 126, 249);
        rbtn_khonghoatdong.Location = new Point(100, 2);
        rbtn_khonghoatdong.Name = "rbtn_khonghoatdong";
        rbtn_khonghoatdong.Size = new Size(118, 19);
        rbtn_khonghoatdong.TabIndex = 142;
        rbtn_khonghoatdong.TabStop = true;
        rbtn_khonghoatdong.Text = "Không hoạt động";
        rbtn_khonghoatdong.UseVisualStyleBackColor = true;
        // 
        // rbtn_hoatdong
        // 
        rbtn_hoatdong.AutoSize = true;
        rbtn_hoatdong.ForeColor = Color.FromArgb(0, 126, 249);
        rbtn_hoatdong.Location = new Point(5, 2);
        rbtn_hoatdong.Name = "rbtn_hoatdong";
        rbtn_hoatdong.Size = new Size(82, 19);
        rbtn_hoatdong.TabIndex = 141;
        rbtn_hoatdong.TabStop = true;
        rbtn_hoatdong.Text = "Hoạt động";
        rbtn_hoatdong.UseVisualStyleBackColor = true;
        // 
        // lbl_tenAnh
        // 
        lbl_tenAnh.AutoSize = true;
        lbl_tenAnh.ForeColor = Color.FromArgb(0, 126, 249);
        lbl_tenAnh.Location = new Point(932, 231);
        lbl_tenAnh.Name = "lbl_tenAnh";
        lbl_tenAnh.Size = new Size(48, 15);
        lbl_tenAnh.TabIndex = 183;
        lbl_tenAnh.Text = "Tên ảnh";
        // 
        // btn_chonAnh
        // 
        btn_chonAnh.ForeColor = Color.FromArgb(0, 126, 249);
        btn_chonAnh.Location = new Point(912, 251);
        btn_chonAnh.Name = "btn_chonAnh";
        btn_chonAnh.Size = new Size(100, 23);
        btn_chonAnh.TabIndex = 182;
        btn_chonAnh.Text = "Chọn ảnh";
        btn_chonAnh.UseVisualStyleBackColor = true;
        btn_chonAnh.Click += btn_chonAnh_Click;
        // 
        // picBox_anhNhanvien
        // 
        picBox_anhNhanvien.Location = new Point(847, 21);
        picBox_anhNhanvien.Name = "picBox_anhNhanvien";
        picBox_anhNhanvien.Size = new Size(230, 195);
        picBox_anhNhanvien.SizeMode = PictureBoxSizeMode.Zoom;
        picBox_anhNhanvien.TabIndex = 181;
        picBox_anhNhanvien.TabStop = false;
        // 
        // txt_email
        // 
        txt_email.Location = new Point(552, 101);
        txt_email.Name = "txt_email";
        txt_email.Size = new Size(245, 23);
        txt_email.TabIndex = 180;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.ForeColor = Color.FromArgb(0, 126, 249);
        label11.Location = new Point(462, 101);
        label11.Name = "label11";
        label11.Size = new Size(36, 15);
        label11.TabIndex = 179;
        label11.Text = "Email";
        // 
        // txt_timkiem
        // 
        txt_timkiem.Location = new Point(552, 223);
        txt_timkiem.Name = "txt_timkiem";
        txt_timkiem.Size = new Size(245, 23);
        txt_timkiem.TabIndex = 175;
        txt_timkiem.Text = "Tìm Kiếm ...";
        // 
        // dgrid_nhanvien
        // 
        dgrid_nhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgrid_nhanvien.Location = new Point(53, 319);
        dgrid_nhanvien.Name = "dgrid_nhanvien";
        dgrid_nhanvien.RowTemplate.Height = 25;
        dgrid_nhanvien.Size = new Size(1245, 454);
        dgrid_nhanvien.TabIndex = 174;
        dgrid_nhanvien.CellClick += dgrid_nhanvien_CellClick;
        // 
        // btn_clear
        // 
        btn_clear.Location = new Point(1158, 154);
        btn_clear.Name = "btn_clear";
        btn_clear.Size = new Size(120, 50);
        btn_clear.TabIndex = 173;
        btn_clear.Text = "Clear";
        btn_clear.UseVisualStyleBackColor = true;
        btn_clear.Click += btn_clear_Click;
        // 
        // btn_sua
        // 
        btn_sua.Location = new Point(1158, 88);
        btn_sua.Name = "btn_sua";
        btn_sua.Size = new Size(120, 50);
        btn_sua.TabIndex = 172;
        btn_sua.Text = "Sửa";
        btn_sua.UseVisualStyleBackColor = true;
        btn_sua.Click += btn_sua_Click;
        // 
        // btn_them
        // 
        btn_them.Location = new Point(1158, 21);
        btn_them.Name = "btn_them";
        btn_them.Size = new Size(120, 50);
        btn_them.TabIndex = 171;
        btn_them.Text = "Thêm";
        btn_them.UseVisualStyleBackColor = true;
        btn_them.Click += btn_them_Click;
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.ForeColor = Color.FromArgb(0, 126, 249);
        label14.Location = new Point(462, 181);
        label14.Name = "label14";
        label14.Size = new Size(61, 15);
        label14.TabIndex = 169;
        label14.Text = "Trạng Thái";
        // 
        // dtpicker_ngaysinh
        // 
        dtpicker_ngaysinh.Location = new Point(552, 61);
        dtpicker_ngaysinh.Name = "dtpicker_ngaysinh";
        dtpicker_ngaysinh.Size = new Size(245, 23);
        dtpicker_ngaysinh.TabIndex = 167;
        // 
        // txt_matkhau
        // 
        txt_matkhau.Location = new Point(552, 141);
        txt_matkhau.Name = "txt_matkhau";
        txt_matkhau.Size = new Size(245, 23);
        txt_matkhau.TabIndex = 166;
        // 
        // txt_sdt
        // 
        txt_sdt.Location = new Point(552, 21);
        txt_sdt.Name = "txt_sdt";
        txt_sdt.Size = new Size(245, 23);
        txt_sdt.TabIndex = 165;
        // 
        // txt_diachi
        // 
        txt_diachi.Location = new Point(187, 223);
        txt_diachi.Name = "txt_diachi";
        txt_diachi.Size = new Size(245, 23);
        txt_diachi.TabIndex = 164;
        txt_diachi.Leave += txt_diachi_Leave;
        // 
        // txt_ten
        // 
        txt_ten.Location = new Point(187, 141);
        txt_ten.Name = "txt_ten";
        txt_ten.Size = new Size(245, 23);
        txt_ten.TabIndex = 163;
        txt_ten.Leave += txt_ten_Leave;
        // 
        // txt_tendem
        // 
        txt_tendem.Location = new Point(187, 101);
        txt_tendem.Name = "txt_tendem";
        txt_tendem.Size = new Size(245, 23);
        txt_tendem.TabIndex = 162;
        txt_tendem.Leave += txt_tendem_Leave;
        // 
        // txt_ho
        // 
        txt_ho.Location = new Point(187, 61);
        txt_ho.Name = "txt_ho";
        txt_ho.Size = new Size(245, 23);
        txt_ho.TabIndex = 161;
        txt_ho.Leave += txt_ho_Leave;
        // 
        // txt_ma
        // 
        txt_ma.Location = new Point(187, 21);
        txt_ma.Name = "txt_ma";
        txt_ma.Size = new Size(245, 23);
        txt_ma.TabIndex = 160;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.ForeColor = Color.FromArgb(0, 126, 249);
        label12.Location = new Point(462, 141);
        label12.Name = "label12";
        label12.Size = new Size(58, 15);
        label12.TabIndex = 159;
        label12.Text = "Mật Khẩu";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.ForeColor = Color.FromArgb(0, 126, 249);
        label9.Location = new Point(462, 61);
        label9.Name = "label9";
        label9.Size = new Size(61, 15);
        label9.TabIndex = 157;
        label9.Text = "Ngày Sinh";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.ForeColor = Color.FromArgb(0, 126, 249);
        label8.Location = new Point(462, 21);
        label8.Name = "label8";
        label8.Size = new Size(27, 15);
        label8.TabIndex = 156;
        label8.Text = "SĐT";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.ForeColor = Color.FromArgb(0, 126, 249);
        label7.Location = new Point(112, 223);
        label7.Name = "label7";
        label7.Size = new Size(45, 15);
        label7.TabIndex = 155;
        label7.Text = "Địa Chỉ";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.ForeColor = Color.FromArgb(0, 126, 249);
        label6.Location = new Point(112, 181);
        label6.Name = "label6";
        label6.Size = new Size(54, 15);
        label6.TabIndex = 154;
        label6.Text = "Giới Tính";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.ForeColor = Color.FromArgb(0, 126, 249);
        label5.Location = new Point(112, 141);
        label5.Name = "label5";
        label5.Size = new Size(25, 15);
        label5.TabIndex = 153;
        label5.Text = "Tên";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.ForeColor = Color.FromArgb(0, 126, 249);
        label4.Location = new Point(112, 101);
        label4.Name = "label4";
        label4.Size = new Size(53, 15);
        label4.TabIndex = 152;
        label4.Text = "Tên Đệm";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.ForeColor = Color.FromArgb(0, 126, 249);
        label3.Location = new Point(112, 61);
        label3.Name = "label3";
        label3.Size = new Size(23, 15);
        label3.TabIndex = 151;
        label3.Text = "Họ";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.ForeColor = Color.FromArgb(0, 126, 249);
        label2.Location = new Point(112, 21);
        label2.Name = "label2";
        label2.Size = new Size(24, 15);
        label2.TabIndex = 150;
        label2.Text = "Mã";
        // 
        // FrmStaff
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1350, 800);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(lbl_tenAnh);
        Controls.Add(btn_chonAnh);
        Controls.Add(picBox_anhNhanvien);
        Controls.Add(txt_email);
        Controls.Add(label11);
        Controls.Add(txt_timkiem);
        Controls.Add(dgrid_nhanvien);
        Controls.Add(btn_clear);
        Controls.Add(btn_sua);
        Controls.Add(btn_them);
        Controls.Add(label14);
        Controls.Add(dtpicker_ngaysinh);
        Controls.Add(txt_matkhau);
        Controls.Add(txt_sdt);
        Controls.Add(txt_diachi);
        Controls.Add(txt_ten);
        Controls.Add(txt_tendem);
        Controls.Add(txt_ho);
        Controls.Add(txt_ma);
        Controls.Add(label12);
        Controls.Add(label9);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FrmStaff";
        Text = "FrmStaff";
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picBox_anhNhanvien).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgrid_nhanvien).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel2;
    private RadioButton rbtn_nu;
    private RadioButton rbtn_nam;
    private Panel panel1;
    private RadioButton rbtn_khonghoatdong;
    private RadioButton rbtn_hoatdong;
    private Label lbl_tenAnh;
    private Button btn_chonAnh;
    private PictureBox picBox_anhNhanvien;
    private TextBox txt_email;
    private Label label11;
    private TextBox txt_timkiem;
    private DataGridView dgrid_nhanvien;
    private Button btn_clear;
    private Button btn_sua;
    private Button btn_them;
    private Label label14;
    private DateTimePicker dtpicker_ngaysinh;
    private TextBox txt_matkhau;
    private TextBox txt_sdt;
    private TextBox txt_diachi;
    private TextBox txt_ten;
    private TextBox txt_tendem;
    private TextBox txt_ho;
    private TextBox txt_ma;
    private Label label12;
    private Label label9;
    private Label label8;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
}