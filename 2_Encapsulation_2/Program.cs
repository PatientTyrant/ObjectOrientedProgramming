namespace _2_Encapsulation_2
{

    // Class members => sınıfın üyelerini ifade eder;
    // field, metot,
    // property  => sınıfların içerisinde metot veya field gibi kullanılabilen yapılardır... 


    internal class Program
    {
        static void Main(string[] args)
        {


            Ogrenci ogr = new Ogrenci();
            ogr.adsoyad = "Umut";
            ogr.yas = 13;

            Console.WriteLine($"{ogr.yas}");

                
        }
    }
}