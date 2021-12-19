using System;
 namespace dizi_tanimlama
 {
     class dizi_tanimlama_program
     {
        static void Main(string[] args)
        {
            //dizi Tanımlama
            string[] Renkler = new string[5];
            string[] Hayvanlar = {"Yılan","akrep","Kartal","Doğan"};
            int[] dizi ;
            dizi = new int[5];
             // değer atama
             dizi[3] = 46;
             Renkler[1] = "yeşil";
             Hayvanlar[1] = "Akrep";

             Console.WriteLine(dizi[3]);
             Console.WriteLine(Renkler[1]);
             Console.WriteLine(Hayvanlar[1]);

             //döngülerle dizi kullanımı
             // klavyeden girilen n tane sayın ın ortalamasını hesaplayan program
             Console.Write("Lütfen dizinin eleman sayısını giriniz : ");
             int dizi_uzunluğu = int.Parse(Console.ReadLine());
             int[] sayi_dizisi = new int[dizi_uzunluğu];
            float toplam = 0;
            for (int i= 0 ;i < dizi_uzunluğu; i ++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz : ",i+1);
                sayi_dizisi[i] = int.Parse(Console.ReadLine());
                toplam += sayi_dizisi[i];
            }
            Console.WriteLine("ortalama : " + toplam/dizi_uzunluğu);

        }
     }
 }