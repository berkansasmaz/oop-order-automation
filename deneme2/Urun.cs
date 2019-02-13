using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
   public class urun
    {
        public int UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public int UrunStokMiktarı { get; set; }
        public int UrunFiyat { get; set; }
        public int UrunKdv { get; set; }
        public int UrunSecilenMiktar { get; set; }
        public double NakliyeAgırlıgı { get; set; }
        public string Acıklama { get; set; }
        public override string ToString()
        {
            return string.Format("{0}\t\t{1}TL\t\t{2} ", UrunAdi, UrunFiyat, UrunStokMiktarı);
        }

        public double getPriceForQuantity(int miktar)//istenilen miktara göre fiyat geri dönüşü sağlanıyor
        {
            return miktar * UrunFiyat;
        }
        public double GetWeight() // istenilen ürünün miktarina göre nakliye ağırlıgı geri döndürülüyor
        {
            return NakliyeAgırlıgı * UrunSecilenMiktar;
        }
    }
}
