using System;
 namespace WhileForeach
 {
     class while_foeeach_program
     {
        static void Main(string[] args)
        {
            //while 
            // 1 den başlayıp consol dan girilen sayıya kadar ortalama hesaplayıp console a yazdıran program
            Console.WriteLine("birden kendisne kadar ortalama hesaplamak istediğiniz bir sayı giriniz !");
            Console.WriteLine("");
            int sayac = 1;
            int Toplam = 0;
            int sayi =0;
            string girdi = null;
            try
            {
            girdi = Console.ReadLine();
            sayi = int.Parse(girdi);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Lütfen bir sayı giriniz !");
            }
            if (sayi !=0)
            {
            while(sayac<=sayi)
            {
                Toplam +=sayac;
                sayac ++;
                
                
            } 
            float Toplamf = Toplam;
            float average = Toplamf/sayi;
            //Console.WriteLine(3/2);
            Console.WriteLine("1 den "+ sayi +" a kadar ortalama : " + average);
            }
            else if(girdi =="0") Console.WriteLine("Lütfen 0 dan büyük bir sayı giriniz !");
            Console.WriteLine("**************CharacterLoop****************");
            char Character = 'a';
            while (Character <= 'z')
            {
                Console.Write(Character + " ");
                Character ++ ;
            }
            Console.WriteLine("");
            Console.WriteLine("************ForEachLoop*************");
            string[] arabalar = {"Hundai","Nissan","voxwagen","Tofaş"};
            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
        }
     }
 }