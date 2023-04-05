using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;



namespace _3.PL.Views;

public partial class FrmColor : Form
{
    private IColorService _colorService;
    private string _maWhenclick;
    
    public FrmColor()
    {
        InitializeComponent();
        _colorService = new ColorService();
        LoadDgrid(null);
        txt_ma.Enabled = false;
    }

    private void LoadDgrid(string input)
    {
        int stt = 1;
        dgrid_color.ColumnCount = 4;
        dgrid_color.Columns[0].Name = "STT";
        dgrid_color.Columns[1].Name = "Mã";
        dgrid_color.Columns[2].Name = "Tên";
        dgrid_color.Columns[3].Name = "Trạng thái";
        dgrid_color.Rows.Clear();

        foreach (var x in _colorService.GetAll(input))
        {
            dgrid_color.Rows.Add(stt++, x.Ma, x.Name, Utility.TrangThai()[x.Status]);
        }
    }

    private ColorView GetDataFromGui()
    {
        return new ColorView()
        {
            Ma = txt_ma.Text,
            Name = txt_ten.Text,
            Status = rbtn_hoatdong.Checked ? 1 : 0,
        };
    }

    private void dgrid_color_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1 || e.RowIndex == _colorService.GetAll().Count) return;
        int rowIndex = e.RowIndex;
        _maWhenclick = dgrid_color.Rows[rowIndex].Cells[1].Value.ToString();
        var obj = _colorService.GetAll().FirstOrDefault(c => c.Ma == _maWhenclick);
        txt_ma.Text = obj.Ma;
        txt_ten.Text = obj.Name;
        if (obj.Status == 1) rbtn_hoatdong.Checked = true;
        else rbtn_khonghoatdong.Checked = true;
    }

    private void btn_them_Click(object sender, EventArgs e)
    {
        var x = GetDataFromGui();

        var ma = string.IsNullOrEmpty(txt_ma.Text) ? "MS" + (_colorService.GetAll().Count + 1) : txt_ma.Text;
        foreach (var y in _colorService.GetAll())
        {
            if (y.Ma == ma) ma = "MS" + (_colorService.GetAll().Count + 1);
        }
        x.Ma = ma;

        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm màu này?", "Xác nhận", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            MessageBox.Show(_colorService.Add(x));
            LoadDgrid(null);
            //FrmCtDienThoai.LoadCmb();
        }
    }

    

    private void btn_sua_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa màu này?", "Xác nhận", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            MessageBox.Show(_colorService.Update(GetDataFromGui()));
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