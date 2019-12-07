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
    public class DAL_KhachHang
    {
        private string connectionString;
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DAL_KhachHang()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public List<DTO_KhachHang> LayDanhSachKhachHang() {
            List<DTO_KhachHang> ls = new List<DTO_KhachHang>();

            string query = "SELECT * FROM tblKhachHang";

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
                                DTO_KhachHang ldl = new DTO_KhachHang();
                                ldl.Id = long.Parse(reader["id"].ToString());
                                ldl.Name = reader.GetString(1);
                                ldl.Sdt= reader.GetString(2); ;
                                ldl.Email = reader.GetString(3);

                                
                                ls.Add(ldl);
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

            return ls;
        }
        public bool ThemKhachHang(DTO_KhachHang ldl) {
            string query = string.Empty;
            query += "INSERT INTO [tblkhachhang] ([[ten],[sdt],[email]) ";
            query += "VALUES (@ten, @sdt, @email )";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    
                    cmd.Parameters.AddWithValue("@ten", ldl.Name);
                    cmd.Parameters.AddWithValue("@sdt", ldl.Sdt);
                    cmd.Parameters.AddWithValue("@email", ldl.Email);
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
        public bool SuaKhachHang(DTO_KhachHang ldl) {
            string query = string.Empty;

            query = "UPDATE [tblkhachhang] " +
                "SET [ten] = @ten ,[sdt] = @sdt ,[email] = @email " +
                "WHERE [id] = @id";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@ten", ldl.Name);
                    cmd.Parameters.AddWithValue("@sdt", ldl.Sdt);
                    cmd.Parameters.AddWithValue("@email", ldl.Email);

                    cmd.Parameters.AddWithValue("@id", ldl.Id);

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
        public bool XoaKhachHang(long id) {
            string query = string.Empty;
            query += "DELETE FROM [tblkhachhang] where [id] = @id";

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
        public List<DTO_KhachHang> TimKiemKhachHang(string tukhoa) {
            List<DTO_KhachHang> ds = new List<DTO_KhachHang>();


            string query = string.Empty;
            query += "SELECT * FROM [tblkhachhang]";
            query += "WHERE ([ten] like '%' + @tukhoa + '%'  or [sdt] like '%' + @tukhoa + '%' )";
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
                                DTO_KhachHang ldl = new DTO_KhachHang();
                                ldl.Id = long.Parse(reader["id"].ToString());
                                ldl.Name = reader.GetString(1);
                                ldl.Sdt = reader.GetString(2); ;
                                ldl.Email = reader.GetString(3);
                                

                                ds.Add(ldl);
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
