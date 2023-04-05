namespace _3.PL.Views.DangNhap
{
    partial class FrmQuenMatKhau
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
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            btn_back = new Guna.UI2.WinForms.Guna2Button();
            btn_confirm = new Guna.UI2.WinForms.Guna2Button();
            txtEmail = new TextBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2Panel1.SuspendLayout();
            guna2Panel3.SuspendLayout();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = guna2Panel1;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(20, 30, 54);
            guna2Panel1.Controls.Add(guna2Panel3);
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(3, 2, 3, 2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(886, 505);
            guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            guna2Panel3.BackColor = Color.White;
            guna2Panel3.BorderRadius = 5;
            guna2Panel3.Controls.Add(btn_back);
            guna2Panel3.Controls.Add(btn_confirm);
            guna2Panel3.Controls.Add(txtEmail);
            guna2Panel3.Controls.Add(guna2HtmlLabel2);
            guna2Panel3.Controls.Add(guna2HtmlLabel1);
            guna2Panel3.Location = new Point(456, 87);
            guna2Panel3.Margin = new Padding(3, 2, 3, 2);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Size = new Size(327, 315);
            guna2Panel3.TabIndex = 0;
            // 
            // btn_back
            // 
            btn_back.Animated = true;
            btn_back.BackColor = Color.Transparent;
            btn_back.BorderColor = Color.FromArgb(94, 148, 255);
            btn_back.BorderRadius = 10;
            btn_back.BorderThickness = 2;
            btn_back.DisabledState.BorderColor = Color.DarkGray;
            btn_back.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_back.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_back.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_back.FillColor = Color.FromArgb(20, 30, 54);
            btn_back.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(178, 229);
            btn_back.Margin = new Padding(3, 2, 3, 2);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(81, 29);
            btn_back.TabIndex = 7;
            btn_back.Text = "Quay lại";
            btn_back.UseTransparentBackground = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_confirm
            // 
            btn_confirm.Animated = true;
            btn_confirm.BackColor = Color.Transparent;
            btn_confirm.BorderRadius = 10;
            btn_confirm.DisabledState.BorderColor = Color.DarkGray;
            btn_confirm.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_confirm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_confirm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_confirm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_confirm.ForeColor = Color.White;
            btn_confirm.Location = new Point(67, 229);
            btn_confirm.Margin = new Padding(3, 2, 3, 2);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(81, 29);
            btn_confirm.TabIndex = 6;
            btn_confirm.Text = "Xác nhận";
            btn_confirm.UseTransparentBackground = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(67, 158);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(193, 23);
            txtEmail.TabIndex = 2;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel2.Location = new Point(114, 88);
            guna2HtmlLabel2.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(92, 23);
            guna2HtmlLabel2.TabIndex = 1;
            guna2HtmlLabel2.Text = "Nhập email";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(87, 52);
            guna2HtmlLabel1.Margin = new Padding(3, 2, 3, 2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(145, 32);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Nhớ mật khẩu";
            // 
            // guna2ShadowForm1
            // 
            guna2ShadowForm1.BorderRadius = 6;
            guna2ShadowForm1.ShadowColor = Color.Gainsboro;
            guna2ShadowForm1.TargetForm = this;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.FromArgb(20, 30, 54);
            guna2Panel2.Controls.Add(guna2PictureBox1);
            guna2Panel2.Dock = DockStyle.Left;
            guna2Panel2.Location = new Point(0, 0);
            guna2Panel2.Margin = new Padding(3, 2, 3, 2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.Size = new Size(409, 505);
            guna2Panel2.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.Image = Properties.Resources.bfe792439c6f42edf0e1daa1bf9b6407;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(0, 0);
            guna2PictureBox1.Margin = new Padding(3, 2, 3, 2);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.Size = new Size(409, 502);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            // 
            // FrmQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 505);
            Controls.Add(guna2Panel2);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmQuenMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmQuenMatKhau";
            guna2Panel1.ResumeLayout(false);
            guna2Panel3.ResumeLayout(false);
            guna2Panel3.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private Guna.UI2.WinForms.Guna2Button btn_confirm;
    }
}