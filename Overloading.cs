using System;
 namespace Metot_overloading
 {
     class Metot_overloading_Program
     {
        static void Main(string[] args)
        {
            // out parametre
            Metotlar metotlar = new Metotlar();
            string sayi = "999";

            bool str_int = int.TryParse(sayi , out int sonuc);
            if (str_int)
            {
                Console.WriteLine("Çevirme işlemi başarılı !");
                Console.WriteLine(sonuc);
            }
            else Console.WriteLine("Çevirme işlemi başarısız !");
            metotlar.Topla(5,7,out int toplam);
            Console.WriteLine(toplam);

            // metot aşırı yükleme
            int sayi2 = 27;
            metotlar.ekranaYazdir(Convert.ToString(sayi2));
            metotlar.ekranaYazdir(sayi2);
            metotlar.ekranaYazdir("Mecid","Elhasan");

            // Metot imzası : Metod adı + parametre sayısı + parametre tipi

        }
     }
     class Metotlar
     {
         public void Topla(int a,int b,out int total)
         {
             total = a+b;
         }
         public void ekranaYazdir(string a)
         {
             Console.WriteLine(a);
         }
         public void ekranaYazdir(int a)
         {
             Console.WriteLine(a);
         }
         public void ekranaYazdir(string  a , string b)
         {
             Console.WriteLine(a +" "+ b);
         }
     }
 }
