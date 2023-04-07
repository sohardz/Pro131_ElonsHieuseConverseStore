using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;

namespace _3.PL.Views;

public partial class FrmMaterial : Form
{
    private IMaterialService _materialService;
    private string _maWhenclick;

    public FrmMaterial()
    {
        InitializeComponent();
        _materialService = new MaterialService();
        txt_ma.Enabled = false;
        LoadDgrid(null);
    }

    private void LoadDgrid(string input)
    {
        int stt = 1;
        dgrid_material.ColumnCount = 4;
        dgrid_material.Columns[0].Name = "STT";
        dgrid_material.Columns[1].Name = "Mã";
        dgrid_material.Columns[2].Name = "Tên";
        dgrid_material.Columns[3].Name = "Trạng thái";
        dgrid_material.Rows.Clear();

        foreach (var x in _materialService.GetAll(input))
        {
            dgrid_material.Rows.Add(stt++, x.Ma, x.Name, Utility.TrangThai()[x.Status]);
        }
    }

    private MaterialView GetDataFromGui()
    {
        return new MaterialView()
        {
            Ma = txt_ma.Text,
            Name = txt_ten.Text,
            Status = rbtn_hoatdong.Checked ? 1 : 0,
        };
    }

    private void dgrid_material_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1 || e.RowIndex == _materialService.GetAll().Count) return;
        int rowIndex = e.RowIndex;
        _maWhenclick = dgrid_material.Rows[rowIndex].Cells[1].Value.ToString();
        var obj = _materialService.GetAll().FirstOrDefault(c => c.Ma == _maWhenclick);
        txt_ma.Text = obj.Ma;
        txt_ten.Text = obj.Name;
        if (obj.Status == 1) rbtn_hoatdong.Checked = true;
        else rbtn_khonghoatdong.Checked = true;
    }

    private void btn_them_Click(object sender, EventArgs e)
    {
        var x = GetDataFromGui();

        var ma = string.IsNullOrEmpty(txt_ma.Text) ? "Material" + (_materialService.GetAll().Count + 1) : txt_ma.Text;
        foreach (var y in _materialService.GetAll())
        {
            if (y.Ma == ma) ma = "Material" + (_materialService.GetAll().Count + 1);
        }
        x.Ma = ma;

        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm chất liệu này?", "Xác nhận", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            MessageBox.Show(_materialService.Add(x));
            LoadDgrid(null);
            //FrmCtDienThoai.LoadCmb();
        }
    }



    private void btn_sua_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa chất liệu này?", "Xác nhận", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            MessageBox.Show(_materialService.Update(GetDataFromGui()));
            LoadDgrid(null);
            //FrmCtDienThoai.LoadCmb();
        }
    }

    private void btn_clear_Click(object sender, EventArgs e)
    {
        txt_ma.Text = "";
        txt_ten.Text = "";
        LoadDgrid(null);
    }
}
