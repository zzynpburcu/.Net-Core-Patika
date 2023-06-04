using System;

namespace ToDo_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kisiler = new Dictionary<int, string>();

            Takım person = new Takım(18, "Zeynep Burcu");
            person.AddPerson(kisiler);
        }
    }
}
