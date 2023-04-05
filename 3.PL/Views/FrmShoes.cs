using _2.BUS.IServices;
using _2.BUS.Services;

namespace _3.PL.Views;

public partial class FrmShoes : Form
{
    private IShoesService _shoesService;
    private IColorService _colorService;
    private ISizeService _sizeService;
    private ICategoryService _categoryService;
    private string _maWhenClick;
    public FrmShoes()
    {
        InitializeComponent();
        _categoryService = new CategoryService();
        _colorService = new ColorService();
        _sizeService = new SizeService();
        _shoesService = new ShoesService();
        LoadDgrid();
    }
    private void LoadDgrid()
    {
        int stt = 1;
        dgrid_shoes.ColumnCount = 11;
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
        dgrid_shoes.Columns[10].Name = "Trạng thái";
        dgrid_shoes.Rows.Clear();

        foreach (var x in _shoesService.GetAll())
        {
            dgrid_shoes.Rows.Add(stt++, x.Ma, x.Name, x.CategoryName, x.ColorName, x.SizeNumber, x.Stock, x.CostPrice, x.SalePrice, x.Description, x.Status);
        }
    }

    private void dgrid_shoes_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        
    }
}
