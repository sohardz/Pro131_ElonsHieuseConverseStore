﻿namespace _3.PL.Views;

partial class FrmMaterial
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
        dgrid_material = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgrid_material).BeginInit();
        SuspendLayout();
        // 
        // rbtn_khonghoatdong
        // 
        rbtn_khonghoatdong.AutoSize = true;
        rbtn_khonghoatdong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        rbtn_khonghoatdong.ForeColor = Color.FromArgb(0, 126, 249);
        rbtn_khonghoatdong.Location = new Point(1091, 308);
        rbtn_khonghoatdong.Name = "rbtn_khonghoatdong";
        rbtn_khonghoatdong.Size = new Size(148, 25);
        rbtn_khonghoatdong.TabIndex = 86;
        rbtn_khonghoatdong.TabStop = true;
        rbtn_khonghoatdong.Text = "Không hoạt động";
        rbtn_khonghoatdong.UseVisualStyleBackColor = true;
        // 
        // rbtn_hoatdong
        // 
        rbtn_hoatdong.AutoSize = true;
        rbtn_hoatdong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        rbtn_hoatdong.ForeColor = Color.FromArgb(0, 126, 249);
        rbtn_hoatdong.Location = new Point(991, 308);
        rbtn_hoatdong.Name = "rbtn_hoatdong";
        rbtn_hoatdong.Size = new Size(101, 25);
        rbtn_hoatdong.TabIndex = 85;
        rbtn_hoatdong.TabStop = true;
        rbtn_hoatdong.Text = "Hoạt động";
        rbtn_hoatdong.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label2.ForeColor = Color.FromArgb(0, 126, 249);
        label2.Location = new Point(906, 308);
        label2.Name = "label2";
        label2.Size = new Size(82, 21);
        label2.TabIndex = 84;
        label2.Text = "Trạng Thái";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label3.ForeColor = Color.FromArgb(0, 126, 249);
        label3.Location = new Point(906, 268);
        label3.Name = "label3";
        label3.Size = new Size(33, 21);
        label3.TabIndex = 83;
        label3.Text = "Tên";
        // 
        // btn_clear
        // 
        btn_clear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        btn_clear.ForeColor = Color.FromArgb(0, 126, 249);
        btn_clear.Location = new Point(1136, 394);
        btn_clear.Name = "btn_clear";
        btn_clear.Size = new Size(120, 50);
        btn_clear.TabIndex = 82;
        btn_clear.Text = "Clear";
        btn_clear.UseVisualStyleBackColor = true;
        btn_clear.Click += btn_clear_Click;
        // 
        // btn_sua
        // 
        btn_sua.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        btn_sua.ForeColor = Color.FromArgb(0, 126, 249);
        btn_sua.Location = new Point(1001, 394);
        btn_sua.Name = "btn_sua";
        btn_sua.Size = new Size(120, 50);
        btn_sua.TabIndex = 81;
        btn_sua.Text = "Sửa";
        btn_sua.UseVisualStyleBackColor = true;
        btn_sua.Click += btn_sua_Click;
        // 
        // btn_them
        // 
        btn_them.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        btn_them.ForeColor = Color.FromArgb(0, 126, 249);
        btn_them.Location = new Point(866, 394);
        btn_them.Name = "btn_them";
        btn_them.Size = new Size(120, 50);
        btn_them.TabIndex = 80;
        btn_them.Text = "Thêm";
        btn_them.UseVisualStyleBackColor = true;
        btn_them.Click += btn_them_Click;
        // 
        // txt_timkiem
        // 
        txt_timkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        txt_timkiem.Location = new Point(991, 188);
        txt_timkiem.Name = "txt_timkiem";
        txt_timkiem.Size = new Size(250, 29);
        txt_timkiem.TabIndex = 79;
        txt_timkiem.Text = "Tìm Kiếm";
        // 
        // txt_ten
        // 
        txt_ten.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        txt_ten.Location = new Point(991, 268);
        txt_ten.Name = "txt_ten";
        txt_ten.Size = new Size(250, 29);
        txt_ten.TabIndex = 78;
        // 
        // txt_ma
        // 
        txt_ma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        txt_ma.Location = new Point(991, 228);
        txt_ma.Name = "txt_ma";
        txt_ma.Size = new Size(250, 29);
        txt_ma.TabIndex = 77;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label1.ForeColor = Color.FromArgb(0, 126, 249);
        label1.Location = new Point(906, 228);
        label1.Name = "label1";
        label1.Size = new Size(32, 21);
        label1.TabIndex = 76;
        label1.Text = "Mã";
        // 
        // dgrid_material
        // 
        dgrid_material.BackgroundColor = Color.White;
        dgrid_material.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgrid_material.Location = new Point(29, 55);
        dgrid_material.Name = "dgrid_material";
        dgrid_material.RowTemplate.Height = 25;
        dgrid_material.Size = new Size(800, 550);
        dgrid_material.TabIndex = 75;
        dgrid_material.CellClick += dgrid_material_CellClick;
        // 
        // FrmMaterial
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
        Controls.Add(dgrid_material);
        Name = "FrmMaterial";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmMaterial";
        ((System.ComponentModel.ISupportInitialize)dgrid_material).EndInit();
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
    private DataGridView dgrid_material;
}