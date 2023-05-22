using System;

namespace DateTime_Math_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // günün tarihi
            Console.WriteLine(DateTime.Now.Date); // saatin dakika saniye detaylarını getirmiyor
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString()); //saat dakika saniye getiriyo
            Console.WriteLine(DateTime.Now.ToShortTimeString()); //saat dakika

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //DateTme Format

            Console.WriteLine(DateTime.Now.ToString("dd")); //23
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Tue
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Tuesday

            Console.WriteLine(DateTime.Now.ToString("MM")); //05
            Console.WriteLine(DateTime.Now.ToString("MMM")); //May
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // May

            Console.WriteLine(DateTime.Now.ToString("yy")); //23
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2023

            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25)); //25
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(30));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3)); // 22.3 den büyük en küçük tam sayı (yukarı yuvarla) :23
            Console.WriteLine(Math.Round(22.3)); // hangisi yakınsa onu getirir :22
            Console.WriteLine(Math.Round(22.7)); //:23
            Console.WriteLine(Math.Floor(22.7)); // 22.7den küçük en büyük sayı (aşagı yuvarla) :22

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(3,4)); // 3^4 ü verir : 81
            Console.WriteLine(Math.Sqrt(9)); // Karekök alır : 3
            Console.WriteLine(Math.Log(9)); // 9 un e tabanındaki logaritmik karşılığı
            Console.WriteLine(Math.Exp(3)); //e üzeri 3 verir
            Console.WriteLine(Math.Log10(10)); // 10 sayısının log10 tabanındaki karşığı




            
            

        }
    }
}
