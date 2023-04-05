using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;

namespace _3.PL.Views;

public partial class FrmStaff : Form
{
    private IStaffService _staffService;
    private string _maWhenclick;
    private string ImagePath = "";
    private string img = @"D:\DuAn1\ProjectPhone\3.PL\Image\AnhNhanVien\1.jpg";

    public FrmStaff()
    {
        InitializeComponent();
        _staffService = new StaffService();
    }

    private void LoadDgrid(string input)
    {
        int stt = 1;
        dgrid_nhanvien.ColumnCount = 11;
        dgrid_nhanvien.Columns[0].Name = "STT";
        dgrid_nhanvien.Columns[1].Name = "Mã";
        dgrid_nhanvien.Columns[2].Name = "Tên Đầy Đủ";
        dgrid_nhanvien.Columns[3].Name = "Cccd";
        dgrid_nhanvien.Columns[4].Name = "Ngày Sinh";
        dgrid_nhanvien.Columns[5].Name = "Giới Tính";
        dgrid_nhanvien.Columns[6].Name = "Địa Chỉ";
        dgrid_nhanvien.Columns[7].Name = "SĐT";
        dgrid_nhanvien.Columns[8].Name = "Email";
        dgrid_nhanvien.Columns[9].Name = "Chức Vụ";
        dgrid_nhanvien.Columns[10].Name = "Trạng Thái";
        dgrid_nhanvien.Rows.Clear();

        foreach (var x in _staffService.GetAll(input))
        {
            dgrid_nhanvien.Rows.Add(stt++, x.Ma, x.LastName + x.MiddleName + x.FirstName, x.DoB, x.Sex == 1 ? "Nam" : "Nữ", x.Address, x.PhoneNumber, x.Email, Utility.TrangThai()[x.Status]);
        }
    }

    private bool CheckGetData(StaffView obj)
    {
        if (!rbtn_nam.Checked && !rbtn_nu.Checked)
        {
            MessageBox.Show("Phải chọn giới tính", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!rbtn_hoatdong.Checked && !rbtn_khonghoatdong.Checked)
        {
            MessageBox.Show("Phải chọn trạng thái", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else return true;
    }

    private StaffView GetDataFromGui()
    {
        StaffView nvv = new StaffView()
        {
            Ma = txt_ma.Text,
            LastName = txt_ho.Text,
            MiddleName = txt_tendem.Text,
            FirstName = txt_ten.Text,
            Email = txt_email.Text,
            Sex = rbtn_nam.Checked ? 1 : 0,
            DoB = dtpicker_ngaysinh.Value,
            Address = txt_diachi.Text,
            PhoneNumber = txt_sdt.Text,
            ImageDirection = ImagePath,
            Password = txt_matkhau.Text,
            Status = rbtn_hoatdong.Checked ? 1 : 0,
        };
        return nvv;
    }
}
