using System;

namespace Foor_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
            Console.Write("Lütfen Bir Sayı giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if(i%2==1)
                Console.WriteLine(i);
            }
            // 1 ile 1000 arasındaki tek ve çift sayıların kendi içerisindeki toplamlarını getir
            int tektoplam=0;
            int cifttoplam=0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i%2 == 1)
                     tektoplam += i;
                else
                     cifttoplam += i;
            }
            Console.WriteLine("Tek toplam :" +tektoplam); //250000
            Console.WriteLine("Çift Toplam :" +cifttoplam); //250500

            //break,continue

            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                break;
                Console.WriteLine(i);
            } // 1 2 3

             for (int i = 1; i < 10; i++)
            {
                if(i==4)
                continue;
                Console.WriteLine(i);
            } // 1 2 3 5 6 7 8 9
        }
    }
}
