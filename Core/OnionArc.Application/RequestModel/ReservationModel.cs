using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biletall.Application.RequestModel
{
    public class ReservationModel
    {
        public int FirmaNo { get; set; }
        public int KalkisNoktaID { get; set; }
        public int VarisNoktaID { get; set; }
        public int SeferTakipNo { get; set;
        }
        public string Tarih { get; set; }
        public string Saat { get; set; }
        public int HatNo { get; set; }
        public int KoltukNo1 { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcKimlikNo { get; set; }
        public string KalkisNokta { get; set; }
        public string TelefonNo { get; set; }
        public int Cinsiyet  { get; set; }
        public int YolcuSayisi { get; set; }    
        public string EMail { get; set; }


    }
}
