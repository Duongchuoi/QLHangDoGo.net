using QLCuaHangDoGo.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDoGo
{
    
    public partial class frmForgotPass : Form
    {
        public frmForgotPass()
        {
            InitializeComponent();
            txtEmail.Text = "";

        }
        KetNoi kn = new KetNoi();
        private void frmForgotPass_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLayMK_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng ký!");
            }
            else
            {
                // Tạo một chuỗi truy vấn SQL
                string query = "SELECT * FROM TaiKhoan WHERE Email=@Email";

                // Tạo một đối tượng DataTable để lưu trữ kết quả

                DataTable resultTable = kn.LayDuLieuu(query, new SqlParameter("@Email", email));

                // Kiểm tra xem có dữ liệu nào được trả về từ cơ sở dữ liệu không
                if (resultTable.Rows.Count > 0)
                {
                    var newPassword = PasswordHelper.GeneratePassword(10);

                    var newHashPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

                    kn.CapNhatMatKhau(email, newHashPassword);

                    var row = resultTable.Rows[0];
                    string taiKhoan = row["TaiKhoan"].ToString();
                    bool isSendMail = SendMail(taiKhoan,email,newPassword);
                    if(isSendMail)
                    {
                        MessageBox.Show("Email gui thanh cong, vui long kiem tra email de thay mat khau moi");


                    }
                    else
                    {
                        MessageBox.Show("Email gui that bai, vui long thu lai");

                    }

                }
                else
                {
                    MessageBox.Show("Không tìm thấy email trong cơ sở dữ liệu!");
                }
            }
        }

        private bool SendMail(string taiKhoan,string email,string password)
        {
            var bodyBuilder = new StringBuilder();
            bodyBuilder.Append($"<h3>Xin chao {taiKhoan}</h3>");
            bodyBuilder.Append($"<p>He thong da nhan duoc thu khoi phuc mat khau.</p>");
            bodyBuilder.Append($"<p>Mat khau moi cua ban la <strong>{password}</strong></p>");
            bodyBuilder.Append($"<h4>Xin cam on</h4>");
            return SendMailHelper.SendMail(new SendMessage()
            {
                Destination = email,
                Subject = "Thư cấp mật khẩu mới",
                Body = bodyBuilder.ToString(),
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Hide();
        }
    }
}
