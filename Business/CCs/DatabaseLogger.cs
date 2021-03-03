using System;

namespace Business.CCs
{
    public class DatabaseLogger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}
