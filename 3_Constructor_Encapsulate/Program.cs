namespace _3_Constructor_Encapsulate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci(30,50);
            ogr.Vize = 50;
            ogr.Final = 90;

            Ogrenci ogr1 = new Ogrenci(40,90);
            ogr1.Vize = 90;
            ogr1.Final = 60;

            Console.WriteLine(ogr.Ortalama);
            Console.WriteLine(ogr1.Ortalama);
            Console.WriteLine(ogr1.HarfNotu);
        }
    }
}