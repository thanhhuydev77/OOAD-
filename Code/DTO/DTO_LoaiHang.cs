using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiHang
    {
        
        private long id;

        private string tenLoaiHang;

        [DisplayName("Mã Loại Hàng")]
        public long Id { get => id; set => id = value; }

        [DisplayName("Tên Loại Hàng")]
        public string TenLoaiHang { get => tenLoaiHang; set => tenLoaiHang = value; }

       
    }
}
