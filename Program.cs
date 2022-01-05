using System;

namespace ToDo_uygulamasi
{
    class Mainclass
    {
        static void Main(string[] args){
            List<Kart> TODO = new List<Kart>();
            List<Kart> IN_PROGRESS = new List<Kart>();
            List<Kart> DONE = new List<Kart>();
            TODO.Add(new Kart("kuriyelik","eve teslim",1,3));
            TODO.Add(new Kart("kuriyelik","dağıtım merkezine teslim",2,5));
            IN_PROGRESS.Add(new Kart("düzenleme","kargoları düzenleme",3,2));
            
            // Program ↓
            Main_menu();
            

            // Main menu
            void Main_menu(){
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)"); 
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                switch(Console.ReadLine()){
                    case "1" :
                        Board_listeleme();
                    break; 
                    case "2" :
                        Kart_ekleme();
                    break;
                    case "3" :
                        Kart_silme();
                    break;
                    case "4" :
                        Kart_Tasima();
                    break;
                    default:
                        Console.WriteLine("Hatalı bir seçim yaptınız!");
                    break;
                }
            }
            

            // (1) Board Listelemek
            void Board_listeleme(){
                Console.WriteLine(" TODO Line");
                Console.WriteLine(" ************************");
                for (int i = 0; i < TODO.Count; i++)
                {
                    TODO[i].print_info();
                    if(i != TODO.Count-1) Console.WriteLine(" - ");
                }
                 Console.WriteLine(""); // boş alan olsun
               
                Console.WriteLine(" IN PROGRESS Line");
                Console.WriteLine(" ************************");
                for (int i = 0; i < IN_PROGRESS.Count; i++)
                {
                    IN_PROGRESS[i].print_info();
                    if(i != IN_PROGRESS.Count-1) Console.WriteLine(" - ");
                }
                Console.WriteLine(""); // boş alan olsun

                Console.WriteLine(" DONE Line");
                Console.WriteLine(" ************************");
                for (int i = 0; i < DONE.Count; i++)
                {
                    DONE[i].print_info();
                    if(i != DONE.Count-1) Console.WriteLine(" - ");
                }
                Console.WriteLine(""); // boş alan olsun
                Console.WriteLine("Ana menü'ye dönmek için 'Enter' tuşuna basınız.");
                switch (Console.ReadLine())
                {
                    default:
                        Main_menu();
                    break;
                }
            }
            //(2) Board'a Kart Eklemek
            void Kart_ekleme(){
                string baslik ="";
                string içerik = "";
                int buyukluk = 0;
                int id = 0;
                Console.Write(" Başlık Giriniz                                  : ");
                baslik = Console.ReadLine();
                Console.Write(" İçerik Giriniz                                  : ");
                içerik = Console.ReadLine();
                Console.Write(" Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
                buyukluk = int.Parse(Console.ReadLine());
                Console.Write(" Kişi (ID) Seçiniz                               : ");
                id = int.Parse(Console.ReadLine());
                if (buyukluk > 0 && buyukluk <6 && id >0 && id <6) 
                {
                    TODO.Add(new Kart(baslik,içerik,id,buyukluk));
                    Main_menu();
                }
                else {Console.WriteLine("Hatalı girişler yaptınız!"); Main_menu();}
            }

            // (3) Board'a Kart Silmek
            void Kart_silme(){
                Console.WriteLine(" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                Console.WriteLine(" Lütfen kart başlığını yazınız:  ");
                string girilen_başlık ="";
                girilen_başlık = Console.ReadLine();
                bool bulundu = false;
                for (int i = 0; i < TODO.Count; i++)
                {            
                    if(girilen_başlık == TODO[i].Baslik){TODO.Remove(TODO[i]);
                     Console.WriteLine("{0} başlıklı kart TODO listesinden silindi", girilen_başlık); bulundu=true; Main_menu();}
                }
                for (int i = 0 ; i < IN_PROGRESS.Count ; i++)
                {
                    if(girilen_başlık == IN_PROGRESS[i].Baslik){IN_PROGRESS.Remove(IN_PROGRESS[i]);
                    Console.WriteLine("{0} başlıklı kart IN PROGRESS listesinden silindi", girilen_başlık); bulundu = true; Main_menu();}
                }
                for (int i = 0 ; i < DONE.Count ; i++)
                {
                    if(girilen_başlık == DONE[i].Baslik){DONE.Remove(DONE[i]);
                     Console.WriteLine("{0} başlıklı kart DONE listesinden silindi", girilen_başlık); bulundu =true; Main_menu();}
                }
                if(!bulundu){
                // kart bulunamaz ise ↓
                    Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine(" * Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine(" * Yeniden denemek için : (2)");
                    switch (Console.ReadLine())
                    {
                        case "1" :
                            Main_menu();
                        break;
                        case "2" :
                            Kart_silme();
                        break;
                        default:
                        break;
                    }
                }
            // aynı isimde birden fazla kart bulunursa ikisi de silinebilir
            }

            // (4) Kart Taşımak
            void Kart_Tasima(){
                Console.WriteLine(" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                Console.WriteLine(" Lütfen kart başlığını yazınız: ");
                string girilen_başlık = "";
                girilen_başlık = Console.ReadLine();
                bool bulundu = false;
                for (int i = 0; i < TODO.Count; i++)
                {            
                    if(girilen_başlık == TODO[i].Baslik) bulundu=true;
                }
                for (int i = 0 ; i < IN_PROGRESS.Count ; i++)
                {
                    if(girilen_başlık == IN_PROGRESS[i].Baslik) bulundu = true;
                }
                for (int i = 0 ; i < DONE.Count ; i++)
                {
                    if(girilen_başlık == DONE[i].Baslik) bulundu =true;
                }

                // Kart bulunamaz ise:
                if(!bulundu){
                    Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine(" * İşlemi sonlandırmak için : (1)");
                    Console.WriteLine(" * Yeniden denemek için : (2)");
                    switch (Console.ReadLine())
                    {
                        case "1" :
                            Main_menu();
                        break;
                        case "2" :
                            Kart_Tasima();
                        break;
                        default:
                        break;
                    }
                }
                // Kart bulunur ise:
                if(bulundu){
                    Console.WriteLine(" Bulunan Kart Bilgileri:");
                    Console.WriteLine(" **************************************");
                    Console.WriteLine("");
                    List<Kart> girilen_başlıkla_ilgili_Kart_listesi = new();
                    for (int i = 0; i < TODO.Count; i++)
                    {            
                        if(girilen_başlık == TODO[i].Baslik) 
                        {
                            TODO[i].print_info();
                            Console.WriteLine(" Line        : TODO");
                            Console.WriteLine("");
                            girilen_başlıkla_ilgili_Kart_listesi.Add(TODO[i]);
                            
                        }
                    }
                    for (int i = 0 ; i < IN_PROGRESS.Count ; i++)
                    {
                        if(girilen_başlık == IN_PROGRESS[i].Baslik)
                        {
                            TODO[i].print_info();
                            Console.WriteLine(" Line        : IN PROGRESS");
                            Console.WriteLine("");
                            girilen_başlıkla_ilgili_Kart_listesi.Add(IN_PROGRESS[i]);
                            IN_PROGRESS.Remove(IN_PROGRESS[i]);
                        }
                    }
                    for (int i = 0 ; i < DONE.Count ; i++)
                    {
                        if(girilen_başlık == DONE[i].Baslik) 
                        {
                            TODO[i].print_info();
                            Console.WriteLine(" Line        : DONE");
                            Console.WriteLine("");
                            girilen_başlıkla_ilgili_Kart_listesi.Add(DONE[i]);
                            DONE.Remove(DONE[i]);
                        }
                    }
                    // silme işlemi ↓
                    void silme_islemi(){
                        for (int i = 0; i < TODO.Count; i++)
                        {
                            if(girilen_başlık == TODO[i].Baslik){ TODO.Remove(TODO[i]); i--;}
                        }
                        for (int i = 0; i < IN_PROGRESS.Count; i++)
                        {
                            if(girilen_başlık == IN_PROGRESS[i].Baslik) {IN_PROGRESS.Remove(IN_PROGRESS[i]); i--;}
                        }
                        for (int i = 0; i < DONE.Count; i++)
                        {
                            if(girilen_başlık == DONE[i].Baslik) {DONE.Remove(DONE[i]); i--;}
                        }
                    }
                    /// silme işlemi ↑
                    Console.WriteLine(" Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                    Console.WriteLine(" (1) TODO");
                    Console.WriteLine(" (2) IN PROGRESS");
                    Console.WriteLine(" (3) DONE");
                    switch (Console.ReadLine())
                    {
                        case "1" :
                            // silme işlemi ↓
                            silme_islemi();
                            // ***********************
                            for (int i = 0; i < girilen_başlıkla_ilgili_Kart_listesi.Count; i++)
                            {   
                                TODO.Add(girilen_başlıkla_ilgili_Kart_listesi[i]);
                            }
                        break;
                        case "2" :
                            // silme işlemi ↓
                            silme_islemi();
                            // ***********************
                            for (int i = 0; i < girilen_başlıkla_ilgili_Kart_listesi.Count; i++)
                            {
                                IN_PROGRESS.Add(girilen_başlıkla_ilgili_Kart_listesi[i]);
                            }
                        break;
                        case "3" :
                            // silme işlemi ↓
                            silme_islemi();
                            // ***********************
                            for (int i = 0; i < girilen_başlıkla_ilgili_Kart_listesi.Count; i++)
                            {
                                DONE.Add(girilen_başlıkla_ilgili_Kart_listesi[i]);
                            }
                        break;
                        default:
                            Console.WriteLine("Hatalı bir seçim yaptınız!");
                        break;
                    }
                    Main_menu();
                }
            }
        }
    }
}