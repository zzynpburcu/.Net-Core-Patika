using System;

namespace String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp Hoşgeldiniz!";
            string degisken2 = "CSharp";

            //Lenght
            Console.WriteLine(degisken.Length);

            //ToUpper , ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken, " Merhaba!"));

            //Compare, CompareTo
            //CompareTo:degisken=degisken2 ise 0 degisken>degisken2 ise 1 degisken<degisken ise -1 döner(karakter sayılarına bakılır)
            Console.WriteLine(degisken.CompareTo(degisken2));

            Console.WriteLine(String.Compare(degisken, degisken2, true)); //büyük küçük harf duyarsız
            Console.WriteLine(String.Compare(degisken, degisken2, false)); //duyarlı (ignoreCase)

            //Contains
            //degiskenin içinde degisken2 var mı?
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf
            //degisken içerisinde CS yi arayacak ve ilk bulduğu yerde C nin indexini dönecek, bulamazsa -1 döner
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba"));

            //PadLeft, PadRight
            //padleft örneği :degisken2 uzunluğu + boşluk 30 kadar tamamlıyo
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

            //REmove 
            Console.WriteLine(degisken.Remove(10)); //10.indexten sonrasını diler
            Console.WriteLine(degisken.Remove(5, 3)); //5.indexten sonra 3 karakter siler
            Console.WriteLine(degisken.Remove(0, 1)); //İlk karakteri siler

            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split - boşluklara göre dizi tanımla ve 1 indexli elemanı getir
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4, 6));
        }
    }
}
