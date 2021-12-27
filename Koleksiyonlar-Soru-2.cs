using System;
 namespace Koleksiyonlar_Soru_2
 {
     class Program
     {
        static void Main(string[] args)
        {
            int[] girilensayılar = new int[20];
            int[] En_küçük = new int[3];
            int[] En_büyük = new int[3];
            Console.WriteLine("Lütfen 20 Adet sayı giriniz");
            for (int i = 0; i < girilensayılar.Length;)
            {
                try{
                girilensayılar[i] = int.Parse(Console.ReadLine());
                 i++;
                }
                catch{
                    Console.WriteLine("Lütfen bir sayı giriniz");
                }
            }
            Array.Sort(girilensayılar);
            for (int i = 0 ; i < En_büyük.Length ; i++)
            {
                En_büyük[i] = girilensayılar[17 +i];
            }
            for (int i = 0 ; i < En_küçük.Length ; i++)
            {
                En_küçük[i] = girilensayılar[i];
            }
            /// ekrana yazdırma
            int kck_toplam = 0, byk_toplam = 0;
            float kck_ort = 0, byk_ort = 0;

            Console.WriteLine("********* En_küçük sayılar grubu *********");
            foreach (int item in En_küçük)
            {
                Console.Write(item + " ");
                kck_toplam += item;
            }
            Console.WriteLine();
            if(kck_toplam != 0 ) {kck_ort = kck_toplam/3.0f;}
            Console.WriteLine("sayı ortalaması : "+ kck_ort);
            
            Console.WriteLine();
            Console.WriteLine("********* En_büyük sayılar grubu *********");
            foreach (int item in En_büyük)
            {
                Console.Write(item + " ");
                byk_toplam += item;
            }
            Console.WriteLine();
            if(byk_toplam != 0 ) byk_ort = byk_toplam/3.0f;
            Console.WriteLine("sayı ortalaması : "+ byk_ort);
            Console.WriteLine();
            Console.WriteLine("iki grubun ortalama toplamları : "+ ((byk_toplam+kck_toplam)/3));
            ///  ekrana yazdırma   bitti  ! 
        }
     }
 }