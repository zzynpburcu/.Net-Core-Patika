using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                 Console.WriteLine("Bir Sayı Giriniz:");
                 int sayi = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Girmiş olduğuunuz sayi:" + sayi);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Hata: "+ ex.Message.ToString()); 
            }
            finally // Hata olsun olmasın kesin olarak dönmesini istediğimiz kod bloğu
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
           
           try
           {
               //int a = int.Parse(null);
               //int a = int.Parse("test");
               int a = int.Parse("-222222222222");
           }
           catch (ArgumentNullException ex)
           {
               
               Console.WriteLine("Boş Değer Girdiniz");
               Console.WriteLine(ex);
           }
           catch(FormatException ex)
           {
            Console.WriteLine("Veri Tipi Uygun Değil");
            Console.WriteLine(ex);
           }
           catch(OverflowException ex)
           {
            Console.WriteLine("Çok küçük yada  çok büyük bir değer girdiniz");
            Console.WriteLine(ex);
           }
           finally{
            Console.WriteLine("İşlem Başarıyla Tamamlandı");
           }
        }
    }
}
