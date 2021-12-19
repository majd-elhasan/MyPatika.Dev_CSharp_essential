using System;

namespace Conversions
{
    class Program4
    {
        static void Main(string[] args)
        {
            // Implicit conversions (Bilinçsiz dönüştürme)
            byte b1 = 12;
            sbyte sb1 = -3;
            short sh1 = 1995;

            int i1 = b1 + sb1 + sh1;
            Console.WriteLine("i1 = " + i1);
            long l1 = i1;
            Console.WriteLine("l1 = " + l1);
            float f1 = l1;
            Console.WriteLine("f1 = " + f1);

            string str1 = "Mecid";
            char ch1 = '7';
            int i2 = 256;

            object ob1 = str1 + ch1 + i2;
            Console.WriteLine("ob1 = " + ob1);

            // Explicit conversions (Bilinçli dönüştürme)
            byte b2 = (byte)sb1;
            Console.WriteLine("b2 = " + b2);
            b2 = (byte)sh1;
            Console.WriteLine("b2 = " + b2);

            float f2 = 5.3f;
            byte b3 = (byte)f2;
            Console.WriteLine("b2 = " + b3);
             // ToString Metodu

             int i3 = 2;
             string str2 = i3.ToString();
             Console.WriteLine("str2 = " + str2);

             string str3 =12.7f.ToString();
             Console.WriteLine("str3 = " +str3);

             //System.Convert
             String str4 = "12", str5 = "67";
             int i4,i5;
             i4 = Convert.ToInt16(str4);
             i5 = Convert.ToInt16(str5);

             int Toplam = i4 + i5;
             Console.WriteLine("Toplam = " + Toplam);

             //Parse

             string str6 = "45", str7 = "90,83";
             int i6 = Int16.Parse(str6);
             double d7 = double.Parse(str7);

             Console.WriteLine("i6 = " + i6);
             Console.WriteLine("d7 = " + d7);

        }
    }
}
