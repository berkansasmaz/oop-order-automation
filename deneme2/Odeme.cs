using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu
{


    public abstract class Odeme //bahar-zişan abstract class 

    {
       // public Siparis GetSiparis = new Siparis();

        public double OdemeMiktarı { get; set; }
        public abstract void UcretOde(double tutar);
        public Odeme()
        {

        }



    }
    
}
