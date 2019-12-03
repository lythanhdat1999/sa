using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doancuoiky.Object
{
    public class HangHoaObj
    {
        string mahh;
        string tenhang;
        int dongia;
        string xuatxu;
        int soluong;

        public string Mahh { get => mahh; set => mahh = value; }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        
        public string Xuatxu { get => xuatxu; set => xuatxu = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        

        public HangHoaObj()
        {

        }
        public HangHoaObj(string mahh,string tenhang,int dongia,string xuatxu,int soluong)
        {
            this.mahh = mahh;
            this.tenhang = tenhang;
            this.dongia = dongia;
            this.xuatxu = xuatxu;
            this.soluong = soluong;


        }
    }
}
