﻿namespace _3.PL.Views;

partial class FrmCustomer
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
        label1 = new Label();
        txt_timkiem = new TextBox();
        dgrid_customer = new DataGridView();
        btn_clear = new Button();
        btn_sua = new Button();
        btn_them = new Button();
        txt_diachi = new TextBox();
        txt_sdt = new TextBox();
        txt_ten = new TextBox();
        txt_tendem = new TextBox();
        txt_ho = new TextBox();
        txt_ma = new TextBox();
        label7 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        ((System.ComponentModel.ISupportInitialize)dgrid_customer).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(350, 48);
        label1.Name = "label1";
        label1.Size = new Size(43, 15);
        label1.TabIndex = 174;
        label1.Text = "Địa chỉ";
        // 
        // txt_timkiem
        // 
        txt_timkiem.Location = new Point(350, 168);
        txt_timkiem.Name = "txt_timkiem";
        txt_timkiem.Size = new Size(332, 23);
        txt_timkiem.TabIndex = 173;
        txt_timkiem.Text = "Tìm Kiếm ...";
        // 
        // dgrid_customer
        // 
        dgrid_customer.BackgroundColor = Color.FromArgb(20, 30, 54);
        dgrid_customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgrid_customer.Dock = DockStyle.Bottom;
        dgrid_customer.Location = new Point(0, 317);
        dgrid_customer.Name = "dgrid_customer";
        dgrid_customer.RowTemplate.Height = 25;
        dgrid_customer.Size = new Size(1350, 483);
        dgrid_customer.TabIndex = 172;
        // 
        // btn_clear
        // 
        btn_clear.Location = new Point(750, 158);
        btn_clear.Name = "btn_clear";
        btn_clear.Size = new Size(125, 45);
        btn_clear.TabIndex = 171;
        btn_clear.Text = "Clear";
        btn_clear.UseVisualStyleBackColor = true;
        // 
        // btn_sua
        // 
        btn_sua.Location = new Point(750, 83);
        btn_sua.Name = "btn_sua";
        btn_sua.Size = new Size(125, 45);
        btn_sua.TabIndex = 170;
        btn_sua.Text = "Sửa";
        btn_sua.UseVisualStyleBackColor = true;
        // 
        // btn_them
        // 
        btn_them.Location = new Point(750, 8);
        btn_them.Name = "btn_them";
        btn_them.Size = new Size(125, 45);
        btn_them.TabIndex = 169;
        btn_them.Text = "Thêm";
        btn_them.UseVisualStyleBackColor = true;
        // 
        // txt_diachi
        // 
        txt_diachi.Location = new Point(450, 48);
        txt_diachi.Name = "txt_diachi";
        txt_diachi.Size = new Size(220, 23);
        txt_diachi.TabIndex = 167;
        // 
        // txt_sdt
        // 
        txt_sdt.Location = new Point(450, 8);
        txt_sdt.Name = "txt_sdt";
        txt_sdt.Size = new Size(220, 23);
        txt_sdt.TabIndex = 166;
        // 
        // txt_ten
        // 
        txt_ten.Location = new Point(85, 128);
        txt_ten.Name = "txt_ten";
        txt_ten.Size = new Size(220, 23);
        txt_ten.TabIndex = 165;
        // 
        // txt_tendem
        // 
        txt_tendem.Location = new Point(85, 88);
        txt_tendem.Name = "txt_tendem";
        txt_tendem.Size = new Size(220, 23);
        txt_tendem.TabIndex = 164;
        // 
        // txt_ho
        // 
        txt_ho.Location = new Point(85, 48);
        txt_ho.Name = "txt_ho";
        txt_ho.Size = new Size(220, 23);
        txt_ho.TabIndex = 163;
        // 
        // txt_ma
        // 
        txt_ma.Location = new Point(85, 8);
        txt_ma.Name = "txt_ma";
        txt_ma.Size = new Size(220, 23);
        txt_ma.TabIndex = 162;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(350, 8);
        label7.Name = "label7";
        label7.Size = new Size(76, 15);
        label7.TabIndex = 160;
        label7.Text = "Số điện thoại";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(15, 128);
        label5.Name = "label5";
        label5.Size = new Size(25, 15);
        label5.TabIndex = 159;
        label5.Text = "Tên";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(15, 88);
        label4.Name = "label4";
        label4.Size = new Size(53, 15);
        label4.TabIndex = 158;
        label4.Text = "Tên Đệm";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(15, 48);
        label3.Name = "label3";
        label3.Size = new Size(23, 15);
        label3.TabIndex = 157;
        label3.Text = "Họ";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(15, 8);
        label2.Name = "label2";
        label2.Size = new Size(24, 15);
        label2.TabIndex = 156;
        label2.Text = "Mã";
        // 
        // FrmCustomer
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1350, 800);
        Controls.Add(label1);
        Controls.Add(txt_timkiem);
        Controls.Add(dgrid_customer);
        Controls.Add(btn_clear);
        Controls.Add(btn_sua);
        Controls.Add(btn_them);
        Controls.Add(txt_diachi);
        Controls.Add(txt_sdt);
        Controls.Add(txt_ten);
        Controls.Add(txt_tendem);
        Controls.Add(txt_ho);
        Controls.Add(txt_ma);
        Controls.Add(label7);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FrmCustomer";
        Text = "FrmCustomer";
        ((System.ComponentModel.ISupportInitialize)dgrid_customer).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label label1;
    private TextBox txt_timkiem;
    private DataGridView dgrid_customer;
    private Button btn_clear;
    private Button btn_sua;
    private Button btn_them;
    private TextBox txt_diachi;
    private TextBox txt_sdt;
    private TextBox txt_ten;
    private TextBox txt_tendem;
    private TextBox txt_ho;
    private TextBox txt_ma;
    private Label label7;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
}