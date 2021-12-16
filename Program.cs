using System;
namespace operatorler
{
    class program
    {
        static void Main(string[] args)
        {
            // atama ve işlamli atama işlemleri 
            Console.WriteLine("*****atama ve işlemli atama işlemleri*****");

            int x = 1;
            int y = 2;
            y = x++;
            Console.WriteLine("y = " + y);
            y = x++;
            Console.WriteLine("y = " + y);
            y += x;
            Console.WriteLine("y = " + y);
            x *= y;
            Console.WriteLine("x = " + x);
            
            // Aritmetik işlemler
            Console.WriteLine("*****Aritmetik işlemler*****");
            y = x%2;
            Console.WriteLine("y = " + y);
            y = x/5;
            Console.WriteLine("y = " + y);
            double z  = Math.Pow(x,2);
            Console.WriteLine("z = " + z);
            z = Math.Pow(x%2 +x/5 , 2);
            Console.WriteLine("z = " + z);

            // Mantıksal işlemler
            Console.WriteLine("*****Mantıksal işlemler*****");
            bool b1 = x>10 && z> 10;
            Console.WriteLine("b1 is " + b1);
            bool b2 = !b1;
            Console.WriteLine("b2 is " + b2);

            // ilişkisel operatörler
            Console.WriteLine("*****ilişkisel operatörler*****");
            bool b5 = z>x;
            Console.WriteLine("b5 is " + b5);
             x++;
            Console.WriteLine("The variable x was increased 1 !");
             Console.WriteLine(x);
             Console.WriteLine(z);
             Console.WriteLine("b5 is " + b5);
            bool b6 = z/2 >x;
            Console.WriteLine("b6 is " +b6);
            bool b7 = z>0;
            Console.WriteLine("b7 is " +b7);
            z = -2;
            b7 = z>0;
            Console.WriteLine("b7 is " +b7);
        }
    }
}
