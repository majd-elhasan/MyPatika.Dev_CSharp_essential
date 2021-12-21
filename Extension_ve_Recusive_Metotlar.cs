using System;
 namespace Extension_ve_Recusive_Metotlar
 {
     class Program
     {
        static void Main(string[] args)
        {
            // Recursive ---- öz yinelemeli
            islemler islemler = new();
            int Number = 1;
            int Number2 = 5;
            for(int i = 0 ; i < 4 ; i++)
            {
                Number *= 3;
            }
            Console.WriteLine(Number);
            int Number3 = islemler.Expo(Number2,3);
            Console.WriteLine(Number3);

            // Extension Metotlar 
            string ifade = "Mecid      Elhasan     Aga";
            Console.WriteLine(ifade.CheckSpaces());
            Console.WriteLine(ifade.RemoveWhiteSpaces());
            Console.WriteLine(ifade.RemoveExtraWhiteSpaces());

            int[] arrayOfNumbers = {5,4,8,32,61,0,27};
            arrayOfNumbers.Array_sortAndPrint();
            Console.WriteLine(ifade.GetFirstCharacter());
            Console.WriteLine(arrayOfNumbers[4].İsEvenNumber());

        }
     }
     class islemler
     {
         public int Expo(int sayi , int üs)
         {
             if(üs ==1 ) return sayi;
            return Expo(sayi , üs-1) * sayi;
         }
         public string RemoveExtraWhiteSpaces(string param)
         {
             string str ="";
             for(int i = 1 ; i < param.Length ; i++)
             {
                 if(param[i] != ' ' || (param[i] == ' ' && param[i-1] != ' '))
                 str += param[i-1];
                  if(i == param.Length-1)
                 {
                   str += param[i];
                 }
             }
             return str;
         }
     }
     
     public static class Extension
     {
         public static bool CheckSpaces(this string ifade)
         {
             return ifade.Contains(" ");
         }
         public static string RemoveWhiteSpaces(this string param)
         {
             string[] dizi = param.Split(" ");
             return string.Join("",dizi);
         }
         public static string RemoveExtraWhiteSpaces(this string param)
         {
             string str ="";
             for(int i = 1 ; i < param.Length ; i++)
             {
                 if(param[i] != ' ' || (param[i] == ' ' && param[i-1] != ' '))
                 str += param[i-1];
                  if(i == param.Length-1)
                 {
                   str += param[i];
                 }
             }
             return str;
         }
         public static void Array_sortAndPrint(this int[] array)
         {
             Array.Sort(array);
             foreach (int item in array)
             {
                 Console.Write(item + " ");
             }
             Console.WriteLine("");
         }
         public static bool İsEvenNumber(this int N)
         {
             return N%2 == 0;
         }
         public static string GetFirstCharacter (this string S)
         {
             return S.Substring(0,1);
         }
    }
 }
