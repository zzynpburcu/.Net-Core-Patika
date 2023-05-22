using System;

namespace Patika_CSharp_Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. soru:
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            // Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.WriteLine("Pozitif bir sayı giriniz (N)");
            int sayi= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi +" adet sayi giriniz");
            int[] sayilar = new int[sayi];
            
           for (int i = 0; i < sayi; i++)
           {
             sayilar[i]=Convert.ToInt32(Console.ReadLine());
           }
           Console.WriteLine("Çift Sayılar :");
           foreach(int s in sayilar){
            if(s%2==0){
                Console.WriteLine(s);
            }
           }
  
           //2.Soru
           //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
           // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
           // Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
           
           Console.WriteLine("Pozitif iki sayı giriniz: "); 
           int n = Convert.ToInt32(Console.ReadLine());
           int m = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(n +" adet pozitif tamsayı giriniz:");
           int[] nSayilar = new int[n];
           for (int i = 0; i < n; i++)
           { 
             nSayilar[i]=Convert.ToInt32(Console.ReadLine());
           }
            Console.WriteLine(m+"'e eşit yada tam bölünenler :");
           foreach(int s in nSayilar){
            if(s%m==0){
                Console.WriteLine(s);
            }
           }

           //3.Soru
           //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
           // Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
           // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

           Console.WriteLine("Pozitif bir sayı giriniz: "); 
           int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi1 +" adet kelime giriniz:");
           string[] nKelime = new string[sayi1];
           for (int i = 0; i < sayi1; i++)
           { 
             nKelime[i]=Console.ReadLine();
           }
           Array.Reverse(nKelime);
            Console.WriteLine("Kullanıcının girdiği kelimeler");
           foreach(string s in nKelime){
                Console.Write(s+" ");
           }
         

            //4.Soru
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Bir cümle yazınız: "); 
           string cumle = Console.ReadLine();
           string[] cumleler = cumle.Split(" ");
           string harfSayisi=string.Join("",cumleler);
           Console.WriteLine("Cümlede toplam "+cumleler.Length+" kelime ve "+harfSayisi.Length +"harf vardır");
            
        }
    }
}
