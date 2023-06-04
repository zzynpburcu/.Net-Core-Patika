using System;

namespace ToDo_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kisiler = new Dictionary<int, string>();

            Takım person1 = new Takım(12, "Zeynep Burcu");
            person1.AddPerson(kisiler);
            Takım person2 = new Takım(15, "Ahmet Kaya");
            person2.AddPerson(kisiler);
            Takım person3 = new Takım(18, "Barış Güney");
            person3.AddPerson(kisiler);
            Takım person4 = new Takım(21, "Leyla Akay");
            person4.AddPerson(kisiler);

           // Console.WriteLine(kisiler[person.id]);

           Console.WriteLine(" Lütfen yapmak istediğiniz işlemi seçiniz :) ");
           Console.WriteLine("*******************************************");
           Console.WriteLine("(1) Board Listelemek");
           Console.WriteLine("(2) Board'a Kart Eklemek");
           Console.WriteLine("(3) Board'dan Kart Silmek");
           Console.WriteLine("(4) Kart Taşımak");

           int choice = Convert.ToInt32(Console.ReadLine());

              switch (choice)
        {
            case 1:
                directory.ListBoard();
                break;
            case 2:
                directory.AddCardToBoard();
                break;
            case 3:
                directory.DeleteCardFromBoard();
                break;
            case 4:
                directory.MoveCard();
                break;
            default:
                Console.WriteLine("Geçersiz seçim. Program kapatılıyor.");
                break;
        }





        }
    }
}
