using System;
 namespace Static_sinif_ve_uyeler
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Çalışan Sayısı : {0}" ,calisan.CalisanSayisi);
            calisan calisan_1 = new calisan("Ayşe","yılmaz","IT");
            Console.WriteLine("Çalışan Sayısı : {0}" ,calisan.CalisanSayisi);
            calisan calisan_2 = new calisan("Mecid","Elhasan","IT");
            Console.WriteLine("Çalışan Sayısı : {0}" ,calisan.CalisanSayisi);
            Console.WriteLine(islemler.Topla(12,9));
            Console.WriteLine(islemler.cikar(12,9));
        }
     }
     class calisan
     {
        private static int calisanSayisi = 0;

        public static int CalisanSayisi { get => calisanSayisi;}
        private string isim;
        private string soyisim;
        private string depatman;
        //static calisan() => calisanSayisi = 0;
        public calisan(string Isim, string Soyisim,string Departman)
        {
            this.isim = Isim;
            this.soyisim = Soyisim;
            this.depatman = Departman;
            calisanSayisi ++;
        }

    }
    static class islemler
    {
        public static long Topla(int value1 , int value2)
        {
            return value1 + value2;
        }
         public static long cikar(int value1 , int value2)
        {
            return value1 - value2;
        }
    }

 }