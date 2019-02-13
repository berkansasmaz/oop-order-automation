using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
   public class SiparisDetay 
    {

        public urun Uruntanimi = new urun();
        public double Vergi { get; set; }
        public double Tutar { get; set; }
        public double Aratoplam()
        {
            //Kdv eklenmişhalini alıyoruz
            Vergi = ((Uruntanimi.getPriceForQuantity(Uruntanimi.UrunSecilenMiktar)) * Uruntanimi.UrunKdv) / 100;
            return Tutar = (Uruntanimi.getPriceForQuantity(Uruntanimi.UrunSecilenMiktar) + Vergi);
        }
        public double CalcWeight()
        {
            //verlien siparişdetayındaki ürünlerin ağırlıgı hesaplanır
            double agırlık = 0;
            return agırlık +=Uruntanimi.GetWeight();

        }
    }
}
