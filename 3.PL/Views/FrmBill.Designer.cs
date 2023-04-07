namespace _3.PL.Views;

partial class FrmBill
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
        dgrid_bill = new DataGridView();
        dgrid_billdetail = new DataGridView();
        textBox1 = new TextBox();
        ((System.ComponentModel.ISupportInitialize)dgrid_bill).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgrid_billdetail).BeginInit();
        SuspendLayout();
        // 
        // dgrid_bill
        // 
        dgrid_bill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgrid_bill.Location = new Point(52, 67);
        dgrid_bill.Name = "dgrid_bill";
        dgrid_bill.RowTemplate.Height = 25;
        dgrid_bill.Size = new Size(1237, 250);
        dgrid_bill.TabIndex = 0;
        // 
        // dgrid_billdetail
        // 
        dgrid_billdetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgrid_billdetail.Location = new Point(52, 350);
        dgrid_billdetail.Name = "dgrid_billdetail";
        dgrid_billdetail.RowTemplate.Height = 25;
        dgrid_billdetail.Size = new Size(1237, 390);
        dgrid_billdetail.TabIndex = 1;
        // 
        // textBox1
        // 
        textBox1.ForeColor = Color.Black;
        textBox1.Location = new Point(988, 12);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(253, 23);
        textBox1.TabIndex = 2;
        textBox1.Text = "Tìm kiếm";
        // 
        // FrmBill
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1350, 800);
        Controls.Add(textBox1);
        Controls.Add(dgrid_billdetail);
        Controls.Add(dgrid_bill);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FrmBill";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmBill";
        ((System.ComponentModel.ISupportInitialize)dgrid_bill).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgrid_billdetail).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dgrid_bill;
    private DataGridView dgrid_billdetail;
    private TextBox textBox1;
}