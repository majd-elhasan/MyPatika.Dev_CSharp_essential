using System;
 namespace Encapsulation
 {
     class MainClass
     {
        static void Main(string[] args)
        {
            ogrenci ogrenci_1 = new ogrenci();
            ogrenci_1.Isim = "Mecid";
            ogrenci_1.Soyisim = "El hasan";
            ogrenci_1.No = 4214694;
            ogrenci_1.Sinif = 3;
            ogrenci_1.ogrenci_bilgilerini_Getir();
            ogrenci_1.Sinif_Atlat();
            ogrenci_1.ogrenci_bilgilerini_Getir();
            ogrenci_1.Sinif_Dusur();
            ogrenci_1.Sinif_Dusur();
            ogrenci_1.Sinif_Dusur();
            ogrenci_1.Sinif_Dusur();

            ogrenci_1.ogrenci_bilgilerini_Getir();
            ogrenci ogrenci_2 =new ogrenci("kamil","taşçı",268,8);
            ogrenci_2.ogrenci_bilgilerini_Getir();
            ogrenci_2.Sinif_Atlat();
            ogrenci_2.ogrenci_bilgilerini_Getir();
        }
     }
     class ogrenci
     {
         private string isim = "";
         private string soyisim ="";
         private int no = 0;
         private int sinif = 0;

        public string Isim {
            get {return isim;}      // we can write (Get Set Method in this way , to make more easier to read .)
            set {isim = value;} 
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int No { get => no; set => no = value; }
        public int Sinif { 
            get{return sinif;}
            set{if (value < 1){ Console.WriteLine("sinif bilgisi 1'den düşük olamaz !"); sinif = 1;}
            else sinif = value; 
            }
        }
        public ogrenci(string ısim, string soyisim, int no, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            No = no;
            Sinif = sinif;
        }
        public ogrenci(){}
        public void ogrenci_bilgilerini_Getir(){
            Console.WriteLine("************************************");
            Console.WriteLine("öğrenci Adı         : {0} ",this.Isim);
            Console.WriteLine("öğrenci Soyadı      : {0} ",this.Soyisim);
            Console.WriteLine("öğrenci No          : {0} ",this.No);
            Console.WriteLine("öğrenci sınıfı      : {0} ",this.Sinif);
            Console.WriteLine("************************************");
        }
        public void Sinif_Atlat(){
            this.Sinif = this.Sinif +1;
        }
        public void Sinif_Dusur(){
            this.Sinif = this.Sinif -1;
        }
    }
 }