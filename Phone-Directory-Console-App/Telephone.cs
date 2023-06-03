using System;
using System.Collections.Generic;

namespace Telephone_Directory
{
    public class Person
    {
        private string name;
        private string surname;
        private int phoneNumber;
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }

        public Person(string name, string surname, int phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }

    }
    public class Directory
    {

        private List<Person> contacts;
        public Directory()
        {
            contacts = new List<Person>();
        }

        public void AddPerson()
        {
            Console.Write("Lütfen isim giriniz             : ");
            string name = Console.ReadLine().ToString();
            Console.Write("Lütfen soyisim giriniz           : ");
            string surname = Console.ReadLine().ToString();
            Console.Write("Lütfen telefon numarası giriniz  : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Person newContact = new Person(name, surname, number);
            contacts.Add(newContact);
            Console.WriteLine(name + " " + surname + ", başarıyla rehbere eklendi");
        }

        public void DeletePerson()
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string searchQuery = Console.ReadLine();

            bool contactFound = false;

            foreach (Person contact in contacts)
            {
                if (contact.Name.ToLower() == searchQuery.ToLower() || contact.Surname.ToLower() == searchQuery.ToLower())
                {
                    contactFound = true;
                    Console.WriteLine();
                    Console.WriteLine($"{contact.Name} {contact.Surname} isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n)");

                    string confirmation = Console.ReadLine().ToLower();

                    if (confirmation == "y")
                    {
                        contacts.Remove(contact);
                        Console.WriteLine("Kişi başarıyla silindi.");
                        break;
                    }
                    else if (confirmation == "n")
                    {
                        Console.WriteLine("Silme işlemi iptal edildi.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz giriş. Silme işlemi iptal edildi.");
                        break;
                    }
                }
            }

            if (!contactFound)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.");
                Console.WriteLine("Lütfen bir seçim yapınız:");
                Console.WriteLine("* Silmeyi sonlandırmak için: (1)");
                Console.WriteLine("* Yeniden denemek için: (2)");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 2)
                {
                    DeletePerson();
                }
            }
        }

        public void ListContacts()
        {
            if (contacts.Count == 0)
                Console.WriteLine("Hiçbir kayıt yok");
            else
            {
                Console.WriteLine("Rehberdeki Kayıtlar:");
                foreach (Person person in contacts)
                {
                    Console.WriteLine("Adı: {0} ", person.Name);
                    Console.WriteLine("Soyadı: {0}", person.Surname);
                    Console.WriteLine("Telefon Numarası: {0}", person.PhoneNumber);
                    Console.WriteLine("---------------------");
                }
            }
        }
        public void UpdateContact()
        {
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string searchQuery = Console.ReadLine();

            bool contactFound = false;

            foreach (Person contact in contacts)
            {
                if (contact.Name.ToLower() == searchQuery.ToLower() || contact.Surname.ToLower() == searchQuery.ToLower())
                {
                    contactFound = true;

                    Console.WriteLine();
                    Console.WriteLine($"Güncellemek istediğiniz kişinin bilgileri: {contact.Name} {contact.Surname} - {contact.PhoneNumber}");


                    Console.WriteLine("Lütfen yeni telefon numarasını giriniz: ");
                    string newPhoneNumber = Console.ReadLine();

                    contact.PhoneNumber = Convert.ToInt32(newPhoneNumber);

                    Console.WriteLine("Kişi bilgileri başarıyla güncellendi.");
                    break;
                }
            }

            if (!contactFound)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.");
                Console.WriteLine("Lütfen bir seçim yapınız:");
                Console.WriteLine("* Güncellemeyi sonlandırmak için: (1)");
                Console.WriteLine("* Yeniden denemek için: (2)");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 2)
                {
                    UpdateContact();
                }
            }
        }

        public void SearchContacts()
        {
            {
                Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz:");
                Console.WriteLine("**********************************************");
                Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Lütfen aramak istediğiniz kişinin adını ya da soyadını giriniz: ");
                    string searchQuery = Console.ReadLine().ToLower();

                    bool contactFound = false;

                    Console.WriteLine("Arama Sonuçlarınız:");
                    Console.WriteLine("**********************************************");

                    foreach (Person contact in contacts)
                    {
                        if (contact.Name.ToLower().Contains(searchQuery) || contact.Surname.ToLower().Contains(searchQuery))
                        {
                            Console.WriteLine($"isim: {contact.Name} Soyisim: {contact.Surname} Telefon Numarası: {contact.PhoneNumber}");
                            contactFound = true;
                        }
                    }

                    if (!contactFound)
                    {
                        Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.");
                    }
                }
                else if (choice == 2)
                {
                    Console.Write("Lütfen aramak istediğiniz telefon numarasını giriniz: ");
                    int searchQuery = Convert.ToInt32(Console.ReadLine());

                    bool contactFound = false;

                    Console.WriteLine("Arama Sonuçlarınız:");
                    Console.WriteLine("**********************************************");

                    foreach (Person contact in contacts)
                    {
                        if (contact.PhoneNumber == searchQuery)
                        {
                            Console.WriteLine($"isim: {contact.Name} Soyisim: {contact.Surname} Telefon Numarası: {contact.PhoneNumber}");
                            contactFound = true;
                        }
                    }

                    if (!contactFound)
                    {
                        Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim. Arama işlemi iptal edildi.");
                }
            }

        }
    }
}



