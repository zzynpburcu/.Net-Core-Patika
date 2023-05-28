﻿using System;

namespace Static_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şirketin Çalışan Sayısı: {0} ", Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Ayşe", "Yılmaz", "IK");
            Console.WriteLine("Şirketin Çalışan Sayısı: {0} ", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Deniz", "Arda", "IK");
            Calisan calisan2 = new Calisan("Zikriye", "Ürkmez", "IK");

            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
            Console.WriteLine("Toplama Sonucu : {0}", Islemler.Topla(100, 200));
            Console.WriteLine("Çıkarma Sonucu : {0}", Islemler.Çıkar(400, 50));



        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Çıkar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
