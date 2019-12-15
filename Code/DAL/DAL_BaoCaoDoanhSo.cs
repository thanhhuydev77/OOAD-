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
  public  class DAL_BaoCaoDoanhSo
    {
        #region prop
        private string connectionString;
        
        public string ConnectionString {
            get { return connectionString; }
            set { connectionString = value; }
        }
        #endregion
        #region method
       // public List<DTO_PhieuXuatHang> list = new List<DTO_PhieuXuatHang>();
        public List<DTO_PhieuXuatHang> listpx = new List<DTO_PhieuXuatHang>();
        public DAL_BaoCaoDoanhSo() {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public List<DTO_PhieuXuatHang> hienthidoanhso(int startmonth, int startyear, int endmonth, int endyear) 
            {
            List<DTO_PhieuXuatHang> List = new List<DTO_PhieuXuatHang>();

            String query = string.Empty;
            //query = "select b.id,tenDL,tyle,sophieuxuat,tongtrigia from tblBaoCaoDoanhSo b join tbldaily d on b.manv = d.id  where maTG in (select id from tblThoiGian where( (nam > @startyear  and nam < @endyear) or (nam = @startyear and thang >= @startmonth and nam < @endyear ) or (nam = @endyear and thang <= @endmonth and nam > @startyear) or ( nam = @startyear and nam = @endyear and thang >= @startmonth and thang <= @endmonth) ))";
            query = "select * from tblhoadonxuat as hd where ( ( (YEAR(hd.ngayxuat) > @startyear  and YEAR(hd.ngayxuat) < @endyear) or (YEAR(hd.ngayxuat) = @startyear and MONTH(hd.ngayxuat) >= @startmonth and YEAR(hd.ngayxuat) < @endyear ) or (YEAR(hd.ngayxuat) = @endyear and MONTH(hd.ngayxuat) <= @endmonth and YEAR(hd.ngayxuat) > @startyear) or ( YEAR(hd.ngayxuat) = @startyear and YEAR(hd.ngayxuat) = @endyear and MONTH(hd.ngayxuat) >= @startmonth and MONTH(hd.ngayxuat) <= @endmonth) ) )";
            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@startmonth", startmonth);
                    cmd.Parameters.AddWithValue("@startyear", startyear);
                    cmd.Parameters.AddWithValue("@endmonth", endmonth);
                    cmd.Parameters.AddWithValue("@endyear", endyear);
                   try {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == true) {
                            while (reader.Read()) {
                                //DTO_BaoCaoDoanhSo bcds = new DTO_BaoCaoDoanhSo();
                                //bcds.Id = long.Parse(reader["id"].ToString());
                                //bcds.Tendaily = reader["tenDL"].ToString();
                                //bcds.Tyle = float.Parse(reader["tyle"].ToString());
                                //bcds.Sophieuxuat = int.Parse(reader["soPhieuXuat"].ToString());
                                //bcds.Tongtrigia = (uint)reader.GetDecimal(4);
                                DTO_PhieuXuatHang px = new DTO_PhieuXuatHang();
                                px.Id = long.Parse(reader["id"].ToString());
                                px.MaNV = long.Parse(reader["manv"].ToString());
                                px.MaKH = long.Parse(reader["makh"].ToString());
                                px.NgayLapPhieu = reader.GetDateTime(3);
                                px.TongTriGia = (uint)reader.GetDecimal(4);

                                List.Add(px);
                            }
                        }
                        con.Close();
                        con.Dispose();
                   } catch {
                        con.Close();
                        return null;
                   }
                    listpx = List;
                    return List;
                }
            }
        }

        public uint hienthitongdoanhthu() {
            uint tong = 0;
            if (listpx.Count != 0)
                for (int i = 0; i < listpx.Count; i++)
                    tong += listpx[i].TongTriGia;
            return tong;
        }
        #endregion
    }
}

