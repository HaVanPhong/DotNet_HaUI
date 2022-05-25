using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaVanPhong_Thuchanh_13052022
{
    class CuonSach
    {
        public string maCuon { get; set; }

        public string tenSach { get; set; }

        public int soTrang { get; set; }

        public string theLoai { get; set; }

        public string nhaXuatBan { get; set; }


        public CuonSach(string maCuon, string tenSach, int soTrang, string theLoai, string nxb)
        {
            this.maCuon = maCuon;
            this.tenSach = tenSach;
            this.soTrang = soTrang;
            this.theLoai = theLoai;
            this.nhaXuatBan = nxb;
        }

        public CuonSach()
        {

        }

        

    }
}
