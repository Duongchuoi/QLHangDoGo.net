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
    public partial class frmThanhToan : Form
    {
        private List<frmDatHang.SanPham> selectedItems;
        public frmThanhToan(List<frmDatHang.SanPham> items)
        {
            InitializeComponent();
            selectedItems = items;
        }

      /*  public frmThanhToan(List<frmDatHang.SanPham> sanPhamDuocChon)
        {
          *//*  this.danhSachSanPhamDaChon = sanPhamDuocChon;
        }*/
        public frmThanhToan(List<SanPham> danhSachSanPhamDaChon)
        {
            this.danhSachSanPhamDaChon = sanPhamDuocChon;
        }
        KetNoi kn = new KetNoi();
        private List<frmDatHang.SanPham> danhSachSanPhamDaChon;
        private List<frmDatHang.SanPham> sanPhamDuocChon;

        private void frmThanhToan_Load(object sender, EventArgs e)
        {

            LoadSanPham();

        }
        private void LoadSanPham()
        {
           
            DataTable dataTable = new DataTable(); // Tạo một DataTable mới để chứa thông tin sản phẩm đã chọn
            dataTable.Columns.Add("MaMH", typeof(int));
            dataTable.Columns.Add("TenMH",typeof(string));
            dataTable.Columns.Add("SoLuong", typeof(int));
            dataTable.Columns.Add("DonGia", typeof(int));
           // dataTable.Columns.Add("TongTien", typeof(decimal)); // Thêm cột mới cho tổng tiền

            // Lặp qua danh sách sản phẩm đã chọn và thêm thông tin vào DataTable
            foreach (var item in selectedItems)
            {
                // Tạo một DataRow mới cho mỗi sản phẩm và thêm vào DataTable
                DataRow newRow = dataTable.NewRow();
                newRow["MaMH"] = item.MaMH;
                newRow["TenMH"] = item.TenMH; // Giả sử 'TenSanPham' là tên trường chứa tên sản phẩm
                newRow["SoLuong"] = item.SoLuong; // Giả sử 'SoLuong' là tên trường chứa số lượng sản phẩm
                newRow["DonGia"] = item.DonGia; // Giả sử 'DonGia' là tên trường chứa đơn giá sản phẩm
                //newRow["TongTien"] = tongTien; // Giả sử 'TongTien' là tên trường chứa tổng tiền sản phẩm
                dataTable.Rows.Add(newRow);
            }

            // Gán dữ liệu vào report
            rpThanhToan.Reset(); // Đặt lại ReportViewer trước khi gắn dữ liệu
            ReportDataSource rds = new ReportDataSource("DataSet1", dataTable); // "DataSet1" là tên dataset trong report
            rpThanhToan.LocalReport.DataSources.Add(rds);
            rpThanhToan.LocalReport.ReportEmbeddedResource = "QLCuaHangDoGo.Report6.rdlc"; // Thay thế bằng tên file report của bạn

            rpThanhToan.RefreshReport();
        }

        public class SanPham

        {
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Xác nhận thanh toán?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Duyệt qua các sản phẩm đã chọn và cập nhật số lượng
                foreach (var item in selectedItems)
                {
                    kn.CapNhatSoLuongSanPham(item.MaMH, item.SoLuong);
                }
               
                MessageBox.Show("Đã Thanh Toán Đơn Hàng");
                
                // Sau khi cập nhật số lượng, bạn có thể làm một số việc khác ở đây
            }
            
            else
            {
                // Người dùng chọn không thanh toán
                // Bạn có thể thực hiện một số hành động khác ở đây
            }
        }
       

       
    }
}
