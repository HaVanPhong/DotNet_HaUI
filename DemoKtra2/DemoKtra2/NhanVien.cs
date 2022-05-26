using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKtra2
{
    class NhanVien
    {
        public int? maNV { get; set; }
        public string? hoTen { get; set; }
        public string? gioiTinh { get; set; }
        public string? ngaySinh { get; set; }
        public long? luongNgay { get; set; }

        public int? soNgayLam { get; set; }

        public NhanVien()
        {

        }
        public NhanVien(int maNV, string hoTen, string gt, string ngay, long luong, int snl)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.gioiTinh = gt; 
            this.ngaySinh = ngay;
            this.luongNgay = luong;
            this.soNgayLam=snl;
        }

        public override string ToString()
        {
            return hoTen;
        }






    }
}
