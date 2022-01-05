using System;

namespace ToDo_uygulamasi
{
    class Kart
    {
        string baslik = "";


        string icerik ="";

        buyuklukler buyukluk ;
        
        Kisiler id;
        
        public string Baslik { get => baslik; set => baslik = value; }
        public string Icerik { get => icerik; set => icerik = value; }
        public buyuklukler Buyukluk { get => buyukluk; set => buyukluk = value; }
        public Kisiler Id { get => id; set => id = value; }

        public Kart(string baslik , string icerik  , int kisi_ID ,int buyukluk){
            Baslik = baslik;
            Icerik = icerik;
            Id = (Kisiler)kisi_ID;
            Buyukluk = (buyuklukler)buyukluk;
        }
        public void print_info(){
            Console.WriteLine(" Başlık      : {0}",this.baslik);
            Console.WriteLine(" İçerik      : {0}",this.icerik);
            Console.WriteLine(" Atanan Kişi : {0}",this.id);
            Console.WriteLine(" Büyüklük    : {0}",this.buyukluk);
        }
        
    }
}