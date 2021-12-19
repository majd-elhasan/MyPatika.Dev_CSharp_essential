using System;

namespace TryCatchFinally
{
    class Program5
    {
        static void Main(string[] args)
        {
            string hata ="";
            Console.WriteLine("******Exception*******");
            try
            {
                Console.WriteLine("bir sayı giriniz");
                int i1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("şunu girdiniz : "+ i1 );
            }
            catch(Exception ex)
            {
                Console.WriteLine(" Hata : "+ ex.Message);
                hata ="a";
            }
            finally
            {
                if (hata != "a"){Console.WriteLine("işleminiz başarıyla tamamlandı.");}
            }
            Console.WriteLine("******ArgumentNullException*******");
            try
            {
                Console.WriteLine("bir sayı giriniz");
                int i1 = int.Parse(null);
                Console.WriteLine("şunu girdiniz : "+ i1 );
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Alanı boş bıraktınız !");
                Console.WriteLine(ex);
            }
            Console.WriteLine("******FormatException*******");
            try
            {
                int f = int.Parse("No");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("veri tipi uygun değil !");
                Console.WriteLine(ex);
            }
            Console.WriteLine("******OverflowException*******");
            try
            {
                int o = int.Parse("-20000000000");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok büyük yada çok küçük değer girdiniz !");
                Console.WriteLine(ex);
            }
        }
    }
}
