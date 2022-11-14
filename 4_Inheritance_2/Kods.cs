using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _4_Inheritance_2
{
    public class Dosya
    {
        public string Path { get; set; }
        public string Uzanti { get; set; }
        public string Adi { get; set; }

    }
    public class ExcelDosya : Dosya
    {       
        public void Yazdir()
        {
            Console.WriteLine($"{Adi}.{Uzanti}");
        }
    }

    public class WordDosya : Dosya
    {
        public void Yazdir()
        {
            Console.WriteLine($"{Adi}.{Uzanti}");
        }
    }

    //Example 2

    public class Files
    {
        public Files(string _Name, string _Extension)
        {
            Name = _Name;
            Extension = _Extension;
        }
        public string Path { get; set; }
        public string Extension { get; set; }
        public string Name { get;  set; }

        public void Yazdir()
        {
            Console.WriteLine($"{Name}{Extension}");
        }
    }

    public class ExcelFile : Files
    {
        //public ExcelFile (string _Name, string _Extension)
        //{
        //    Name = _Name;
        //    Extension = _Extension; 
        //}      
        //    public void Yazdir()
        //    {
        //        Console.WriteLine($"{Name}.{Extension}");
        //    }

        // ExcelFile gelen parametreleri Base sınıfa göndermemiz gerekir.
        public ExcelFile( string _Name, string _Extension) : base(_Name, _Extension)
        {

        }
        
    }
   
    public class WordFile : Files
    {
        //public WordFile(string _Name, string _Extension)
        //{
        //    Name = _Name;
        //    Extension = _Extension;
        //}
        //public void Yazdir()
        //{
        //    Console.WriteLine($"{Name}.{Extension}");
        //}
        public WordFile(string _Name, string _Extension) : base(_Name, _Extension)
        {

        }
    }


}
