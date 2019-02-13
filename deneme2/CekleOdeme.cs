using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
   public class CekleOdeme :Odeme
    {
        public string Isim { get; set; }
        public int BankID { get; set; }
        int onay;
        public int authorized()
        {
            onay = 1;
            return onay;
        }
        public override void UcretOde(double tutar)
        {
            OdemeMiktarı = tutar;

        }

    }
}
