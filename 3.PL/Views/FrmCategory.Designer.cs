﻿namespace _3.PL.Views;

partial class FrmCategory
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
        rbtn_khonghoatdong = new RadioButton();
        rbtn_hoatdong = new RadioButton();
        label2 = new Label();
        label3 = new Label();
        btn_clear = new Button();
        btn_sua = new Button();
        btn_them = new Button();
        txt_timkiem = new TextBox();
        txt_ten = new TextBox();
        txt_ma = new TextBox();
        label1 = new Label();
        dgrid_category = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgrid_category).BeginInit();
        SuspendLayout();
        // 
        // rbtn_khonghoatdong
        // 
        rbtn_khonghoatdong.AutoSize = true;
        rbtn_khonghoatdong.ForeColor = Color.FromArgb(0, 126, 249);
        rbtn_khonghoatdong.Location = new Point(1088, 296);
        rbtn_khonghoatdong.Name = "rbtn_khonghoatdong";
        rbtn_khonghoatdong.Size = new Size(118, 19);
        rbtn_khonghoatdong.TabIndex = 74;
        rbtn_khonghoatdong.TabStop = true;
        rbtn_khonghoatdong.Text = "Không hoạt động";
        rbtn_khonghoatdong.UseVisualStyleBackColor = true;
        // 
        // rbtn_hoatdong
        // 
        rbtn_hoatdong.AutoSize = true;
        rbtn_hoatdong.ForeColor = Color.FromArgb(0, 126, 249);
        rbtn_hoatdong.Location = new Point(988, 296);
        rbtn_hoatdong.Name = "rbtn_hoatdong";
        rbtn_hoatdong.Size = new Size(82, 19);
        rbtn_hoatdong.TabIndex = 73;
        rbtn_hoatdong.TabStop = true;
        rbtn_hoatdong.Text = "Hoạt động";
        rbtn_hoatdong.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.ForeColor = Color.FromArgb(0, 126, 249);
        label2.Location = new Point(903, 296);
        label2.Name = "label2";
        label2.Size = new Size(61, 15);
        label2.TabIndex = 72;
        label2.Text = "Trạng Thái";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.ForeColor = Color.FromArgb(0, 126, 249);
        label3.Location = new Point(903, 256);
        label3.Name = "label3";
        label3.Size = new Size(25, 15);
        label3.TabIndex = 71;
        label3.Text = "Tên";
        // 
        // btn_clear
        // 
        btn_clear.Location = new Point(1133, 382);
        btn_clear.Name = "btn_clear";
        btn_clear.Size = new Size(120, 50);
        btn_clear.TabIndex = 70;
        btn_clear.Text = "Clear";
        btn_clear.UseVisualStyleBackColor = true;
        // 
        // btn_sua
        // 
        btn_sua.Location = new Point(998, 382);
        btn_sua.Name = "btn_sua";
        btn_sua.Size = new Size(120, 50);
        btn_sua.TabIndex = 68;
        btn_sua.Text = "Sửa";
        btn_sua.UseVisualStyleBackColor = true;
        // 
        // btn_them
        // 
        btn_them.Location = new Point(863, 382);
        btn_them.Name = "btn_them";
        btn_them.Size = new Size(120, 50);
        btn_them.TabIndex = 67;
        btn_them.Text = "Thêm";
        btn_them.UseVisualStyleBackColor = true;
        // 
        // txt_timkiem
        // 
        txt_timkiem.Location = new Point(988, 176);
        txt_timkiem.Name = "txt_timkiem";
        txt_timkiem.Size = new Size(250, 23);
        txt_timkiem.TabIndex = 66;
        txt_timkiem.Text = "Tìm Kiếm";
        // 
        // txt_ten
        // 
        txt_ten.Location = new Point(988, 256);
        txt_ten.Name = "txt_ten";
        txt_ten.Size = new Size(250, 23);
        txt_ten.TabIndex = 65;
        // 
        // txt_ma
        // 
        txt_ma.Location = new Point(988, 216);
        txt_ma.Name = "txt_ma";
        txt_ma.Size = new Size(250, 23);
        txt_ma.TabIndex = 64;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.ForeColor = Color.FromArgb(0, 126, 249);
        label1.Location = new Point(903, 216);
        label1.Name = "label1";
        label1.Size = new Size(24, 15);
        label1.TabIndex = 63;
        label1.Text = "Mã";
        // 
        // dgrid_category
        // 
        dgrid_category.BackgroundColor = Color.White;
        dgrid_category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgrid_category.Location = new Point(26, 43);
        dgrid_category.Name = "dgrid_category";
        dgrid_category.RowTemplate.Height = 25;
        dgrid_category.Size = new Size(800, 550);
        dgrid_category.TabIndex = 62;
        // 
        // FrmCategory
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1284, 661);
        Controls.Add(rbtn_khonghoatdong);
        Controls.Add(rbtn_hoatdong);
        Controls.Add(label2);
        Controls.Add(label3);
        Controls.Add(btn_clear);
        Controls.Add(btn_sua);
        Controls.Add(btn_them);
        Controls.Add(txt_timkiem);
        Controls.Add(txt_ten);
        Controls.Add(txt_ma);
        Controls.Add(label1);
        Controls.Add(dgrid_category);
        Name = "FrmCategory";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmCategory";
        ((System.ComponentModel.ISupportInitialize)dgrid_category).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private RadioButton rbtn_khonghoatdong;
    private RadioButton rbtn_hoatdong;
    private Label label2;
    private Label label3;
    private Button btn_clear;
    private Button btn_sua;
    private Button btn_them;
    private TextBox txt_timkiem;
    private TextBox txt_ten;
    private TextBox txt_ma;
    private Label label1;
    private DataGridView dgrid_category;
}