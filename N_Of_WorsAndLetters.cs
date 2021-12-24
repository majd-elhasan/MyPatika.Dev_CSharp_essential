using System;
 namespace N_Of_WorsAndLetters
 {
     class Program4
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle giriniz !");
            string str = RemoveExtraWhiteSpaces(Console.ReadLine());
            string[] dizi = str.Split(" ");
            string str_joined = string.Join("",dizi);
            Console.WriteLine("cümleniz {0} adet kelimeden ve {1} adet harften oluşmaktadır ",dizi.Length , str_joined.Length);

        }
        static  string RemoveExtraWhiteSpaces(string param)
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
 }
