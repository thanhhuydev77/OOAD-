using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_ChiTietPhieuNhap
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public DAL_ChiTietPhieuNhap()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public List<DTO_ChiTietPhieuNhap> LayDanhSachChiTiet(long mahoadon)
        {
            List<DTO_ChiTietPhieuNhap> ds = new List<DTO_ChiTietPhieuNhap>();

            string query = string.Empty;
            query = "select a.id,a.mahoadon,a.mahang,b.ten,a.dongiaban,a.soluong from tblcthoadonnhap a , tblhang b  where a.mahang = b.id and a.mahoadon = " + mahoadon ;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                DTO_ChiTietPhieuNhap ctpn = new DTO_ChiTietPhieuNhap();
                                ctpn.Id = long.Parse(reader["id"].ToString());
                                ctpn.MaHD = long.Parse(reader["mahoadon"].ToString());
                                ctpn.TenHang = reader["ten"].ToString();
                                ctpn.DonGiaBan = long.Parse(reader["dongiaban"].ToString());
                                ctpn.SoLuong = int.Parse(reader["soLuong"].ToString());
                                ctpn.Mahang = long.Parse(reader["mahang"].ToString());
                                ds.Add(ctpn);
                            }
                        }
                        con.Close();
                        con.Dispose();
                    }
                    catch
                    {
                        con.Close();
                        return null;
                    }
                }
            }

            return ds;
        }
        public bool ThemChiTiet(DTO_ChiTietPhieuNhap chitiet)
        {

            string query = string.Empty;
            query += "INSERT [dbo].[tblcthoadonnhap] ([mahoadon], [mahang], [dongiaban], [soluong])";
            query += "VALUES (@mahoadon, @mahang, @dongiaban, @soluong)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@mahoadon", chitiet.MaHD);
                    cmd.Parameters.AddWithValue("@mahang", chitiet.Mahang);
                    cmd.Parameters.AddWithValue("@dongiaban", chitiet.DonGiaBan);
                    cmd.Parameters.AddWithValue("@soluong", chitiet.SoLuong);
                    try
                    {
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            con.Close();
                            con.Dispose();
                            return true;
                        }
                        else
                        {
                            con.Close();
                            return false;
                        }
                    }
                    catch
                    {
                        con.Close();
                        return false;
                    }
                }
            }
        }
        public bool XoaChiTiet(long id)
        {
            string query = string.Empty;
            query += "DELETE FROM [tblcthoadonnhap] where [id] = @id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@id", id);

                    try
                    {
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            con.Close();
                            con.Dispose();
                            return true;
                        }
                        else
                        {
                            con.Close();
                            return false;
                        }
                    }
                    catch
                    {
                        con.Close();
                        return false;
                    }
                }
            }
        }
        public bool SuaChiTietPX(DTO_ChiTietPhieuNhap ctpn)
        {
            string query = string.Empty;
            query = "UPDATE [tblcthoadonnhap] " +
                "SET [mahoadon] = @mahoadon , [mahang] = @mahang,[dongiaban] = @dongiaban, [soluong] = @soluong " +
                "WHERE [id] = @id";
            //query = "SuaDaiLy";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@mahoadon", ctpn.MaHD);
                    cmd.Parameters.AddWithValue("@mahang", ctpn.Mahang);
                    cmd.Parameters.AddWithValue("@dongiaban", ctpn.DonGiaBan);
                    cmd.Parameters.AddWithValue("@soluong", ctpn.SoLuong);
                    cmd.Parameters.AddWithValue("@id", ctpn.Id);


                    try
                    {
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            con.Close();
                            con.Dispose();
                            return true;
                        }
                        else
                        {
                            con.Close();
                            return false;
                        }
                    }
                    catch
                    {
                        con.Close();
                        return false;
                    }
                }
            }
        }
        public List<DTO_ChiTietPhieuNhap> timkiem(string tukhoa)
        {
            List<DTO_ChiTietPhieuNhap> ds = new List<DTO_ChiTietPhieuNhap>();

            string query = string.Empty;
            query += "SELECT * FROM [tblcthoadonnhap]";
            query += "WHERE [mahoadon] = @tukhoa";


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@tukhoa", tukhoa);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                DTO_ChiTietPhieuNhap ctpn = new DTO_ChiTietPhieuNhap();
                                ctpn.Id = long.Parse(reader["id"].ToString());
                                ctpn.MaHD = long.Parse(reader["mahoadon"].ToString());
                                ctpn.Mahang = long.Parse(reader["mahang"].ToString());
                                ctpn.DonGiaBan = long.Parse(reader["dongiaban"].ToString());
                                ctpn.SoLuong = int.Parse(reader["soLuong"].ToString());
                                ds.Add(ctpn);
                            }
                        }
                        con.Close();
                        con.Dispose();
                    }
                    catch
                    {
                        con.Close();
                        return null;
                    }
                }
            }

            return ds;
        }
    }
}
