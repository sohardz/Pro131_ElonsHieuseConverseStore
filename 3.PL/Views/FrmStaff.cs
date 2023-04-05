using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;
using System.ComponentModel.DataAnnotations;

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
        txt_ma.Enabled = false;
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

    private void dgrid_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex != -1 || e.RowIndex != _staffService.GetAll().Count)
        {
            int rowIndex = e.RowIndex;
            _maWhenclick = dgrid_nhanvien.Rows[rowIndex].Cells[1].Value.ToString().Trim();
            var obj = _staffService.GetAll().FirstOrDefault(x => x.Ma == _maWhenclick);
            txt_ma.Text = obj.Ma;
            txt_ho.Text = obj.LastName;
            txt_tendem.Text = obj.MiddleName;
            txt_ten.Text = obj.FirstName;
            txt_email.Text = obj.Email;
            if (obj.Sex == 0) rbtn_nam.Checked = true;
            else rbtn_nu.Checked = true;
            txt_diachi.Text = obj.Address;
            txt_sdt.Text = obj.PhoneNumber;
            dtpicker_ngaysinh.Value = obj.DoB;
            txt_matkhau.Text = obj.Address;
            if (obj.Status == 0) rbtn_khonghoatdong.Checked = true;
            else rbtn_hoatdong.Checked = true;
            if (string.IsNullOrEmpty(obj.ImageDirection))
            {
                picBox_anhNhanvien.Image = new Bitmap(img);
            }
            else picBox_anhNhanvien.Image = new Bitmap(obj.ImageDirection);
        }
        else return;
    }

    private void btn_them_Click(object sender, EventArgs e)
    {
        var x = GetDataFromGui();
        var ma = string.IsNullOrEmpty(txt_ma.Text) ? "NV" + (_staffService.GetAll().Count + 1) : txt_ma.Text;
        foreach (var y in _staffService.GetAll())
        {
            if (y.Ma == ma) ma = "NV" + (_staffService.GetAll().Count + 1);
        }
        x.Ma = ma;

        ValidationContext validContext = new ValidationContext(x, null, null);
        IList<ValidationResult> errors = new List<ValidationResult>();
        if (!Validator.TryValidateObject(x, validContext, errors, true))
        {
            foreach (var item in errors)
            {
                MessageBox.Show(item.ErrorMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        if (!CheckGetData(x)) return;

        DialogResult dialogResult = MessageBox.Show("bạn có chắc muốn thêm nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            MessageBox.Show(_staffService.Add(x));
            LoadDgrid(null);
        }
    }

    private void btn_sua_Click(object sender, EventArgs e)
    {
        var x = GetDataFromGui();

        ValidationContext validContext = new ValidationContext(x, null, null);
        IList<ValidationResult> errors = new List<ValidationResult>();
        if (!Validator.TryValidateObject(x, validContext, errors, true))
        {
            foreach (var item in errors)
            {
                MessageBox.Show(item.ErrorMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        if (!CheckGetData(x)) return;

        DialogResult dialogResult = MessageBox.Show("bạn có chắc muốn sửa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            MessageBox.Show(_staffService.Update(x));
            LoadDgrid(null);
        }
    }

    private void btn_clear_Click(object sender, EventArgs e)
    {
        ImagePath = "";
        picBox_anhNhanvien.Image = null;
        txt_ma.Text = "";
        txt_ho.Text = "";
        txt_tendem.Text = "";
        txt_ten.Text = "";
        txt_email.Text = "";
        rbtn_nam.Checked = true;
        txt_diachi.Text = "";
        txt_sdt.Text = "";
        txt_matkhau.Text = "";
        dtpicker_ngaysinh.Value = DateTime.Now;
        LoadDgrid(null);
    }

    private void txt_ho_Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txt_ho.Text)) return;
        txt_ho.Text = Utility.VietHoaFullName(txt_ho.Text);
    }

    private void txt_tendem_Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txt_tendem.Text)) return;
        txt_tendem.Text = Utility.VietHoaFullName(txt_tendem.Text);
    }

    private void txt_ten_Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txt_ten.Text)) return;
        txt_ten.Text = Utility.VietHoaFullName(txt_ten.Text);
    }

    private void txt_diachi_Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txt_diachi.Text)) return;
        txt_diachi.Text = Utility.VietHoaFullName(txt_diachi.Text);
    }

    private void btn_chonAnh_Click(object sender, EventArgs e)
    {
        Utility.LoadImage(ref ImagePath);
        picBox_anhNhanvien.Image = new Bitmap(ImagePath);
    }
}
