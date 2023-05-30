using System;

namespace Interface
{
    //interface metodlarını imlement etmek gerekir
    public class DatabaseLogger : ILogger
    {
        public void writeLog()
        {
            Console.WriteLine("Database e log yazar.");
        }
    }
}