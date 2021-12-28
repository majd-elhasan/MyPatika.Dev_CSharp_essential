using System;
 namespace sinif_ozellikleri 
 {
     class main_class
     {
        static void Main(string[] args)
        {
            // class sözdizimi
            //sınıfAdi 
            // { 
                // (Erişim_belirleyici      veri_tipi    özellik_Adı)
                // Erişim belirleyici   geri dönüş tipi    Metod_Adı (parametre listesi))
                // {
                //       metot komutları
                // }
            // }

            // erişim belirleyici
            // public
            // private
            // internal
            // protected
            calisan calisan1 = new calisan();
            calisan1.Ad ="Mecid";
            calisan1.Soyad ="el hasan";
            calisan1.Cep_telefonu = 05355517164;
            calisan1.Departman = "Döşeme";
            calisan1.calisan_bilgileri();
            Console.WriteLine("*****************");
            calisan calisan2 = new calisan();
            calisan2.Ad ="yemin";
            calisan2.Soyad ="japon";
            //calisan2.Cep_telefonu = 05874135784;
            calisan2.Departman = "tasarlamacılık";
            calisan2.calisan_bilgileri();
        }
     }
     class calisan
     {
         public string Ad ="";
         public string Soyad = "";
         public long Cep_telefonu ;
         public string Departman= "";
         public void calisan_bilgileri(){
            Console.WriteLine("çalışan adı          : {0}", Ad);
            Console.WriteLine("çalışan soyadı       : {0}", Soyad);
            Console.WriteLine("çalışan cep_telefonu : {0}", Cep_telefonu);
            Console.WriteLine("çalışan depatmanı    : {0}", Departman);
         }
     }
 }
