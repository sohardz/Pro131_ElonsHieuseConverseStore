using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;

namespace _3.PL.Views;
public partial class FrmConfigShoes : Form
{
    private IShoesService _shoesService;
    private IColorService _colorService;
    private ISizeService _sizeService;
    private ICategoryService _categoryService;
    private IMaterialService _materialService;
    private string ImagePath;
    private string img = @"C:\Users\adm\Desktop\Pro131_ElonsHieuseConverseStore\3.PL\Image\noimage.png";

    FrmShoes _frmShoes;

    public FrmConfigShoes(FrmShoes frmShoes)
    {
        InitializeComponent();
        _categoryService = new CategoryService();
        _colorService = new ColorService();
        _sizeService = new SizeService();
        _shoesService = new ShoesService();
        _materialService = new MaterialService();
        LoadCmb();
        _frmShoes = frmShoes;
        txt_ma.Enabled = false;
    }

    public void takeData(string text)
    {
        var shoes = _shoesService.GetAll().FirstOrDefault(c => c.Ma == text);
        txt_ma.Text = shoes.Ma;
        txt_ten.Text = shoes.Name;
        cmb_category.SelectedIndex = _categoryService.GetAll().FindIndex(c => c.Ma == shoes.MaCategory);
        cmb_color.SelectedIndex = _colorService.GetAll().FindIndex(c => c.Ma == shoes.MaColor);
        cmb_size.SelectedIndex = _sizeService.GetAll().FindIndex(c => c.Ma == shoes.MaSize);
        cmb_material.SelectedIndex = _materialService.GetAll().FindIndex(c => c.Ma == shoes.MaMaterial);
        txt_soluong.Text = shoes.Stock.ToString();
        txt_gianhap.Text = shoes.CostPrice.ToString();
        txt_giaban.Text = shoes.SalePrice.ToString();
        if (shoes.Status == 0) rbtn_khonghoatdong.Checked = true;
        else rbtn_hoatdong.Checked = true;
        richtxt_mota.Text = shoes.Description;
        if (string.IsNullOrEmpty(shoes.ImageDirection))
        {
            picBox_shoesImage.Image = new Bitmap(img);
        }
        else picBox_shoesImage.Image = new Bitmap(shoes.ImageDirection);
    }

    public void LoadCmb()
    {
        cmb_category.Items.Clear();
        cmb_color.Items.Clear();
        cmb_size.Items.Clear();
        cmb_material.Items.Clear();

        foreach (var x in _materialService.GetAll())
        {
            cmb_material.Items.Add(x.Name);
        }

        foreach (var x in _categoryService.GetAll())
        {
            cmb_category.Items.Add(x.Name);
        }

        foreach (var x in _colorService.GetAll())
        {
            cmb_color.Items.Add(x.Name);
        }

        foreach (var x in _sizeService.GetAll())
        {
            cmb_size.Items.Add(x.SizeNumber);
        }
    }

    private bool CheckGetData()
    {
        if (cmb_category.SelectedIndex == -1)
        {
            MessageBox.Show("Hãy chọn loại sản phẩm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        if (cmb_color.SelectedIndex == -1)
        {
            MessageBox.Show("Hãy chọn màu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        if (cmb_size.SelectedIndex == -1)
        {
            MessageBox.Show("Hãy chọn kích cỡ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;

        }
        if (txt_soluong.Text.Length == 0)
        {
            MessageBox.Show("Phải nhập số lượng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!int.TryParse(txt_soluong.Text, out _))
        {
            MessageBox.Show("Hãy nhập đúng định dạng cho số lượng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        if (txt_gianhap.Text.Length == 0)
        {
            MessageBox.Show("Phải nhập giá nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!decimal.TryParse(txt_gianhap.Text, out _))
        {
            MessageBox.Show("Hãy nhập đúng định dạng cho giá nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        if (txt_giaban.Text.Length == 0)
        {
            MessageBox.Show("Phải nhập giá bán", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!decimal.TryParse(txt_giaban.Text, out _))
        {
            MessageBox.Show("Hãy nhập đúng định dạng cho giá bán", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        else if (!int.TryParse(txt_soluong.Text, out _))
        {
            MessageBox.Show("Hãy nhập đúng định dạng cho năm bảo hành", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        if (!rbtn_hoatdong.Checked && !rbtn_khonghoatdong.Checked)
        {
            MessageBox.Show("Hãy chọn trạng thái", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        return true;
    }
    private ShoesView GetDataFromGui()
    {
        var shoes = new ShoesView()
        {
            Ma = txt_ma.Text,
            MaMaterial = _materialService.GetAll()[cmb_material.SelectedIndex].Ma,
            MaCategory = _categoryService.GetAll()[cmb_category.SelectedIndex].Ma,
            MaSize = _sizeService.GetAll()[cmb_size.SelectedIndex].Ma,
            MaColor = _colorService.GetAll()[cmb_color.SelectedIndex].Ma,
            Name = txt_ten.Text,
            Stock = Convert.ToInt32(txt_soluong.Text),
            CostPrice = Convert.ToDecimal(txt_gianhap.Text),
            SalePrice = Convert.ToDecimal(txt_giaban.Text),
            Description = richtxt_mota.Text,
            ImageDirection = ImagePath,
            Status = rbtn_hoatdong.Checked ? 1 : 0,
        };
        return shoes;
    }

    private void btn_save_Click(object sender, EventArgs e)
    {
        if (!CheckGetData()) return;

        var x = GetDataFromGui();

        var ma = string.IsNullOrEmpty(txt_ma.Text) ? "Shoes" + (_shoesService.GetAll().Count + 1) : txt_ma.Text;
        foreach (var y in _shoesService.GetAll())
        {
            if (y.Ma == ma) ma = "CTDT" + (_shoesService.GetAll().Count + 1);
        }
        x.Ma = ma;

        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            MessageBox.Show(_shoesService.Add(x));
            _frmShoes.LoadDgrid(null);
            Close();
        }
    }

    private void btn_huy_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Bản có chắc muốn hủy?", "Xác nhận", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            Close();
        }
    }

    private void btn_chonAnh_Click(object sender, EventArgs e)
    {
        Utility.LoadImage(ref ImagePath);
        picBox_shoesImage.Image = new Bitmap(ImagePath);
    }

    private void btn_sua_Click(object sender, EventArgs e)
    {
        if (!CheckGetData()) return;

        var x = GetDataFromGui();

        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            MessageBox.Show(_shoesService.Update(x));
            _frmShoes.LoadDgrid(null);
            Close();
        }
    }
}
