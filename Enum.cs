using System;
 namespace Enums
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            Console.WriteLine(gunler.cuma);
            Console.WriteLine((int)gunler.cuma);
            Console.WriteLine("Şuanki hava sıcaklığını giriniz ");
            int Tempreture = int.Parse(Console.ReadLine());
            if (Tempreture < (int)HavaDurumu.Dondurucu)
                Console.WriteLine("dışarıya çıkmak için çok soğuk bir gün");
            else if (Tempreture > (int)HavaDurumu.Dondurucu && Tempreture <= (int)HavaDurumu.Soğuk)
            {
                Console.WriteLine("dışarıya çıkmak için soğuk bir gün , ama kalın elbise giyersen iyi olur");
            }
            else if (Tempreture > (int)HavaDurumu.Soğuk && Tempreture <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("dışarıya çıkalım .Hava çok güzel");
            }
            else if (Tempreture > (int)HavaDurumu.Normal && Tempreture <= (int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("dışarıya çıkmak için sıcak bir gün , ama ince veya açık renkli elbise giyersen iyi olur");
            }
            else if (Tempreture > (int)HavaDurumu.Sıcak && Tempreture < (int)HavaDurumu.ÇokSıcak)
            {
                Console.WriteLine("dışarıya çıkmak için çok sıcak bir gün ,  sakın dışarı çıkma !");
            }
            else
            {
                Console.WriteLine("etrafınızda yangın mı var ! Durumunuz kötü vallah ");
            }
        }
     }
     enum gunler
     {
         pazartersi =1,
         salı,
         çarşamba,
         perşembe,
         cuma,
         cumartesi,
         pazar
     }
     enum  HavaDurumu
     {
         Dondurucu = -5,
         Soğuk = 10,
         Normal = 20,
         Sıcak = 30,
         ÇokSıcak = 36
     }
 }