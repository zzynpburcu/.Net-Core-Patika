using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru2
            //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
            // her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
            // (Array sınıfını kullanarak yazınız.)
            int[] sayilar = new int[20];
            for( int i=0; i< 20; i++)
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //Sayilar küçükten büyüğe doğru sıralandı
            Array.Sort(sayilar);  
            int[] enBuyukElemanlar = new int[3];  
            int[] enKucukElemanlar = new int[3];  
            for(int i=0; i<3; i++)
            { //en buyuk değerler ve en küçük değerler ayrı dizilere atıldı
                enKucukElemanlar[i]=sayilar[i];
                int k= sayilar.Length-1;
                enBuyukElemanlar[i]=sayilar[k-i];
            }
            //dizilerin toplamlarını alalım
            int enBuyukElemanlarToplam =0; int enKucukElemanlarToplam = 0; 
            foreach(var item in enBuyukElemanlar)
            enBuyukElemanlarToplam += item;
             foreach(var item in enKucukElemanlar)
            enKucukElemanlarToplam += item;

            //Ortalmaları ve Ortalama Toplamlarını yazalım
            Console.WriteLine("En Büyük 3 Eleman Dizisi ve En Küçük 3 Eleman Dizisi Ortalamaları:");
            Console.WriteLine("En Büyük Ort: "+(enBuyukElemanlarToplam/enBuyukElemanlar.Length)+" En Küçük Ort: "+(enKucukElemanlarToplam/enKucukElemanlar.Length));
            Console.WriteLine("Ortalama Toplamları: "+(enBuyukElemanlarToplam/enBuyukElemanlar.Length+enKucukElemanlarToplam/enKucukElemanlar.Length) );


            
            



        }
    }
}
