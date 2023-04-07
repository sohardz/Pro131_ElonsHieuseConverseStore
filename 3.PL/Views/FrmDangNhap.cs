using _2.BUS.IServices;
using _2.BUS.Services;

namespace _3.PL.Views.DangNhap
{
    public partial class FrmDangNhap : Form
    {
        IStaffService nhanVienService;
        string username = "admin";
        string password = "admin";

        public FrmDangNhap()
        {
            InitializeComponent();
            nhanVienService = new StaffService();
        }

        private bool KiemTranDangNhap(string tentaikhoan, string matkhau)
        {
            if (tentaikhoan == username && matkhau == password)
            {
                return true;
            }
            else
            {
                foreach (var item in nhanVienService.GetAll())
                {
                    if (item.Email == tentaikhoan && item.Password == matkhau)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (KiemTranDangNhap(txt_email.Text, txt_password.Text))
            {
                Hide();
                var staff = nhanVienService.GetAll().FirstOrDefault(c => c.Email == txt_email.Text);
                FrmDashboard frmDashBoard = new(staff);
                frmDashBoard.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập sai hoặc mật khẩu sai", "Error");
                txt_email.Clear();
                txt_password.Clear();
            }

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmQuenMatKhau frmQuenMatKhau = new();
            frmQuenMatKhau.Show();
            Hide();
        }

        private void cb_SaveAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_email.Text != "" && txt_password.Text != "")
            {
                if (cb_SaveAccount.Checked == true)
                {
                    string email = txt_email.Text;
                    string pass = txt_password.Text;
                    Properties.Settings.Default.Email = email;
                    Properties.Settings.Default.Password = pass;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txt_email.Text = Properties.Settings.Default.Email;
            txt_password.Text = Properties.Settings.Default.Password;
            if (Properties.Settings.Default.Email != string.Empty)
            {
                cb_SaveAccount.Checked = true;
            }
        }

        // ẩn mật khẩu
        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '\0')
            {
                button1.BringToFront();
                txt_password.PasswordChar = '*';
            }
        }

        // hiện mật khẩu
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '*')
            {
                button2.BringToFront();
                txt_password.PasswordChar = '\0';
            }
        }
    }
}
