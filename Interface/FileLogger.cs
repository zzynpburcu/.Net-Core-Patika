using System;

namespace Interface
{
    //interface metodlarını imlement etmek gerekir
    public class FileLogger : ILogger
    {
        public void writeLog()
        {
            Console.WriteLine("Dosyaya log yazar.");
        }
    }
}