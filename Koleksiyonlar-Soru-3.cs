using System;
 namespace Koleksiyonlar_Soru_3
 {
     class Program
     {
        static void Main(string[] args)
        {
            string s ="";
            sentence(ref s);
            char[] sesli_harfler = {'a','e','ı','i','o','ö','u','ü'}; 
            List<char> ayrılan_ünlüler = new List<char>();
            for(int i = 0 ; i < sesli_harfler.Length ; i++){
                foreach (char item in s)
                {
                    if(sesli_harfler[i] == item){ayrılan_ünlüler.Add(item);}
                }
            }
            char[] array = new char[ayrılan_ünlüler.Count];
            for ( int i = 0 ; i< ayrılan_ünlüler.Count ; i++)
            {
                array[i] = ayrılan_ünlüler[i];
            }
            /*foreach (char item in array)   // türk alfabesine göre saralanmıştır ✓
            {
                Console.Write(item + " ");
            }*/
        }
        static void sentence(ref string s){
            Console.WriteLine("Lütfen bir cümle giriniz");
            s = Console.ReadLine();
            if(s == null || s =="") sentence(ref s);
        }
     }

 }