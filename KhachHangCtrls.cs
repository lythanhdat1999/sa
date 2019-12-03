using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doancuoiky.Model;
using Doancuoiky.Object;
using System.Data;
namespace Doancuoiky.Control
{
    public class KhachHangCtrls
    {
        KhachHangMod khMod = new KhachHangMod();
        public DataTable getData()
        {
            return khMod.GetData();
        }
        public bool addData(KhachHangObj khObj)
        {
            return khMod.AddData(khObj);

        }
        public bool upData(KhachHangObj khObj)
        {
            return khMod.UpData(khObj);
        }
        public bool delData(string ma)
        {
            return khMod.DelData(ma);
        }
    }
}
