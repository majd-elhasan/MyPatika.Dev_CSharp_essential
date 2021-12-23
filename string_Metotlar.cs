using System;
 namespace String_Metotlar
 {
     class string_Metotlar
     {
        static void Main(string[] args)
        {
            string variable1 = "Dersimiz Csharp; Hoşgeldiniz!";
            string variable2 ="Csharp";
            //Length
            Console.WriteLine(variable1.Length);
            //ToUpper ToLower
            Console.WriteLine(variable1.ToUpper());
            Console.WriteLine(variable1.ToLower());
            //Concat  (adding a string to the end of the current string)
            Console.WriteLine(String.Concat(variable1," Merhaba!"));
            // CompareTo   // if (variable1 > variable2) returns 1 ,  if (variable1 < variable2) returns -1 , if (variable1 == variable2) returns 0;
            Console.WriteLine(variable1.CompareTo(variable2)); 
            //Compare      // if (variable1 > variable2) returns 1 ,  if (variable1 < variable2) returns -1 , if (variable1 == variable2) returns 0;
            Console.WriteLine(String.Compare(variable1,variable2,true));  //  Büyük_Küçük harf duyarlılığı yok
            Console.WriteLine(String.Compare(variable1,variable2,false));  // //  Büyük_Küçük harf duyarlılığı var
            //Contains   // returns (true || false)
            Console.WriteLine(variable1.Contains(variable2));
            Console.WriteLine(variable1.EndsWith("Hoşgeldiniz!"));  // ?
            Console.WriteLine(variable1.StartsWith("Merhaba !"));  // ?
            // indexOf
            Console.WriteLine(variable1.IndexOf("Cs")); // ilk Cs kombinasyonunun sıralamasını verir // yoksa  -1 değerini verir ;

            // Last index of
            Console.WriteLine(variable1.LastIndexOf("i"));  // bu durumda 26
            // insert
            Console.WriteLine(variable1.Insert(0, "Merhaba ! "));
            // PadLeft ,PadRight
            Console.WriteLine(variable2.PadLeft(10));   // returns (' ' *4 + "Csharp")  == "    Csharp"     // because in this case Csharp.Length = 6 .
            Console.WriteLine(variable2.PadLeft(10,'*'));  // returns ('*' *4 + "Csharp")  == "    Csharp"     // because in this case Csharp.Length = 6 .
            // Remove
            Console.WriteLine(variable1.Remove(10));   // removes from index 10 to the end of the variable
            Console.WriteLine(variable1.Remove(10,3));  // removes from index 10 , 3 Times (to index [10] + [3] = [13]) (13 not included)
            // Replace
            Console.WriteLine(variable1.Replace("Csharp","C#"));
            Console.WriteLine(variable1.Replace(" ","*"));
            // Split
            Console.WriteLine(variable1.Split(" ")[1]);
            //Substring
            Console.WriteLine(variable1.Substring(7));  //  7. index'ten başlayarak stringin sonuna kadar getirir 
            Console.WriteLine(variable1.Substring(7,6));  // 7, index'ten başlayarak 6 karakter getirir 

        }
     }
 }
