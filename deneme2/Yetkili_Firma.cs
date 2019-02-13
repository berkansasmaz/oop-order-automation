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
    public partial class Yetkili_Firma : Form //Bahar-zişan
    {
        
        public static YetkiliFirma firma = new YetkiliFirma();
     
        public urun GetUrun { get; set; }
        public string Kayit { get; set; }

        public Yetkili_Firma()
        {
            InitializeComponent();
            
        }
        public void ListViewTemizle()
        {
            listView_urun.Clear();
            listView_urun.Columns.Add("Ürün", 100);
            listView_urun.Columns.Add("Fiyatı", 100);
            listView_urun.Columns.Add("Adedi", 100);
            listView_urun.Columns.Add("Ağırlık", 100);
            listView_urun.Columns.Add("Urun Kodu", 100);
            listView_urun.Columns.Add("Açıklama", 500);

            for (int i = 0; i < firma.UrunListesi.Count; i++)
            {
                listView_urun.Items.Add(firma.UrunListesi[i].UrunAdi);
                listView_urun.Items[i].SubItems.Add(firma.UrunListesi[i].UrunFiyat.ToString());
                listView_urun.Items[i].SubItems.Add(firma.UrunListesi[i].UrunStokMiktarı.ToString());
                listView_urun.Items[i].SubItems.Add(firma.UrunListesi[i].NakliyeAgırlıgı.ToString());
                listView_urun.Items[i].SubItems.Add(firma.UrunListesi[i].UrunKodu.ToString());
                listView_urun.Items[i].SubItems.Add(firma.UrunListesi[i].Acıklama.ToString());
            }

        }
        private void btn_yEkle_Click(object sender, EventArgs e)
        {
            if (text_yUrunAdı.Text == "" || text_yUrunMiktar.Text == "" || txt_yUrunFiyat.Text == "" || txt_yUrun_Aciklama.Text == "" || text_UrunAgırlıgı.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!");
            }
            else
            {

                GetUrun = new urun()
                {
                    Acıklama = txt_yUrun_Aciklama.Text,
                    UrunFiyat = int.Parse(txt_yUrunFiyat.Text),
                    UrunKodu = firma.UrunListesi.Count + 1,
                    UrunAdi = text_yUrunAdı.Text,
                    UrunStokMiktarı = Convert.ToInt32(text_yUrunMiktar.Text),
                    NakliyeAgırlıgı = double.Parse(text_UrunAgırlıgı.Text)
                    
                };
                firma.UrunEkle(GetUrun);
                ListViewTemizle();
                
            }

        }

        private void btn_yGüncelle_Click(object sender, EventArgs e)
        {
            if (text_UrunAdi.Text == "" || text_Fiyat.Text == "" || text_miktar.Text == "" || text_UrunAciklamasi.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!");
            }
            else
            {
                if (listView_urun.SelectedItems.Count == 1)
                {
                    firma.UrunGüncelle(int.Parse(listView_urun.SelectedItems[0].SubItems[4].Text), text_UrunAdi.Text, int.Parse(text_miktar.Text), text_UrunAciklamasi.Text, int.Parse(text_Fiyat.Text));
                }

                ListViewTemizle();
            }
        }

        private void Yetkili_Firma_Load(object sender, EventArgs e)
        {
           
            listView_urun.Columns.Add("Ürün", 100);
            listView_urun.Columns.Add("Fiyatı", 100);
            listView_urun.Columns.Add("Adedi", 100);
            listView_urun.Columns.Add("Ağırlık", 100);
            listView_urun.Columns.Add("Urun Kodu", 100);
            listView_urun.Columns.Add("Açıklama", 500);

            for (int i = 0; i < firma.UrunListesi.Count; i++)
            {
                listView_urun.Items.Add(firma.UrunListesi[i].UrunAdi);
                listView_urun.Items[i].SubItems.Add(firma.UrunListesi[i].UrunFiyat.ToString());

                listView_urun.Items[i].SubItems.Add(firma.UrunListesi[i].UrunStokMiktarı.ToString());

                listView_urun.Items[i].SubItems.Add(firma.UrunListesi[i].NakliyeAgırlıgı.ToString());
                listView_urun.Items[i].SubItems.Add(firma.UrunListesi[i].UrunKodu.ToString());
                listView_urun.Items[i].SubItems.Add(firma.UrunListesi[i].Acıklama.ToString());
                
            }
            
        }

        private void btn_SiparisListele_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            listView1.Columns.Add("Müşteri ID", 50);
            listView1.Columns.Add("İsim", 150);
            listView1.Columns.Add("Müşteri Adres", 150);

            listView1.Columns.Add("Ürün Adı", 100);
            listView1.Columns.Add("Miktarı", 50);
            listView1.Columns.Add("Fiyatı", 50);
            listView1.Columns.Add("Urun Kodu", 50);
            listView1.Columns.Add("SiparişTarihi", 600);
            try
            {
                if (Sepet.Siparis.Detaylar.Count == 0)
                {
                    MessageBox.Show("Sipariş Yok");

                }
                else
                {
                    for (int i = 0; i < Sepet.Siparis.Detaylar.Count; i++)
                    {
                        listView1.Items.Add(Sepet.Siparis.Musteri.MusteriID.ToString());
                        listView1.Items[i].SubItems.Add(Sepet.Siparis.Musteri.AdSoyad.ToString());
                        listView1.Items[i].SubItems.Add(Sepet.Siparis.Musteri.Adres.ToString());

                        
                        listView1.Items[i].SubItems.Add(Sepet.Siparis.Detaylar[i].Uruntanimi.UrunAdi.ToString());
                        listView1.Items[i].SubItems.Add(Sepet.Siparis.Detaylar[i].Uruntanimi.UrunSecilenMiktar.ToString());
                        listView1.Items[i].SubItems.Add(Sepet.Siparis.Detaylar[i].Uruntanimi.UrunFiyat.ToString());
                        listView1.Items[i].SubItems.Add(Sepet.Siparis.Detaylar[i].Uruntanimi.UrunKodu.ToString());
                        listView1.Items[i].SubItems.Add(Sepet.Siparis.SiparisTarihi.ToString());


                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Sipariş Tanımlanmamıştır.");
            }


        } 

        private void btn_Urun_Cikar_Click(object sender, EventArgs e)
        {   
           
                if (listView_urun.CheckedItems.Count > 0)
                {
                   

                    for (int i = 0; i < listView_urun.CheckedItems.Count; i++)
                    {
                        int a = int.Parse(listView_urun.CheckedItems[i].SubItems[4].Text);
                        firma.UrunCıkart(a);
                    }

                }
                ListViewTemizle();
            
        }

        private void listView_urun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_urun.SelectedItems.Count == 1)
            {
                text_UrunAdi.Text = listView_urun.SelectedItems[0].SubItems[0].Text;
                text_Fiyat.Text     = listView_urun.SelectedItems[0].SubItems[1].Text;
                text_miktar.Text = listView_urun.SelectedItems[0].SubItems[2].Text;
                text_UrunAciklamasi.Text = listView_urun.SelectedItems[0].SubItems[5].Text;

            }
        }

    }
}
