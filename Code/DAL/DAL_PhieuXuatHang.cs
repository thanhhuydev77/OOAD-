﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_PhieuXuatHang
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public DAL_PhieuXuatHang()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public List<DTO_PhieuXuatHang> TimKiemPhieuXuatHang(string tukhoa)
        {
            List<DTO_PhieuXuatHang> ds = new List<DTO_PhieuXuatHang>();

            string query = string.Empty;
            query += "SELECT * FROM [tblhoadonxuat]";
            query += "WHERE [maDL] = @tukhoa";
           

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
                                DTO_PhieuXuatHang pxh = new DTO_PhieuXuatHang();
                                pxh.Id = long.Parse(reader["id"].ToString());
                                pxh.MaNV = long.Parse(reader["manv"].ToString());
                                pxh.MaKH = long.Parse(reader["makh"].ToString());
                                pxh.NgayLapPhieu = reader.GetDateTime(3);
                                pxh.TongTriGia = (uint)reader.GetDecimal(4);
                                ds.Add(pxh);
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
        public bool ThemPhieuXuat(DTO_PhieuXuatHang pxh)
        {

            string query = string.Empty;
            query += "INSERT INTO [tblhoadonxuat] ([manv], [makh], [ngayxuat], [tongtien]) ";
            query += "VALUES (@manv, @makh, @ngayxuat, @tongtien)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@manv", pxh.MaNV);
                    cmd.Parameters.AddWithValue("@makh", pxh.MaKH);
                    cmd.Parameters.AddWithValue("@ngayxuat", pxh.NgayLapPhieu);
                    cmd.Parameters.AddWithValue("@tongtien", Decimal.Parse(pxh.TongTriGia.ToString()));
                   

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
        public List<DTO_PhieuXuatHang> LayDanhSachPhieuXuat()
        {
            List<DTO_PhieuXuatHang> ds = new List<DTO_PhieuXuatHang>();

            string query = string.Empty;
            query = "select * from tblhoadonxuat ";
            
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
                                DTO_PhieuXuatHang pxh = new DTO_PhieuXuatHang();
                                pxh.Id = long.Parse(reader["id"].ToString());
                                pxh.MaNV= long.Parse(reader["manv"].ToString());
                                pxh.MaKH = long.Parse(reader["makh"].ToString());
                                pxh.NgayLapPhieu = reader.GetDateTime(3);
                                pxh.TongTriGia = (uint)reader.GetDecimal(4);
                                ds.Add(pxh);
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
        public bool XoaPhieuXuat(long id)
        {
            string query = string.Empty;
            query += "DELETE FROM [tblhoadonxuat] where [id] = @id";

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
        public bool SuaPhieuXuat(DTO_PhieuXuatHang pxh)
        {
            string query = string.Empty;
            query = "UPDATE [tblhoadonxuat] " +
                "SET [manv] = @manv , [makh] = @makh, [tongtien] = @tongtien " +
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

                    cmd.Parameters.AddWithValue("@manv", pxh.MaNV);
                    cmd.Parameters.AddWithValue("@makh", pxh.MaKH);
                    cmd.Parameters.AddWithValue("@tongtrigia", Decimal.Parse(pxh.TongTriGia.ToString()));
                    cmd.Parameters.AddWithValue("@id", pxh.Id);

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

        public uint TongXuat(long madl, int thang, int nam)
        {
            uint tt = 0;
            string query = string.Empty;
            query += "SELECT sum(tongtien) FROM [tblhoadonxuat] ";
            query += "WHERE maDL =@manv and MONTH(ngayxuat) = @thang and YEAR(ngayxuat) = @nam";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@manv", madl);
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
    }
}
