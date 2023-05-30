using System;

namespace Interface
{
    //interface metodlarını imlement etmek gerekir
    public class LogManager:ILogger
    { 
        public ILogger _logger; // logger sınıfının instanceı
        public LogManager(ILogger logger){
            _logger = logger;
        }

        public void writeLog()
        {
           _logger.writeLog();
        }
    }
}