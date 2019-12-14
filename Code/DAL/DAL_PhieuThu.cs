using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DAL_PhieuThu
    {
        #region prop
        private string connectionString;

        public string ConnectionString {
            get { return connectionString; }
            set { connectionString = value; }
        }
        #endregion
        #region method
        public DAL_PhieuThu() {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool ThemPhieuThu(DTO_PhieuThu pt) {

            string query = string.Empty;
            query += "INSERT INTO tblhoadonnhap ([manv],[ngayTiepNhan],[mancc],[tongtien]) ";
            query += " VALUES (@manv, @ngaythu, @mancc, @sotien)";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@manv", pt.MaNV);
                    cmd.Parameters.AddWithValue("@ngaythu", pt.Ngaythu);
                    cmd.Parameters.AddWithValue("@mancc",pt.MaNCC);
                    cmd.Parameters.AddWithValue("@sotien", decimal.Parse(pt.Sotien.ToString()));

                    //try 
                    {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0) {
                        con.Close();
                        con.Dispose();
                        return true;
                    } else {
                        con.Close();
                        return false;
                    }
                    }
                    //catch 
                    {
                    con.Close();
                    return false;
                }
               }
            }
        }

        public List<DTO_PhieuThu> LayDanhSachPhieuThu() {
            List<DTO_PhieuThu> ds = new List<DTO_PhieuThu>();

            string query = string.Empty;
            query = "SELECT * FROM tblhoadonnhap";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try 
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == true) {
                            while (reader.Read()) {
                                DTO_PhieuThu pt = new DTO_PhieuThu();
                                pt.Id = long.Parse(reader["id"].ToString());
                                pt.MaNV = long.Parse(reader["manv"].ToString());
                                pt.Ngaythu = DateTime.Parse(reader["ngayTiepNhan"].ToString());
                                pt.MaNCC = long.Parse(reader["mancc"].ToString());
                                pt.Sotien = (double)reader.GetDecimal(4);
                                ds.Add(pt);
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

        public bool XoaPhieuThu(long id) {
            XoaTatCaPhieuThu(id);
            string query = string.Empty;
            query += "DELETE FROM [tblhoadonnhap] where [id] = @id";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@id", id);

                    try {
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0) {
                            con.Close();
                            con.Dispose();
                            return true;
                        } else {
                            con.Close();
                            return false;
                        }
                    } catch {
                        con.Close();
                        return false;
                    }
                }
            }
        }
        public bool XoaTatCaPhieuThu(long id) {
            string query = string.Empty;
            query += "DELETE FROM [tblCThoadonnhap] where [mahoadon] = @id";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@id", id);

                    try {
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0) {
                            con.Close();
                            con.Dispose();
                            return true;
                        } else {
                            con.Close();
                            return false;
                        }
                    } catch {
                        con.Close();
                        return false;
                    }
                }
            }
        }

        public bool SuaPhieuThu(DTO_PhieuThu pt) {
            string query = string.Empty;
            query = "UPDATE [tblhoadonnhap] " +
                "SET [tongtien] = @sotien " +
                "WHERE [id] = @id";
            

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@sotien", Decimal.Parse(pt.Sotien.ToString()));
                    cmd.Parameters.AddWithValue("@id", pt.Id);

                    try
                    {
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0) {
                            con.Close();
                            con.Dispose();
                            return true;
                        } else {
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
        public bool capnhatPhieuThu(DTO_PhieuThu pt) {
            string query = string.Empty;
            query = "UPDATE [tblhoadonnhap] " +
                "SET [tongtien] = tongtien+ @sotien " +
                "WHERE [id] = @id";


            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@sotien", Decimal.Parse(pt.Sotien.ToString()));
                    cmd.Parameters.AddWithValue("@id", pt.Id);

                    try {
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0) {
                            con.Close();
                            con.Dispose();
                            return true;
                        } else {
                            con.Close();
                            return false;
                        }
                    } catch {
                        con.Close();
                        return false;
                    }
                }
            }
        }
        public uint TongThu(long madl, int thang, int nam)
        {
            uint tt = 0;
            string query = string.Empty;
            query += "select sum(soTienThu) from tblPhieuThu ";
            query += "where maDL =@madl and MONTH(ngayThu) = @thang and YEAR(ngayThu) = @nam";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@madl", madl);
                    cmd.Parameters.AddWithValue("@thang", thang);
                    cmd.Parameters.AddWithValue("@nam", nam);

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                tt = (uint)reader.GetDecimal(0);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch
                    {
                        con.Close();
                    }
                }
            }

            return tt;
        }
        #endregion
    }
}
