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
  public  class DAL_NhanVien
    {
        #region prop
        private string connectionString;

        public string ConnectionString {
            get { return connectionString; }
            set { connectionString = value; }
        }
        #endregion
        #region method
        public DAL_NhanVien() {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
       

        public List<DTO_NhanVien> LayDanhSachNhanVien() {
            List<DTO_NhanVien> ds = new List<DTO_NhanVien>();

            string query = string.Empty;
            query = "SELECT * FROM tblnhanvien";

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
                                DTO_NhanVien dl = new DTO_NhanVien();
                                dl.Id = long.Parse(reader["id"].ToString());
                                dl.TenNhanVien = reader.GetString(1);
                                dl.ChucVu = reader.GetString(2);
                                dl.GioiTinh = (bool)reader.GetBoolean(3);
                                dl.Tuoi = int.Parse(reader["tuoi"].ToString());
                                dl.DiaChi = reader.GetString(5);
                                dl.Email = reader.GetString(6);
                                dl.SDT = reader.GetString(7);
                                dl.PhanQuyen = int.Parse(reader["phanquyen"].ToString());
                                dl.TaiKhoan = long.Parse(reader["userid"].ToString());
                                ds.Add(dl);
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

        public List<DTO_Right> LayDanhSachQuyen() {
            List<DTO_Right> ds = new List<DTO_Right>();

            string query = string.Empty;
            query = "SELECT * FROM tblright";

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
                                DTO_Right dl = new DTO_Right();
                                dl.Id = int.Parse(reader["id"].ToString());
                                dl.Name = reader.GetString(1);
                                
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
        public string timTaiKhoan(string tenNhanVIen)
        {
            string result  = string.Empty;

            string query = string.Empty;
            query = "select username from tblaccount a,tblnhanvien b where a.id = b.userId and b.hoten = @ten";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@ten", tenNhanVIen);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                result = reader.GetString(0);
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

            return result;
        }

        public bool ThemNhanVien(DTO_NhanVien mh) {
            string query = string.Empty;
            query += "INSERT INTO tblNhanVien ([hoten],[chucvu],[gioitinh],[tuoi],[diachi],[email],[sdt],[phanquyen],[userid]) ";
            query += " VALUES (@hoten, @chucvu, @gioitinh,@tuoi,@diachi,@email,@sdt,@phanquyen,@userid)";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    
                    cmd.Parameters.AddWithValue("@hoten",mh.TenNhanVien);
                    cmd.Parameters.AddWithValue("@chucvu",mh.ChucVu);
                    cmd.Parameters.AddWithValue("@gioitinh", mh.GioiTinh);
                    cmd.Parameters.AddWithValue("@tuoi", mh.Tuoi);
                    cmd.Parameters.AddWithValue("@diachi", mh.DiaChi);
                    cmd.Parameters.AddWithValue("@email", mh.Email);
                    cmd.Parameters.AddWithValue("@sdt", mh.SDT);
                    cmd.Parameters.AddWithValue("@phanquyen", mh.PhanQuyen);
                    cmd.Parameters.AddWithValue("@userid", mh.TaiKhoan);
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

        public bool XoaNhanVien(long id) {
            string query = string.Empty;
            query += "DELETE FROM [tblNhanvien] where [id] = @id";

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

        public bool SuaNhanVien(DTO_NhanVien mh) {
            string query = string.Empty;
            query = "UPDATE [tblNhanvien] " +
                "SET [hoten] = @hoten,[chucvu] = @chucvu,[gioitinh] = @gioitinh,[tuoi] = @tuoi,[diachi] = @diachi,[email] = @email,[sdt] = @sdt,[phanquyen] = @phanquyen " +
                " " +
                "WHERE [Id] = @id";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@id", mh.Id);
                    cmd.Parameters.AddWithValue("@hoten", mh.TenNhanVien);
                    cmd.Parameters.AddWithValue("@chucvu", mh.ChucVu);
                    cmd.Parameters.AddWithValue("@gioitinh", mh.GioiTinh);
                    cmd.Parameters.AddWithValue("@tuoi", mh.Tuoi);
                    cmd.Parameters.AddWithValue("@diachi", mh.DiaChi);
                    cmd.Parameters.AddWithValue("@email", mh.Email);
                    cmd.Parameters.AddWithValue("@sdt", mh.SDT);
                    cmd.Parameters.AddWithValue("@phanquyen", mh.PhanQuyen);
                    

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

        public List<DTO_NhanVien> TimKiemNhanVien(string tukhoa) {
            List<DTO_NhanVien> list = new List<DTO_NhanVien>();

            string query = string.Empty;
            query += "SELECT * FROM [tblNhanVien]";
            query += "WHERE [hoten] like '%' + @tukhoa + '%'";
                
            long tk;
            if (long.TryParse(tukhoa, out tk)) {
                query += "OR [id] like '%' + @tukhoa + '%' ";
            }

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@tukhoa", tukhoa);
                    cmd.Parameters.AddWithValue("@tk", tk);

                    try
                        {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == true) {
                            while (reader.Read()) {
                                DTO_NhanVien dl = new DTO_NhanVien();
                                dl.Id = long.Parse(reader["id"].ToString());
                                dl.TenNhanVien = reader.GetString(1);
                                dl.ChucVu = reader.GetString(2);
                                dl.GioiTinh = (bool)reader.GetBoolean(3);
                                dl.Tuoi = int.Parse(reader["tuoi"].ToString());
                                dl.DiaChi = reader.GetString(5);
                                dl.Email = reader.GetString(6);
                                dl.SDT = reader.GetString(7);
                                dl.PhanQuyen = int.Parse(reader["phanquyen"].ToString());
                                dl.TaiKhoan = long.Parse(reader["userid"].ToString());
                                list.Add(dl);
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

            return list;
        }
        #endregion
    }
}
