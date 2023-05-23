using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collection.Generic

            Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();

            kullanıcılar.Add(10,"Zeynep Burcu");
            kullanıcılar.Add(12,"Dotnet Core");
            kullanıcılar.Add(18,"Patika Dev");
            kullanıcılar.Add(20,"Daily Coding");

            //Dizinin elemanlarına erişim
            Console.WriteLine("********** Elemanlara Erişim ***********");
            Console.WriteLine(kullanıcılar[12]);
            foreach(var item in kullanıcılar)
            Console.WriteLine(item);

            //Count
            Console.WriteLine("********** Count ***********");
            Console.WriteLine(kullanıcılar.Count);

            //Contains
            Console.WriteLine("********** Contains ***********");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Patika"));

            //Remove
            Console.WriteLine("********** Remove ***********");
            kullanıcılar.Remove(12);
              foreach(var item in kullanıcılar)
            {Console.WriteLine(item);
            Console.WriteLine(item.Key);}

            //Keys
            Console.WriteLine("************ Keys *************");
            foreach (var item in kullanıcılar.Keys)
            Console.WriteLine(item);
            

             //Values
            Console.WriteLine("************ Values *************");
            foreach (var item in kullanıcılar.Values)
            Console.WriteLine(item);
            


        }
    }
}
