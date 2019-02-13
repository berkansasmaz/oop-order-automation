using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyonu
{
    public partial class Ana_Menu : Form
    {
        public Ana_Menu()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';

        }
        
        //verileri statik direk erişebiliyoruz
        public static List<string> ID = new List<string>();
        public static List<string> users = new List<string>();
        public static List<string> pass = new List<string>();
        public static List<string> Adres = new List<string>();

        public static bool Kontrol { get; set; }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rdoCustomer.Checked)// customer radio buton' a tıklandığında 
            {
                // StreamReader sınıfının nesnesini türettim. Aynı zamanda çekilen veriyi alfabemize uygun hale getirdim.
                StreamReader customerLogin = new StreamReader("CustomerLogin.txt",Encoding.GetEncoding("iso-8859-9"));

                string temp = "";
                while ((temp = customerLogin.ReadLine()) != null)// dosyanın içinde ki verileri çekip temp değişkenine atadım.
                {
                    // temp içinde ki verileri her bir boşluk gördüğünde components dizisine atıyacak şekilde ayarladım.
                    string[] components = temp.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (txtPassword.Text==components[2])
                    {
                        ID.Add(components[0]);
                          users.Add(components[1]);
                         pass.Add(components[2]);
                        Adres.Add(components[3]);
                    }
                }

                customerLogin.Close();


                if (users.Contains(txtUser.Text) && pass.Contains(txtPassword.Text) && Array.IndexOf(users.ToArray(), txtUser.Text) == Array.IndexOf(pass.ToArray(), txtPassword.Text))
                {   
                    //yetkilendirme boolen değişken
                    Kontrol = false;//müşteri giriş yaptığında yetkili formu gözükmemesi için geriye boolean değer döndürdük
                    
                    //İd ve password doğruysa olucaklar
                    Menu menu = new Menu();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    //Müşteri hatalı giriş yaparsa olucaklar
                    MessageBox.Show("Lütfen doğru kullanıcı adı veya şifre giriniz.");
                    txtPassword.Text = "";
                    txtUser.Text = "";
                }
            }

            if (rdoAdmin.Checked)// Admin radio buton' a tıklandığında
            {
                // StreamReader sınıfının nesnesini türettim. Aynı zamanda çekilen veriyi alfabemize uygun hale getirdim.
                StreamReader adminLogin = new StreamReader("AdminLogin.txt");
                string temp2 = "";
                while ((temp2 = adminLogin.ReadLine()) != null)// dosyanın içinde ki verileri çekip temp değişkenine atadım.
                {
                    // temp içinde ki verileri her bir boşluk gördüğünde components dizisine atıyacak şekilde ayarladım.

                    string[] components2 = temp2.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    users.Add(components2[0]);
                    pass.Add(components2[1]);

                }
               
                adminLogin.Close();
                

                if (users.Contains(txtUser.Text) && pass.Contains(txtPassword.Text) && Array.IndexOf(users.ToArray(), txtUser.Text) == Array.IndexOf(pass.ToArray(), txtPassword.Text))
                {
                    //İd ve password doğruysa olucaklar
                    Kontrol = true;
                    Menu m = new Menu();
                    this.Hide();
                    m.Show();
                }
                else
                {  
                    //İd ve password yanlışsa olucaklar
                    MessageBox.Show("Lütfen doğru kullanıcı adı veya şifre giriniz.");
                    txtPassword.Text = "";
                    txtUser.Text = "";
                }

            }
        }
        private void Ana_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
