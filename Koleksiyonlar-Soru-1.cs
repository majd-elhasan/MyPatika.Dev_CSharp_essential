using System;
using System.Collections;

 namespace Koleksiyonlar_Soru_1
 {
     class Program
     {
        static void Main(string[] args)
        {
            ArrayList asal = new ArrayList();
            ArrayList asal_olmayan = new ArrayList();
            List<uint> asal_sayılar = new List<uint>(){2};
            for(uint i = 3 ; i< 66000 ;i++)
            {
                double root = Math.Sqrt(i);
                uint Ceiling_Of_Root = (uint)Math.Ceiling(root);
                if (Math.Round(root) == root ) {continue;}
                for(int j = 0 ; j < asal_sayılar.Count ; j++)
                {
                    if (i%asal_sayılar[j] == 0){break;}
                    if(j == asal_sayılar.Count-1 || asal_sayılar[j] > Ceiling_Of_Root ){asal_sayılar.Add(i); break;}
                }
            }
            // giriş mesajı
            Console.WriteLine("Lütfen 20 Adet pozitif sayı giriniz");
            for(int k = 0 ; k< 20 ; k++) 
            {
                try{
                    string s = Console.ReadLine();
                    uint girilen_sayi = uint.Parse(s);
                    if (girilen_sayi > asal_sayılar[asal_sayılar.Count-1])
                    for(uint i = asal_sayılar[asal_sayılar.Count-1] ; i< girilen_sayi+1 ;i++)
                    {
                        double root = Math.Sqrt(i);
                        uint Ceiling_Of_Root = (uint)Math.Ceiling(root);
                        if (Math.Round(root) == root ) {continue;}
                        for(int j = 0 ; j < asal_sayılar.Count ; j++)
                        {
                            if (i%asal_sayılar[j] == 0){break;}
                            if(j == asal_sayılar.Count-1 || asal_sayılar[j] > Ceiling_Of_Root ){
                                asal_sayılar.Add(i);
                                break;
                                }
                        }
                    }
                    foreach (uint item in asal_sayılar)
                    {
                       if(item == girilen_sayi && !asal.Contains(girilen_sayi)){ asal.Add(girilen_sayi); break;}
                       if(girilen_sayi%item == 0 && !asal_olmayan.Contains(girilen_sayi)) asal_olmayan.Add(girilen_sayi);
                    }
                }
                catch{Console.WriteLine("Lütfen pozitif bir sayı giriniz ");}
                
            }
            Console.WriteLine();
            uint asal_toplam =0;
            uint asal_olmayan_toplam = 0 ;
            // asal sayılar
            Console.WriteLine("Asal sayılar dizisi : ");
            asal.Sort(); asal.Reverse();
            foreach (uint item in asal)
            {
                Console.Write(item + " ");
                asal_toplam += item; 
            }
            Console.WriteLine();
            // asal olmayan sayılar
            Console.WriteLine("Asal olmayan sayılar dizisi: ");
            asal_olmayan.Sort(); asal_olmayan.Reverse();
            foreach (uint item in asal_olmayan)
            {
                Console.Write(item + " ");
                asal_olmayan_toplam += item;
            }
            Console.WriteLine();
            Console.WriteLine();

            // eleman sayısı ve ortalama
            if (asal.Count == 0) {Console.WriteLine("     asal    sayılar dizisi eleman sayısı {0} , sayıların ortalamısı ise {1} ",0, 0);}
            else Console.WriteLine("     asal    sayılar dizisi eleman sayısı {0} , sayıların ortalamısı ise {1} ",asal.Count, (float)asal_toplam/asal.Count);
            if(asal_olmayan.Count == 0) { Console.WriteLine("asal olmayan sayılar dizisi eleman sayısı {0} , sayıların ortalamısı ise {1} ",0, 0);}
            else Console.WriteLine("asal olmayan sayılar dizisi eleman sayısı {0} , sayıların ortalamısı ise {1} ",asal_olmayan.Count, (float)asal_olmayan_toplam/asal_olmayan.Count);
            

        }
     }
 }