using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_PhieuThu
    {
        #region prop
        private long id;
        private long maNV;
        private DateTime ngaythu;
        private long maNCC;
        private uint sotien;
        [DisplayName("Mã phiếu thu")]
        public long Id { get => id; set => id = value; }    
        [DisplayName("Mã nhân viên")]
        public long MaNV { get => maNV; set => maNV = value; }
        [DisplayName("Ngày thu")]
        public DateTime Ngaythu { get => ngaythu; set => ngaythu = value; }
        [DisplayName("Mã nhà cung cấp")]
        public long MaNCC { get => maNCC; set => maNCC = value; }
        [DisplayName("Số tiền")]
        public uint Sotien { get => sotien; set => sotien = value; }
        #endregion
    }
}
