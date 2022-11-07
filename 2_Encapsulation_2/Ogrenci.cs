using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _2_Encapsulation_2
{
    internal class Ogrenci
    {
        public string adsoyad;

       
        public string AdSoyad
        {
            get
            {
                return adsoyad;
            }
            set
            {
                adsoyad = value;

            }
        }

        public string kursAdi;

        public string KursAdi { get; set; }


        public int yas;
        public int Yas
        {
            get
            {
                return yas;
            }
            set
            {
                if (value < 18)
                    yas = 18;
                else
                    yas = value;

            }

            // prop yapıp tab tab yaparsak kısayol yapıyor
            
            
        }
        
    }
}
