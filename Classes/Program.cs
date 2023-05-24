using System;

namespace Classes
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

             Calisan calisan1 = new Calisan();
             calisan1.Ad = "Ayşe";
             calisan1.Soyad = "Kara";
             calisan1.No = 23425634;
             calisan1.Departman = "İnsan Kaynakları";
             calisan1.CalisanBilgileri();
             Console.WriteLine("***************");

             Calisan calisan2 = new Calisan();
             calisan2.Ad = "Deniz";
             calisan2.Soyad = "Arda";
             calisan2.No = 25646789;
             calisan2.Departman = "Satın Alma";
             calisan2.CalisanBilgileri();


        }
    }

    class Calisan
    { // Propertiler yani özellikleri tanımlıyoruz
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı:{0} ",Ad);
            Console.WriteLine("Çalışanın Soyadı:{0} ",Soyad);
            Console.WriteLine("Çalışanın Numarası:{0} ",No);
            Console.WriteLine("Çalışanın Departmanı:{0} ",Departman);
        }

    }
}
