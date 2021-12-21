using System;
 namespace Metot_tanimlama
 {
     class Metot_tanimlama_Program
     {
        static void Main(string[] args)
        {
            //erişim belirtici geridönüş_tipi  metodun_adı(paramitre_listesi/arguman)
            //{
                //return
            //}
            int a = 2;
            int b = 3;
            
            
            Metotlar metotlar = new Metotlar();
            metotlar.ArttırVeTopla_yerineYaz_(ref a,ref b);
            int sonuc = Topla(a,b);
            metotlar.EkranaYazdır(Convert.ToString(sonuc));
            
        }
        static int Topla(int deger1 , int deger2)
        {
            return deger1+deger2;
        }
     }
     class Metotlar
     {
         public void EkranaYazdır(string veri)
         {
             Console.WriteLine(veri);
         }
         public int ArttırVeTopla(int deger1, int deger2)
         {
             deger1 ++; deger2++;
             return deger1 + deger2;
         }
         //reference ↓
          public int ArttırVeTopla_yerineYaz_(ref int deger1,ref int deger2)
         {
             deger1 ++; deger2++;
             return deger1 + deger2;
         }
     }
 }