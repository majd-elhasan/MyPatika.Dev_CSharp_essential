using System;
using System.Collections;

 namespace arrayList
 {
     class Program
     {
        static void Main(string[] args)
        {
            // using System.Collections;
            ArrayList liste = new ArrayList();
            /*liste.Add("Ayşe");
            liste.Add(2);
            liste.Add('N');
            liste.Add(false);
            liste.Add("Mecid");
            liste.Add("Yemin");
            liste.Add(5);
            liste.Add(true);
            liste.Add('A');*/
            liste.Add(5);
            liste.Add(30);
            liste.Add(03);
            liste.Add(05);
            liste.Add(84);
            liste.Add(75);
            liste.Add(61);
            liste.Add(13);
            liste.Add(9);
           

            // içerisinde verilere erişim
            Console.WriteLine(liste[3]);

            // the capasity of the ArrayList in Bytes  8 , 16 , 24 , 32 , .......8*i
            Console.WriteLine("**********list.Capacity**********");
            Console.WriteLine(liste.Capacity);

            // the number of the elements in the list
            Console.WriteLine("**********list.Count**********");
            Console.WriteLine(liste.Count);

            Console.WriteLine("*********sortedArraylist*********");
            for(int i = 0 ; i < liste.Count ; i++)
            {
                
                Console.Write(liste.Sort_Arraylist()[i] + " ");
                
            }
            liste = liste.Sort_Arraylist();
            Console.WriteLine();

            // we can add lists or arrays to our ArrayList by AddRange Method 
            List<string> hayvanlar = new List<string>(){"köpek","kedi","yılan","at","maymun"};
            string[] renkler = {"mavi","sarı","mor","turuncu"};

            //liste.AddRange(renkler);
            //liste.AddRange(hayvanlar);
            
            Console.WriteLine();
            liste = liste.Sort_Arraylist();
            Console.WriteLine(liste.BinarySearch(5));
            Console.WriteLine("**********Reverse***********");
            liste.Reverse();
            for(int i = 0 ; i < liste.Count ; i++)
            {
                
                Console.Write(liste[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("**********Clear***********");
            liste.Clear();
            for(int i = 0 ; i < liste.Count ; i++)
            {
                
                Console.Write(liste[i] + " ");
            }

        }
     }
     public static class Extentions
     {
         public static ArrayList Sort_Arraylist(this ArrayList list)
         {
             // string  - char - int - bool
             ArrayList SortedList = new ArrayList();
             ArrayList str_list = new ArrayList();
             ArrayList char_list = new ArrayList();
             ArrayList int_list = new ArrayList();
             ArrayList bool_list = new ArrayList();
            for(int i = 0 ;i < list.Count ; i ++ ){
             if (list[i] is string) str_list.Add(list[i]);
             if (list[i] is char) char_list.Add(list[i]);
             if (list[i] is int) int_list.Add(list[i]);
             if (list[i] is bool) bool_list.Add(list[i]); 
            }
            str_list.Sort();
            char_list.Sort();
            int_list.Sort();
            bool_list.Sort();
            SortedList.AddRange(str_list);
            SortedList.AddRange(char_list);
            SortedList.AddRange(int_list);
            SortedList.AddRange(bool_list);
            return SortedList;
         }
     }
 }
