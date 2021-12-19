using System;

namespace SwitchCase
{
    class Program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir ayın sıralamasını giriniz yada Enter'a basıp işlemi bilgisayara devredin ");
            int Manuel_Month =0;
            string s_Manuel_Month ="";
            try
            {
                s_Manuel_Month = Console.ReadLine();
                Manuel_Month = int.Parse(s_Manuel_Month);
            }
            catch(FormatException ex)
            {
                if(s_Manuel_Month !="")
                {
                Console.WriteLine("*******geçersiz bir sayı yazdınız !*********");
                 Environment.Exit(0);
                }
                if(s_Manuel_Month =="")
                {
                Console.WriteLine("*******seçimi bilgisayara bıraktınız*********");
                Manuel_Month = 0;
                }
               
            }
            int Month = Manuel_Month!= 0 ? Manuel_Month: DateTime.Now.Month;
            switch(Month)
            {
                case 1 :
                    Console.WriteLine("Ocak ayındasınız"); 
                    break;
                case 2 :
                    Console.WriteLine("Şubat ayındasınız"); 
                    break;
                case 3 :
                    Console.WriteLine("Mart ayındasınız"); 
                    break;
                case 4 :
                    Console.WriteLine("Nisan ayındasınız"); 
                    break;
                case 5 :
                    Console.WriteLine("mayıs ayındasınız"); 
                    break;
                case 6 :
                    Console.WriteLine("Haziran ayındasınız"); 
                    break;
                case 7 :
                    Console.WriteLine("Temmuz ayındasınız"); 
                    break;
                case 8 :
                    Console.WriteLine("Ağustos ayındasınız"); 
                    break;
                case 9 :
                    Console.WriteLine("Eylül ayındasınız"); 
                    break;
                case 10 :
                    Console.WriteLine("Ekim ayındasınız"); 
                    break;
                case 11 :
                    Console.WriteLine("Kasım ayındasınız"); 
                    break;
                case 12 :
                    Console.WriteLine("Aralık ayındasınız"); 
                    break;
                    // default komutunu da ekleyebilirim 
                default:
                    Console.WriteLine("Zamandan bağımsızsınız :)");
                    break; 
            }
            switch(Month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("kış mevsimindsiniz");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimindsiniz");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimindsiniz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimindsiniz");
                    break;

            }

        }

    }
}
