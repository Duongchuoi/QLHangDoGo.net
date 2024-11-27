using BCrypt.Net;
using System;

using System.Windows.Forms;
using static BCrypt.Net.BCrypt;

namespace QLCuaHangDoGo
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void button2_Click(object sender, EventArgs e)
        {           
                // Validate input fields (optional)
                if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text) || string.IsNullOrWhiteSpace(txtMaNV.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                // Check if the username already exists
                string checkUserQuery = $"SELECT COUNT(*) FROM TaiKhoan WHERE TaiKhoan = '{txtTaiKhoan.Text}'";
            /*int userCount = kn.LayDuLieu(checkUserQuery).Tables[0].Rows[0].Field<int>(0);*/
            int userCount = Convert.ToInt32(kn.LayDuLieu(checkUserQuery).Tables[0].Rows[0][0]);

            if (userCount > 0)
                {
                    MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tên khác.");
                    return;
                }

                // Perform user registration
                string insertQuery = string.Format("INSERT INTO TaiKhoan VALUES('{0}', '{1}', '{2}','{3}')",
                    txtTaiKhoan.Text,
                    HashPassword(txtMatKhau.Text,GenerateSalt()),
                    txtMaNV.Text,
                    txtEmail.Text
                    );

                int result = kn.ThucThi(insertQuery);

                if (result > 0)
                {
                    MessageBox.Show("Đăng ký thành công");
                // Optionally, you can clear the input fields after successful registration
                // txtTaiKhoan.Text = "";
                // txtMatKhau.Text = "";
                // txtMaNV.Text = "";

                // Show login form and hide the registration form
                    frmDangNhap frm = new frmDangNhap();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi. Vui lòng thử lại sau.");
                }
            }

        private void frmDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Hide();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Hide();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
