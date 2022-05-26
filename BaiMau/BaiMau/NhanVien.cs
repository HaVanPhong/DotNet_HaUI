using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiMau
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public double Luong { get; set; }
        public int SoNgayLam { get; set; }

        public double TienLuong
        {
            get {
                return TinhLuong();
            }
        }

        public double TinhLuong()
        {
            if (SoNgayLam <= 24)
                return SoNgayLam * Luong;
            else
                return (24 + (SoNgayLam - 24) * 2) * Luong;
        }

        public override string ToString()
        {
            return HoTen; 
        }
    }
}
