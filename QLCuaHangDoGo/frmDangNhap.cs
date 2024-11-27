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
   
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            //Mã hoá mật khẩu
            /*string password = txtMatKhau.Text; // Mật khẩu từ người dùng
            string hashedPassword = MD5Hasher.Hash(password);*/

            /*  string query = string.Format("select * from TaiKhoan where TaiKhoan = '{0}' and MatKhau = '{1}' ", txtTaiKhoan.Text, hashedPassword);*/
            /* string query = $"SELECT * FROM TaiKhoan WHERE TaiKhoan = '{txtTaiKhoan.Text}' AND MatKhau = '{hashedPassword}'";*/
            string query = string.Format("SELECT * FROM TaiKhoan WHERE TaiKhoan ='{0}'", txtTaiKhoan.Text);
            DataSet ds = kn.LayDuLieu(query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                string hashPassword = ds.Tables[0].Rows[0]["MatKhau"] as string ?? "";
                string currentPassword = txtMatKhau.Text;
                if (BCrypt.Net.BCrypt.Verify(currentPassword, hashPassword))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    frmHeThong frm = new frmHeThong();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mat khau khong dung, vui long thu lai");

                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
           
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnForgotPassWord_Click(object sender, EventArgs e)
        {
            
        }

        private void lb_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy frm = new frmDangKy();
            frm.Show();
            this.Hide();
        }

        private void lb_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotPass frm = new frmForgotPass();
            frm.Show();
            this.Hide();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void phide_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.PasswordChar == '*')
            {
                peye.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void peye_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                phide.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }
    }
}
