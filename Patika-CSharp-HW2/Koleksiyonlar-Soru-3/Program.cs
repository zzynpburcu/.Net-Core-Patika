using System;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru 3
            //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.


            string cumle = Console.ReadLine();
            char[] cumleDizi = cumle.ToCharArray();
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü', 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };
            string cumleSesliHarflerString = "";
            foreach (var item in cumleDizi)
            {
                if (Array.IndexOf(sesliHarfler, item) >= 0)
                    cumleSesliHarflerString += item;
            }
            char[] cumleSesliHarfler = cumleSesliHarflerString.ToCharArray();
            foreach (var item in cumleSesliHarfler)
                Console.WriteLine(item);

        }
    }
}
