using System;

namespace Telephone_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
          Directory directory = new Directory();

        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
        Console.WriteLine("******************************************ß**");
        Console.WriteLine("(1) Yeni Numara Kaydetmek");
        Console.WriteLine("(2) Varolan Numarayı Silmek");
        Console.WriteLine("(3) Varolan Numarayı Güncelleme");
        Console.WriteLine("(4) Rehberi Listelemek");
        Console.WriteLine("(5) Rehberde Arama Yapmak");
        Console.WriteLine();

        int choice =  Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                directory.AddPerson();
                break;
            case 2:
                directory.DeletePerson();
                break;
            case 3:
                directory.UpdateContact();
                break;
            case 4:
                directory.ListContacts();
                break;
            case 5:
                directory.SearchContacts();
                break;
            default:
                Console.WriteLine("Geçersiz seçim. Program kapatılıyor.");
                break;
        }

         

         // directory.DeletePerson(person1);

         directory.ListContacts();
         
        }
    }
}
