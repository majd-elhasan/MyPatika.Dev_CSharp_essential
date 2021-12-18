using System;
namespace For_dongusu
{
    class program8
    {
        static void Main(string[] args)
        {
            Console.Write("bir sayı giriniz : ");
            int sayi = 0;
            try{
            sayi = int.Parse(Console.ReadLine());}
            catch(FormatException ex)
            {Console.WriteLine("girdiğiniz değer sayi değildir !");}
            for(int i= 0; i <=sayi; i++)
            {
                if(sayi != 0)
                    Console.WriteLine(i);

            }
            for(int i=0;i<256;i++)
            {
                if(i%2 ==0)
                continue;
                Console.Write(i);
                Console.Write("  ");
            }
            Console.WriteLine("");
            int TekSayilar  = 0;
            int ciftSayilar = 0;
            for(int i=0;i<256;i++)
            {
                if(i%2 ==0)
                ciftSayilar += i;
                if(i%2 ==1)
                TekSayilar  += i;
               
            }
             Console.Write("TekSayılar Toplamı : " + TekSayilar + ", çiftSayılar Toplamı : " + ciftSayilar);
        }
    }
}