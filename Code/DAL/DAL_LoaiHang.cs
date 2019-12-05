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
    public class DAL_LoaiHang
    {
        private string connectionString;

        public string ConnectionString {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public DAL_LoaiHang() {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public List<DTO_LoaiHang> LayDanhSachLoaiHang() {
            List<DTO_LoaiHang> ds = new List<DTO_LoaiHang>();

            string query = string.Empty;
            query = "SELECT * FROM tblnhomhang";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == true) {
                            while (reader.Read()) {
                                DTO_LoaiHang dl = new DTO_LoaiHang();
                                dl.Id = long.Parse(reader["id"].ToString());
                                dl.TenLoaiHang = reader.GetString(1);
                                ds.Add(dl);
                            }
                        }
                        con.Close();
                        con.Dispose();
                    } catch {
                        con.Close();
                        return null;
                    }
                }
            }

            return ds;
        }

        public bool ThemLoaiHang(DTO_LoaiHang dl) {

            string query = string.Empty;
            query += "INSERT INTO [tblnhomhang] ([ten]) ";
            query += "VALUES (@tennh)";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@tennh", dl.TenLoaiHang);

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

        public bool XoaNhomHang(long id) {
            string query = string.Empty;
            query += "DELETE FROM [tblnhomhang] WHERE [id] = @id";

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

        public bool SuaLoaiHang(DTO_LoaiHang dl) {
            string query = string.Empty;
            query = "UPDATE [tblnhomhang] " +
                "SET [ten] = @tendl " +
                "WHERE [id] = @id";
            //query = "SuaDaiLy";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@tendl", dl.TenLoaiHang);
                    cmd.Parameters.AddWithValue("@id", dl.Id);

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

        public List<DTO_LoaiHang> TimKiemLoaiHang(string tukhoa) {
            List<DTO_LoaiHang> ds = new List<DTO_LoaiHang>();

            string query = string.Empty;
            query += "SELECT * FROM [tblnhomhang]";
            query += "WHERE [ten] like '%' + @tukhoa + '%' ";
            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@tukhoa", tukhoa);

                    try {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == true) {
                            while (reader.Read()) {
                                DTO_LoaiHang dl = new DTO_LoaiHang();
                                dl.Id = long.Parse(reader["id"].ToString());
                                dl.TenLoaiHang = reader.GetString(1);
                                ds.Add(dl);
                            }
                        }
                        con.Close();
                        con.Dispose();
                    } catch {
                        con.Close();
                        return null;
                    }
                }
            }

            return ds;
        }
    }
}