using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views.DangNhap
{
    public partial class FrmQuenMatKhau : Form
    {
        IStaffService nhanVienService;
        string body;
        string email;

        string from = "lemonade182003@gmail.com";
        public FrmQuenMatKhau()
        {
            InitializeComponent();
            nhanVienService = new StaffService();
        }

        public bool CheckMail()
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email không được bỏ trống", "Thông báo");
                return false;
            }
            return true;
        }
        public void SendMail(string ballsack)
        {

            MailMessage message = new MailMessage(from, email, "", body);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("lemonade182003@gmail.com", "pjarnbssnhfszjwm");
            client.Send(message);

            //Để dùng được chức năng gửi mật khẩu cần bật less sercurity trong manage your account và chỉ có email của tổ chức mới bật được ví dụ như email trường email cá nhân chỉ dùng làm đối tượng được gửi đến

            //Hoặc manage your account -> Security -> 2-Step verification -> Security -> App passwords -> Select app -> mail -> select devices -> window computer -> copy dòng hiện lên rồi paste vào password 
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (var item in nhanVienService.GetAll())
                {
                    if (item.Email == txtEmail.Text)
                    {
                        var matkhau = nhanVienService.GetAll().FirstOrDefault(c => c.Email == txtEmail.Text).Password;
                        email = txtEmail.Text;
                        body = "Mật khẩu của bạn là " + matkhau;
                        SendMail(txtEmail.Text);
                        MessageBox.Show("Gửi mail thành công", "Thông ball");
                    }

                }

            }


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDangNhap = new();
            frmDangNhap.Show();
            Close();
        }


    }
}
