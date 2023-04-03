namespace _3.PL.Views;

partial class FrmShoes
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
        dgrid_shoes = new DataGridView();
        txt_timkiem = new TextBox();
        btn_category = new Button();
        btn_material = new Button();
        btn_size = new Button();
        btn_color = new Button();
        button4 = new Button();
        ((System.ComponentModel.ISupportInitialize)dgrid_shoes).BeginInit();
        SuspendLayout();
        // 
        // dgrid_shoes
        // 
        dgrid_shoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgrid_shoes.Location = new Point(75, 75);
        dgrid_shoes.Name = "dgrid_shoes";
        dgrid_shoes.RowTemplate.Height = 25;
        dgrid_shoes.Size = new Size(1200, 600);
        dgrid_shoes.TabIndex = 0;
        // 
        // txt_timkiem
        // 
        txt_timkiem.Location = new Point(1025, 30);
        txt_timkiem.Name = "txt_timkiem";
        txt_timkiem.Size = new Size(250, 23);
        txt_timkiem.TabIndex = 67;
        txt_timkiem.Text = "Tìm Kiếm";
        // 
        // btn_category
        // 
        btn_category.ForeColor = Color.FromArgb(0, 126, 249);
        btn_category.Location = new Point(75, 707);
        btn_category.Name = "btn_category";
        btn_category.Size = new Size(120, 50);
        btn_category.TabIndex = 81;
        btn_category.Text = "Category";
        btn_category.UseVisualStyleBackColor = true;
        // 
        // btn_material
        // 
        btn_material.ForeColor = Color.FromArgb(0, 126, 249);
        btn_material.Location = new Point(244, 707);
        btn_material.Name = "btn_material";
        btn_material.Size = new Size(120, 50);
        btn_material.TabIndex = 82;
        btn_material.Text = "Material";
        btn_material.UseVisualStyleBackColor = true;
        // 
        // btn_size
        // 
        btn_size.ForeColor = Color.FromArgb(0, 126, 249);
        btn_size.Location = new Point(416, 707);
        btn_size.Name = "btn_size";
        btn_size.Size = new Size(120, 50);
        btn_size.TabIndex = 83;
        btn_size.Text = "Size";
        btn_size.UseVisualStyleBackColor = true;
        // 
        // btn_color
        // 
        btn_color.ForeColor = Color.FromArgb(0, 126, 249);
        btn_color.Location = new Point(585, 707);
        btn_color.Name = "btn_color";
        btn_color.Size = new Size(120, 50);
        btn_color.TabIndex = 84;
        btn_color.Text = "Color";
        btn_color.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.ForeColor = Color.FromArgb(0, 126, 249);
        button4.Location = new Point(1155, 707);
        button4.Name = "button4";
        button4.Size = new Size(120, 50);
        button4.TabIndex = 85;
        button4.Text = "Thêm";
        button4.UseVisualStyleBackColor = true;
        // 
        // FrmShoes
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1350, 800);
        Controls.Add(button4);
        Controls.Add(btn_color);
        Controls.Add(btn_size);
        Controls.Add(btn_material);
        Controls.Add(btn_category);
        Controls.Add(txt_timkiem);
        Controls.Add(dgrid_shoes);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FrmShoes";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmShoes";
        ((System.ComponentModel.ISupportInitialize)dgrid_shoes).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dgrid_shoes;
    private TextBox txt_timkiem;
    private Button btn_category;
    private Button btn_material;
    private Button btn_size;
    private Button btn_color;
    private Button button4;
}