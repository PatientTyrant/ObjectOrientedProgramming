using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Constructor
{
    internal class Ogrenci
    {
        // Constructor ( Yapıcılar ) => sınıftan instance alındığında tektiklenen metotlardır...eğer bir sınıfta constructor tanımlanmazsa o sınıftan instance alınamaz. Bu yüzden sınıfın içerisinde constructor yazılmadığı sürece gizli constructor kullanılır. Eğer constructor açık bir şekilde yazılırsa gizli constructor iptal edilecektir...

        // Constructırlar birer metot gibi davranılar. Sadece instance alındığında otomatik çalışırlar.Bunlar birer metot gibi davrandığı için overload edilebilir ancak constructorlar özel metotlardır ve geri dönüş tipi yoktur. İsmi sınıf ismi ile aynı olmalıdır.

        // Constructorlar sınıftan instance alındığında yani new ifadesi ile çağrıldığında tetiklenir...
        public Ogrenci()
        {

        }
        public string adi;
        public string Adi
        {
            get
            {
                return adi;
            }

            set
            {
                adi = value.ToUpper();
            }
        }

            public string SoyAdi { get; set; }
           
    }
}
