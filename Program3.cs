using System;
 namespace Reverse_Sentence
 {
     class Program3
     {
        static void Main(string[] args)
        {
            byte n = 0;
            n_input_Method(ref n);
            Console.WriteLine("Lütfen {0} tane kelime giriniz ! ", n );
            string[] array = new string[n];
            for(byte b = 0 ; b < n ; b++)
            {
                array[b] = Console.ReadLine();
            }
            Console.WriteLine("girmiş olduğunuz kelimelerin ters sıralaması şu şekildeir : " );
            for(byte b = 1 ; b < n+1 ; b++)
            {
                Console.Write(array[n-b] + " ");
            }
        }
        static void n_input_Method(ref byte n)
        {
            Console.WriteLine("Lütfen kaç tane pozitif sayı girmek istediğinizi giriniz (n) !");
            string n_str = Console.ReadLine();
            bool n_input = byte.TryParse(n_str, out n);
            if (!n_input)
            {
                Console.WriteLine("Lütfen pozitif bir sayı (n) giriniz !");
                n_input_Method(ref n);
            }
        }
     }
 }