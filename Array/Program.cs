using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama

            string[] renkler=new string[5];

            string[] hayvanlar = {"Kedi","Köpek","Tavuk"};

            int[] dizi;

            dizi= new int[5];

            //Dizilere değer atama ve erişim

            renkler[0]="Mavi";

            dizi[3]=10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[3]);

            //Döngülerde Dizi Kullanımı
            //Klavyeden girilen n tane sayının ortalamasını oluşturan program

            Console.WriteLine("Bir Sayı Giriniz");
            int diziUzunlugu = int.Parse(Console.ReadLine());

            int[] sayiDizisi= new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
             Console.Write("Lütfen {0}. elemanı giriniz:",i+1);
             sayiDizisi[i]= int.Parse(Console.ReadLine());   
            }
            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam+=sayi;
            }

            Console.WriteLine(toplam/diziUzunlugu);
        }
    }
}
