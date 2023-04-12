using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;

namespace _3.PL.Views;

public partial class FrmSelling : Form
{
    private IStaffService _staffService;
    private IShoesService _shoesService;
    private ICustomerService _customerService;
    private IBillService _billService;
    private IBillDetailService _billDetailService;

    private List<BillDetailView> lstHdCt;
    private string maCtHoaDon;
    private string maCtGiay;
    private string maHd;
    private CustomerView khachHang;
    private List<BillView> lstHd;

    private List<BillView> lstBillNow;
    private List<BillDetailView> lstBillDetailNow;

    public FrmSelling()
    {
        InitializeComponent();
        _staffService = new StaffService();
        _shoesService = new ShoesService();
        _customerService = new CustomerService();
        _billService = new BillService();
        _billDetailService = new BillDetailService();
        lstHdCt = new List<BillDetailView>();
        lstHd = new List<BillView>();
        LoadCmb();
        LoadSanPham();
        LoadHoaDonCho();
        LoadGioHang();
    }

    //Load combobox
    private void LoadCmb()
    {
        cmb_customerPhoneNumber.Items.Clear();
        cmb_staff.Items.Clear();

        foreach (var x in _customerService.GetAll())
        {
            cmb_customerPhoneNumber.Items.Add(x.PhoneNumber);
        }

        foreach (var x in _staffService.GetAll())
        {
            cmb_staff.Items.Add(x.PhoneNumber);
        }
    }

    //load sản phẩm
    private void LoadSanPham()
    {
        int stt = 1;
        dgrid_productDetail.ColumnCount = 5;
        dgrid_productDetail.Columns[0].Name = "STT";
        dgrid_productDetail.Columns[1].Name = "Mã";
        dgrid_productDetail.Columns[2].Name = "Tên sản phẩm";
        dgrid_productDetail.Columns[3].Name = "Số lượng tồn";
        dgrid_productDetail.Columns[4].Name = "Đơn giá";
        dgrid_productDetail.Rows.Clear();

        foreach (var x in _shoesService.GetAll())
        {
            dgrid_productDetail.Rows.Add(stt++, x.Ma, x.Name, x.Stock, x.SalePrice);
        }
    }

    //load hóa đơn chờ
    private void LoadHoaDonCho()
    {
        int stt = 1;
        dgrid_undoneOrder.ColumnCount = 3;
        dgrid_undoneOrder.Columns[0].Name = "STT";
        dgrid_undoneOrder.Columns[1].Name = "Mã hóa đơn";
        dgrid_undoneOrder.Columns[2].Name = "Tên khách hàng";
        dgrid_undoneOrder.Rows.Clear(); ;

        foreach (var x in _billService.GetAll().Where(c => c.Status == 0))
        {
            dgrid_undoneOrder.Rows.Add(stt++, x.Ma, x.CustomerName);
        }
    }

    //load giỏ hàng
    private void LoadGioHang()
    {
        int stt = 1;
        dgrid_orderDetail.ColumnCount = 6;
        dgrid_orderDetail.Columns[0].Name = "STT";
        dgrid_orderDetail.Columns[1].Name = "Mã CTHĐ";
        dgrid_orderDetail.Columns[2].Name = "Mã sản phẩm";
        dgrid_orderDetail.Columns[3].Name = "Tên sản phẩm";
        dgrid_orderDetail.Columns[4].Name = "Số lượng";
        dgrid_orderDetail.Columns[5].Name = "Đơn giá";
        dgrid_orderDetail.Columns[1].Visible = false;
        dgrid_orderDetail.Rows.Clear();

        dgrid_orderDetail.Columns[0].Width = 35;
        dgrid_orderDetail.Columns[2].Width = 70;

        foreach (var x in lstHdCt)
        {
            dgrid_orderDetail.Rows.Add(stt++, x.Ma, x.MaShoes, x.ShoesName, x.Quantity, x.UnitPrice);
        }
    }

    //tổng tiền
    private void TotalCart()
    {
        if (lstHdCt != null)
        {
            int total = 0;
            foreach (var x in lstHdCt)
            {
                total += Convert.ToInt32(x.UnitPrice) * x.Quantity;
            }
            lbl_totalcart.Text = total.ToString();
            //lbl_tongtien.Text = total.ToString();
        }
        else
        {
            lbl_totalcart.Text = "";
            //lbl_tongtien.Text = "";
        }
    }

    //thêm sản phẩm vào giỏ hàng
    private void AddProductToCart(string ma)
    {
        var giay = _shoesService.GetAll().FirstOrDefault(c => c.Ma == ma);
        var data = lstHdCt.FirstOrDefault(c => c.Ma == giay.Ma);
        int soluong = 0;
        using FrmSoLuong frmSoLuong = new();
        if (frmSoLuong.ShowDialog() == DialogResult.OK)
        {
            soluong = frmSoLuong.SoLuong;
        }
        BillDetailView hoaDonctView = new()
        {
            Ma = "HDCT" + Utility.GetNumber(9),
            MaShoes = giay.Ma,
            ShoesName = giay.Name,
            Quantity = soluong,
            UnitPrice = giay.SalePrice,
        };
        lstHdCt.Add(hoaDonctView);
        MessageBox.Show("Thêm sản phẩm thành công", "Thông báo");
        TotalCart();
        LoadGioHang();
        LoadHoaDonCho();
    }

    //thêm sản phẩm vào giỏ hàng
    private void dgrid_productDetail_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && e.RowIndex <= dgrid_productDetail.RowCount - 1)
        {
            maCtGiay = dgrid_productDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
            AddProductToCart(maCtGiay);
            TotalCart();
        }
        else return;
    }


    private void dgrid_orderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && e.RowIndex <= dgrid_orderDetail.RowCount - 1)
        {
            maCtGiay = dgrid_orderDetail.Rows[e.RowIndex].Cells[2].Value.ToString();
            maCtHoaDon = dgrid_orderDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        else return;
    }

    //thay đổi số lượng ở giỏ hàng
    private void dgrid_orderDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow r = dgrid_orderDetail.Rows[e.RowIndex];
            if (int.TryParse(dgrid_orderDetail.Rows[r.Index].Cells[4].Value.ToString(), out int x))
            {
                if (dgrid_orderDetail.Rows[r.Index].Cells[4].Value != lstHdCt[r.Index].Quantity.ToString())
                {
                    if (Convert.ToInt32(dgrid_orderDetail.Rows[r.Index].Cells[4].Value) <= 0)
                    {
                        MessageBox.Show("Nhập sai số lượng");
                        dgrid_orderDetail.Rows[r.Index].Cells[4].Value = lstHdCt[r.Index].Quantity;
                    }
                    else
                    {
                        var p = _shoesService.GetAll().FirstOrDefault(x => x.Ma == lstHdCt[r.Index].MaShoes);
                        if (p.Stock < Convert.ToInt32(dgrid_orderDetail.Rows[r.Index].Cells[4].Value))
                        {
                            MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                            dgrid_orderDetail.Rows[r.Index].Cells[4].Value = lstHdCt[r.Index].Quantity;
                        }
                        else
                        {
                            lstHdCt[r.Index].Quantity = Convert.ToInt32(dgrid_orderDetail.Rows[r.Index].Cells[4].Value);
                            TotalCart();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập sai số lượng");
                dgrid_orderDetail.Rows[r.Index].Cells[4].Value = lstHdCt[r.Index].Quantity;
            }
        }
        else return;
    }

    //thanh toán
    private void btn_pay_Click(object sender, EventArgs e)
    {
        if (txt_maOrder.Text != "")
        {
            BillView hoadon = _billService.GetAll().FirstOrDefault(c => c.Ma.Equals(txt_maOrder.Text) && c.Status == 0);
            if (hoadon == null)
            {
                MessageBox.Show("Đơn hàng không tồn tại hoặc đã thanh toán");
                lbl_orderTotal.Text = "0";
            }
            else
            {
                var khachhang = _customerService.GetAll().FirstOrDefault(c => c.Ma == hoadon.MaKh);
                int x;

                if (Convert.ToDecimal(lbl_change.Text) < 0 || txt_customerGive.Text == "" || !int.TryParse(txt_customerGive.Text, out int y) || y < 0)
                {
                    MessageBox.Show("Vui lòng nhập đúng số tiền");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thanh toán không?", "Thanh toán", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        hoadon.DateofPayment = DateTime.Now;
                        hoadon.Status = 1;
                        _billService.Update(hoadon);
                        MessageBox.Show("Thanh toán thành công");
                        txt_maOrder.Text = "";
                        txt_customerGive.Text = "";
                        lbl_orderTotal.Text = "0";
                        lbl_change.Text = "0";
                        rtxt_note.Text = "";
                        LoadHoaDonCho();
                        lstHdCt = new List<BillDetailView>();
                        LoadGioHang();
                    }
                }
            }
        }
        else
        {
            MessageBox.Show("Vui lòng chọn hóa đơn");
        }
    }

    //nhập tiền khách đưa -> tiền trả
    private void txt_customerGive_TextChanged(object sender, EventArgs e)
    {
        if (!(txt_customerGive.Text == ""))
        {
            if (decimal.TryParse(txt_customerGive.Text, out decimal _))
            {
                lbl_change.Text = (Convert.ToDecimal(txt_customerGive.Text) - Convert.ToDecimal(lbl_orderTotal.Text)).ToString();
            }
        }
    }

    //xóa sản phẩm khỏi giỏ hàng
    private void btn_deleteProduct_Click(object sender, EventArgs e)
    {
        if (lstHdCt.Any())
        {
            var item = lstHdCt.FirstOrDefault(x => x.MaShoes == maCtGiay);
            lstHdCt.Remove(item);
            LoadGioHang();
            TotalCart();
        }
        else
        {
            MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
        }
    }

    //xóa giỏ hàng click
    private void btn_deleteCart_Click(object sender, EventArgs e)
    {
        if (lstHdCt.Any())
        {
            lstHdCt = new List<BillDetailView>();
            LoadGioHang();
        }
        else
        {
            MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
        }
    }

    //thêm hóa đơn click 
    private void btn_addOrder_Click(object sender, EventArgs e)
    {
        if (cmb_staff.SelectedIndex == -1)
        {
            MessageBox.Show("bạn chưa chọn nhân vien");
        }
        else
        {
            if (lstHdCt.Any())
            {
                string maNhanvien = _staffService.GetAll().FirstOrDefault(c => c.PhoneNumber == cmb_staff.Text).Ma;
                khachHang = _customerService.GetAll().FirstOrDefault(c => c.PhoneNumber == cmb_customerPhoneNumber.Text);
                if (khachHang != null)
                {
                    BillView hoadon = new()
                    {
                        Ma = "HD" + Utility.GetNumber(8),
                        DateofCreation = DateTime.Now,
                        MaNv = maNhanvien,
                        MaKh = khachHang.Ma,
                        Status = 0,
                        CustomerName = khachHang.LastName + khachHang.MiddleName + khachHang.FirstName,
                        TotalCost = Convert.ToDecimal(lbl_totalcart.Text),
                    };
                    _billService.Add(hoadon);
                    foreach (var item in lstHdCt)
                    {
                        item.MaBill = hoadon.Ma;
                        _billDetailService.Add(item);
                        var sp = _shoesService.GetAll().FirstOrDefault(c => c.Ma == item.MaShoes);
                        sp.Stock -= item.Quantity;
                        _shoesService.Update(sp);
                    }
                    cmb_customerPhoneNumber.Text = "";
                    lbl_totalcart.Text = "";
                    cmb_staff.Text = "";
                    MessageBox.Show($"Tạo hóa đơn thành công. ID: {hoadon.Ma}");
                    LoadSanPham();
                    LoadHoaDonCho();
                    lstHdCt = new List<BillDetailView>();
                    dgrid_orderDetail.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }
    }

    //cập nhật hóa đơn click 
    private void btn_updateOrder_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(maHd))
        {
            if (lstHdCt.Any())
            {
                khachHang = _customerService.GetAll().FirstOrDefault(c => c.PhoneNumber == cmb_customerPhoneNumber.Text);
                if (khachHang != null)
                {
                    var hoadon = _billService.GetAll().FirstOrDefault(c => c.Ma == maHd);
                    var hdct = _billDetailService.GetAll(_billService.GetId(hoadon.Ma));
                    foreach (var item in hdct)
                    {
                        item.MaBill = hoadon.Ma;
                        _billDetailService.Delete(item);
                    }
                    foreach (var item in lstHdCt)
                    {
                        item.MaBill = hoadon.Ma;
                        _billDetailService.Add(item);
                        var sp = _shoesService.GetAll().FirstOrDefault(c => c.Ma == item.MaShoes);
                        sp.Stock -= item.Quantity;
                        _shoesService.Update(sp);
                    }
                    string maNhanvien = _staffService.GetAll().FirstOrDefault(c => c.PhoneNumber == cmb_staff.Text).Ma;
                    hoadon.DateofCreation = DateTime.Now;
                    hoadon.MaNv = maNhanvien;
                    hoadon.MaKh = khachHang.Ma;
                    hoadon.TotalCost = Convert.ToDecimal(lbl_totalcart.Text);
                    _billService.Update(hoadon);

                    cmb_customerPhoneNumber.Text = "";
                    lbl_totalcart.Text = "";
                    MessageBox.Show($"Cập nhật hóa đơn thành công. ID: {hoadon.Ma}");
                    maHd = "";
                    LoadSanPham();
                    LoadHoaDonCho();
                    dgrid_orderDetail.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập khách hàng");
                }
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }
        else
        {
            MessageBox.Show("Vui lòng chọn hóa đơn chưa thanh toán");
        }
    }

    //chọn đơn hàng đang xử lí
    private void dgrid_undoneOrder_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && e.RowIndex < dgrid_undoneOrder.RowCount - 1)
        {
            DataGridViewRow r = dgrid_undoneOrder.Rows[e.RowIndex];
            maHd = r.Cells[1].Value.ToString();
            var hoadonview = _billService.GetAll().FirstOrDefault(c => c.Ma == maHd);
            var hoadonchitiet = _billDetailService.GetAll(_billService.GetId(hoadonview.Ma));
            txt_maOrder.Text = hoadonview.Ma;
            cmb_customerPhoneNumber.Text = _customerService.GetAll().FirstOrDefault(c => c.Ma == hoadonview.MaKh).PhoneNumber;
            cmb_staff.Text = _staffService.GetAll().FirstOrDefault(c => c.Ma == hoadonview.MaNv).PhoneNumber;

            lstHdCt = new List<BillDetailView>();
            foreach (var item in hoadonchitiet)
            {
                var sp = _shoesService.GetAll().FirstOrDefault(c => c.Ma == item.MaShoes);
                BillDetailView hdct = new BillDetailView()
                {
                    MaShoes = item.MaShoes,
                    ShoesName = sp.Name,
                    UnitPrice = sp.SalePrice,
                    Quantity = hoadonchitiet.FirstOrDefault(c => c.MaShoes == sp.Ma).Quantity,
                };
                lstHdCt.Add(hdct);
                LoadGioHang();
            }
            TotalCart();
            lbl_orderTotal.Text = lbl_totalcart.Text;
        }
        else return;
    }
}
