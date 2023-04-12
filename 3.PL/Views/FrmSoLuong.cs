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
public partial class FrmSoLuong : Form
{
    public int SoLuong;

    public FrmSoLuong()
    {
        InitializeComponent();
    }

    private bool Check(string TxtValue)
    {
        if (TxtValue == "")
        {
            MessageBox.Show("Không được để trống", "Cảnh báo");
            return false;
        }
        bool x = int.TryParse(TxtValue, out _);
        if (x == false)
        {
            MessageBox.Show("Hãy nhập đúng định dạng cho số lượng", "Cảnh báo");
            return false;
        }
        return true;
    }

    private void btn_them_Click(object sender, EventArgs e)
    {
        if (Check(txt_soluong.Text))
        {
            SoLuong = Convert.ToInt32(txt_soluong.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
