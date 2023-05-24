using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Soru
            //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
            //Negatif ve numeric olmayan girişleri engelleyin.
            //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            ArrayList asalDizi = new ArrayList();
            ArrayList asalOlmayanDizi = new ArrayList();
            Console.WriteLine("20 tane sayı giriniz:");
            for(int i=0; i< 20; i++){
                int n = Convert.ToInt32(Console.ReadLine());
                if(n<0) 
                break;
                int sayac=0;
                for(int j=1; j<=n; j++){
                    //gelen elemanın kaç sayıya bölünebileceğini sayac ile tutuyoruz
                    if(n%j==0)
                    sayac++;
                }
                if(sayac==2)
                asalDizi.Add(n);
                else
                asalOlmayanDizi.Add(n);
            }
            //dizileri küçükten büyüğe  sıralama
            asalDizi.Sort();
            asalOlmayanDizi.Sort();
            //dizilerin tersini alma
            asalDizi.Reverse();
            asalOlmayanDizi.Reverse();
            //dizilerin elemanlarını yazdırma
            int asalArrayToplam=0; int asalOlmayanArrayToplam=0;
            Console.WriteLine("Asal Olan Dizi Elamnları:");
            foreach(var item in asalDizi){
             Console.WriteLine(item); 
             asalArrayToplam+=Convert.ToInt32(item);
            }
            Console.WriteLine("Asal Olmayan Dizi Elemanları:");
            foreach(var item in asalOlmayanDizi)
            {
             Console.WriteLine(item); 
             asalOlmayanArrayToplam+=Convert.ToInt32(item);
            }
            //dizilerin eleman sayısı
            Console.WriteLine("Asal Dizinin Eleman Sayısı: "+asalDizi.Count+" Ortalaması: "+(asalArrayToplam/asalDizi.Count));
            Console.WriteLine("Asal Olmayan Dizinin Eleman Sayısı: "+asalOlmayanDizi.Count+" Ortalaması: "+(asalOlmayanArrayToplam/asalOlmayanDizi.Count));

        }
    }
}
