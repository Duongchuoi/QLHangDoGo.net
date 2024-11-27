using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.ComponentModel;
//using Microsoft.ReportingServices.Diagnostics.Internal;

namespace QLCuaHangDoGo
{
    internal class KetNoi
    {
        string constr = @"Data Source=DESKTOP-T3JKLLT\DUONGCHUOI;Initial Catalog=QLDG;Integrated Security=True";
        //string constr = @"Data Source=Admin-PC\SQLEXPRESS;Initial Catalog=QLDG;Integrated Security=True";
        SqlConnection con;

        public KetNoi()
        {
            con = new SqlConnection(constr);
            con.Open();
        }
        public DataSet LayDuLieu(string truyvan)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(truyvan, con);
            da.Fill(ds);
            return ds;
        }
        public int ThucThi(string truyvan)
        {
            SqlCommand cmd = new SqlCommand(truyvan, con);
            int r = cmd.ExecuteNonQuery();
            return r;
        }

        public DataTable getAllLuong()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM BangLuong";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dataTable);
            return dataTable;
        }
        public DataTable getAllHangHoa()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM CTPhieuNhap";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dataTable);
            return dataTable;
        }
        
        public DataTable getAllSanPham()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM MatHang"; // Thay TenBangSanPham bằng tên bảng sản phẩm thực tế của bạn
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dataTable);
            return dataTable;
        }
        
            
        public DataTable LayDuLieuu(string truyvan, params SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            using (SqlCommand cmd = new SqlCommand(truyvan, con))
            {
                cmd.Parameters.AddRange(parameters);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }
            }
            return dataTable;
        }
      
        // hàm xử lý Thanh Toán
        public void CapNhatSoLuongSanPham(string maMH, int soLuongMua)
        { 
            string query = "UPDATE MatHang SET SoLuong = SoLuong - @soLuongMua WHERE MaMH = @maMH";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@soLuongMua", soLuongMua);
                cmd.Parameters.AddWithValue("@maMH", maMH);

                try
                {
                    if(con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    // Xử lý ngoại lệ nếu cần thiết
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public void CapNhatSoLuongSanPhamNhap(string maMH, int soLuongMua)
        {
            string query = "UPDATE GioHang SET SoLuong = SoLuong + @soLuongMua WHERE MaMH = @maMH";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@soLuongMua", soLuongMua);
                cmd.Parameters.AddWithValue("@maMH", maMH);

                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    // Xử lý ngoại lệ nếu cần thiết
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public int TaoPhieuNhap()
        {
            int maPn = 0;
            using (SqlCommand cmd = new SqlCommand("usp_ThemPhieuNhap", con)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    cmd.Parameters.Add(new SqlParameter("@maPn", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    });

                    cmd.ExecuteNonQuery();
                    maPn = int.Parse(cmd.Parameters["@maPn"].Value.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    // Xử lý ngoại lệ nếu cần thiết
                }
                finally
                {
                    con.Close();
                }
                return maPn;
            }
        }

        internal void ThemSanPhamVaoHoaDon(int maHd,string maMh,int soLuong, int donGia)
        {
            string query = "Insert into CTPhieuNhap values(@maHd,@maMh,@soLuong,@donGia)";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.Parameters.AddWithValue("@maHd", maHd);
                    cmd.Parameters.AddWithValue("@maMh", maMh);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@donGia", donGia);


                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    // Xử lý ngoại lệ nếu cần thiết
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public void CapNhatMatKhau(string email,string hashPassword)
        {
            string query = "Update TaiKhoan set MatKhau =@MatKhau where Email = @Email";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    cmd.Parameters.AddWithValue("@MatKhau", hashPassword);
                    cmd.Parameters.AddWithValue("@Email", email);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    // Xử lý ngoại lệ nếu cần thiết
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
