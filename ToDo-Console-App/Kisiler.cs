using System;
using System.Collections.Generic;

namespace ToDo_Console_App
{
    public class Takım
    {
        public Dictionary<int, string> Uyeler { get; private set; }

    public Takım()
    {
        Uyeler = new Dictionary<int, string>();
        Uyeler.Add(1, "Ahmet");
        Uyeler.Add(2, "Mehmet");
        Uyeler.Add(3, "Ayşe");
    }
    }

}