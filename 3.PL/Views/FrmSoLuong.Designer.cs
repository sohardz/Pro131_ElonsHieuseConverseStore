namespace _3.PL.Views;

partial class FrmSoLuong
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
        btn_them = new Button();
        txt_soluong = new TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(78, 9);
        label1.Name = "label1";
        label1.Size = new Size(142, 21);
        label1.TabIndex = 5;
        label1.Text = "Mời nhập số lượng";
        // 
        // btn_them
        // 
        btn_them.Location = new Point(184, 51);
        btn_them.Name = "btn_them";
        btn_them.Size = new Size(75, 23);
        btn_them.TabIndex = 4;
        btn_them.Text = "Thêm";
        btn_them.UseVisualStyleBackColor = true;
        btn_them.Click += btn_them_Click;
        // 
        // txt_soluong
        // 
        txt_soluong.Location = new Point(26, 51);
        txt_soluong.Name = "txt_soluong";
        txt_soluong.Size = new Size(108, 23);
        txt_soluong.TabIndex = 3;
        // 
        // FrmSoLuong
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(300, 100);
        Controls.Add(label1);
        Controls.Add(btn_them);
        Controls.Add(txt_soluong);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FrmSoLuong";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmSoLuong";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Button btn_them;
    private TextBox txt_soluong;
}