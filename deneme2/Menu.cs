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

    public  partial class Menu : Form

    {

        Urunler U;
        Sepet S;
        Payment O;
        Yetkili_Firma firmaForm;
        public  bool Kontrol;

        public Menu()
        {
            InitializeComponent();
            this.Kontrol = Ana_Menu.Kontrol;//yetkilendirme 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Kontrol == true)
            {
                yetkiliFirmaToolStripMenuItem.Visible = true;
                ürünlerToolStripMenuItem.Visible = false;
                sepetToolStripMenuItem.Visible = false  ;
                ödemeToolStripMenuItem.Visible = false;

            }
            else
            {

                yetkiliFirmaToolStripMenuItem.Visible = false;
                ürünlerToolStripMenuItem.Visible = true;
                sepetToolStripMenuItem.Visible = true;
                ödemeToolStripMenuItem.Visible = true;
            }

            
        }
        
        private void sepetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (S == null)
            {
                S = new Sepet(Urunler.SepetUrunList);//her seferinde sepetin içindeki veriler sepet formuna aktrarılıyor
                S.MdiParent = this;
                S.FormClosed += S_FormClosed;
                S.Show();

            }
            else
                S.Activate();
        }

        private void S_FormClosed(object sender, FormClosedEventArgs e)
        {
            S = null;
        }

        private void ödemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (O == null)
            {
                O = new Payment();
                O.MdiParent = this;
                O.FormClosed += O_FormClosed;
                O.Show();

            }
            else
                O.Activate();
        }

        private void O_FormClosed(object sender, FormClosedEventArgs e)
        {
            O = null;
            
        }
        private void ürünlerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (U == null)
            {
                U = new Urunler();
                U.MdiParent = this;
                U.FormClosed += U_FormClosed;
                U.Show();

            }
            else
                U.Activate();
        }

        private void U_FormClosed(object sender, FormClosedEventArgs e)
        {
            U = null;
        }

        private void yetkiliFirmaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (firmaForm == null)
            {
                firmaForm = new Yetkili_Firma();
                firmaForm.MdiParent = this;
                firmaForm.FormClosed += FirmaForm_FormClosed;
                firmaForm.Show();

            }
            else
                firmaForm.Activate();
        }

        private void FirmaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            firmaForm = null;
           
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
       
    }

