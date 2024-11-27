using QLCuaHangDoGo.Thống_kê___Báo_cáo;
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
    public partial class frmDatHang : Form
    {
        public frmDatHang()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void getData()
        {
            string query = "select * from MatHang";
            DataSet ds = kn.LayDuLieu(query);
            dgMatHang.DataSource = ds.Tables[0];

        }
        private void HideAllOpenForms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Hide();
            }
        }
        public void clearText()
        {
            cbMatHang.Text = "";
            numSoLuong.Text = "";
        }
        public void getCV()
        {
            string query = "select * from MatHang";
            DataSet ds = kn.LayDuLieu(query);
            cbMatHang.DataSource = ds.Tables[0];
            cbMatHang.DisplayMember = "TenMH";
            cbMatHang.ValueMember = "MaMH";

        }
        private void frmDatHang_Load(object sender, EventArgs e)
        {
            getData();
           
            getCV();
        }
        public void hienthids()
        {
            string query = "Select * from MatHang";
            DataSet ds = kn.LayDuLieu(query);
            dgMatHang.DataSource = ds.Tables[0];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
          
            // Lấy thông tin sản phẩm đã chọn từ DataGridView và ComboBox
            int rowIndex = dgMatHang.CurrentCell.RowIndex;
            string selectedProductId = dgMatHang.Rows[rowIndex].Cells["MaMH"].Value.ToString();
            string selectedProductName = dgMatHang.Rows[rowIndex].Cells["TenMH"].Value.ToString();
            int selectedQuantity = (int)numSoLuong.Value;          
            //Đổi kiểu
            int selectedUnitPrice = Convert.ToInt32(dgMatHang.Rows[rowIndex].Cells["DonGia"].Value);

            //kiem tra vuot qua so luong
            var soLuongSanCo = ((dgMatHang.SelectedRows[0].DataBoundItem as DataRowView).Row[3]) as int? ?? 0;
            if (selectedQuantity > soLuongSanCo)
            {
                MessageBox.Show("So luong vuot qua, vui long thu lai");
                return;
            }
            // Tạo đối tượng sản phẩm đã chọn
            SanPham sanPhamDuocChon = new SanPham
            {
                MaMH = selectedProductId,
                TenMH = selectedProductName,
                SoLuong = selectedQuantity,
                DonGia = selectedUnitPrice,
            };

            

            // Kiểm tra nếu sản phẩm chưa có trong danh sách đã chọn thì thêm vào
            if (!danhSachSanPhamDaChonBinding.Any(sp => sp.MaMH == sanPhamDuocChon.MaMH))
            {
                danhSachSanPhamDaChonBinding.Add(sanPhamDuocChon);

                // Cập nhật dữ liệu trong DataGridView
                dgDanhSach.DataSource = null;
                dgDanhSach.DataSource = danhSachSanPhamDaChonBinding;
            }
        }
        public class SanPham
        {
            public string MaMH { get; set; }
            public string TenMH { get; set; }
            public int SoLuong { get; set; }
            public int DonGia { get; set; }
      
        }
        private void dgMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                cbMatHang.SelectedValue = dgMatHang.Rows[r].Cells["MaMH"].Value.ToString();
            }
        }
        private List<SanPham> danhSachSanPhamDaChon = new List<SanPham>();
        private List<SanPham> danhSachSanPhamDaChonBinding = new List<SanPham>();
        private void btnNhapHang_Click(object sender, EventArgs e)
        {           
            HideAllOpenForms();
            frmThanhToan frm = new frmThanhToan(danhSachSanPhamDaChonBinding);
            frm.ShowDialog();

            danhSachSanPhamDaChon.Clear();
            danhSachSanPhamDaChonBinding.Clear();

            hienthids();
        }

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count = dgDanhSach.SelectedRows.Count;
            while (count > 0)
            {
                var current = dgDanhSach.SelectedRows[0];
                danhSachSanPhamDaChonBinding.Remove(current.DataBoundItem as SanPham);
                count--;

            }
            dgDanhSach.DataSource = danhSachSanPhamDaChonBinding;
            dgDanhSach.ClearSelection();
            dgDanhSach.Refresh();
            dgDanhSach.RefreshEdit();
                    //dgDanhSach.Rows.RemoveAt(.Index);

            
        }

        private void cbMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
