using System;
 namespace Datetime_AndMathClasses
 {
     class Program
     {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine("********Add******");
            Console.WriteLine(DateTime.Now.AddDays(2));  // 2 gün ekle
            Console.WriteLine(DateTime.Now.AddHours(1));

            Console.WriteLine("*******Date Format********");
            Console.WriteLine(DateTime.Now.ToString("dd")); //  24
            Console.WriteLine(DateTime.Now.ToString("ddd"));  // sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); // saturday

            Console.WriteLine(DateTime.Now.ToString("MM"));  //  04
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // April

            Console.WriteLine(DateTime.Now.ToString("yy")); // 21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2021

            Console.WriteLine("*********Math kütühanesi*******");
            Console.WriteLine(Math.Abs(-27));
            Console.WriteLine(Math.Sin(Math.PI/6));  // in radian

        }
     }
 }