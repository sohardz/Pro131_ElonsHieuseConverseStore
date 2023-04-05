using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;

namespace _3.PL.Views;

public partial class FrmCategory : Form
{
    private ICategoryService _categoryService;
    public FrmCategory()
    {
        InitializeComponent();
        _categoryService = new CategoryService();
        LoadDgrid(null);
    }

    private void LoadDgrid(string input)
    {
        int stt = 1;
        dgrid_category.ColumnCount = 4;
        dgrid_category.Columns[0].Name = "STT";
        dgrid_category.Columns[1].Name = "Mã";
        dgrid_category.Columns[2].Name = "Loại giày";
        dgrid_category.Columns[3].Name = "Trạng thái";
        dgrid_category.Rows.Clear();

        foreach (var x in _categoryService.GetAll(input))
        {
            dgrid_category.Rows.Add(stt++, x.Ma, x.Name, Utility.TrangThai()[x.Status]);
        }

    }
    private CategoryView GetDataFromGui()
    {
        var size = new CategoryView()
        {
            Ma = txt_ma.Text,
            Name = txt_ten.Text,
            Status = rbtn_hoatdong.Checked ? 1 : 0,
        };
        return size;
    }
    private void btn_them_Click(object sender, EventArgs e)
    {
        var x = GetDataFromGui();

        var ma = string.IsNullOrEmpty(txt_ma.Text) ? "Size" + (_categoryService.GetAll().Count + 1) : txt_ma.Text;
        foreach (var y in _categoryService.GetAll())
        {
            if (y.Ma == ma) ma = "Size " + (_categoryService.GetAll().Count + 1);
        }
        x.Ma = ma;

        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm kích cỡ này?", "Xác nhận", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            MessageBox.Show(_categoryService.Add(x));
            LoadDgrid(null);
        }
    }

    private void btn_sua_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa loại giày này?", "Xác nhận", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            MessageBox.Show(_categoryService.Update(GetDataFromGui()));
            LoadDgrid(null);
        }
    }

    private void btn_clear_Click(object sender, EventArgs e)
    {
        txt_ma.Text = "";
        txt_ten.Text = "";
        rbtn_hoatdong.Checked = false;
        rbtn_khonghoatdong.Checked = false;
        LoadDgrid(null);
    }
}
