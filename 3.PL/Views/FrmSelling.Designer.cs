namespace _3.PL.Views;

partial class FrmSelling
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        groupBox4 = new GroupBox();
        btn_pay = new Button();
        lbl_change = new Label();
        lbl_orderTotal = new Label();
        txt_customerGive = new TextBox();
        txt_maOrder = new TextBox();
        rtxt_note = new RichTextBox();
        label12 = new Label();
        label11 = new Label();
        label10 = new Label();
        label9 = new Label();
        label7 = new Label();
        groupBox3 = new GroupBox();
        txt_searchProduct = new TextBox();
        dgrid_productDetail = new DataGridView();
        groupBox2 = new GroupBox();
        dgrid_undoneOrder = new DataGridView();
        groupBox1 = new GroupBox();
        cmb_staff = new ComboBox();
        label4 = new Label();
        cmb_customerPhoneNumber = new ComboBox();
        lbl_totalcart = new Label();
        label6 = new Label();
        btn_updateOrder = new Button();
        btn_addOrder = new Button();
        btn_deleteCart = new Button();
        btn_deleteProduct = new Button();
        lbl_customerName = new Label();
        label2 = new Label();
        label1 = new Label();
        dgrid_orderDetail = new DataGridView();
        groupBox4.SuspendLayout();
        groupBox3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgrid_productDetail).BeginInit();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgrid_undoneOrder).BeginInit();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgrid_orderDetail).BeginInit();
        SuspendLayout();
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(btn_pay);
        groupBox4.Controls.Add(lbl_change);
        groupBox4.Controls.Add(lbl_orderTotal);
        groupBox4.Controls.Add(txt_customerGive);
        groupBox4.Controls.Add(txt_maOrder);
        groupBox4.Controls.Add(rtxt_note);
        groupBox4.Controls.Add(label12);
        groupBox4.Controls.Add(label11);
        groupBox4.Controls.Add(label10);
        groupBox4.Controls.Add(label9);
        groupBox4.Controls.Add(label7);
        groupBox4.ForeColor = Color.FromArgb(0, 126, 249);
        groupBox4.Location = new Point(888, 405);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(450, 383);
        groupBox4.TabIndex = 23;
        groupBox4.TabStop = false;
        groupBox4.Text = "Thanh toán";
        // 
        // btn_pay
        // 
        btn_pay.Location = new Point(107, 282);
        btn_pay.Name = "btn_pay";
        btn_pay.Size = new Size(219, 37);
        btn_pay.TabIndex = 16;
        btn_pay.Text = "Thanh toán";
        btn_pay.UseVisualStyleBackColor = true;
        btn_pay.Click += btn_pay_Click;
        // 
        // lbl_change
        // 
        lbl_change.AutoSize = true;
        lbl_change.Location = new Point(137, 139);
        lbl_change.Name = "lbl_change";
        lbl_change.Size = new Size(13, 15);
        lbl_change.TabIndex = 20;
        lbl_change.Text = "0";
        // 
        // lbl_orderTotal
        // 
        lbl_orderTotal.AutoSize = true;
        lbl_orderTotal.Location = new Point(137, 63);
        lbl_orderTotal.Name = "lbl_orderTotal";
        lbl_orderTotal.Size = new Size(13, 15);
        lbl_orderTotal.TabIndex = 19;
        lbl_orderTotal.Text = "0";
        // 
        // txt_customerGive
        // 
        txt_customerGive.Location = new Point(137, 97);
        txt_customerGive.Name = "txt_customerGive";
        txt_customerGive.Size = new Size(232, 23);
        txt_customerGive.TabIndex = 18;
        txt_customerGive.TextChanged += txt_customerGive_TextChanged;
        // 
        // txt_maOrder
        // 
        txt_maOrder.Location = new Point(137, 22);
        txt_maOrder.Name = "txt_maOrder";
        txt_maOrder.Size = new Size(232, 23);
        txt_maOrder.TabIndex = 16;
        // 
        // rtxt_note
        // 
        rtxt_note.Location = new Point(137, 172);
        rtxt_note.Name = "rtxt_note";
        rtxt_note.Size = new Size(307, 45);
        rtxt_note.TabIndex = 6;
        rtxt_note.Text = "";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(34, 175);
        label12.Name = "label12";
        label12.Size = new Size(48, 15);
        label12.TabIndex = 5;
        label12.Text = "Ghi chú";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(34, 139);
        label11.Name = "label11";
        label11.Size = new Size(56, 15);
        label11.TabIndex = 4;
        label11.Text = "Tiền thừa";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(34, 100);
        label10.Name = "label10";
        label10.Size = new Size(87, 15);
        label10.TabIndex = 3;
        label10.Text = "Tiền khách đưa";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(34, 63);
        label9.Name = "label9";
        label9.Size = new Size(57, 15);
        label9.TabIndex = 2;
        label9.Text = "Tổng tiền";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(34, 30);
        label7.Name = "label7";
        label7.Size = new Size(71, 15);
        label7.TabIndex = 0;
        label7.Text = "Mã hóa đơn";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(txt_searchProduct);
        groupBox3.Controls.Add(dgrid_productDetail);
        groupBox3.ForeColor = Color.FromArgb(0, 126, 249);
        groupBox3.Location = new Point(12, 405);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(862, 386);
        groupBox3.TabIndex = 24;
        groupBox3.TabStop = false;
        groupBox3.Text = "Danh sách sản phẩm";
        // 
        // txt_searchProduct
        // 
        txt_searchProduct.Location = new Point(6, 22);
        txt_searchProduct.Name = "txt_searchProduct";
        txt_searchProduct.Size = new Size(297, 23);
        txt_searchProduct.TabIndex = 3;
        txt_searchProduct.Text = "Tìm kiếm...";
        // 
        // dgrid_productDetail
        // 
        dgrid_productDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Window;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 126, 249);
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
        dgrid_productDetail.DefaultCellStyle = dataGridViewCellStyle1;
        dgrid_productDetail.Location = new Point(6, 51);
        dgrid_productDetail.Name = "dgrid_productDetail";
        dgrid_productDetail.RowTemplate.Height = 25;
        dgrid_productDetail.Size = new Size(850, 329);
        dgrid_productDetail.TabIndex = 2;
        dgrid_productDetail.CellClick += dgrid_productDetail_CellClick;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(dgrid_undoneOrder);
        groupBox2.ForeColor = Color.FromArgb(0, 126, 249);
        groupBox2.Location = new Point(897, 12);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(441, 380);
        groupBox2.TabIndex = 25;
        groupBox2.TabStop = false;
        groupBox2.Text = "Đơn hàng đang xử lí";
        // 
        // dgrid_undoneOrder
        // 
        dgrid_undoneOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 126, 249);
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgrid_undoneOrder.DefaultCellStyle = dataGridViewCellStyle2;
        dgrid_undoneOrder.Dock = DockStyle.Fill;
        dgrid_undoneOrder.Location = new Point(3, 19);
        dgrid_undoneOrder.Name = "dgrid_undoneOrder";
        dgrid_undoneOrder.RowTemplate.Height = 25;
        dgrid_undoneOrder.Size = new Size(435, 358);
        dgrid_undoneOrder.TabIndex = 1;
        dgrid_undoneOrder.CellClick += dgrid_undoneOrder_CellClick;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(cmb_staff);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(cmb_customerPhoneNumber);
        groupBox1.Controls.Add(lbl_totalcart);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(btn_updateOrder);
        groupBox1.Controls.Add(btn_addOrder);
        groupBox1.Controls.Add(btn_deleteCart);
        groupBox1.Controls.Add(btn_deleteProduct);
        groupBox1.Controls.Add(lbl_customerName);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(dgrid_orderDetail);
        groupBox1.ForeColor = Color.FromArgb(0, 126, 249);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(879, 380);
        groupBox1.TabIndex = 22;
        groupBox1.TabStop = false;
        groupBox1.Text = "Giỏ hàng";
        // 
        // cmb_staff
        // 
        cmb_staff.FormattingEnabled = true;
        cmb_staff.Location = new Point(690, 83);
        cmb_staff.Name = "cmb_staff";
        cmb_staff.Size = new Size(172, 23);
        cmb_staff.TabIndex = 18;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(585, 86);
        label4.Name = "label4";
        label4.Size = new Size(61, 15);
        label4.TabIndex = 17;
        label4.Text = "Nhân viên";
        // 
        // cmb_customerPhoneNumber
        // 
        cmb_customerPhoneNumber.FormattingEnabled = true;
        cmb_customerPhoneNumber.Location = new Point(690, 17);
        cmb_customerPhoneNumber.Name = "cmb_customerPhoneNumber";
        cmb_customerPhoneNumber.Size = new Size(172, 23);
        cmb_customerPhoneNumber.TabIndex = 16;
        // 
        // lbl_totalcart
        // 
        lbl_totalcart.AutoSize = true;
        lbl_totalcart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lbl_totalcart.Location = new Point(112, 248);
        lbl_totalcart.Name = "lbl_totalcart";
        lbl_totalcart.Size = new Size(19, 21);
        lbl_totalcart.TabIndex = 15;
        lbl_totalcart.Text = "0";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label6.Location = new Point(6, 245);
        label6.Name = "label6";
        label6.Size = new Size(83, 21);
        label6.TabIndex = 14;
        label6.Text = "Tổng tiền";
        // 
        // btn_updateOrder
        // 
        btn_updateOrder.Location = new Point(353, 295);
        btn_updateOrder.Name = "btn_updateOrder";
        btn_updateOrder.Size = new Size(110, 30);
        btn_updateOrder.TabIndex = 11;
        btn_updateOrder.Text = "Cập nhật ĐH";
        btn_updateOrder.UseVisualStyleBackColor = true;
        btn_updateOrder.Click += btn_updateOrder_Click;
        // 
        // btn_addOrder
        // 
        btn_addOrder.Location = new Point(237, 295);
        btn_addOrder.Name = "btn_addOrder";
        btn_addOrder.Size = new Size(110, 30);
        btn_addOrder.TabIndex = 10;
        btn_addOrder.Text = "Tạo đơn hàng";
        btn_addOrder.UseVisualStyleBackColor = true;
        btn_addOrder.Click += btn_addOrder_Click;
        // 
        // btn_deleteCart
        // 
        btn_deleteCart.Location = new Point(121, 295);
        btn_deleteCart.Name = "btn_deleteCart";
        btn_deleteCart.Size = new Size(110, 30);
        btn_deleteCart.TabIndex = 9;
        btn_deleteCart.Text = "Xóa giỏ hàng";
        btn_deleteCart.UseVisualStyleBackColor = true;
        btn_deleteCart.Click += btn_deleteCart_Click;
        // 
        // btn_deleteProduct
        // 
        btn_deleteProduct.Location = new Point(5, 295);
        btn_deleteProduct.Name = "btn_deleteProduct";
        btn_deleteProduct.Size = new Size(110, 30);
        btn_deleteProduct.TabIndex = 8;
        btn_deleteProduct.Text = "Xóa sản phẩm";
        btn_deleteProduct.UseVisualStyleBackColor = true;
        btn_deleteProduct.Click += btn_deleteProduct_Click;
        // 
        // lbl_customerName
        // 
        lbl_customerName.AutoSize = true;
        lbl_customerName.Location = new Point(690, 56);
        lbl_customerName.Name = "lbl_customerName";
        lbl_customerName.Size = new Size(16, 15);
        lbl_customerName.TabIndex = 5;
        lbl_customerName.Text = "...";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(585, 56);
        label2.Name = "label2";
        label2.Size = new Size(90, 15);
        label2.TabIndex = 2;
        label2.Text = "Tên khách hàng";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(585, 20);
        label1.Name = "label1";
        label1.Size = new Size(90, 15);
        label1.TabIndex = 1;
        label1.Text = "Sđt Khách hàng";
        // 
        // dgrid_orderDetail
        // 
        dgrid_orderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = SystemColors.Window;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 126, 249);
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgrid_orderDetail.DefaultCellStyle = dataGridViewCellStyle3;
        dgrid_orderDetail.Location = new Point(6, 20);
        dgrid_orderDetail.Name = "dgrid_orderDetail";
        dgrid_orderDetail.RowTemplate.Height = 25;
        dgrid_orderDetail.Size = new Size(562, 212);
        dgrid_orderDetail.TabIndex = 0;
        dgrid_orderDetail.CellClick += dgrid_orderDetail_CellClick;
        dgrid_orderDetail.CellValueChanged += dgrid_orderDetail_CellValueChanged;
        // 
        // FrmSelling
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1350, 800);
        Controls.Add(groupBox4);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FrmSelling";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmSelling";
        groupBox4.ResumeLayout(false);
        groupBox4.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgrid_productDetail).EndInit();
        groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgrid_undoneOrder).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgrid_orderDetail).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox4;
    private Button btn_pay;
    private Label lbl_change;
    private Label lbl_orderTotal;
    private TextBox txt_customerGive;
    private TextBox txt_maOrder;
    private RichTextBox rtxt_note;
    private Label label12;
    private Label label11;
    private Label label10;
    private Label label9;
    private Label label7;
    private GroupBox groupBox3;
    private TextBox txt_searchProduct;
    private DataGridView dgrid_productDetail;
    private GroupBox groupBox2;
    private DataGridView dgrid_undoneOrder;
    private GroupBox groupBox1;
    private ComboBox cmb_staff;
    private Label label4;
    private ComboBox cmb_customerPhoneNumber;
    private Label lbl_totalcart;
    private Label label6;
    private Button btn_updateOrder;
    private Button btn_addOrder;
    private Button btn_deleteCart;
    private Button btn_deleteProduct;
    private Label lbl_customerName;
    private Label label2;
    private Label label1;
    private DataGridView dgrid_orderDetail;
}