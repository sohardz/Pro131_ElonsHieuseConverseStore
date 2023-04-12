namespace _3.PL.Views.DangNhap
{
    partial class FrmDangNhap
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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            linkLabel1 = new LinkLabel();
            cb_SaveAccount = new Guna.UI2.WinForms.Guna2CheckBox();
            btn_login = new Guna.UI2.WinForms.Guna2Button();
            txt_password = new TextBox();
            txt_email = new TextBox();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(20, 30, 54);
            guna2Panel1.Controls.Add(linkLabel1);
            guna2Panel1.Controls.Add(cb_SaveAccount);
            guna2Panel1.Controls.Add(btn_login);
            guna2Panel1.Controls.Add(txt_password);
            guna2Panel1.Controls.Add(txt_email);
            guna2Panel1.Controls.Add(guna2PictureBox1);
            guna2Panel1.Dock = DockStyle.Left;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(3, 2, 3, 2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(290, 505);
            guna2Panel1.TabIndex = 7;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(40, 324);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(150, 25);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // cb_SaveAccount
            // 
            cb_SaveAccount.AutoSize = true;
            cb_SaveAccount.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cb_SaveAccount.CheckedState.BorderRadius = 0;
            cb_SaveAccount.CheckedState.BorderThickness = 0;
            cb_SaveAccount.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cb_SaveAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_SaveAccount.ForeColor = Color.White;
            cb_SaveAccount.Location = new Point(40, 285);
            cb_SaveAccount.Margin = new Padding(3, 2, 3, 2);
            cb_SaveAccount.Name = "cb_SaveAccount";
            cb_SaveAccount.Size = new Size(129, 25);
            cb_SaveAccount.TabIndex = 8;
            cb_SaveAccount.Text = "Nhớ mật khẩu";
            cb_SaveAccount.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cb_SaveAccount.UncheckedState.BorderRadius = 0;
            cb_SaveAccount.UncheckedState.BorderThickness = 0;
            cb_SaveAccount.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            cb_SaveAccount.CheckedChanged += cb_SaveAccount_CheckedChanged;
            // 
            // btn_login
            // 
            btn_login.Animated = true;
            btn_login.BackColor = Color.Transparent;
            btn_login.BorderRadius = 10;
            btn_login.DisabledState.BorderColor = Color.DarkGray;
            btn_login.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(70, 372);
            btn_login.Margin = new Padding(3, 2, 3, 2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(120, 40);
            btn_login.TabIndex = 4;
            btn_login.Text = "Đăng nhập";
            btn_login.UseTransparentBackground = true;
            btn_login.Click += btn_login_Click;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(23, 238);
            txt_password.Margin = new Padding(3, 2, 3, 2);
            txt_password.Name = "txt_password";
            txt_password.PlaceholderText = "Mật khẩu";
            txt_password.Size = new Size(246, 33);
            txt_password.TabIndex = 3;
            txt_password.UseSystemPasswordChar = true;
            // 
            // txt_email
            // 
            txt_email.BackColor = SystemColors.Window;
            txt_email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(23, 187);
            txt_email.Margin = new Padding(3, 2, 3, 2);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "Email";
            txt_email.Size = new Size(246, 33);
            txt_email.TabIndex = 2;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.FromArgb(20, 30, 54);
            guna2PictureBox1.FillColor = Color.Transparent;
            guna2PictureBox1.Image = Properties.Resources.H;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(64, 32);
            guna2PictureBox1.Margin = new Padding(3, 2, 3, 2);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.Size = new Size(152, 101);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 1;
            guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(guna2ControlBox2);
            guna2Panel2.Controls.Add(guna2ControlBox1);
            guna2Panel2.Controls.Add(guna2PictureBox2);
            guna2Panel2.Dock = DockStyle.Fill;
            guna2Panel2.Location = new Point(290, 0);
            guna2Panel2.Margin = new Padding(3, 2, 3, 2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.Size = new Size(741, 505);
            guna2Panel2.TabIndex = 8;
            // 
            // guna2ControlBox2
            // 
            guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBox2.FillColor = Color.FromArgb(20, 30, 54);
            guna2ControlBox2.HoverState.FillColor = Color.Navy;
            guna2ControlBox2.IconColor = Color.White;
            guna2ControlBox2.Location = new Point(658, 9);
            guna2ControlBox2.Margin = new Padding(3, 2, 3, 2);
            guna2ControlBox2.Name = "guna2ControlBox2";
            guna2ControlBox2.Size = new Size(33, 27);
            guna2ControlBox2.TabIndex = 7;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.FillColor = Color.FromArgb(20, 30, 54);
            guna2ControlBox1.HoverState.FillColor = Color.Navy;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(697, 9);
            guna2ControlBox1.Margin = new Padding(3, 2, 3, 2);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.Size = new Size(33, 27);
            guna2ControlBox1.TabIndex = 6;
            // 
            // guna2PictureBox2
            // 
            guna2PictureBox2.Image = Properties.Resources.Side_Step_WebBanners_Converse;
            guna2PictureBox2.ImageRotate = 0F;
            guna2PictureBox2.Location = new Point(6, 0);
            guna2PictureBox2.Margin = new Padding(3, 2, 3, 2);
            guna2PictureBox2.Name = "guna2PictureBox2";
            guna2PictureBox2.Size = new Size(729, 503);
            guna2PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox2.TabIndex = 0;
            guna2PictureBox2.TabStop = false;
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
            // guna2ShadowForm1
            // 
            guna2ShadowForm1.BorderRadius = 6;
            guna2ShadowForm1.ShadowColor = Color.Gainsboro;
            guna2ShadowForm1.TargetForm = this;
            // 
            // FrmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 505);
            Controls.Add(guna2Panel2);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDangNhap";
            Load += FrmDangNhap_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private TextBox txt_password;
        private TextBox txt_email;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2CheckBox cb_SaveAccount;
    }
}