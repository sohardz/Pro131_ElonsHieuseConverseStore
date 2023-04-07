using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;
using System.ComponentModel.DataAnnotations;

namespace _3.PL.Views;

public partial class FrmCustomer : Form
{
    private ICustomerService _customerService;
    private string _maWhenclick;

    public FrmCustomer()
    {
        InitializeComponent();
        _customerService = new CustomerService();
        txt_ma.Enabled = false;
        LoadDgrid(null);
    }

    private void LoadDgrid(string input)
    {
        int stt = 1;
        dgrid_customer.ColumnCount = 5;
        dgrid_customer.Columns[0].Name = "Stt";
        dgrid_customer.Columns[1].Name = "Mã";
        dgrid_customer.Columns[2].Name = "Họ và Tên";
        dgrid_customer.Columns[3].Name = "Sđt";
        dgrid_customer.Columns[4].Name = "Địa chỉ";
        dgrid_customer.Rows.Clear();

        foreach (var x in _customerService.GetAll(input))
        {
            dgrid_customer.Rows.Add(stt++, x.Ma, x.LastName + x.MiddleName + x.FirstName, x.PhoneNumber, x.Address);
        }
    }

    private CustomerView GetDataFromGui()
    {
        return new CustomerView()
        {
            Ma = txt_ma.Text,
            FirstName = txt_ten.Text,
            MiddleName = txt_tendem.Text,
            LastName = txt_ho.Text,
            PhoneNumber = txt_sdt.Text,
            Address = txt_diachi.Text,
        };
    }

    private void dgrid_customer_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1 || e.RowIndex == _customerService.GetAll().Count) return;
        int rowIndex = e.RowIndex;
        _maWhenclick = dgrid_customer.Rows[rowIndex].Cells[1].Value.ToString();
        var obj = _customerService.GetAll().FirstOrDefault(x => x.Ma == _maWhenclick);
        txt_ma.Text = obj.Ma;
        txt_ho.Text = obj.LastName;
        txt_tendem.Text = obj.MiddleName;
        txt_ten.Text = obj.FirstName;
        txt_sdt.Text = obj.PhoneNumber;
        txt_diachi.Text = obj.Address;
    }

    private void btn_them_Click(object sender, EventArgs e)
    {
        var x = GetDataFromGui();

        var ma = string.IsNullOrEmpty(txt_ma.Text) ? "KH" + (_customerService.GetAll().Count + 1) : txt_ma.Text;
        foreach (var y in _customerService.GetAll())
        {
            if (y.Ma == ma) ma = "KH" + (_customerService.GetAll().Count + 1);
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

        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            MessageBox.Show(_customerService.Add(x));
            LoadDgrid(null);
        }
        if (dialogResult == DialogResult.No) return;
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

        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            MessageBox.Show(_customerService.Update(x));
            LoadDgrid(null);
        }
        if (dialogResult == DialogResult.No) return;
    }

    private void btn_clear_Click(object sender, EventArgs e)
    {
        txt_ma.Text = "";
        txt_ho.Text = "";
        txt_tendem.Text = "";
        txt_ten.Text = "";
        txt_sdt.Text = "";
        txt_diachi.Text = "";
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
}
