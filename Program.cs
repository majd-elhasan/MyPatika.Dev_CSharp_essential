using System;
using System.Collections.Generic;
 namespace Dictionary 
 {
     class Program
     {
        static void Main(string[] args)
        {
            // System.Collections.Generic;
            Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(45,"Ahmed");
            kullanıcılar.Add(41,"Mahmud");
            kullanıcılar.Add(31,"Ömer");
            kullanıcılar.Add(12,"Muhammed");
            kullanıcılar.Add(27,"Mecid");
            kullanıcılar.Add(17,"Yemin");
            // Dizi Elemanlara erişim 
            Console.WriteLine("***********Dizi elemanlarına erişim".PadRight(40,'*'));
            Console.WriteLine(kullanıcılar[27]);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }
            // Count
            Console.WriteLine("***********Count".PadRight(40,'*'));
            Console.WriteLine(kullanıcılar.Count);
            // Contains
            Console.WriteLine("***********Contains".PadRight(40,'*'));
            Console.WriteLine(kullanıcılar.ContainsKey(27));
            Console.WriteLine(kullanıcılar.ContainsValue("Yemin"));
            // Remove 
            Console.WriteLine("***********Remove".PadRight(40,'*'));
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item.Value);   
            }
            // Keys 
            Console.WriteLine("***********Keys".PadRight(40,'*'));
            foreach (var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item);
            }

            // Values 
            Console.WriteLine("***********Values".PadRight(40,'*'));
            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
            }
        }
     }
 }