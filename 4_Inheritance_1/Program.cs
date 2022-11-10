namespace _4_Inheritance_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Berat";

            Hoca hc = new Hoca();
            hc.Adi = "Ekrem";
            hc.Maas = 500;

            Test(ogr);
        }

        public static void Test(Ogrenci p)
        {
            Console.WriteLine(p.Adi);
        }
    }
}