using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;

namespace _3.PL.Views;

public partial class FrmSize : Form
{
    private ISizeService _sizeService;
    private string _maWhenclick;

    public FrmSize()
    {
        InitializeComponent();
        _sizeService = new SizeService();
        LoadDgrid(null);
    }

    private void LoadDgrid(string input)
    {
        int stt = 1;
        dgrid_size.ColumnCount = 4;
        dgrid_size.Columns[0].Name = "STT";
        dgrid_size.Columns[1].Name = "Mã";
        dgrid_size.Columns[2].Name = "Kích cỡ";
        dgrid_size.Columns[3].Name = "Trạng thái";
        dgrid_size.Rows.Clear();

        foreach (var x in _sizeService.GetAll(input))
        {
            dgrid_size.Rows.Add(stt++, x.Ma, x.SizeNumber, Utility.TrangThai()[x.Status]);
        }

    }
    private SizeView GetDataFromGui()
    {
        var size = new SizeView()
        {
            Ma = txt_ma.Text,
            SizeNumber = Convert.ToInt32(txt_size.Text),
            Status = rbtn_hoatdong.Checked ? 1 : 0,
        };
        return size;
    }
    private void btn_them_Click(object sender, EventArgs e)
    {
        var x = GetDataFromGui();

        var ma = string.IsNullOrEmpty(txt_ma.Text) ? "Size" + (_sizeService.GetAll().Count + 1) : txt_ma.Text;
        foreach (var y in _sizeService.GetAll())
        {
            if (y.Ma == ma) ma = "Size " + (_sizeService.GetAll().Count + 1);
        }
        x.Ma = ma;

        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm kích cỡ này?", "Xác nhận", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            MessageBox.Show(_sizeService.Add(x));
            LoadDgrid(null);
        }
    }

    private void btn_sua_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa màu này?", "Xác nhận", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            MessageBox.Show(_sizeService.Update(GetDataFromGui()));
            LoadDgrid(null);
        }
    }

    private void btn_clear_Click(object sender, EventArgs e)
    {

        //DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa dung lượng pin này?", "Xác nhận", MessageBoxButtons.YesNo);
        //if (dialogResult == DialogResult.Yes)
        //{
        //    MessageBox.Show(_sizeService.Delete(GetDataFromGui()));
        //    LoadDgrid(null);

        //}
        txt_ma.Text = "";
        txt_size.Text = "";
        rbtn_hoatdong.Checked = false;
        rbtn_khonghoatdong.Checked = false;
        LoadDgrid(null);
    }

    private void dgrid_size_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1 || e.RowIndex == _sizeService.GetAll().Count) return;
        int rowIndex = e.RowIndex;
        _maWhenclick = dgrid_size.Rows[rowIndex].Cells[1].Value.ToString();
        var obj = _sizeService.GetAll().FirstOrDefault(c => c.Ma == _maWhenclick);
        txt_ma.Text = obj.Ma;
        txt_size.Text = obj.SizeNumber.ToString();
        if (obj.Status == 1) rbtn_hoatdong.Checked = true;
        else rbtn_khonghoatdong.Checked = true;
    }
}
