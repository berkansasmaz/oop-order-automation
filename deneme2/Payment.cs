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
    public partial class Payment : Form
    {
        KrediKartıylaOdeme K_Odeme = new KrediKartıylaOdeme();
        NakitOdeme N_Odeme = new NakitOdeme();
        CekleOdeme C_Odeme = new CekleOdeme();
        public int yOnay = 0;
        public double geciciTutar { get; set; }

       
        public Payment()
        {
            InitializeComponent();
        }

        public Payment(double tutar)
        {
            InitializeComponent();
            this.geciciTutar = tutar;
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            panel_Kredi.Enabled = false;
            panel_nakit.Enabled = false;
            panel_check.Enabled = false;
            
            label_oToplam.Text= Convert.ToString(geciciTutar);
        }

        private void combo_Odeme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combo_Odeme.Text=="Kredi Kartı")
            {
                panel_Kredi.Enabled = true;
                panel_nakit.Enabled = false;
                panel_check.Enabled = false;
            }
           else if (combo_Odeme.Text == "Nakit")
            {

                panel_Kredi.Enabled = false;
                panel_nakit.Enabled = true;
                panel_check.Enabled = false;

            }
           else if (combo_Odeme.Text == "Çek")
            {

                panel_Kredi.Enabled = false;
                panel_nakit.Enabled = false;
                panel_check.Enabled = true;
            }

        }

        private void btn_Ode_Click(object sender, EventArgs e)
        {
            if (combo_Odeme.Text == "")
            {
                MessageBox.Show("Bir ödeme yöntemi seçiniz!");
            }
            else
            {
                if (combo_Odeme.Text == "Kredi Kartı")
                {
                    if (txt_krediKno.Text == "" || txt_kTip.Text == "" || datetimepicker_Tarih.Text =="" )
                    {
                        MessageBox.Show("Lütfen boş alan bırakmayınız!");

                    }
                    else
                    {
                        
                        
                        K_Odeme.KartNO = Convert.ToDecimal(txt_krediKno.Text);
                        K_Odeme.Tip = txt_kTip.Text;
                        K_Odeme.SonKullanımTarihi = Convert.ToDateTime(datetimepicker_Tarih.Text);

                        yOnay = K_Odeme.authorized();
                        if (yOnay == 1)
                        {
                            K_Odeme.UcretOde(geciciTutar);
                            MessageBox.Show("Ödeme Başarılı");
                            this.Close();
                        }

                        AnaMenuCagır();
                    }

                }
                else if (combo_Odeme.Text == "Nakit")
                {
                    yOnay = C_Odeme.authorized();
                   
                    if (yOnay == 1)
                    {
                        N_Odeme.UcretOde(geciciTutar);
                        label_nakit.Text = N_Odeme.OdemeMiktarı.ToString();
                        MessageBox.Show("Ödeme Başarılı Nakit Ödemeniz için %10 indirim yapılmıştır indirimli tutar = "+label_nakit.Text);
                       
                        this.Close();
                    }
                    AnaMenuCagır();
                }
              
                else if (combo_Odeme.Text == "Çek")
                {
                    if (txt_cNo.Text == "" || txt_cİsim.Text == "")
                    {
                        MessageBox.Show("Lütfen boş alan bırakmayınız!");
                    }
                    else
                    {
                        C_Odeme.Isim = txt_cİsim.Text;
                        C_Odeme.BankID = Convert.ToInt32(txt_cNo.Text);
                        
                        yOnay = C_Odeme.authorized();
                        if (yOnay == 1)
                        {
                            C_Odeme.UcretOde(geciciTutar);
                            MessageBox.Show("Ödeme Başarılı");
                            this.Close();
                        }
                        AnaMenuCagır();
                    } 
                       
                }
            }
        }
        private void AnaMenuCagır()
        {
            foreach (urun item in Yetkili_Firma.firma.UrunListesi)
            {
                Yetkili_Firma.firma.stokAzalt(item.UrunAdi, item.UrunSecilenMiktar);
            }
            Ana_Menu A = new Ana_Menu();
            A.Show();
            this.Close();

        }
        private void btn_cikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz İptal Edilmiştir");
            Urunler.SepetUrunList.Clear();
            Sepet.Siparis.Detaylar.Clear();
            this.Close();
            
        }
    }
}
