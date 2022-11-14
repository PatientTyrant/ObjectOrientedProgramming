namespace _5_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Polymorphism ( Çok Biçimlilik) => Base classlardan gelen üyelerin Derived Classlarda farklı davranışlar sergilemesini sağlama yaklaşımıdır...

             */

            Kedi k = new Kedi();
           
            Console.WriteLine(k.Ses());

            Kus ku = new Kus();
            Console.WriteLine(ku.Ses());

            // Miras veren sınıf ile miras alan sınıf yer değiştirdiklerinde birbirleri gibi davranabilmelidir.
            HavanlarAlemi h = k;
           Console.WriteLine( h.Ses());

            HavanlarAlemi h1 = ku;
            Console.WriteLine(h1.Ses());
        }
    }
}