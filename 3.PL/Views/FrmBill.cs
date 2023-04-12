using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Utilities;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Printing;

using System.Windows.Forms;
using System.Xml.Linq;



namespace _3.PL.Views;

public partial class FrmBill : Form
{
    private IBillService _billService;
    private IBillDetailService _billDetailService;
    private string maHoadon;
    private List<BillDetailView> lstBill;
    private int stt = 1;
    public FrmBill()
    {
        InitializeComponent();
        _billService = new BillService();
        _billDetailService = new BillDetailService();
        LoadDgridBill();
        SetupBillDetailDrgid();
    }

    private void LoadDgridBill()
    {
        int stt = 1;
        dgrid_bill.ColumnCount = 8;
        dgrid_bill.Columns[0].Name = "STT";
        dgrid_bill.Columns[1].Name = "Mã";
        dgrid_bill.Columns[2].Name = "Ngày tạo";
        dgrid_bill.Columns[3].Name = "Ngày thanh toán";
        dgrid_bill.Columns[4].Name = "Khách hàng";
        dgrid_bill.Columns[5].Name = "Nhân viên";
        dgrid_bill.Columns[6].Name = "Trạng thái";
        dgrid_bill.Rows.Clear();

        foreach (var x in _billService.GetAll())
        {
            dgrid_bill.Rows.Add(stt++, x.Ma, x.DateofCreation, x.DateofPayment, x.CustomerName, x.StaffName, Utility.TrangThaiHoaDon()[x.Status]);
        }
    }
    private void SetupBillDetailDrgid()
    {
        dgrid_billdetail.ColumnCount = 7;
        dgrid_billdetail.Columns[0].Name = "STT";
        dgrid_billdetail.Columns[1].Name = "Mã";
        dgrid_billdetail.Columns[2].Name = "Tên sản phẩm";
        dgrid_billdetail.Columns[3].Name = "Đơn giá";
        dgrid_billdetail.Columns[4].Name = "Số lượng";
        dgrid_billdetail.Columns[5].Name = "Thành tiền";
        dgrid_billdetail.Columns[6].Name = "Trạng thái";
    }
    private void btn_printBill_Click(object sender, EventArgs e)
    {
        if (dgrid_bill.Rows.Count > 0)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Output.pdf";
            bool fileError = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi:" + ex.Message);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        PdfPTable pdfTable = new PdfPTable(dgrid_bill.Columns.Count);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        foreach (DataGridViewColumn column in dgrid_bill.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            pdfTable.AddCell(cell);
                        }

                        foreach (DataGridViewRow row in dgrid_bill.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(cell.Value.ToString());
                            }
                        }

                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();
                            stream.Close();
                        }

                        MessageBox.Show("Dữ liệu Export thành công!!!", "Info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mô tả lỗi :" + ex.Message);
                    }
                }
            }
        }
        else
        {
            MessageBox.Show("Không có bản ghi nào được Export!!!", "Info");
        }
    }

    private void dgrid_bill_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && e.RowIndex <= dgrid_bill.RowCount - 1)
        {
            maHoadon = dgrid_bill.Rows[e.RowIndex].Cells[1].Value.ToString();
            lstBill = _billDetailService.ShowHoadonChitiet(_billService.GetId(maHoadon));
            foreach (var x in lstBill)
            {
                dgrid_billdetail.Rows.Add(stt++, x.Ma, x.ShoesName, x.UnitPrice, x.Quantity, x.Total, x.Status);
            }
        }
        else return;
    }
}

