using _2.BUS.IServices;
using _2.BUS.Services;
using _3.PL.Utilities;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System.Windows.Forms;

namespace _3.PL.Views;

public partial class FrmShoes : Form
{
    private IShoesService _shoesService;
    private IColorService _colorService;
    private ISizeService _sizeService;
    private ICategoryService _categoryService;
    private string _maWhenclick;

    public delegate void passData(string text);

    public FrmShoes()
    {
        InitializeComponent();
        _categoryService = new CategoryService();
        _colorService = new ColorService();
        _sizeService = new SizeService();
        _shoesService = new ShoesService();
        LoadDgrid();
    }

    public void LoadDgrid()
    {
        
        DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
        int stt = 1;
        dgrid_shoes.ColumnCount = 12;
        dgrid_shoes.Columns[0].Name = "STT";
        dgrid_shoes.Columns[1].Name = "Mã";
        dgrid_shoes.Columns[2].Name = "Tên giày";
        dgrid_shoes.Columns[3].Name = "Loại giày";
        dgrid_shoes.Columns[4].Name = "Màu sắc";
        dgrid_shoes.Columns[5].Name = "Kích cỡ";
        dgrid_shoes.Columns[6].Name = "Số lượng tồn";
        dgrid_shoes.Columns[7].Name = "Giá nhập";
        dgrid_shoes.Columns[8].Name = "Giá bán";
        dgrid_shoes.Columns[9].Name = "Mô tả";
        
        dgrid_shoes.Columns[11].Name = "Trạng thái";
        dgrid_shoes.Rows.Clear();
        
        foreach (var x in _shoesService.GetAll())
        {
            
            dgrid_shoes.Rows.Add(stt++, x.Ma, x.Name, x.CategoryName, x.ColorName, x.SizeNumber, x.Stock, x.CostPrice, x.SalePrice,
                x.Description,Utility.TrangThai()[x.Status]);
        }
    }

    private void dgrid_shoes_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1 || e.RowIndex == _shoesService.GetAll().Count) return;
        int rowIndex = e.RowIndex;
        _maWhenclick = dgrid_shoes.Rows[rowIndex].Cells[1].Value.ToString();
        FrmConfigShoes frmConfigShoes = new(this);
        passData shoes = new(frmConfigShoes.takeData);
        shoes(_maWhenclick);
        frmConfigShoes.Show();
    }

    private void btn_category_Click(object sender, EventArgs e)
    {
        FrmCategory frmCategory = new();
        frmCategory.Show();
    }

    private void btn_material_Click(object sender, EventArgs e)
    {
        FrmMaterial frmMaterial = new();
        frmMaterial.Show();
    }

    private void btn_size_Click(object sender, EventArgs e)
    {
        FrmSize frmSize = new();
        frmSize.Show();
    }

    private void btn_color_Click(object sender, EventArgs e)
    {
        FrmColor frmColor = new();
        frmColor.Show();
    }

    private void btn_them_Click(object sender, EventArgs e)
    {
        FrmConfigShoes frmConfigShoes = new(this);
        frmConfigShoes.Show();
    }
}
