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
        picBox_shoesImage = new PictureBox();
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
        cmb_color = new ComboBox();
        richtxt_mota = new RichTextBox();
        label9 = new Label();
        label7 = new Label();
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        label1 = new Label();
        label8 = new Label();
        txt_ten = new TextBox();
        btn_save = new Button();
        btn_huy = new Button();
        cmb_material = new ComboBox();
        label2 = new Label();
        btn_sua = new Button();
        ((System.ComponentModel.ISupportInitialize)picBox_shoesImage).BeginInit();
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
        btn_chonAnh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        btn_chonAnh.ForeColor = Color.FromArgb(0, 126, 249);
        btn_chonAnh.Location = new Point(1001, 392);
        btn_chonAnh.Name = "btn_chonAnh";
        btn_chonAnh.Size = new Size(123, 40);
        btn_chonAnh.TabIndex = 200;
        btn_chonAnh.Text = "Chọn ảnh";
        btn_chonAnh.UseVisualStyleBackColor = true;
        btn_chonAnh.Click += btn_chonAnh_Click;
        // 
        // picBox_shoesImage
        // 
        picBox_shoesImage.Location = new Point(858, 12);
        picBox_shoesImage.Name = "picBox_shoesImage";
        picBox_shoesImage.Size = new Size(400, 350);
        picBox_shoesImage.SizeMode = PictureBoxSizeMode.Zoom;
        picBox_shoesImage.TabIndex = 199;
        picBox_shoesImage.TabStop = false;
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label15.ForeColor = Color.FromArgb(0, 126, 249);
        label15.Location = new Point(430, 269);
        label15.Name = "label15";
        label15.Size = new Size(82, 21);
        label15.TabIndex = 188;
        label15.Text = "Trạng Thái";
        // 
        // rbtn_khonghoatdong
        // 
        rbtn_khonghoatdong.AutoSize = true;
        rbtn_khonghoatdong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        rbtn_khonghoatdong.ForeColor = Color.FromArgb(0, 126, 249);
        rbtn_khonghoatdong.Location = new Point(640, 270);
        rbtn_khonghoatdong.Name = "rbtn_khonghoatdong";
        rbtn_khonghoatdong.Size = new Size(148, 25);
        rbtn_khonghoatdong.TabIndex = 198;
        rbtn_khonghoatdong.TabStop = true;
        rbtn_khonghoatdong.Text = "Không hoạt động";
        rbtn_khonghoatdong.UseVisualStyleBackColor = true;
        // 
        // rbtn_hoatdong
        // 
        rbtn_hoatdong.AutoSize = true;
        rbtn_hoatdong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        rbtn_hoatdong.ForeColor = Color.FromArgb(0, 126, 249);
        rbtn_hoatdong.Location = new Point(540, 270);
        rbtn_hoatdong.Name = "rbtn_hoatdong";
        rbtn_hoatdong.Size = new Size(101, 25);
        rbtn_hoatdong.TabIndex = 197;
        rbtn_hoatdong.TabStop = true;
        rbtn_hoatdong.Text = "Hoạt động";
        rbtn_hoatdong.UseVisualStyleBackColor = true;
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label13.ForeColor = Color.FromArgb(0, 126, 249);
        label13.Location = new Point(27, 25);
        label13.Name = "label13";
        label13.Size = new Size(32, 21);
        label13.TabIndex = 196;
        label13.Text = "Mã";
        // 
        // txt_ma
        // 
        txt_ma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        txt_ma.Location = new Point(124, 22);
        txt_ma.Name = "txt_ma";
        txt_ma.Size = new Size(225, 29);
        txt_ma.TabIndex = 195;
        // 
        // cmb_size
        // 
        cmb_size.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        cmb_size.FormattingEnabled = true;
        cmb_size.Location = new Point(124, 342);
        cmb_size.Name = "cmb_size";
        cmb_size.Size = new Size(225, 29);
        cmb_size.TabIndex = 192;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label11.ForeColor = Color.FromArgb(0, 126, 249);
        label11.Location = new Point(27, 342);
        label11.Name = "label11";
        label11.Size = new Size(30, 21);
        label11.TabIndex = 191;
        label11.Text = "Cỡ";
        // 
        // cmb_category
        // 
        cmb_category.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        cmb_category.FormattingEnabled = true;
        cmb_category.Location = new Point(124, 146);
        cmb_category.Name = "cmb_category";
        cmb_category.Size = new Size(225, 29);
        cmb_category.TabIndex = 187;
        // 
        // txt_soluong
        // 
        txt_soluong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        txt_soluong.Location = new Point(535, 22);
        txt_soluong.Name = "txt_soluong";
        txt_soluong.Size = new Size(250, 29);
        txt_soluong.TabIndex = 186;
        // 
        // txt_giaban
        // 
        txt_giaban.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        txt_giaban.Location = new Point(535, 186);
        txt_giaban.Name = "txt_giaban";
        txt_giaban.Size = new Size(250, 29);
        txt_giaban.TabIndex = 184;
        // 
        // txt_gianhap
        // 
        txt_gianhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        txt_gianhap.Location = new Point(535, 102);
        txt_gianhap.Name = "txt_gianhap";
        txt_gianhap.Size = new Size(250, 29);
        txt_gianhap.TabIndex = 183;
        // 
        // cmb_color
        // 
        cmb_color.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        cmb_color.FormattingEnabled = true;
        cmb_color.Location = new Point(124, 269);
        cmb_color.Name = "cmb_color";
        cmb_color.Size = new Size(225, 29);
        cmb_color.TabIndex = 181;
        // 
        // richtxt_mota
        // 
        richtxt_mota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        richtxt_mota.Location = new Point(540, 339);
        richtxt_mota.Name = "richtxt_mota";
        richtxt_mota.Size = new Size(250, 55);
        richtxt_mota.TabIndex = 179;
        richtxt_mota.Text = "";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label9.ForeColor = Color.FromArgb(0, 126, 249);
        label9.Location = new Point(430, 342);
        label9.Name = "label9";
        label9.Size = new Size(53, 21);
        label9.TabIndex = 178;
        label9.Text = "Mô Tả";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label7.ForeColor = Color.FromArgb(0, 126, 249);
        label7.Location = new Point(430, 186);
        label7.Name = "label7";
        label7.Size = new Size(63, 21);
        label7.TabIndex = 176;
        label7.Text = "Giá Bán";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label6.ForeColor = Color.FromArgb(0, 126, 249);
        label6.Location = new Point(430, 102);
        label6.Name = "label6";
        label6.Size = new Size(75, 21);
        label6.TabIndex = 175;
        label6.Text = "Giá Nhập";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label5.ForeColor = Color.FromArgb(0, 126, 249);
        label5.Location = new Point(430, 22);
        label5.Name = "label5";
        label5.Size = new Size(77, 21);
        label5.TabIndex = 174;
        label5.Text = "Số Lượng";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label4.ForeColor = Color.FromArgb(0, 126, 249);
        label4.Location = new Point(27, 269);
        label4.Name = "label4";
        label4.Size = new Size(67, 21);
        label4.TabIndex = 173;
        label4.Text = "Màu sắc";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label1.ForeColor = Color.FromArgb(0, 126, 249);
        label1.Location = new Point(27, 146);
        label1.Name = "label1";
        label1.Size = new Size(120, 21);
        label1.TabIndex = 170;
        label1.Text = "Dòng sản phẩm";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label8.ForeColor = Color.FromArgb(0, 126, 249);
        label8.Location = new Point(27, 84);
        label8.Name = "label8";
        label8.Size = new Size(33, 21);
        label8.TabIndex = 203;
        label8.Text = "Tên";
        // 
        // txt_ten
        // 
        txt_ten.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        txt_ten.Location = new Point(124, 81);
        txt_ten.Name = "txt_ten";
        txt_ten.Size = new Size(225, 29);
        txt_ten.TabIndex = 202;
        // 
        // btn_save
        // 
        btn_save.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        btn_save.Location = new Point(365, 425);
        btn_save.Name = "btn_save";
        btn_save.Size = new Size(150, 50);
        btn_save.TabIndex = 204;
        btn_save.Text = "Thêm";
        btn_save.UseVisualStyleBackColor = true;
        btn_save.Click += btn_save_Click;
        // 
        // btn_huy
        // 
        btn_huy.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        btn_huy.Location = new Point(726, 425);
        btn_huy.Name = "btn_huy";
        btn_huy.Size = new Size(150, 50);
        btn_huy.TabIndex = 205;
        btn_huy.Text = "Hủy";
        btn_huy.UseVisualStyleBackColor = true;
        btn_huy.Click += btn_huy_Click;
        // 
        // cmb_material
        // 
        cmb_material.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        cmb_material.FormattingEnabled = true;
        cmb_material.Location = new Point(124, 207);
        cmb_material.Name = "cmb_material";
        cmb_material.Size = new Size(225, 29);
        cmb_material.TabIndex = 207;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label2.ForeColor = Color.FromArgb(0, 126, 249);
        label2.Location = new Point(27, 207);
        label2.Name = "label2";
        label2.Size = new Size(71, 21);
        label2.TabIndex = 206;
        label2.Text = "Chất liệu";
        // 
        // btn_sua
        // 
        btn_sua.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        btn_sua.Location = new Point(549, 425);
        btn_sua.Name = "btn_sua";
        btn_sua.Size = new Size(150, 50);
        btn_sua.TabIndex = 208;
        btn_sua.Text = "Sửa";
        btn_sua.UseVisualStyleBackColor = true;
        btn_sua.Click += btn_sua_Click;
        // 
        // FrmConfigShoes
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1284, 511);
        Controls.Add(btn_sua);
        Controls.Add(cmb_material);
        Controls.Add(label2);
        Controls.Add(btn_huy);
        Controls.Add(btn_save);
        Controls.Add(label8);
        Controls.Add(txt_ten);
        Controls.Add(lbl_tenAnh);
        Controls.Add(btn_chonAnh);
        Controls.Add(picBox_shoesImage);
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
        Controls.Add(cmb_color);
        Controls.Add(richtxt_mota);
        Controls.Add(label9);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label1);
        Name = "FrmConfigShoes";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmConfigShoes";
        ((System.ComponentModel.ISupportInitialize)picBox_shoesImage).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbl_tenAnh;
    private Button btn_chonAnh;
    private PictureBox picBox_shoesImage;
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
    private ComboBox cmb_color;
    private RichTextBox richtxt_mota;
    private Label label9;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label1;
    private Label label8;
    private TextBox txt_ten;
    private Button btn_save;
    private Button btn_huy;
    private ComboBox cmb_material;
    private Label label2;
    private Button btn_sua;
}