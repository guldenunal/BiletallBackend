using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Biletall.Application.RequestModel
{
    public class JourneySearchModel
    {
        public int FirmaNo { get; set; }
        public int KalkisNoktaID { get; set;}
        public int VarisNoktaID { get; set;}
        public string Tarih { get; set; }
        public int AraNoktaGelsin { get; set; }
        public int IslemTipi { get; set; }
        public int YolcuSayisi { get;set; }
        

    }
}
