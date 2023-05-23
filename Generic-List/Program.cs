﻿using System;
using System.Collections.Generic;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            //System.Collections.Generic
            // T-> object türündedir. 

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve Listforeach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);

            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4); // değere göre çıkarır
            renkListesi.Remove("Yeşil"); // değere göre çıkarır
            sayiListesi.RemoveAt(0); // indise göre çıkarır
            renkListesi.RemoveAt(1); //indise göre çıkarır
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içinde arama
            if (sayiListesi.Contains(10))
                Console.WriteLine("Liste içinde bulundu");

            //Eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Diziyi List' e çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar); // hayvanlar dizisini hayvanlarListe ye çeviriyor

            //Tüm listeyi temizleme
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Zeynep";
            kullanıcı1.Soyisim = "Burcu";
            kullanıcı1.Yas = 27;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Patika";
            kullanıcı2.Soyisim = "Dev";
            kullanıcı2.Yas = 30;

            kullanıcıListesi.Add(kullanıcı1); //kullaniciListesi List ine 2 tane kullanıcı nesnesi eklendi
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Dotnet",
                Soyisim = "Core",
                Yas = 21
            });
            
            foreach (var kullanıcı in yeniListe)
            {
                Console.WriteLine("Kullanıcı Adı:"+ kullanıcı.Isim);  
                Console.WriteLine("Kullanıcı Soyadı:"+ kullanıcı.Soyisim);  
                Console.WriteLine("Kullanıcı Yaşı:"+ kullanıcı.Yas);   
            }

            yeniListe.Clear(); // Listeyi temizle




        }
    }

    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
