using System;
 namespace Array_sinifi
 {
     class Array_sinifi_program
     {
        static void Main(string[] args)
        {
            Console.WriteLine("*******sırasız dizi**********");
            int[] sayidizisi = {4,5,87,26,32,10,41,0};
            foreach (var item in sayidizisi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*******sıralı dizi**********");
            Array.Sort(sayidizisi);
            foreach (var item in sayidizisi)
            {
                 Console.WriteLine(item);
            }
            Console.WriteLine("*******Clear metodu**********");
            Array.Clear(sayidizisi,3,2);
            foreach (var item in sayidizisi)
            {
                 Console.WriteLine(item);
            }
            Console.WriteLine("*******yeniden boyutlandırma**********");
            Array.Resize<int>(ref sayidizisi,10);
            foreach (var item in sayidizisi)
            {
                 Console.WriteLine(item);
            }
            Console.WriteLine("*******terse çevirme**********");
            Array.Reverse(sayidizisi);
            foreach (var item in sayidizisi)
            {
                 Console.WriteLine(item);
            }
            Console.WriteLine("*******index Of**********");            
            Console.WriteLine(Array.IndexOf(sayidizisi,15));
        }
     }
 }