using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{
   public  class YetkiliFirma
    {

        //
        public Siparis Siparisler { get; set; }
        public int YetkiliID { get; set; }
        public   List <urun> UrunListesi { get; set; }
     
      public void stokAzalt(string u,int Miktar)
        {

            foreach (urun item in UrunListesi)
            {
                if (u == item.UrunAdi)
                {
                    UrunListesi[item.UrunKodu - 1].UrunStokMiktarı -= Miktar;
             
                }
            }

        }

        public void UrunEkle(urun urn)
        {
                UrunListesi.Add(urn);
        }
       
        public void UrunCıkart(int index)
        {

            for (int i = 0; i < UrunListesi.Count; i++)
            {
                if (index == UrunListesi[i].UrunKodu)
                {
                    UrunListesi.Remove(UrunListesi[i]);
                }
            }         
        }

        public void UrunGüncelle(int index, string ad,int miktar, string aciklama, int fiyat)
            //Gelen index parametresiyle urunlistesi içinde arama yapıp  ürün bilgilerini günceller
        {
            for (int i = 0; i < UrunListesi.Count; i++)
            {
                if (index == UrunListesi[i].UrunKodu)
                {
                    UrunListesi[i].UrunFiyat = fiyat;
                    UrunListesi[i].UrunAdi = ad;
                    UrunListesi[i].UrunStokMiktarı = miktar;
                    UrunListesi[i].Acıklama = aciklama;

                }
            }

        }

        public YetkiliFirma()
        {
            // StreamReader sınıfının nesnesini türettim.

            StreamReader ItemsList = new StreamReader("ItemData.txt");
            this.UrunListesi = new List<urun>();
            urun u2;
            string temp = "";
            int i = 0;          
            while ((temp = ItemsList.ReadLine()) != null)// dosyanın içinde ki verileri çekip temp değişkenine atadım.
            {
                // temp içinde ki verileri her bir boşluk gördüğünde components dizisine atıyacak şekilde ayarladım.
                string[] components = temp.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                //Listbox' ta daha sonra yazdırmak için components dizisinin içindeki verilerin bazılarını \t ile ayırarak dataArray değişkenine atadım.
                string dataArray = components[0] + "\t\t" + components[1] + "\t\t " + components[2] + "       \n";
                //Listbox' tan yazdırlan veriyi \t ile daha önce ayırmıştım şimdi ise kullanıcının listbox'tan seçtiği veriyi \t ile ayırarak aldım.
                string[] selectedRow = dataArray.Split("\t\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                // temp içinde ki verileri her bir boşluk gördüğünde components dizisine atıyacak şekilde ayarladım.
                string[] components2 = temp.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (components2[0] == selectedRow[0])
                {
                    //Çektiğim verileri gerekli değişkenlere atadım.
                    u2 = new urun();
                    u2.UrunAdi = components[1];
                    u2.UrunKodu = Convert.ToInt32(components[0]);
                    u2.UrunFiyat = Convert.ToInt32(components[2]);
                    u2.UrunKdv = Convert.ToInt32(components2[4]);
                    u2.NakliyeAgırlıgı = Convert.ToDouble(components2[5]);
                    u2.UrunStokMiktarı = Convert.ToInt32(components[3]);
                    u2.Acıklama = "Ürün Adı: " + u2.UrunAdi + "Ürün Fiyatı: " + u2.UrunFiyat + "Ürün ağırlığı: " + u2.NakliyeAgırlıgı;
                    UrunListesi.Add(u2);

                }
                i++;
                if (i == 1)
                {
                    temp = "";
                    i = 0;
                }
            }
        }
        
    }
}

