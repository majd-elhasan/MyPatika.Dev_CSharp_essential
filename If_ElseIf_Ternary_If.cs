using System;
namespace If_ElseIf_Ternary_If
{
    class Program6
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time > 5 && time<10){Console.WriteLine("Günaydın !");}
            else if(time >= 10 && time <18 ){Console.WriteLine("iyi günler !");}
            else Console.WriteLine("iyi geceler !");

            /// yada
            string s_time = time >5 && time <10 ? "Günaydın !":time >= 10 && time <18?"iyi günler !": "iyi geceler !";
            Console.WriteLine(s_time);
        }
    }
}
