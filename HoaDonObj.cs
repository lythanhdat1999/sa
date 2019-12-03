using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doancuoiky.Object
{
    public class HoaDonObj
    {
        string mahd, ngaylap, khachhang;

        public string Mahd { get => mahd; set => mahd = value; }
        public string Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string Khachhang { get => khachhang; set => khachhang = value; }
        public HoaDonObj()
        {

        }
        public HoaDonObj(string mahd,string ngaylap,string khachhang)
        {
            this.mahd = mahd;
            this.ngaylap = ngaylap;
            this.khachhang = khachhang;
        }
    }
}
