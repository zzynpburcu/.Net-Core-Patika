using System;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Out Parametreler
            string sayi="999";
            int outSayi;

            bool sonuc = int.TryParse(sayi, out outSayi);
            if(sonuc == true){
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }else{
                Console.WriteLine("Başarısız");
            }
            
             Metodlar instance = new Metodlar();
             // return ifadeler yerine out parametreler kullanarak da sonucu döndürebiliriz
             instance.Topla(4,5,out int toplamSonucu);
             Console.WriteLine(toplamSonucu);

             //Method Aşırı Yükleme - Overloading

             int ifade = 999;
             instance.ekranaYazdir(ifade);
             instance.ekranaYazdir(ifade.ToString());
             instance.ekranaYazdir("Zeynep","Burcu");

             // Method Imzası
             //Metot Adı + Metod Parametresi + Parametre Sayısı

        }
       
        
    }

    class Metodlar{

        public void Topla(int a, int b,out int toplam){
            toplam= a+b;
        }

        public void ekranaYazdir(string veri){
            Console.WriteLine(veri);
        }
        public void ekranaYazdir(int veri){
            Console.WriteLine(veri);
        }
         public void ekranaYazdir(string veri1,string veri2){
            Console.WriteLine(veri1 + veri2);
        }
    }
}
