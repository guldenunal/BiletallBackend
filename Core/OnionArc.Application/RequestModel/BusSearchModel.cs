using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biletall.Application.RequestModel
{
    public class BusSearchModel
    {
        public int FirmaNo { get; set; }
        public int KalkisNoktaID { get; set; }
        public int VarisNoktaID { get; set; }
        public string Tarih { get; set; }
        public string Saat { get; set; }
        public int HatNo { get; set; }
        public int IslemTipi { get; set; }
        public int SeferTakipNo { get; set; }
      

    }
}
