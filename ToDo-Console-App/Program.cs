using System;
using System.Collections.Generic;

namespace ToDo_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Boards board = new Boards();
            Takım takim = new Takım(); 

            



            // Console.WriteLine(kisiler[person.id]);

            Console.WriteLine(" Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    board.BoarduListele();
                    break;
                case 2:
                    KartEkle(board, takim);
                    break;
                case 3:
                    KartSil(board);
                    break;
                case 4:
                    KartTasi(board);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim. Program kapatılıyor.");
                    break;
            }





        }
         static void KartEkle(Boards board, Takım takim)
    {
        Console.WriteLine("Başlık Giriniz: ");
        string baslik = Console.ReadLine();

        Console.WriteLine("İçerik Giriniz: ");
        string icerik = Console.ReadLine();

        Console.WriteLine("Büyüklük Seçiniz -> XS(1), S(2), M(3), L(4), XL(5): ");
        int buyuklukSecim = Convert.ToInt32(Console.ReadLine());

        if (!Enum.IsDefined(typeof(Buyukluk), buyuklukSecim))
        {
            Console.WriteLine("Geçersiz bir büyüklük seçimi yaptınız!");
            return;
        }

        Console.WriteLine("Kişi Seçiniz: ");
        foreach (var uye in takim.Uyeler)
        {
            Console.WriteLine(uye.Key + ". " + uye.Value);
        }

        int kisiSecim = Convert.ToInt32(Console.ReadLine());

        if (!takim.Uyeler.ContainsKey(kisiSecim))
        {
            Console.WriteLine("Geçersiz bir kişi seçimi yaptınız!");
            return;
        }

        Card kart = new Card
        {
            Baslik = baslik,
            Icerik = icerik,
            Buyukluk = (Buyukluk)buyuklukSecim,
            Atanankisi = takim.Uyeler[kisiSecim]
        };

        board.KartEkle(kart, "TODO");
    }
    static void KartSil(Boards board)
    {
        Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
        Console.WriteLine("Lütfen kart başlığını yazınız: ");
        string baslik = Console.ReadLine();

        board.KartSil(baslik);
    }
    static void KartTasi(Boards board)
    {
        Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
        Console.WriteLine("Lütfen kart başlığını yazınız: ");
        string baslik = Console.ReadLine();

        Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
        Console.WriteLine("(1) TODO");
        Console.WriteLine("(2) IN PROGRESS");
        Console.WriteLine("(3) DONE");

        int lineSecim = Convert.ToInt32(Console.ReadLine());

        if (lineSecim < 1 || lineSecim > 3)
        {
            Console.WriteLine("Geçersiz bir seçim yaptınız!");
            return;
        }

        string hedefLine = "";

        switch (lineSecim)
        {
            case 1:
                hedefLine = "TODO";
                break;
            case 2:
                hedefLine = "IN PROGRESS";
                break;
            case 3:
                hedefLine = "DONE";
                break;
        }

        board.KartTasi(baslik, hedefLine);
    }
    }
  
}
