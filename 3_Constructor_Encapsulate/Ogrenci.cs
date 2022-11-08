using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Constructor_Encapsulate
{
    internal class Ogrenci
    {
        public Ogrenci(float v, float f)
        {
            Vize = v;
            Final = f;
            Ortalama = v * 0.4f + f * 0.6f;
        }
        public float Vize;
        public float Final;

        // fieldlara class seviyesinde erişilemez..Class seviyesinden tanımlanan üyelere erişilemez.Üyelere sadece alt scopelardan erişilebilir...
        //public float Ortalama = Vize* 0.4f + Final * 0.6f;

        public float Ortalama { get; }

        public string HarfNotu
        {
            get
            {
                return Ortalama switch
                {
                    >= 80 and <= 100 => "AA",
                    >= 70 and <= 80 => "BA",
                    >= 60 and <= 70 => "BB",
                    >= 50 and <= 60 => "CC",
                    >= 40 and <= 50 => "DC",
                    <40 => "FF"


                };
            }
        }


    }
}
