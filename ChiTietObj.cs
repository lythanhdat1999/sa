using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doancuoiky.Object
{
    public class ChiTietObj
    {
        string mahd, mahh;
        int soluong, dongia;

        public string Mahd { get => mahd; set => mahd = value; }
        public string Mahh { get => mahh; set => mahh = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public ChiTietObj()
        {

        }
        public ChiTietObj(string mahd,string mahh,int soluong,int dongia)
        {
            this.mahd = mahd;
            this.mahh = mahh;
            this.soluong = soluong;
            this.dongia = dongia;
        }
    }
}
