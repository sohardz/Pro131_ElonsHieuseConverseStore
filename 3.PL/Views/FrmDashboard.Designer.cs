namespace _3.PL.Views;

partial class FrmDashboard
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
        components = new System.ComponentModel.Container();
        panel1 = new Panel();
        pnl_nav = new Panel();
        btn_customerService = new Button();
        btn_orderService = new Button();
        btn_dangxuat = new Button();
        btn_staffService = new Button();
        btn_productDetailService = new Button();
        btn_sellingService = new Button();
        panel2 = new Panel();
        label2 = new Label();
        lbl_userName = new Label();
        picBox_userAvatar = new PictureBox();
        lbl_title = new Label();
        lbl_timenow = new Label();
        pnl_formLoader = new Panel();
        timeNow = new System.Windows.Forms.Timer(components);
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picBox_userAvatar).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.GradientActiveCaption;
        panel1.Controls.Add(pnl_nav);
        panel1.Controls.Add(btn_customerService);
        panel1.Controls.Add(btn_orderService);
        panel1.Controls.Add(btn_dangxuat);
        panel1.Controls.Add(btn_staffService);
        panel1.Controls.Add(btn_productDetailService);
        panel1.Controls.Add(btn_sellingService);
        panel1.Controls.Add(panel2);
        panel1.Dock = DockStyle.Left;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(220, 900);
        panel1.TabIndex = 3;
        // 
        // pnl_nav
        // 
        pnl_nav.BackColor = Color.FromArgb(0, 126, 249);
        pnl_nav.Location = new Point(0, 231);
        pnl_nav.Name = "pnl_nav";
        pnl_nav.Size = new Size(3, 100);
        pnl_nav.TabIndex = 7;
        // 
        // btn_customerService
        // 
        btn_customerService.BackColor = SystemColors.ActiveCaption;
        btn_customerService.Dock = DockStyle.Top;
        btn_customerService.FlatAppearance.BorderSize = 0;
        btn_customerService.FlatStyle = FlatStyle.Flat;
        btn_customerService.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        btn_customerService.ForeColor = Color.FromArgb(0, 126, 249);
        btn_customerService.Location = new Point(0, 425);
        btn_customerService.Name = "btn_customerService";
        btn_customerService.Size = new Size(220, 50);
        btn_customerService.TabIndex = 6;
        btn_customerService.Text = "Khách hàng";
        btn_customerService.TextImageRelation = TextImageRelation.TextBeforeImage;
        btn_customerService.UseVisualStyleBackColor = false;
        btn_customerService.Click += btn_customerService_Click;
        btn_customerService.Leave += btn_customerService_Leave;
        // 
        // btn_orderService
        // 
        btn_orderService.BackColor = SystemColors.ActiveCaption;
        btn_orderService.Dock = DockStyle.Top;
        btn_orderService.FlatAppearance.BorderSize = 0;
        btn_orderService.FlatStyle = FlatStyle.Flat;
        btn_orderService.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        btn_orderService.ForeColor = Color.FromArgb(0, 126, 249);
        btn_orderService.Location = new Point(0, 375);
        btn_orderService.Name = "btn_orderService";
        btn_orderService.Size = new Size(220, 50);
        btn_orderService.TabIndex = 5;
        btn_orderService.Text = "Hóa đơn";
        btn_orderService.TextImageRelation = TextImageRelation.TextBeforeImage;
        btn_orderService.UseVisualStyleBackColor = false;
        btn_orderService.Click += btn_orderService_Click;
        btn_orderService.Leave += btn_orderService_Leave;
        // 
        // btn_dangxuat
        // 
        btn_dangxuat.BackColor = SystemColors.ActiveCaption;
        btn_dangxuat.Dock = DockStyle.Bottom;
        btn_dangxuat.FlatAppearance.BorderSize = 0;
        btn_dangxuat.FlatStyle = FlatStyle.Flat;
        btn_dangxuat.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        btn_dangxuat.ForeColor = Color.FromArgb(0, 126, 249);
        btn_dangxuat.Location = new Point(0, 860);
        btn_dangxuat.Name = "btn_dangxuat";
        btn_dangxuat.Size = new Size(220, 40);
        btn_dangxuat.TabIndex = 4;
        btn_dangxuat.Text = "Đăng xuất";
        btn_dangxuat.TextImageRelation = TextImageRelation.TextBeforeImage;
        btn_dangxuat.UseVisualStyleBackColor = false;
        btn_dangxuat.Click += btn_dangxuat_Click;
        // 
        // btn_staffService
        // 
        btn_staffService.BackColor = SystemColors.ActiveCaption;
        btn_staffService.Dock = DockStyle.Top;
        btn_staffService.FlatAppearance.BorderSize = 0;
        btn_staffService.FlatStyle = FlatStyle.Flat;
        btn_staffService.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        btn_staffService.ForeColor = Color.FromArgb(0, 126, 249);
        btn_staffService.Location = new Point(0, 325);
        btn_staffService.Name = "btn_staffService";
        btn_staffService.Size = new Size(220, 50);
        btn_staffService.TabIndex = 3;
        btn_staffService.Text = "Nhân viên";
        btn_staffService.TextImageRelation = TextImageRelation.TextBeforeImage;
        btn_staffService.UseVisualStyleBackColor = false;
        btn_staffService.Click += btn_staffService_Click;
        btn_staffService.Leave += btn_staffService_Leave;
        // 
        // btn_productDetailService
        // 
        btn_productDetailService.BackColor = SystemColors.ActiveCaption;
        btn_productDetailService.Dock = DockStyle.Top;
        btn_productDetailService.FlatAppearance.BorderSize = 0;
        btn_productDetailService.FlatStyle = FlatStyle.Flat;
        btn_productDetailService.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        btn_productDetailService.ForeColor = Color.FromArgb(0, 126, 249);
        btn_productDetailService.Location = new Point(0, 275);
        btn_productDetailService.Name = "btn_productDetailService";
        btn_productDetailService.Size = new Size(220, 50);
        btn_productDetailService.TabIndex = 2;
        btn_productDetailService.Text = "Sản phẩm";
        btn_productDetailService.TextImageRelation = TextImageRelation.TextBeforeImage;
        btn_productDetailService.UseVisualStyleBackColor = false;
        btn_productDetailService.Click += btn_productDetailService_Click;
        btn_productDetailService.Leave += btn_productDetailService_Leave;
        // 
        // btn_sellingService
        // 
        btn_sellingService.BackColor = SystemColors.ActiveCaption;
        btn_sellingService.Dock = DockStyle.Top;
        btn_sellingService.FlatAppearance.BorderSize = 0;
        btn_sellingService.FlatStyle = FlatStyle.Flat;
        btn_sellingService.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        btn_sellingService.ForeColor = Color.FromArgb(0, 126, 249);
        btn_sellingService.Location = new Point(0, 225);
        btn_sellingService.Name = "btn_sellingService";
        btn_sellingService.Size = new Size(220, 50);
        btn_sellingService.TabIndex = 1;
        btn_sellingService.Text = "Bán hàng";
        btn_sellingService.TextImageRelation = TextImageRelation.TextBeforeImage;
        btn_sellingService.UseVisualStyleBackColor = false;
        btn_sellingService.Click += btn_sellingService_Click;
        btn_sellingService.Leave += btn_sellingService_Leave;
        // 
        // panel2
        // 
        panel2.BackColor = SystemColors.GradientActiveCaption;
        panel2.Controls.Add(label2);
        panel2.Controls.Add(lbl_userName);
        panel2.Controls.Add(picBox_userAvatar);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(220, 225);
        panel2.TabIndex = 0;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
        label2.ForeColor = Color.FromArgb(158, 161, 176);
        label2.Location = new Point(53, 172);
        label2.Name = "label2";
        label2.Size = new Size(84, 13);
        label2.TabIndex = 2;
        label2.Text = "Some user text";
        // 
        // lbl_userName
        // 
        lbl_userName.AutoSize = true;
        lbl_userName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lbl_userName.ForeColor = Color.FromArgb(0, 126, 249);
        lbl_userName.Location = new Point(53, 129);
        lbl_userName.Name = "lbl_userName";
        lbl_userName.Size = new Size(94, 21);
        lbl_userName.TabIndex = 1;
        lbl_userName.Text = "User Name";
        // 
        // picBox_userAvatar
        // 
        picBox_userAvatar.Location = new Point(53, 26);
        picBox_userAvatar.Name = "picBox_userAvatar";
        picBox_userAvatar.Size = new Size(100, 90);
        picBox_userAvatar.SizeMode = PictureBoxSizeMode.Zoom;
        picBox_userAvatar.TabIndex = 0;
        picBox_userAvatar.TabStop = false;
        // 
        // lbl_title
        // 
        lbl_title.AutoSize = true;
        lbl_title.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
        lbl_title.ForeColor = Color.FromArgb(0, 126, 249);
        lbl_title.Location = new Point(238, 9);
        lbl_title.Name = "lbl_title";
        lbl_title.Size = new Size(136, 37);
        lbl_title.TabIndex = 10;
        lbl_title.Text = "Bán hàng";
        // 
        // lbl_timenow
        // 
        lbl_timenow.AutoSize = true;
        lbl_timenow.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
        lbl_timenow.ForeColor = Color.FromArgb(0, 126, 249);
        lbl_timenow.Location = new Point(1306, 8);
        lbl_timenow.Name = "lbl_timenow";
        lbl_timenow.Size = new Size(59, 25);
        lbl_timenow.TabIndex = 11;
        lbl_timenow.Text = "label3";
        // 
        // pnl_formLoader
        // 
        pnl_formLoader.Location = new Point(238, 88);
        pnl_formLoader.Name = "pnl_formLoader";
        pnl_formLoader.Size = new Size(1350, 800);
        pnl_formLoader.TabIndex = 12;
        // 
        // timeNow
        // 
        timeNow.Tick += timeNow_Tick;
        // 
        // FrmDashboard
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientActiveCaption;
        ClientSize = new Size(1600, 900);
        Controls.Add(pnl_formLoader);
        Controls.Add(lbl_timenow);
        Controls.Add(lbl_title);
        Controls.Add(panel1);
        ForeColor = SystemColors.ControlText;
        FormBorderStyle = FormBorderStyle.None;
        Name = "FrmDashboard";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmDashboard";
        Load += FrmDashboard_Load;
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picBox_userAvatar).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Panel pnl_nav;
    private Button btn_customerService;
    private Button btn_orderService;
    private Button btn_dangxuat;
    private Button btn_staffService;
    private Button btn_productDetailService;
    private Button btn_sellingService;
    private Panel panel2;
    private Label label2;
    private Label lbl_userName;
    private PictureBox picBox_userAvatar;
    private Label lbl_title;
    private Label lbl_timenow;
    private Panel pnl_formLoader;
    private System.Windows.Forms.Timer timeNow;
}