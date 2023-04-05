using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;

namespace _3.PL.Views;

public partial class FrmCategory : Form
{
    private ICategoryService _categoryService;
    private string _maWhenclick;

    public FrmCategory()
    {
        InitializeComponent();
        _categoryService = new CategoryService();
        LoadDgrid(null);
        txt_ma.Enabled = false;
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

    private void dgrid_category_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1 || e.RowIndex == _categoryService.GetAll().Count) return;
        int rowIndex = e.RowIndex;
        _maWhenclick = dgrid_category.Rows[rowIndex].Cells[1].Value.ToString();
        var obj = _categoryService.GetAll().FirstOrDefault(c => c.Ma == _maWhenclick);
        txt_ma.Text = obj.Ma;
        txt_ten.Text = obj.Name;
        if (obj.Status == 1) rbtn_hoatdong.Checked = true;
        else rbtn_khonghoatdong.Checked = true;
    }

    private void btn_them_Click(object sender, EventArgs e)
    {
        var x = GetDataFromGui();

        var ma = string.IsNullOrEmpty(txt_ma.Text) ? "Category" + (_categoryService.GetAll().Count + 1) : txt_ma.Text;
        foreach (var y in _categoryService.GetAll())
        {
            if (y.Ma == ma) ma = "Category " + (_categoryService.GetAll().Count + 1);
        }
        x.Ma = ma;

        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm loại giày này này?", "Xác nhận", MessageBoxButtons.YesNo);
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
