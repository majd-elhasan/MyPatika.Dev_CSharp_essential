using System;
 namespace EvenNumberPrinter
 {
     class Program1
     {
        static void Main(string[] args)
        {
            byte n = 0;
            n_input_Method(ref n);
            TheNumbers_Method(n);
        }
        static byte n_input_Method(ref byte n)
        {
            Console.WriteLine("Lütfen kaç tane pozitif sayı girmek istediğinizi giriniz (n) !");
            string n_str = Console.ReadLine();
            bool n_input = byte.TryParse(n_str, out n);
            if (!n_input)
            {
                Console.WriteLine("Lütfen pozitif bir sayı (n) giriniz !");
                n_input_Method(ref n);
            }
            return n;
        }
        static void TheNumbers_Method(byte n)
        {
            Console.WriteLine("Lütfen {0} tane pozitif sayı giriniz !",n);
            uint[] array = new uint[n];
            uint Number =0;
            for (byte b = 0; b <n ;b++)
            {   
               TekrarGir(ref Number ,ref array , ref b);
            }
            Console.Write("Girmiş olduğunuz sayılar : ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Girmiş olduğunuz sayıların çift olanları aşağıdadır ↓");
            foreach (var item in array)
            {
                if(item %2 == 0)
                Console.Write(item + " ");
            }

        }
        static void TekrarGir(ref uint Number , ref uint[] array , ref byte b)
        {
            string str = Console.ReadLine();
            bool Number_input = uint.TryParse(str, out Number);
            if (!Number_input)
                {
                     Console.WriteLine("Lütfen pozitif bir sayı giriniz!");
                     TekrarGir(ref Number , ref array, ref b);
                }
            else {array[b] = Number;}
        }

     }
 }