using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

using System.ComponentModel;
using System.Data;
using System.Drawing;


namespace DAL
{
    public class DAL_Hang
    {
        private string connectionString;
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DAL_Hang()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public List<DTO_Hang> LayDanhSachMatHangKhac()
        {
            List<DTO_Hang> ls = new List<DTO_Hang>();

            string query = "SELECT * FROM tblhang where manhom = 2 ";

            using(SqlConnection con = new SqlConnection(connectionString))
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
                            while(reader.Read())
                            {
                                DTO_Hang ldl = new DTO_Hang();
                                ldl.MaMatHang = long.Parse(reader["id"].ToString());
                                ldl.TenMatHang = reader.GetString(2);
                                ldl.MaNhomHang = long.Parse(reader["manhom"].ToString());
                                ldl.CongDung = reader.GetString(3);
                                ldl.ThanhPhan = reader.GetString(4);
                                ldl.MaDVT = long.Parse(reader["dvt"].ToString());
                                ldl.XuatXu= reader.GetString(6);
                                ldl.SoLuong = int.Parse(reader["soluong"].ToString());
                                ldl.GiaNhap = (uint)reader.GetDecimal(8);
                                ldl.GiaBan = (uint)reader.GetDecimal(9);
                                ls.Add(ldl);
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

            return ls;
        }
        public List<DTO_Hang> LayDanhSachKho() {
            List<DTO_Hang> ls = new List<DTO_Hang>();

            string query = "SELECT * FROM tblhang ";

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
                                DTO_Hang ldl = new DTO_Hang();
                                ldl.MaMatHang = long.Parse(reader["id"].ToString());
                                ldl.TenMatHang = reader.GetString(2);
                                ldl.MaNhomHang = long.Parse(reader["manhom"].ToString());
                                ldl.CongDung = reader.GetString(3);
                                ldl.ThanhPhan = reader.GetString(4);
                                ldl.MaDVT = long.Parse(reader["dvt"].ToString());
                                ldl.XuatXu = reader.GetString(6);
                                ldl.SoLuong = int.Parse(reader["soluong"].ToString());
                                ldl.GiaNhap = (uint)reader.GetDecimal(8);
                                ldl.GiaBan = (uint)reader.GetDecimal(9);
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
        public List<DTO_Hang> LayDanhSachThuoc() {
            List<DTO_Hang> ls = new List<DTO_Hang>();

            string query = "SELECT * FROM tblhang where manhom = 1 ";

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
                                DTO_Hang ldl = new DTO_Hang();
                                ldl.MaMatHang = long.Parse(reader["id"].ToString());
                                ldl.TenMatHang = reader.GetString(2);
                                ldl.MaNhomHang = long.Parse(reader["manhom"].ToString());
                                ldl.CongDung = reader.GetString(3);
                                ldl.ThanhPhan = reader.GetString(4);
                                ldl.MaDVT = long.Parse(reader["dvt"].ToString());
                                ldl.XuatXu = reader.GetString(6);
                                ldl.SoLuong = int.Parse(reader["soluong"].ToString());
                                ldl.GiaNhap = (uint)reader.GetDecimal(8);
                                ldl.GiaBan = (uint)reader.GetDecimal(9);
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
        public bool ThemMatHang(DTO_Hang ldl)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblhang] ([manhom],[ten],[congdung],[thanhphan],[dvt],[xuatxu], [soluong],[gianhap],[giaban]) ";
            query += "VALUES (@manhom, @ten, @congdung, @thanhphan, @dvt, @xuatxu, @soluong, @gianhap, @giaban)";
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@manhom", ldl.MaNhomHang);
                    cmd.Parameters.AddWithValue("@ten", ldl.TenMatHang);
                    cmd.Parameters.AddWithValue("@congdung", ldl.CongDung);
                    cmd.Parameters.AddWithValue("@thanhphan", ldl.ThanhPhan);
                    cmd.Parameters.AddWithValue("@dvt", ldl.MaDVT);
                    cmd.Parameters.AddWithValue("@xuatxu", ldl.XuatXu);
                    cmd.Parameters.AddWithValue("@soluong", ldl.SoLuong);
                    cmd.Parameters.AddWithValue("@gianhap", decimal.Parse(ldl.GiaNhap.ToString()));
                    cmd.Parameters.AddWithValue("@giaban", decimal.Parse(ldl.GiaBan.ToString()));

                    //try
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
                    //catch
                    {
                        con.Close();
                        return false;
                    }
                }
            }
        }
        public bool SuaMatHang(DTO_Hang ldl)
        {
            string query = string.Empty;
            query = "UPDATE [tblhang] " +
                "SET [manhom] = @manhom,[ten] = @ten ,[congdung] = @congdung ,[thanhphan] = @thanhphan ,[dvt] = @dvt ,[xuatxu] = @xuatxu , [soluong] = @soluong ,[gianhap] = @gianhap ,[giaban] =  @giaban " +
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

                    cmd.Parameters.AddWithValue("@manhom", ldl.MaNhomHang);
                    cmd.Parameters.AddWithValue("@ten", ldl.TenMatHang);
                    cmd.Parameters.AddWithValue("@congdung", ldl.CongDung);
                    cmd.Parameters.AddWithValue("@thanhphan", ldl.ThanhPhan);
                    cmd.Parameters.AddWithValue("@dvt", ldl.MaDVT);
                    cmd.Parameters.AddWithValue("@xuatxu", ldl.XuatXu);
                    cmd.Parameters.AddWithValue("@soluong", ldl.SoLuong);
                    cmd.Parameters.AddWithValue("@gianhap", decimal.Parse(ldl.GiaNhap.ToString()));
                    cmd.Parameters.AddWithValue("@giaban", decimal.Parse(ldl.GiaBan.ToString()));
                    cmd.Parameters.AddWithValue("@id", ldl.MaMatHang);

                    //try
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
                    //catch
                    {
                        con.Close();
                        return false;
                    }
                }
            }
        }
        public bool XoaMatHang(long id)
        {
            string query = string.Empty;
            query += "DELETE FROM [tblhang] where [id] = @id";

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
        public List<DTO_Hang> TimKiemHang(string tukhoa,int loai)
        {
            List<DTO_Hang> ds = new List<DTO_Hang>();
            

            string query = string.Empty;
                query += "SELECT * FROM [tblhang]";
            if (loai != 0)
                query += "WHERE [manhom] = "+loai+ " and ([ten] like '%' + @tukhoa + '%'  or [congdung] like '%' + @tukhoa + '%' )";
            else
                query += "WHERE ([ten] like '%' + @tukhoa + '%'  or [congdung] like '%' + @tukhoa + '%' )";
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
                                DTO_Hang ldl = new DTO_Hang();
                                ldl.MaMatHang = long.Parse(reader["id"].ToString());
                                ldl.TenMatHang = reader.GetString(2);
                                ldl.MaNhomHang = long.Parse(reader["manhom"].ToString());
                                ldl.CongDung = reader.GetString(3);
                                ldl.ThanhPhan = reader.GetString(4);
                                ldl.MaDVT = long.Parse(reader["dvt"].ToString());
                                ldl.XuatXu = reader.GetString(6);
                                ldl.SoLuong = int.Parse(reader["soluong"].ToString());
                                ldl.GiaNhap = (uint)reader.GetDecimal(8);
                                ldl.GiaBan = (uint)reader.GetDecimal(9);
                                ds.Add(ldl);
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


        public bool SuaKho(DTO_Hang ldl) {
            string query = string.Empty;
            query = "UPDATE [tblhang] " +
                "SET [manhom] = @manhom,[ten] = @ten , [dvt] = @dvt ,[xuatxu] = @xuatxu , [soluong] = @soluong WHERE [id] = @id";
            //query = "SuaDaiLy";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@manhom", ldl.MaNhomHang);
                    cmd.Parameters.AddWithValue("@ten", ldl.TenMatHang);
                    
                    cmd.Parameters.AddWithValue("@dvt", ldl.MaDVT);
                    cmd.Parameters.AddWithValue("@xuatxu", ldl.XuatXu);
                    cmd.Parameters.AddWithValue("@soluong", ldl.SoLuong);
                    cmd.Parameters.AddWithValue("@id", ldl.MaMatHang);

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
    }
}
