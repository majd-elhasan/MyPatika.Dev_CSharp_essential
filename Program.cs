using System;
 namespace Generic_koleksiyonlar_ve_list 
 {
     class Program
     {
        static void Main(string[] args)
        {
            // List<T> class;
            // System.Collection.Generic
            // T object türündedir
            List<int> sayılistesi = new List<int>();
            sayılistesi.Add(12);
            sayılistesi.Add(14);
            sayılistesi.Add(25);
            sayılistesi.Add(96);
            sayılistesi.Add(78);
            sayılistesi.Add(06);

            List<string> renklerlistesi = new List<string>();
            renklerlistesi.Add("mavi");
            renklerlistesi.Add("yeşil");
            renklerlistesi.Add("kırmızı");
            renklerlistesi.Add("sarı");
            renklerlistesi.Add("gri");

            Console.WriteLine(sayılistesi.Count);
            Console.WriteLine(renklerlistesi.Count);

            foreach (var item in sayılistesi)
            {
                Console.WriteLine(item);
            }
            foreach (var item in renklerlistesi)
            {
                Console.WriteLine(item);
            }

            sayılistesi.ForEach(sayi => Console.WriteLine(sayi));
            renklerlistesi.ForEach(renk => Console.WriteLine(renk));

            sayılistesi.Remove(14);
            renklerlistesi.Remove("mavi");

            sayılistesi.RemoveAt(0);
            renklerlistesi.RemoveAt(3);

            sayılistesi.ForEach(sayi => Console.WriteLine(sayi));
            renklerlistesi.ForEach(renk => Console.WriteLine(renk));

            //  liste içinde arama
            if(sayılistesi.Contains(96))
                Console.WriteLine("96 sayısı sayılistesinde yer alıyor ");

            Console.WriteLine(renklerlistesi.BinarySearch("sarı"));

            // bir array'i liste'ye kopyalama
            string[] hayvanlar_array = {"timsah","köpek","kedi"};
            List<string> hayvanlar_liste = new List<string>(hayvanlar_array);

            // listeyi nasıl silerm
            hayvanlar_liste.Clear();

            // Liste içerisinde nesne tutmak

            List<kullanici> kullanicilistesi = new List<kullanici>();
            kullanici kullanici1 = new kullanici();
            kullanici1.Isim = "Ayşe";
            kullanici1.Soyisim = "yılmaz";
            kullanici1.Yas = 28;
            kullanici kullanici2 = new kullanici();
            kullanici2.Isim = "özcan";
            kullanici2.Soyisim = "çalışkan";
            kullanici2.Yas = 24;

            kullanicilistesi.Add(kullanici1);
            kullanicilistesi.Add(kullanici2);

            // şu şekilde de ekleyebiliriz

            kullanicilistesi.Add(new kullanici(){
                Isim = "Mahmud",
                Soyisim = "ulebi",
                Yas = 21
            });

            foreach (kullanici item in kullanicilistesi)   //  var yerine kullanici kullanmamız mümkün
            {
                Console.WriteLine("kullanıcı adı : " + item.Isim);
                Console.WriteLine("kullanıcı soyadı : " + item.Soyisim);
                Console.WriteLine("kullanıcı yaşı : " + item.Yas);
            }
            // şöyle de silebiliriz
            kullanicilistesi.Clear();
            }

        }
     }

     public class kullanici
     {
        private string isim ;
        private string soyisim;
        private int yas;

        public string Isim {get => isim ; set => isim = value; }
        public string Soyisim {get => soyisim ; set => soyisim = value; }
        public int Yas {get => yas ; set => yas = value; }
     }

 }