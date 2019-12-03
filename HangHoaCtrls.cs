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
    public class HangHoaCtrls
    {
        HangHoaMod hhMod= new HangHoaMod();
        public DataTable getData()
        {
            return hhMod.GetData();
        }
        public bool addData(HangHoaObj hhObj)
        {
            return hhMod.AddData(hhObj);

        }
        public bool upData(HangHoaObj hhObj)
        {
            return hhMod.UpData(hhObj);
        }
        public bool delData(string ma)
        {
            return hhMod.DelData(ma);
        }
        
    }
}
