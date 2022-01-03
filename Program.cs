using System;
using System.Collections;
 namespace Telefon_Rehberi_Space
 {
     class Program
     {
        static void Main(string[] args)
        {
            List<Kisiler> kisiler_list = new List<Kisiler>();
            Kisiler kisiler_1 = new Kisiler("MECİD","EL HASAN",5987431);
            Kisiler kisiler_2 = new Kisiler("AHMET","ASLAN",4568732);
            Kisiler kisiler_3 = new Kisiler("AYŞE","DEMİRCİ",8760456);
            Kisiler kisiler_4 = new Kisiler("FUAT","YAHYA",4554006);
            Kisiler kisiler_5 = new Kisiler("YUNUS","EMRE",1149682);
            kisiler_list.Add(kisiler_1);
            kisiler_list.Add(kisiler_2);
            kisiler_list.Add(kisiler_3);
            kisiler_list.Add(kisiler_4);
            kisiler_list.Add(kisiler_5);
            Main_Menu();
            void Main_Menu(){
                Console.WriteLine();
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine("*******************************************");
                Console.WriteLine("  (1) Yeni Numara Kaydetmek");
                Console.WriteLine("  (2) Varolan Numarayı Silmek");
                Console.WriteLine("  (3) Varolan Numarayı Güncelleme");
                Console.WriteLine("  (4) Rehberi Listelemek");
                Console.WriteLine("  (5) Rehberde Arama Yapmak");
                switch(Console.ReadLine()){
                    case "1":
                        kisi_Ekle();
                        break;
                    case "2":
                        kisi_sil();
                        break;
                    case "3":
                        Numara_Guncelle();
                        break;
                    case "4":
                        Rehber_Listeleme();
                        break;
                    case "5":
                        Rehberde_Arama();
                        break;
                    default:
                        Console.WriteLine("yanlış seçim yaptınız , lütfen tekar seçiniz !");
                        Main_Menu();
                    break;
                }

            }

            // (1) Yeni Numara Kaydetmek
            void kisi_Ekle()
            {
                Console.Write("Lütfen isim giriniz             :");
                string isim = Console.ReadLine().ToUpper();
                Console.Write("Lütfen soyisim giriniz          :");
                string soyisim = Console.ReadLine().ToUpper();
                Console.Write("Lütfen telefon numarası giriniz :");
                long numara = long.Parse(Console.ReadLine());
                if (isim != null && soyisim != null && numara !=0)
                {
                    Kisiler _kisiler = new Kisiler(isim,soyisim,numara);
                    kisiler_list.Add(_kisiler);
                    Main_Menu();
                }
                else {Console.WriteLine("Lütfen alanları boş bırakmayınız !");}
            }

            // (2) Var olan Numarayı Silmek
            void kisi_sil()
            {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string input=Console.ReadLine();
                if (input != null)
                {
                    input = input.ToUpper();
                    for (int i = 0 ; i < kisiler_list.Count; i ++)
                    {
                        if (kisiler_list[i].Isim == input || kisiler_list[i].Soyisim == input) {
                            kisiler_list[i].Kisi_bilgilerini_Getir();
                            // Rehberde uygun veri bulunursa:
                            Console.WriteLine("  {0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",kisiler_list[i].Isim);
                            if(Console.ReadLine()== "y") 
                            {
                                Console.WriteLine("{0} isimli kişi rehberden silindi ",kisiler_list[i].Isim);
                                kisiler_list.RemoveAt(i);
                                Main_Menu();
                            }
                            else {Main_Menu();}
                            }
                        else if (i == kisiler_list.Count-1) kisi_silme_veriBulunamadı();
                    }
                    
                }
                else Main_Menu();
            }
            void kisi_silme_veriBulunamadı(){
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                        Console.WriteLine("* Yeniden denemek için      : (2)");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Main_Menu();
                                break;
                            case "2":
                                kisi_sil();
                                break;
                            default:
                            Console.WriteLine("Hatalı bir tuşlama yaptınız "); kisi_silme_veriBulunamadı();
                            break;
                        }
            }
            void kisi_guncelleme_veriBulunamadı(){
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                        Console.WriteLine("* Yeniden denemek için      : (2)");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Main_Menu();
                                break;
                            case "2":
                                kisi_sil();
                                break;
                            default:
                            Console.WriteLine("Hatalı bir tuşlama yaptınız "); kisi_silme_veriBulunamadı();
                            break;
                        }
            }
            
            // Not: Rehber uygun kriterlere uygun birden fazla kişi bulunursa ilk bulunan silinmeli.

            // (3) Varolan Numarayı Güncelleme
            void Numara_Guncelle(){
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string input=Console.ReadLine();
                if (input != null)
                {
                    input = input.ToUpper();
                    for (int i = 0 ; i < kisiler_list.Count; i ++)
                    {
                        if (kisiler_list[i].Isim == input || kisiler_list[i].Soyisim == input) {
                            kisiler_list[i].Kisi_bilgilerini_Getir();
                            // Rehberde uygun veri bulunursa:
                            Console.WriteLine("  {0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",kisiler_list[i].Isim);
                            if(Console.ReadLine()== "y") {kisiler_list.RemoveAt(i); kisi_Ekle();}
                            else {Main_Menu();}
                            }
                        else if (i == kisiler_list.Count-1) kisi_silme_veriBulunamadı();
                    }
                }
                else Main_Menu();
            }

            // (4) Rehberi Listelemek
            void Rehber_Listeleme(){
                Console.WriteLine("Lütfen Listeleme seklini seçiniz");
                Console.WriteLine("* A'dan Z'ye  : (1)");
                Console.WriteLine("* Z'den A'ya  : (2)");
                switch (Console.ReadLine())
                {
                    case "1":
                        List<Kisiler> Sorted_list_AZ = new List<Kisiler>();
                        for(int i = 0;i<kisiler_list.Count ; i++)
                        {
                            int ii = 0;
                            for(int j = 0;j<kisiler_list.Count ; j++)
                            {
                                bool Go_ahead = false;
                                if (kisiler_list[i] == kisiler_list[j]){
                                    ii++;
                                    if (ii == kisiler_list.Count) {Sorted_list_AZ.Add(kisiler_list[i]); kisiler_list.RemoveAt(i); i=-1; break;}
                                    else continue;}
                                switch(kisiler_list[i].Isim.Length > kisiler_list[j].Isim.Length)
                                {
                                    case true :
                                        for(int k = 0 ; k< kisiler_list[j].Isim.Length; k ++)
                                        {
                                            if (kisiler_list[i].Isim[k] > kisiler_list[j].Isim[k]) break;
                                            else if (kisiler_list[i].Isim[k] == kisiler_list[j].Isim[k]) {
                                                if (k != kisiler_list[i].Isim.Length-1) continue;
                                                else {ii++; Go_ahead=true; break;}
                                            }
                                            else if (kisiler_list[i].Isim[k] < kisiler_list[j].Isim[k]) {ii++; Go_ahead=true; break;}
                                        }
                                    break;
                                    case false:
                                        for(int k = 0 ; k< kisiler_list[i].Isim.Length; k ++)
                                        {
                                            if (kisiler_list[i].Isim[k] > kisiler_list[j].Isim[k]) break;
                                            else if (kisiler_list[i].Isim[k] == kisiler_list[j].Isim[k])
                                            {
                                                if (k != kisiler_list[i].Isim.Length-1) continue;
                                                else {ii++; Go_ahead=true; break;}
                                            } 
                                            else if (kisiler_list[i].Isim[k] < kisiler_list[j].Isim[k]) {ii++; Go_ahead=true; break;}
                                        }
                                    break;
                                }
                                if (ii == kisiler_list.Count) {Sorted_list_AZ.Add(kisiler_list[i]); kisiler_list.RemoveAt(i); i=-1;}
                                if (Go_ahead) {Go_ahead = false; continue;}
                                break;
                            }
                        }
                        if (kisiler_list.Count ==1) {Sorted_list_AZ.Add(kisiler_list[0]); kisiler_list.Clear(); }
                        kisiler_list = Sorted_list_AZ;
                    break;
                    case "2" :
                        List<Kisiler> Sorted_list_ZA = new List<Kisiler>();
                        for(int i = 0;i<kisiler_list.Count ; i++)
                        {
                            int ii = 0;
                            for(int j = 0;j<kisiler_list.Count ; j++)
                            {
                                bool Go_ahead = false;
                                if (kisiler_list[i] == kisiler_list[j])
                                {
                                    ii++;
                                    if (ii == kisiler_list.Count) {Sorted_list_ZA.Add(kisiler_list[i]); kisiler_list.RemoveAt(i); i=-1; break;}
                                    else continue;
                                    }
                                switch(kisiler_list[i].Isim.Length > kisiler_list[j].Isim.Length)
                                {
                                    case true :
                                        for(int k = 0 ; k< kisiler_list[j].Isim.Length; k ++)
                                        {
                                            if (kisiler_list[i].Isim[k] < kisiler_list[j].Isim[k]) break;
                                            else if (kisiler_list[i].Isim[k] == kisiler_list[j].Isim[k]) 
                                            {
                                                if (k != kisiler_list[i].Isim.Length-1) continue;
                                                else {ii++; Go_ahead=true; break;}
                                            }
                                            else if (kisiler_list[i].Isim[k] > kisiler_list[j].Isim[k]) {ii++; Go_ahead=true; break;}
                                        }
                                    break;
                                    case false:
                                        for(int k = 0 ; k< kisiler_list[i].Isim.Length; k ++)
                                        {
                                            if (kisiler_list[i].Isim[k] < kisiler_list[j].Isim[k]) break;
                                            else if (kisiler_list[i].Isim[k] == kisiler_list[j].Isim[k]) 
                                            {
                                                if (k != kisiler_list[i].Isim.Length-1) continue;
                                                else {ii++; Go_ahead=true; break;}
                                            }
                                            else if (kisiler_list[i].Isim[k] > kisiler_list[j].Isim[k]) {ii++; Go_ahead=true; break;}
                                        }
                                    break;
                                }
                                if (ii == kisiler_list.Count) {Sorted_list_ZA.Add(kisiler_list[i]); kisiler_list.RemoveAt(i); i=-1;}
                                if (Go_ahead) {Go_ahead = false; continue;}
                                break;
                            }
                        }
                        if (kisiler_list.Count ==1) {Sorted_list_ZA.Add(kisiler_list[0]); kisiler_list.Clear(); }
                        kisiler_list = Sorted_list_ZA;
                    break; 
                }
                Console.WriteLine("Telefon Rehberi");
                Console.WriteLine("**********************************************");
                foreach (var item in kisiler_list)
                {
                    Console.WriteLine("isim            : {0} ",item.Isim);
                    Console.WriteLine("Soyisim         : {0} ",item.Soyisim);
                    Console.WriteLine("Telefon Numarası: {0} ",item.No);
                    Console.WriteLine("-");
                }
                Main_Menu();
            }
            
            // (5) Rehberde Arama Yapmak
            void Rehberde_Arama(){
                List<Kisiler> Arama_listesi = new List<Kisiler>();
                Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                Console.WriteLine(" **********************************************");
                Console.WriteLine("* İsim veya soyisime göre arama yapmak için: (1)");
                Console.WriteLine("* Telefon numarasına göre arama yapmak için: (2)");
                string input =Console.ReadLine();
                if (input != null)
                {
                    switch(input)
                    {   
                        case "1":
                            
                            Console.Write("İsim veya Soyisim : ");
                            string i_s = Console.ReadLine().ToUpper();
                            foreach (var item in kisiler_list)
                            {
                                if(i_s == item.Isim || i_s == item.Soyisim) Arama_listesi.Add(item);
                            }
                            Console.WriteLine("Arama Sonuçlarınız:");
                            Console.WriteLine(" **********************************************");
                            foreach (var item in Arama_listesi)
                            {
                                Console.WriteLine("isim            : {0} ",item.Isim);
                                Console.WriteLine("Soyisim         : {0} ",item.Soyisim);
                                Console.WriteLine("Telefon Numarası: {0} ",item.No);
                                Console.WriteLine("-");
                            }

                        break;
                        case "2" :
                            Console.Write("Numara : ");
                            long l = long.Parse(Console.ReadLine());
                            foreach (var item in kisiler_list)
                            {
                                if(l == item.No) Arama_listesi.Add(item);
                            }
                            Console.WriteLine("Arama Sonuçlarınız:");
                            Console.WriteLine(" **********************************************");
                            foreach (var item in Arama_listesi)
                            {
                                Console.WriteLine("isim            : {0} ",item.Isim);
                                Console.WriteLine("Soyisim         : {0} ",item.Soyisim);
                                Console.WriteLine("Telefon Numarası: {0} ",item.No);
                                Console.WriteLine("-");
                            }
                        break;
                        default:
                            Console.WriteLine("yanlış seçim yaptınız , lütfen tekar seçiniz !");
                            Rehberde_Arama();
                        break;
                    }
                }
                Main_Menu();
            }
            // Arama sonucuna göre bulunan veriler aşağıdaki formatta gösterilmeli.
        }
     }
         class Kisiler
     {
         private string isim = "";
         private string soyisim ="";
         private long no = 0;

        public string Isim {
            get {return isim;}      // we can write (Get Set Method in this way , to make more easier to read .)
            set {isim = value;} 
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public long No { get => no; set => no = value; }
        public Kisiler(string ısim, string soyisim, long no)
        {
            Isim = ısim;
            Soyisim = soyisim;
            No = no;
           
        }
        public Kisiler(){}
        public void Kisi_bilgilerini_Getir(){
            Console.WriteLine("************************************");
            Console.WriteLine("isim              : {0} ",this.Isim);
            Console.WriteLine("Soyisim           : {0} ",this.Soyisim);
            Console.WriteLine("Telefon Numarası  : {0} ",this.No);
            Console.WriteLine("************************************");
        }
     }
 }