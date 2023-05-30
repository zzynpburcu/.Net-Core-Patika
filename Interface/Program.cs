using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger(); //instance
            fileLogger.writeLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.writeLog();

            SmsLogger smsLogger = new(); // .net 9 dan itibaren bu şekilde instance tanımlayabiliyoruz
            smsLogger.writeLog();

            LogManager logManager =  new LogManager(new FileLogger());
            logManager.writeLog();


        }
    }
}
