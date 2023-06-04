using System;
using System.Collections.Generic;

namespace ToDo_Console_App
{
    public class Takım
    {
        private string namesurname;
        private int id;

        public Takım(int id, string namesurname = null)
        {
            this.id = id;
            this.namesurname = namesurname;
        }

        Dictionary<int, string> kisiler = new Dictionary<int, string>();



        public void AddPerson(Dictionary<int, string> kisiler)
        {
            kisiler.Add(id, namesurname);
        }


    }

}