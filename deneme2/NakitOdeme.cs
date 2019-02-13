using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
   public  class NakitOdeme:Odeme
    {
        int onay;
        public int authorized()
        {
            onay = 1;
            return onay;
        }
        public override void UcretOde(double tutar)
        {
            OdemeMiktarı = tutar-((tutar *10)/100);
        }
    }
}
