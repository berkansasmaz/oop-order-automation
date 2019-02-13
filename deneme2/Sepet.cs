using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyonu
{
    public partial class Sepet : Form
    {
        public YetkiliFirma Firma { get; set; }
        public  List<urun> SepetListesi = new List<urun>();
        public musteri M { get; set; }
        public static SiparisDetay sd { get; set; }
        public static Siparis Siparis;
        public int GeciciToplam { get; set; }
        public Sepet(List<urun> u)
        {
            InitializeComponent();
            this.SepetListesi = u;//urun classından gelen siparişleri sepet listesine atıyoruz
            M = new musteri();
            Firma = new YetkiliFirma();
            Siparis = new Siparis(this.M);
            Siparis.Detaylar = new List<SiparisDetay>();
            M.AdSoyad = Ana_Menu.users[0].ToString();
            M.MusteriID = Convert.ToInt32(Ana_Menu.ID[0]);
            M.Adres = Convert.ToString(Ana_Menu.Adres[0]);
        }
        public Sepet()
        {
            InitializeComponent();
        }
        private void Sepet_Load(object sender, EventArgs e)
        {
            foreach (urun item in SepetListesi)//sepetteki ürünleri listeliyoruz
            {
                listBox1.Items.Add(item.UrunAdi+"\t\t"+item.UrunFiyat +"\t\t"+ item.UrunSecilenMiktar.ToString());
               
                GeciciToplam += (item.UrunFiyat*item.UrunSecilenMiktar);
            }
            text_sToplam.Text = GeciciToplam.ToString();

        }

        private void btn_sAlısveris_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sCikis_Click(object sender, EventArgs e)
        {
            Ana_Menu menu = new Ana_Menu();
            menu.Show();
        }
        private void btn_sOnayOde_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SepetListesi.Count; i++)
            {
                //yeni bir sipariş detayı ekliyoruz
                sd = new SiparisDetay();
                sd.Uruntanimi.UrunAdi = SepetListesi[i].UrunAdi;
                sd.Uruntanimi.UrunFiyat = SepetListesi[i].UrunFiyat;
                sd.Uruntanimi.UrunKdv = SepetListesi[i].UrunKdv;
                sd.Uruntanimi.UrunSecilenMiktar = SepetListesi[i].UrunSecilenMiktar;
                sd.Uruntanimi.UrunKodu = SepetListesi[i].UrunKodu;
                sd.Uruntanimi.NakliyeAgırlıgı = SepetListesi[i].NakliyeAgırlıgı;
                sd.Uruntanimi.Acıklama = SepetListesi[i].Acıklama;
                Siparis.SiparisTarihi = DateTime.Now;
                // sipariş detaylarını sepetlistesinden çekerek siparişi tamamlıyoruz
                Siparis.SiparisDetayEkle(sd);
            }

            double ToplamTutar = Siparis.ToplamTutarHesapla();
            double kargoucreti = Siparis.ToplamKargoUcreti();
            double toplamVergi = Siparis.CalcTax();
            MessageBox.Show("Kesilen Kargo Ücreti = " + kargoucreti.ToString());
            MessageBox.Show("Kesilen  Vergi Ücreti = " + toplamVergi.ToString());
            MessageBox.Show("Toplam Tutar = " + ToplamTutar.ToString());
            Payment p = new Payment(Siparis.ToplamTutarHesapla());
            p.Show();
            
        }

        private void btn_sTemizle_Click(object sender, EventArgs e)
        {
            SepetListesi.Clear();
            this.Close();
        }

    }
}