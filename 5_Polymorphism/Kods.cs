using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Polymorphism
{
    public class HavanlarAlemi
    {
        public string Tur { get; set; }
        // virtual => üyenin miras alan sınıf tarafından gövdesinin değiştirilebilir hale gelmesini sağlar. Runtime'da derived sınıf base üzerinden çağrılırsa üye base'deki değil derived sınıftaki gibi davranır.
        // virtual=> Üyenin alt sınıflar tarafından ezileilir olduğu anlamına gelir..
        // virtual üyeler override ifadesi ile ezilir.
        public virtual string Ses()
        {
            return "xxx";
        }
    }


    public class Kedi : HavanlarAlemi
    {
        //Override => Baseden gelen virtual üyeyi ezmek için kullanılır.
        public override string Ses()
        {
            return "MİYAV MİYAV";
        }
    }

    public class Kus : HavanlarAlemi
    {
        public override string Ses()
        {
            return "CİK CİK";
        }
    }

}