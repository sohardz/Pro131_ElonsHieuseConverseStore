namespace _3.PL.Views;

partial class FrmConfigShoes
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
        lbl_tenAnh = new Label();
        btn_chonAnh = new Button();
        picBox_anhNhanvien = new PictureBox();
        label15 = new Label();
        rbtn_khonghoatdong = new RadioButton();
        rbtn_hoatdong = new RadioButton();
        label13 = new Label();
        txt_ma = new TextBox();
        cmb_size = new ComboBox();
        label11 = new Label();
        cmb_category = new ComboBox();
        txt_soluong = new TextBox();
        txt_giaban = new TextBox();
        txt_gianhap = new TextBox();
        cmb_ = new ComboBox();
        richtxt_mota = new RichTextBox();
        label9 = new Label();
        label7 = new Label();
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        label1 = new Label();
        label8 = new Label();
        txt_ten = new TextBox();
        button1 = new Button();
        button2 = new Button();
        ((System.ComponentModel.ISupportInitialize)picBox_anhNhanvien).BeginInit();
        SuspendLayout();
        // 
        // lbl_tenAnh
        // 
        lbl_tenAnh.AutoSize = true;
        lbl_tenAnh.ForeColor = Color.FromArgb(0, 126, 249);
        lbl_tenAnh.Location = new Point(1039, 365);
        lbl_tenAnh.Name = "lbl_tenAnh";
        lbl_tenAnh.Size = new Size(48, 15);
        lbl_tenAnh.TabIndex = 201;
        lbl_tenAnh.Text = "Tên ảnh";
        // 
        // btn_chonAnh
        // 
        btn_chonAnh.ForeColor = Color.FromArgb(0, 126, 249);
        btn_chonAnh.Location = new Point(1003, 383);
        btn_chonAnh.Name = "btn_chonAnh";
        btn_chonAnh.Size = new Size(125, 30);
        btn_chonAnh.TabIndex = 200;
        btn_chonAnh.Text = "Chọn ảnh";
        btn_chonAnh.UseVisualStyleBackColor = true;
        // 
        // picBox_anhNhanvien
        // 
        picBox_anhNhanvien.Location = new Point(858, 12);
        picBox_anhNhanvien.Name = "picBox_anhNhanvien";
        picBox_anhNhanvien.Size = new Size(400, 350);
        picBox_anhNhanvien.SizeMode = PictureBoxSizeMode.Zoom;
        picBox_anhNhanvien.TabIndex = 199;
        picBox_anhNhanvien.TabStop = false;
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.ForeColor = Color.FromArgb(0, 126, 249);
        label15.Location = new Point(430, 269);
        label15.Name = "label15";
        label15.Size = new Size(61, 15);
        label15.TabIndex = 188;
        label15.Text = "Trạng Thái";
        // 
        // rbtn_khonghoatdong
        // 
        rbtn_khonghoatdong.AutoSize = true;
        rbtn_khonghoatdong.ForeColor = Color.FromArgb(0, 126, 249);
        rbtn_khonghoatdong.Location = new Point(640, 270);
        rbtn_khonghoatdong.Name = "rbtn_khonghoatdong";
        rbtn_khonghoatdong.Size = new Size(118, 19);
        rbtn_khonghoatdong.TabIndex = 198;
        rbtn_khonghoatdong.TabStop = true;
        rbtn_khonghoatdong.Text = "Không hoạt động";
        rbtn_khonghoatdong.UseVisualStyleBackColor = true;
        // 
        // rbtn_hoatdong
        // 
        rbtn_hoatdong.AutoSize = true;
        rbtn_hoatdong.ForeColor = Color.FromArgb(0, 126, 249);
        rbtn_hoatdong.Location = new Point(540, 270);
        rbtn_hoatdong.Name = "rbtn_hoatdong";
        rbtn_hoatdong.Size = new Size(82, 19);
        rbtn_hoatdong.TabIndex = 197;
        rbtn_hoatdong.TabStop = true;
        rbtn_hoatdong.Text = "Hoạt động";
        rbtn_hoatdong.UseVisualStyleBackColor = true;
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.ForeColor = Color.FromArgb(0, 126, 249);
        label13.Location = new Point(27, 25);
        label13.Name = "label13";
        label13.Size = new Size(24, 15);
        label13.TabIndex = 196;
        label13.Text = "Mã";
        // 
        // txt_ma
        // 
        txt_ma.Location = new Point(124, 22);
        txt_ma.Name = "txt_ma";
        txt_ma.Size = new Size(225, 23);
        txt_ma.TabIndex = 195;
        // 
        // cmb_size
        // 
        cmb_size.FormattingEnabled = true;
        cmb_size.Location = new Point(124, 342);
        cmb_size.Name = "cmb_size";
        cmb_size.Size = new Size(225, 23);
        cmb_size.TabIndex = 192;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.ForeColor = Color.FromArgb(0, 126, 249);
        label11.Location = new Point(27, 342);
        label11.Name = "label11";
        label11.Size = new Size(22, 15);
        label11.TabIndex = 191;
        label11.Text = "Cỡ";
        // 
        // cmb_category
        // 
        cmb_category.FormattingEnabled = true;
        cmb_category.Location = new Point(124, 186);
        cmb_category.Name = "cmb_category";
        cmb_category.Size = new Size(225, 23);
        cmb_category.TabIndex = 187;
        // 
        // txt_soluong
        // 
        txt_soluong.Location = new Point(535, 22);
        txt_soluong.Name = "txt_soluong";
        txt_soluong.Size = new Size(250, 23);
        txt_soluong.TabIndex = 186;
        // 
        // txt_giaban
        // 
        txt_giaban.Location = new Point(535, 186);
        txt_giaban.Name = "txt_giaban";
        txt_giaban.Size = new Size(250, 23);
        txt_giaban.TabIndex = 184;
        // 
        // txt_gianhap
        // 
        txt_gianhap.Location = new Point(535, 102);
        txt_gianhap.Name = "txt_gianhap";
        txt_gianhap.Size = new Size(250, 23);
        txt_gianhap.TabIndex = 183;
        // 
        // cmb_
        // 
        cmb_.FormattingEnabled = true;
        cmb_.Location = new Point(124, 269);
        cmb_.Name = "cmb_";
        cmb_.Size = new Size(225, 23);
        cmb_.TabIndex = 181;
        // 
        // richtxt_mota
        // 
        richtxt_mota.Location = new Point(540, 339);
        richtxt_mota.Name = "richtxt_mota";
        richtxt_mota.Size = new Size(250, 55);
        richtxt_mota.TabIndex = 179;
        richtxt_mota.Text = "";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.ForeColor = Color.FromArgb(0, 126, 249);
        label9.Location = new Point(430, 342);
        label9.Name = "label9";
        label9.Size = new Size(40, 15);
        label9.TabIndex = 178;
        label9.Text = "Mô Tả";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.ForeColor = Color.FromArgb(0, 126, 249);
        label7.Location = new Point(430, 186);
        label7.Name = "label7";
        label7.Size = new Size(47, 15);
        label7.TabIndex = 176;
        label7.Text = "Giá Bán";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.ForeColor = Color.FromArgb(0, 126, 249);
        label6.Location = new Point(430, 102);
        label6.Name = "label6";
        label6.Size = new Size(56, 15);
        label6.TabIndex = 175;
        label6.Text = "Giá Nhập";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.ForeColor = Color.FromArgb(0, 126, 249);
        label5.Location = new Point(430, 22);
        label5.Name = "label5";
        label5.Size = new Size(57, 15);
        label5.TabIndex = 174;
        label5.Text = "Số Lượng";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.ForeColor = Color.FromArgb(0, 126, 249);
        label4.Location = new Point(27, 269);
        label4.Name = "label4";
        label4.Size = new Size(51, 15);
        label4.TabIndex = 173;
        label4.Text = "Màu sắc";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.ForeColor = Color.FromArgb(0, 126, 249);
        label1.Location = new Point(27, 186);
        label1.Name = "label1";
        label1.Size = new Size(91, 15);
        label1.TabIndex = 170;
        label1.Text = "Dòng sản phẩm";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.ForeColor = Color.FromArgb(0, 126, 249);
        label8.Location = new Point(27, 105);
        label8.Name = "label8";
        label8.Size = new Size(25, 15);
        label8.TabIndex = 203;
        label8.Text = "Tên";
        // 
        // txt_ten
        // 
        txt_ten.Location = new Point(124, 102);
        txt_ten.Name = "txt_ten";
        txt_ten.Size = new Size(225, 23);
        txt_ten.TabIndex = 202;
        // 
        // button1
        // 
        button1.Location = new Point(425, 425);
        button1.Name = "button1";
        button1.Size = new Size(150, 50);
        button1.TabIndex = 204;
        button1.Text = "Lưu";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(635, 425);
        button2.Name = "button2";
        button2.Size = new Size(150, 50);
        button2.TabIndex = 205;
        button2.Text = "Hủy";
        button2.UseVisualStyleBackColor = true;
        // 
        // FrmConfigShoes
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1284, 511);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label8);
        Controls.Add(txt_ten);
        Controls.Add(lbl_tenAnh);
        Controls.Add(btn_chonAnh);
        Controls.Add(picBox_anhNhanvien);
        Controls.Add(label15);
        Controls.Add(rbtn_khonghoatdong);
        Controls.Add(rbtn_hoatdong);
        Controls.Add(label13);
        Controls.Add(txt_ma);
        Controls.Add(cmb_size);
        Controls.Add(label11);
        Controls.Add(cmb_category);
        Controls.Add(txt_soluong);
        Controls.Add(txt_giaban);
        Controls.Add(txt_gianhap);
        Controls.Add(cmb_);
        Controls.Add(richtxt_mota);
        Controls.Add(label9);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label1);
        Name = "FrmConfigShoes";
        Text = "FrmConfigShoes";
        ((System.ComponentModel.ISupportInitialize)picBox_anhNhanvien).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbl_tenAnh;
    private Button btn_chonAnh;
    private PictureBox picBox_anhNhanvien;
    private Label label15;
    private RadioButton rbtn_khonghoatdong;
    private RadioButton rbtn_hoatdong;
    private Label label13;
    private TextBox txt_ma;
    private ComboBox cmb_size;
    private Label label11;
    private ComboBox cmb_category;
    private TextBox txt_soluong;
    private TextBox txt_giaban;
    private TextBox txt_gianhap;
    private ComboBox cmb_;
    private RichTextBox richtxt_mota;
    private Label label9;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label1;
    private Label label8;
    private TextBox txt_ten;
    private Button button1;
    private Button button2;
}