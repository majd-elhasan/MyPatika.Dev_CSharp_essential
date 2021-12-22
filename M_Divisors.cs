using System;
 namespace M_Divisors
 {
     class Program2
     {
        static void Main(string[] args)
        {
            byte  n = 0;
            uint m = 0;
            n_input_Method(ref n);
            m_Method(ref m);
            TheNumbers_Method(n,m);
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
        static void m_Method(ref uint m)
        {
            Console.WriteLine("Lütfen pozitif bir (m) sayı giriniz !");
            string m_str = Console.ReadLine();
            bool m_input = uint .TryParse(m_str, out m);
            if (!m_input)
            {
                Console.WriteLine("Lütfen pozitif bir (m) sayı giriniz !");
                m_Method(ref m);
            }
        }
        static void TheNumbers_Method(byte n , uint m)
        {
            Console.WriteLine("Lütfen {0} tane pozitif sayı giriniz !",n);
            uint[] array = new uint[n];
            uint Number =0;
            for (uint b = 0; b <n ;b++)
            {   
               TekrarGir(ref Number ,ref array , ref b);
            }
            Console.Write("Girmiş olduğunuz sayılar : ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Girmiş olduğunuz sayıların m'e eşit yada tam bölünenleri aşağıdadır ↓");
            foreach (var item in array)
            {
                if(m%item == 0)
                Console.Write(item + " ");
            }

        }
        static void TekrarGir(ref uint Number , ref uint[] array , ref uint b)
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
