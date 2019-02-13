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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
         
        }
      public  Sepet S;
      public static urun Urun=new urun();
      public static YetkiliFirma firma;
      public static  List<urun> SepetUrunList = new List<urun>();
       
        private void btn_uSepeteEkle_Click(object sender, EventArgs e)
        {
            if (combo_uAdet.Text=="")
            {
                MessageBox.Show("Lütfen ürün adedi seçiniz!");

            }
            else
            {
                urun u = (urun)listbox_giyim.SelectedItem;//lisboxda seçilen veriyi u tipine çevirerek urun sepetine atıyoruz
                u.UrunSecilenMiktar = int.Parse(combo_uAdet.Text);
                SepetUrunList.Add(u);
                S = new Sepet(SepetUrunList);
                S.Show();
            }
           
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            
            //ürünlerimizi yetkili firma classımızdaki ürün listesinden çekiyoruz
            foreach (urun u in Yetkili_Firma.firma.UrunListesi)
            {
                listbox_giyim.Items.Add(u);
                
            }
            if (listbox_giyim.SelectedItem == null)
            {
                btn_uSepeteEkle.Enabled = false;
                combo_uAdet.Enabled = false;
            }
            combo_uAdet.SelectionStart = 1;

        }

        private void listbox_giyim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_giyim.SelectedItem == null)
            {
                btn_uSepeteEkle.Enabled = false;
            }
            else
            {
                btn_uSepeteEkle.Enabled = true;
                combo_uAdet.Enabled = true;

            }
           
        }

        private void combo_uAdet_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            urun u = (urun)listbox_giyim.SelectedItem;//secili ürünü urun tipine çevirerek u değişkenine atıyoruz
           
            u.UrunSecilenMiktar = int.Parse(combo_uAdet.SelectedItem.ToString());
            lbl_uFiyat.Text = u.UrunFiyat.ToString();
       
            label_uKdv.Text = u.UrunKdv.ToString();
        }
       
        private void listbox_giyim_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listbox_giyim.SelectedItem == null)
            {
                btn_uSepeteEkle.Enabled = false;
            }
            else
            {
                btn_uSepeteEkle.Enabled = true;
                combo_uAdet.Enabled = true;
                foreach (urun u in Yetkili_Firma.firma.UrunListesi)
                {
                    urun urn = (urun)listbox_giyim.SelectedItem;
                    if ( urn.UrunAdi == u.UrunAdi)
                    {
                        combo_uAdet.Items.Clear();
                        string[] temp = new string[u.UrunStokMiktarı];
                        int i = 0;
                        for (int j = 1; j <= u.UrunStokMiktarı; j++)
                        {
                            
                            temp[i] = j.ToString();
                            i++;
                            
                        }
                        combo_uAdet.Items.AddRange(temp);
                    }

                }

            }
        }
    }
}
