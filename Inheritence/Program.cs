using System;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
           //ınheritence
           //                    Canlılar
           //        Bitkiler                Hayvanlar
           // Tohumlu     Tohumsuz    Surungenler  Kuslar 

           TohumluBitkiler tohumluBitki = new TohumluBitkiler();
           tohumluBitki.TohumlaCogalma();
           Console.WriteLine("******************");

           Kuslar martı = new Kuslar();
           martı.Ucmak();
        }
    }
}
