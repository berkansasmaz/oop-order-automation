using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
    public class KrediKartıylaOdeme :Odeme
    {
        public decimal  KartNO { get; set; }
        public string Tip { get; set; }
        public DateTime SonKullanımTarihi { get; set; }
        int onay;
        public int  authorized()
        {
            onay = 1;
            return onay;
        }

        public override void UcretOde(double tutar)
        {
            OdemeMiktarı = tutar ;
            
        }
    }
}
