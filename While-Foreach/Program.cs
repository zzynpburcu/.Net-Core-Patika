using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // While 
            // 1den başlayarak consoledan girilen sayıya kadar sayı dahil ortalama hesaplayıp console yazdır
            Console.WriteLine("Bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine(toplam/sayi);

            // A'dan Z'ye kadar tüm harfleri console a yazdır

            char character='a';
            while(character <='z'){
                Console.Write(character);
                character++;
            }

            //foreach

            string[] arabalar = {"BMW","Ford","Toyota","Renault"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
