using System;
namespace Variables
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("");
            int i = 5;
            uint ui = 4000000000u;
            double d = 3.2d;
            float f = 1.6f;
            decimal dec = 51234567891234567891234567893.54000m;

            short sh = -20598;
            ushort ush = 40000;
            byte b1 = 210;
            sbyte sb1 = -100;

            long l1 = -1234567890123456789l;
            ulong ul1 = 12345678901234567890ul;

            char ch = '5';
            bool bool1 = true;
            string str1 = "27";

            object obje1= "Patika.dev";
            object obje2 = 10;
            object obje3 = "numara !";

            
            string str = "the life is good when we live it true !";
            Console.WriteLine(Convert.ToInt32(str1)+i);

            DateTime d_today = DateTime.Today;
            Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy"));
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            Console.WriteLine(obje1);
            Console.WriteLine(obje2);
            Console.WriteLine(obje3);

            
        }
    }
}
