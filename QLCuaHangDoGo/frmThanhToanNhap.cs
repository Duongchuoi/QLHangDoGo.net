using Microsoft.Reporting.WinForms;
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
    public partial class frmThanhToanNhap : Form
    {
        private List<frmTaoPhieuNhap.SanPham1> selectedItem;

        public frmThanhToanNhap(List<frmTaoPhieuNhap.SanPham1> item)
        {
            InitializeComponent();
            selectedItem = item;
        }
        KetNoi kn = new KetNoi();

        public frmThanhToanNhap(List<SanPham1> danhSachSanPhamDaChon)
        {
            this.danhSachSanPhamDaChon = sanPhamDuocChon;
        }
       
        private List<frmTaoPhieuNhap.SanPham1> danhSachSanPhamDaChon;
        private List<frmTaoPhieuNhap.SanPham1> sanPhamDuocChon;
        private void frmThanhToanNhap_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            
        }
        private void LoadSanPham()
        {
            // Tạo một DataTable mới để chứa thông tin sản phẩm đã chọn
            DataTable dataTable = new DataTable(); 
            dataTable.Columns.Add("MaMH", typeof(int));
            dataTable.Columns.Add("TenMH", typeof(string));
            dataTable.Columns.Add("SoLuong", typeof(int));
            dataTable.Columns.Add("DonGia", typeof(int));
          
            // Lặp qua danh sách sản phẩm đã chọn và thêm thông tin vào DataTable
            foreach (var item in selectedItem)
            {
                

                // Tạo một DataRow mới cho mỗi sản phẩm và thêm vào DataTable
                DataRow newRow = dataTable.NewRow();
                newRow["MaMH"] = item.MaMH;
                newRow["TenMH"] = item.TenMH; // Giả sử 'TenSanPham' là tên trường chứa tên sản phẩm
                newRow["SoLuong"] = item.SoLuong; // Giả sử 'SoLuong' là tên trường chứa số lượng sản phẩm
                newRow["DonGia"] = item.DonGia; // Giả sử 'DonGia' là tên trường chứa đơn giá sản phẩm
              
                dataTable.Rows.Add(newRow);
            }

            // Gán dữ liệu vào report
            rpThanhToanNhap.Reset(); // Đặt lại ReportViewer trước khi gắn dữ liệu
            ReportDataSource rds = new ReportDataSource("DataSet1", dataTable); // "DataSet1" là tên dataset trong report
            rpThanhToanNhap.LocalReport.DataSources.Add(rds);
            rpThanhToanNhap.LocalReport.ReportEmbeddedResource = "QLCuaHangDoGo.Report7.rdlc"; // Thay thế bằng tên file report của bạn

            rpThanhToanNhap.RefreshReport();
        }
        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thanh toán hàng nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int maNcc = 0;
            if (result == DialogResult.Yes)
            {
                int maPn = kn.TaoPhieuNhap();
                if (maPn > 0)
                {
                    foreach (var item in selectedItem)
                    {

                        kn.CapNhatSoLuongSanPhamNhap(item.MaMH, item.SoLuong);
                        kn.ThemSanPhamVaoHoaDon(maPn, item.MaMH, item.SoLuong, item.DonGia);
                    }
                }
                // Duyệt qua các sản phẩm đã chọn và cập nhật số lượng
                
                

                MessageBox.Show("Đã Thanh Toán Đơn Hàng");
             
                // Sau khi cập nhật số lượng, bạn có thể làm một số việc khác ở đây

                //Tao phieu nhap moi

            }

            
            else
            {
                // Người dùng chọn không thanh toán
                // Bạn có thể thực hiện một số hành động khác ở đây
            }
        }
        public class SanPham1

        {
        }
    }
}
