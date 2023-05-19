using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // erisim_belirteci geri_donu_tipi metod_adi(parametreListesi/arguman)
            //{
              //  komutlar
              // return
            //}

            int a=2;
            int b=3;
            int sonuc =Topla(a,b);

            Console.WriteLine(sonuc);

            Methods ornek = new Methods();

            ornek.ekranaYazdir(sonuc.ToString());

            int sonuc2= ornek.ArttirVeTopla(ref a,ref b);
            ornek.ekranaYazdir(sonuc2.ToString());
             ornek.ekranaYazdir((a+b).ToString());
        }

        static int Topla(int deger1,int deger2){
            return (deger1 + deger2);
        }
    }

    class Methods{
        public void ekranaYazdir(string veri){
            Console.WriteLine(veri);
        }
        // ref vererek global değişkeni değiştiribiliyoruz
        public int ArttirVeTopla(ref int deger1,ref int deger2){
            deger1++; deger2++;
            return (deger1+deger2);
        }
    }
}
