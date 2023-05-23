using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayListt
{
    class Program
    {
        static void Main(string[] args)
        {
           //System.Collections namespace

           ArrayList liste =new ArrayList();
           liste.Add("Ayşe");
           liste.Add(2);
           liste.Add(true);
           liste.Add('A');

           //İçerisindeki verilere erişim

           Console.WriteLine(liste[1]);
           foreach (var item in liste)
               Console.WriteLine(item);
           
           // AddRange  birden fazla elemanı toplu halde ekleme
           Console.WriteLine("********** Add Range **********");
           string[] renkler = {"kırmızı", "sarı", "yeşil" };
           List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};
           liste.AddRange(renkler);
           liste.AddRange(sayılar);

           foreach (var item in liste)
           Console.WriteLine(item);
            ArrayList liste2 =new ArrayList();
            liste2.AddRange(sayılar);
           //Sort
           Console.WriteLine("********** Sort **********");
           liste2.Sort(); // bu sortu kullanırken listemizdeki elemanların int olduğundan emin olmalıyız yoksa hata verir

            //BinarySearch
           Console.WriteLine("********** Binary Search **********");
           Console.WriteLine(liste2.BinarySearch(7));

           //Reverse
           Console.WriteLine("********** Reverse **********");
           liste2.Reverse();
           foreach(var item in liste2)
           Console.WriteLine(item);

           //Clear
           Console.WriteLine("********** Clear **********");
           liste2.Clear();
           foreach(var item in liste2)
           Console.WriteLine(item);


        }
    }
}
