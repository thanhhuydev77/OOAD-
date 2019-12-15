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
    public class DAL_NhaCungCap
    {
        private string connectionString;
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DAL_NhaCungCap()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public List<DTO_NhaCungCap> LayDanhSachnhacungcap() {
            List<DTO_NhaCungCap> ls = new List<DTO_NhaCungCap>();

            string query = "SELECT * FROM tblnhacungcap";

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
                                DTO_NhaCungCap ldl = new DTO_NhaCungCap();
                                ldl.Id = long.Parse(reader["id"].ToString());
                                ldl.Name = reader.GetString(1);
                                ldl.Sdt= reader.GetString(2); ;
                                ldl.Email = reader.GetString(3);
                                ldl.DiaChi = reader.GetString(4);
                                
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
        public bool ThemNhaCungCap(DTO_NhaCungCap ldl) {
            string query = string.Empty;
            query += "INSERT INTO [tblnhacungcap] ([ten],[sdt],[email],[diachi]) ";
            query += "VALUES (@ten, @sdt, @email, @diachi)";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    
                    cmd.Parameters.AddWithValue("@ten", ldl.Name);
                    cmd.Parameters.AddWithValue("@sdt", ldl.Sdt);
                    cmd.Parameters.AddWithValue("@diachi", ldl.DiaChi);
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
        public bool SuaNhaCungCap(DTO_NhaCungCap ldl) {
            string query = string.Empty;

            query = "UPDATE [tblnhacungcap] " +
                "SET [ten] = @ten ,[sdt] = @sdt ,[email] = @email ,[diachi] = @diachi " +
                "WHERE [id] = @id";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@ten", ldl.Name);
                    cmd.Parameters.AddWithValue("@sdt", ldl.Sdt);
                    cmd.Parameters.AddWithValue("@diachi", ldl.DiaChi);
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
        public bool XoaNhaCungCap(long id) {
            string query = string.Empty;
            query += "DELETE FROM [tblnhacungcap] where [id] = @id";

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
        public List<DTO_NhaCungCap> TimKiemHang(string tukhoa) {
            List<DTO_NhaCungCap> ds = new List<DTO_NhaCungCap>();


            string query = string.Empty;
            query += "SELECT * FROM [tblnhacungcap]";
            query += "WHERE ([ten] like '%' + @tukhoa + '%'  or [diachi] like '%' + @tukhoa + '%' )";
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
                                DTO_NhaCungCap ldl = new DTO_NhaCungCap();
                                ldl.Id = long.Parse(reader["id"].ToString());
                                ldl.Name = reader.GetString(1);
                                ldl.Sdt = reader.GetString(2); ;
                                ldl.Email = reader.GetString(3);
                                ldl.DiaChi = reader.GetString(4);

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
