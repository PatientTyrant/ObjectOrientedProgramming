namespace _4_Inheritance_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            ExcelDosya d = new ExcelDosya();
            d.Adi = "Hesaplar";
            d.Uzanti = "xls";

            d.Yazdir();

            WordDosya d1 = new WordDosya();
            d1.Adi = "Analiz_1";
            d1.Uzanti = "doc";

            d1.Yazdir();
            Files f = new Files("AAAA","BBB");

            var ddddd = new ExcelFile("BBB","BBB");

            ExcelFile ef = new ExcelFile("Hesaplar","xlsx");

            WordFile wf = new WordFile("Analiz", "docx");

            ef.Yazdir();
            wf.Yazdir();    
        }
    }
}