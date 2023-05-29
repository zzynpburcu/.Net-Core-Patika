using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdörtgen dikdörtgen = new Dikdörtgen();
            dikdörtgen.KısaKenar = 3;
            dikdörtgen.UzunKenar = 4;
            Console.WriteLine("Class Alan Hesabı: {0}", dikdörtgen.AlanHesapla());

            // struch da new ile tanımlamaya gerek yok bu şekilde de tanımlayabiliriz   
            Dikdörtgen_Struct dikdörtgen_struct = new Dikdörtgen_Struct(3, 4);
            /*   dikdörtgen_struct.KısaKenar = 3;
              dikdörtgen_struct.UzunKenar = 4; */
            Console.WriteLine("Struct Alan Hesabı: {0}", dikdörtgen_struct.AlanHesapla());
        }
    }
    class Dikdörtgen
    {
        public int KısaKenar;
        public int UzunKenar;
        public long AlanHesapla()
        {
            return this.KısaKenar * this.UzunKenar;
        }
    }
    struct Dikdörtgen_Struct
    {
        public int KısaKenar;
        public int UzunKenar;
        //Buş constructor tanımlayamıyoruz
        public Dikdörtgen_Struct(int kisakenar, int uzunkenar)
        {
            this.KısaKenar = kisakenar;
            this.UzunKenar = uzunkenar;
        }
        public long AlanHesapla()
        {
            return this.KısaKenar * this.UzunKenar;
        }
    }
}
