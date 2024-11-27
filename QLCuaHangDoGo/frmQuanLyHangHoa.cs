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
    public partial class frmQuanLyHangHoa : Form
    {
        public frmQuanLyHangHoa()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void getData()
        {
            string query = "select * from MatHang";
            DataSet ds = kn.LayDuLieu(query);
            dg.DataSource = ds.Tables[0];
        }
        public void getNCC()
        {
            string query = "select * from NhaCungCap";
            DataSet ds = kn.LayDuLieu(query);
            cbNCC.DataSource = ds.Tables[0];
            cbNCC.DisplayMember = "TenNCC";
            cbNCC.ValueMember = "MaNCC";

        }
        public void clearText()
        {
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            cbNCC.Text = "";
            txtSoLuong.Text = "";
            txtDVT.Text = "";
            txtLoai.Text = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            txtMaHH.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into MatHang values( '{0}',N'{1}', '{2}','{3}',N'{4}','N{5}')",
                    txtMaHH.Text,
                    txtTenHH.Text,
                    cbNCC.SelectedValue,
                    txtSoLuong.Text,
                    txtDVT.Text,
                    txtLoai.Text
                );
            int r = kn.ThucThi(query);
            if (r > 0)
            {
                MessageBox.Show("Thêm Thành Công!");
                getData();
            }
            else MessageBox.Show("Thêm Thất Bại");
        }

        private void frmQuanLyHangHoa_Load(object sender, EventArgs e)
        {
            getNCC();
            getData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update MatHang set TenMH = N'{1}', MaNCC = '{2}', SoLuong = '{3}', DVT = N'{4}', Loai = N'{5}' where MaMH = {0}",
                    txtMaHH.Text,
                    txtTenHH.Text,
                    cbNCC.SelectedValue,
                    txtSoLuong.Text,
                    txtDVT.Text,
                    txtLoai.Text
                );
            int r = kn.ThucThi(query);
            if (r > 0)
            {
                MessageBox.Show("Sửa thành công");
                getData();
                clearText();
            }
            else MessageBox.Show("Sửa thất bại");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete from NhanVien where MaMH = '{0}'",
                     txtMaHH.Text
                    );
            int r = kn.ThucThi(query);
            if (r > 0)
            {
                MessageBox.Show("Xoa thanh cong");
                getData();
                clearText();
            }
            else
                MessageBox.Show("Xoa that bai");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaHH.Enabled = false;
                txtMaHH.Text = dg.Rows[r].Cells["MaMH"].Value.ToString();
                txtTenHH.Text = dg.Rows[r].Cells["TenMH"].Value.ToString();
                cbNCC.SelectedValue = dg.Rows[r].Cells["MaNCC"].Value.ToString();
                txtSoLuong.Text = dg.Rows[r].Cells["SoLuong"].Value.ToString();
                txtDVT.Text = dg.Rows[r].Cells["DVT"].Value.ToString();
                txtLoai.Text = dg.Rows[r].Cells["Loai"].Value.ToString();
            }
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maSanPhamTimKiem = txtTimKiem.Text; // Lấy mã sản phẩm từ TextBox tìm kiếm

            if (string.IsNullOrWhiteSpace(maSanPhamTimKiem))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm cần tìm kiếm.");
                return;
            }

            string query = string.Format("SELECT * FROM MatHang WHERE MaMH like '%{0}%'",maSanPhamTimKiem);

            DataTable resultTable = kn.LayDuLieuu(query);

            if (resultTable.Rows.Count > 0)
            {
                MessageBox.Show("Đã tìm thấy kết quả!");
                // Hiển thị kết quả tìm kiếm trong DataGridView hoặc bất kỳ cách nào bạn muốn
                dg.DataSource = resultTable;
                await Task.Delay(600);
                
               
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm với mã sản phẩm này.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getData();
        }
    }
}
