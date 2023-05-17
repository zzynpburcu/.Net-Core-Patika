using System;

namespace Array_Class_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
           //Sort
           int[] sayiDizisi = {20,12,4,86,72,3,11,17};
            Console.WriteLine("********** Sırasız Liste *********");
           foreach(var sayi in sayiDizisi)
           {
            Console.WriteLine(sayi);
           }
           Console.WriteLine("******** Sıralı Liste *****");
           Array.Sort(sayiDizisi);
           foreach(var sayi in sayiDizisi)
           {
            Console.WriteLine(sayi);
           }

           //Clear
           Console.WriteLine("******** Array Clear *****");
           // sayiDizisini kullanarak 2. indisten itibaren iki elemanı 0 yaptı
           Array.Clear(sayiDizisi,2,2);
           foreach(var sayi in sayiDizisi)
           {
            Console.WriteLine(sayi);
           }

           //Reverse 
           Console.WriteLine("******** Array Reverse *****");
           Array.Reverse(sayiDizisi);
            foreach(var sayi in sayiDizisi)
           {
            Console.WriteLine(sayi);
           }

           //IndexOf : Verilen elemanın varsa indexini döner yoksa -1 döner
            Console.WriteLine("******** Array IndexOf *****");
            int deger=Array.IndexOf(sayiDizisi,20);
            Console.WriteLine(deger);

            //Resize
            Console.WriteLine("******** Array Resize *****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;
            foreach(var sayi in sayiDizisi)
           {
            Console.WriteLine(sayi);
           }

        }
    }
}
