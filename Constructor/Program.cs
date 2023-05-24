﻿using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            // class SinifAdi
            // {
            //  [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
            //  [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi(Parametre Listesi)
            //  {
            //     Metot Komutları
            //  }

            /* Erişim Belirleyiciler
             * Public       --her yerden erişilir
             * Private      --sadece tanımlandığı sınıf içinden erişilir propertiler private tanımlanır
             * Internal     --sadece kendi prjesi içerinde geçerlidir ör program.cs
             * Protected    --sadece tanımlandıı sınıfta ve kalıtım yapılan sınıftan erişilir*/
            Console.WriteLine("*********** Çalışan 1 ***********");
            Calisan calisan1 = new Calisan("Ayşe", "Kara", 23425634, "İnsan Kaynakları");
            /*   calisan1.Ad = "Ayşe";
              calisan1.Soyad = "Kara";
              calisan1.No = 23425634;
              calisan1.Departman = "İnsan Kaynakları"; */
            calisan1.CalisanBilgileri();

            Console.WriteLine("*********** Çalışan 2 ***********");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 25646789;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();
            Console.WriteLine("*********** Çalışan 3 ***********");
            Calisan calisan3 = new Calisan("Zeynep", "Burcu");
            calisan3.CalisanBilgileri();


        }
    }

    class Calisan
    { // Propertiler yani özellikleri tanımlıyoruz
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public Calisan() { }


        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı:{0} ", Ad);
            Console.WriteLine("Çalışanın Soyadı:{0} ", Soyad);
            Console.WriteLine("Çalışanın Numarası:{0} ", No);
            Console.WriteLine("Çalışanın Departmanı:{0} ", Departman);
        }

    }
}
