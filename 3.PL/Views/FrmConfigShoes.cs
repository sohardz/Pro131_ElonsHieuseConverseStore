using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views;
public partial class FrmConfigShoes : Form
{
    private IShoesService _shoesService;
    private IColorService _colorService;
    private ISizeService _sizeService;
    private ICategoryService _categoryService;
    private IMaterialService _materialService;
    private string ImagePath;
    private string img = @"C:\Users\This PC\OneDrive - Đại học FPT- FPT University\Desktop\conv1.png";

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

        DialogResult dialogResult = MessageBox.Show("Bạn có chắc đã hoàn thành?", "Xác nhận", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            MessageBox.Show(_shoesService.Add(x));
            _frmShoes.LoadDgrid();
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
}
