using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDoGo
{
    
    public partial class frmQuanLyNhanVien : Form
    {
        KetNoi kn = new KetNoi();
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        public void getData()
        {
            string query = "select * from NhanVien";
            DataSet ds = kn.LayDuLieu(query);
            dg.DataSource = ds.Tables[0];
        }
        public void getCV()
        {
            string query = "select * from ChucVu";
            DataSet ds = kn.LayDuLieu(query);
            cbChucVu.DataSource = ds.Tables[0];
            cbChucVu.DisplayMember = "TenCV";
            cbChucVu.ValueMember = "MaCV";

        }
        public void clearText()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cbChucVu.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtGioitinh.Text = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            txtMaNV.Enabled = true;
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            getCV();
            getData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into NhanVien values( '{0}',N'{1}', '{2}',N'{3}',N'{4}','{5}',N'{6}')",
                    txtMaNV.Text,
                    txtTenNV.Text,
                    cbChucVu.SelectedValue,
                    txtDiaChi.Text,
                    txtSoDienThoai.Text,
                    dtpNgaySinh.Value.Date,
                    txtGioitinh.Text
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
            string query = string.Format("update NhanVien set TenNV = N'{1}', MaCV = '{2}', DiaChi = N'{3}', SDT = N'{4}', NgaySinh = '{5}', Gioitinh = N'{6}' where MaNV = {0}",
                    txtMaNV.Text,
                    txtTenNV.Text,
                    cbChucVu.SelectedValue,
                    txtDiaChi.Text,
                    txtSoDienThoai.Text,
                    dtpNgaySinh.Value.Date,
                    txtGioitinh.Text
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

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaNV.Enabled = false;
                txtMaNV.Text = dg.Rows[r].Cells["MaNV"].Value.ToString();
                txtTenNV.Text = dg.Rows[r].Cells["TenNV"].Value.ToString();
                cbChucVu.SelectedValue = dg.Rows[r].Cells["MaCV"].Value.ToString();
                txtDiaChi.Text = dg.Rows[r].Cells["DiaChi"].Value.ToString();
                txtSoDienThoai.Text = dg.Rows[r].Cells["SDT"].Value.ToString();
                dtpNgaySinh.Text = dg.Rows[r].Cells["NgaySinh"].Value.ToString();
                txtGioitinh.Text = dg.Rows[r].Cells["GioiTinh"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete from NhanVien where MaNV = '{0}'",
                     txtMaNV.Text
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maNhanVienTimKiem = txtTimKiem.Text; // Lấy mã sản phẩm từ TextBox tìm kiếm

            if (string.IsNullOrWhiteSpace(maNhanVienTimKiem))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần tìm kiếm.");
                return;
            }

            string query = string.Format("SELECT * FROM NhanVien WHERE MaNV like '%{0}%'", maNhanVienTimKiem);

            DataTable resultTable = kn.LayDuLieuu(query);

            if (resultTable.Rows.Count > 0)
            {
                MessageBox.Show("Đã tìm thấy kết quả!");
                // Hiển thị kết quả tìm kiếm trong DataGridView hoặc bất kỳ cách nào bạn muốn
                dg.DataSource = resultTable;
                

            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên với mã nhân viên này.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtGioitinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getData();
        }
    }
}
