using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Inheritance_1
{
    // inheritance => bir sınıfın başka bir sınıftan türetilmesidir. Mirsa alan sınıg miras veren sınıfın özelliklerini kullanır. Bu sayade ortak modüller tek bi sınıf altında toplanıp diğer sınıflara devreder.

    // miras veren sınıfa base class denir. Mirsa alan sınıfada derived class, child class sub class) gibi isimler verilir. c$ dilinde kalıtım operatörü : 'dir.

    // c# dilinde tekli kalıtım vardır. Bir sınıf yalnızca bir sınıftan türeyebilir.

    public class Insan
    {
        public string Adi { get; set; }
    }
    //miras alan sınıflar miras veren sınıfların özelliklerini aldıkları gibi kendi özellikleride olabilir.
    public class Ogrenci : Insan
    {
      
    }
    public class Hoca : Insan
    {
     public decimal Maas { get; set; }
    }
}
