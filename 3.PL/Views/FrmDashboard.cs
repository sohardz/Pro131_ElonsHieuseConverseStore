using _2.BUS.ViewModels;
using _3.PL.Views.DangNhap;
using System.Runtime.InteropServices;

namespace _3.PL.Views;

public partial class FrmDashboard : Form
{
    private string img = @"C:\Users\adm\Desktop\Pro131_ElonsHieuseConverseStore\3.PL\Image\noimage.png";

    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );

    public FrmDashboard(StaffView staff)
    {
        InitializeComponent();
        Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        pnl_nav.Height = btn_sellingService.Height;
        pnl_nav.Top = btn_sellingService.Top;
        pnl_nav.Left = btn_sellingService.Left;
        //btn_sellingService.BackColor = Color.FromArgb(46, 51, 73);

        if(staff != null )
        {
            picBox_userAvatar.Image = new Bitmap(staff.ImageDirection);
            lbl_userName.Text = staff.LastName + staff.MiddleName + staff.FirstName;
        }
        else
        {
            picBox_userAvatar.Image = new Bitmap(img);
            lbl_userName.Text = "Admin";
        }
    }

    private void FrmDashboard_Load(object sender, EventArgs e)
    {
        timeNow.Start();
        lbl_timenow.Text = DateTime.Now.ToString();
        btn_sellingService_Click(sender, e);
    }

    private void timeNow_Tick(object sender, EventArgs e)
    {
        lbl_timenow.Text = DateTime.Now.ToString();
        timeNow.Start();
    }

    private void btn_sellingService_Click(object sender, EventArgs e)
    {
        pnl_nav.Height = btn_sellingService.Height;
        pnl_nav.Top = btn_sellingService.Top;
        pnl_nav.Left = btn_sellingService.Left;
        btn_sellingService.BackColor = SystemColors.GradientInactiveCaption;

        lbl_title.Text = "Bán hàng";
        pnl_formLoader.Controls.Clear();
        FrmSelling frmBanhang = new()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
        };
        pnl_formLoader.Controls.Add(frmBanhang);
        frmBanhang.Show();
    }

    private void btn_productDetailService_Click(object sender, EventArgs e)
    {
        pnl_nav.Height = btn_productDetailService.Height;
        pnl_nav.Top = btn_productDetailService.Top;
        btn_productDetailService.BackColor = SystemColors.GradientInactiveCaption;

        lbl_title.Text = "Sản phẩm";
        pnl_formLoader.Controls.Clear();
        FrmShoes frmShoes = new()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
        };
        pnl_formLoader.Controls.Add(frmShoes);
        frmShoes.Show();
    }

    private void btn_staffService_Click(object sender, EventArgs e)
    {
        pnl_nav.Height = btn_staffService.Height;
        pnl_nav.Top = btn_staffService.Top;
        btn_staffService.BackColor = SystemColors.GradientInactiveCaption;

        lbl_title.Text = "Nhân viên";
        pnl_formLoader.Controls.Clear();
        FrmStaff frmNhanVien = new()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
        };
        pnl_formLoader.Controls.Add(frmNhanVien);
        frmNhanVien.Show();
    }

    private void btn_orderService_Click(object sender, EventArgs e)
    {
        pnl_nav.Height = btn_orderService.Height;
        pnl_nav.Top = btn_orderService.Top;
        btn_orderService.BackColor = SystemColors.GradientInactiveCaption;

        lbl_title.Text = "Hóa Đơn";
        pnl_formLoader.Controls.Clear();
        FrmBill frmHoaDon = new()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
        };
        pnl_formLoader.Controls.Add(frmHoaDon);
        frmHoaDon.Show();
    }

    private void btn_customerService_Click(object sender, EventArgs e)
    {
        pnl_nav.Height = btn_customerService.Height;
        pnl_nav.Top = btn_customerService.Top;
        btn_customerService.BackColor = SystemColors.GradientInactiveCaption;

        lbl_title.Text = "Khách hàng";
        pnl_formLoader.Controls.Clear();
        FrmCustomer frmKhachHang = new()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
        };
        pnl_formLoader.Controls.Add(frmKhachHang);
        frmKhachHang.Show();
    }

    private void btn_dangxuat_Click(object sender, EventArgs e)
    {
        pnl_nav.Height = btn_dangxuat.Height;
        pnl_nav.Top = btn_dangxuat.Top;
        btn_dangxuat.BackColor = SystemColors.GradientInactiveCaption;

        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn đăng xuất ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dialogResult == DialogResult.Yes)
        {
            Close();
            FrmDangNhap frmDangNhap = new();
            frmDangNhap.Show();
        }
        else return;
    }

    private void btn_sellingService_Leave(object sender, EventArgs e)
    {
        //btn_sellingService.BackColor = Color.FromArgb(20, 30, 54);
        btn_sellingService.BackColor = SystemColors.ActiveCaption;
    }

    private void btn_productDetailService_Leave(object sender, EventArgs e)
    {
        btn_productDetailService.BackColor = SystemColors.ActiveCaption;
    }

    private void btn_staffService_Leave(object sender, EventArgs e)
    {
        btn_staffService.BackColor = SystemColors.ActiveCaption;
    }

    private void btn_orderService_Leave(object sender, EventArgs e)
    {
        btn_orderService.BackColor = SystemColors.ActiveCaption;
    }

    private void btn_customerService_Leave(object sender, EventArgs e)
    {
        btn_customerService.BackColor = SystemColors.ActiveCaption;
    }
}
