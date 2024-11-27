using QLCuaHangDoGo.QuanLyNhapHang;
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
    public partial class frmHeThong : Form
    {
        public frmHeThong()
        {
            InitializeComponent();
            
        }
        private void HideAllOpenForms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Hide();
            }
        }
        public void HideHeThongForm()
        {
            this.Hide();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllOpenForms();
            frmQuanLyNhanVien frm = new frmQuanLyNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllOpenForms();
            frmQuanLyHangHoa frm = new frmQuanLyHangHoa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tạoPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllOpenForms();
            frmTaoPhieuNhap frm = new frmTaoPhieuNhap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void chỉnhSửaThôngTinNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllOpenForms();
            frmThongTinNhaCungCap frm = new frmThongTinNhaCungCap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllOpenForms();
            frmDatHang frm = new frmDatHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void báoCáoTheoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllOpenForms();
            frmBaoCaoTT frm = new frmBaoCaoTT();
            frm.MdiParent = this;
            frm.Show();
        }

        private void báoCáoTheoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmBaoCaoTN();
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            HideAllOpenForms();
            frmBaoCaoTN frm = new frmBaoCaoTN();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmHeThong_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmHeThong_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                

                HideHeThongForm();
                 // Perform logout actions here
                 frmDangNhap frmLoGin = new frmDangNhap();
                frmLoGin.MdiParent = null;
                frmLoGin.Show();
               
            }
            else
            {
                // User chose not to logout
                // You can add any specific action or leave it blank
            }

        }

        private void frmHeThong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void thốngKêHàngHoáNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllOpenForms();
            frmThongKeHangNhap frm = new frmThongKeHangNhap();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
