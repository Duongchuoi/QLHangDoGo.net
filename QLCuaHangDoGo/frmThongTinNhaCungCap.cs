using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDoGo.QuanLyNhapHang
{
    public partial class frmThongTinNhaCungCap : Form
    {
        public frmThongTinNhaCungCap()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void getData()
        {
            string query = "select * from NhaCungCap";
            DataSet ds = kn.LayDuLieu(query);
            dg.DataSource = ds.Tables[0];
        }
        public void clearText()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            txtMaNCC.Enabled = true;
        }
        private void frmThongTinNhaCungCap_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into NhaCungCap values( '{0}',N'{1}', N'{2}',N'{3}')",
                    txtMaNCC.Text,
                    txtTenNCC.Text,
                    txtDiaChi.Text,
                    txtSoDienThoai.Text
                );
            int r = kn.ThucThi(query);
            if (r > 0)
            {
                MessageBox.Show("Them thanh cong");
                getData();
            }
            else MessageBox.Show("Them that bai");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update NhaCungCap set TenNCC = N'{1}', DiaChi = N'{2}', SDT = N'{3}' where MaNCC = {0}",
                    txtMaNCC.Text,
                    txtTenNCC.Text,
                    txtDiaChi.Text,
                    txtSoDienThoai.Text
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
            string query = string.Format("delete from NhaCungCap where MaNCC = '{0}'",
                     txtMaNCC.Text
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
                txtMaNCC.Enabled = false;
                txtMaNCC.Text = dg.Rows[r].Cells["MaNCC"].Value.ToString();
                txtTenNCC.Text = dg.Rows[r].Cells["TenNCC"].Value.ToString();
                txtDiaChi.Text = dg.Rows[r].Cells["DiaChi"].Value.ToString();
                txtSoDienThoai.Text = dg.Rows[r].Cells["SDT"].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maNCCTimKiem = txtTimKiem.Text; // Lấy mã sản phẩm từ TextBox tìm kiếm

            if (string.IsNullOrWhiteSpace(maNCCTimKiem))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần tìm kiếm.");
                return;
            }

            string query = string.Format("SELECT * FROM NhaCungCap WHERE MaNCC like '%{0}%'", maNCCTimKiem);

            DataTable resultTable = kn.LayDuLieuu(query);

            if (resultTable.Rows.Count > 0)
            {
                MessageBox.Show("Đã tìm thấy kết quả!");
                // Hiển thị kết quả tìm kiếm trong DataGridView hoặc bất kỳ cách nào bạn muốn
                dg.DataSource = resultTable;


            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên với mã nhà cung cấp này.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
           getData();
        }
    }
}
