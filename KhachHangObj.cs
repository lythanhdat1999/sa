using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doancuoiky.Object
{
    public class KhachHangObj
    {
        string makh;
        string tenkh;
        string diachi;
        string sodt;
        public string Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sodt { get => sodt; set => sodt = value; }
        public KhachHangObj()
        {

        }
        public KhachHangObj(string makh, string tenkh, string diachi, string sodt)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.diachi = diachi;
            this.sodt = sodt;
        }
        public override string ToString()
        {
            return tenkh;
        }
    }
}
