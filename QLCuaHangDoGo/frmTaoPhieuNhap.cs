using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDoGo
{
    public partial class frmTaoPhieuNhap : Form
    {
        public frmTaoPhieuNhap()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void getData1()
        {
            string query = "select * from GioHang";
            DataSet ds = kn.LayDuLieu(query);
            dgMatHangNhap.DataSource = ds.Tables[0];

        }       
        public void clearText()
        {
            cbMatHang.Text = "";
            numSoLuong.Text = "";
        }
        public void getCV()
        {
            string query = "select * from GioHang";
            DataSet ds = kn.LayDuLieu(query);
            cbMatHang.DataSource = ds.Tables[0];
            cbMatHang.DisplayMember = "TenMH";
            cbMatHang.ValueMember = "MaMH";

        }
        private void frmTaoPhieuNhap_Load(object sender, EventArgs e)
        {
            getData1();
            
            getCV();
        }
        private void HideAllOpenForms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Hide();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           

            // Lấy thông tin sản phẩm đã chọn từ DataGridView và ComboBox
            int rowIndexx = dgMatHangNhap.CurrentCell.RowIndex;
            string selectedProductId = dgMatHangNhap.Rows[rowIndexx].Cells["MaMH"].Value.ToString();
            string selectedProductName = dgMatHangNhap.Rows[rowIndexx].Cells["TenMH"].Value.ToString();
            int selectedQuantity = (int)numSoLuong.Value;
            //Đổi kiểus
            int selectedUnitPrice = Convert.ToInt32(dgMatHangNhap.Rows[rowIndexx].Cells["DonGia"].Value);

            //Kiểm tra vượt quá số lượng 
            var item = (dgMatHangNhap.SelectedRows[0].DataBoundItem as DataRowView);
            var soLuongSanCo = (item.Row[2]) as int? ?? 0;
            if (selectedQuantity > soLuongSanCo)
            {
                MessageBox.Show("So luong vuot qua, vui long thu lai");
                return;
            }
            // Tạo đối tượng sản phẩm đã chọnm
            SanPham1 sanPhamDuocChon = new SanPham1
            {
                MaMH = selectedProductId,
                TenMH = selectedProductName,
                SoLuong = selectedQuantity,
                DonGia = selectedUnitPrice,
            };

            // Kiểm tra nếu sản phẩm chưa có trong danh sách đã chọn thì thêm vào
            /* if (!danhSachSanPhamDaChon.Any(sp => sp.MaMH == sanPhamDuocChon.MaMH))
             {
                 danhSachSanPhamDaChon.Add(sanPhamDuocChon);

                 // Cập nhật dữ liệu trong DataGridView
                 dgDanhSachNhap.DataSource = null;
                 dgDanhSachNhap.DataSource = danhSachSanPhamDaChon;
             }*/
            if (!danhSachSanPhamDaChonBinding.Any(sp => sp.MaMH == sanPhamDuocChon.MaMH))
            {
                danhSachSanPhamDaChonBinding.Add(sanPhamDuocChon);

                // Cập nhật dữ liệu trong DataGridView
                dgDanhSachNhap.DataSource = null;
                dgDanhSachNhap.DataSource = danhSachSanPhamDaChonBinding;
            }
        }

        //private void dgMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int r = e.RowIndex;
        //    if (r >= 0)
        //    {
        //        cbMatHang.SelectedValue = dgMatHangNhap.Rows[r].Cells["MaMH"].Value.ToString();
        //    }
        //}

        private void btnNhapHang_Click(object sender, EventArgs e)
        {


            HideAllOpenForms();
            frmThanhToanNhap frm = new frmThanhToanNhap(danhSachSanPhamDaChonBinding);
            frm.ShowDialog();

            danhSachSanPhamDaChon.Clear();
            danhSachSanPhamDaChonBinding.Clear();

            getData1();
            /*frmThanhToanNhap frm = new frmThanhToanNhap(danhSachSanPhamDaChon);
            frm.Show();*/
        }
        private List<SanPham1> danhSachSanPhamDaChon = new List<SanPham1>();
        private List<SanPham1> danhSachSanPhamDaChonBinding = new List<SanPham1>();
        public class SanPham1
        {
            public string MaMH { get; set; }
            public string TenMH { get; set; }
            public int SoLuong { get; set; }
            public int DonGia { get; set; }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            /* string query = $"DELETE FROM #TEMP_DanhSach WHERE MaMH = '{cbMatHang.SelectedValue}'";
             kn.ThucThi(query);*/
            int count = dgDanhSachNhap.SelectedRows.Count;
            while (count > 0)
            {
                var current = dgDanhSachNhap.SelectedRows[0];
                danhSachSanPhamDaChonBinding.Remove(current.DataBoundItem as SanPham1);
                count--;

            }
            dgDanhSachNhap.DataSource = danhSachSanPhamDaChonBinding;
            dgDanhSachNhap.ClearSelection();
            dgDanhSachNhap.Refresh();
            dgDanhSachNhap.RefreshEdit();

        }
        private void dgDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                cbMatHang.SelectedValue = dgMatHangNhap.Rows[r].Cells["MaMH"].Value.ToString();
            }
        }


 
    }
}
