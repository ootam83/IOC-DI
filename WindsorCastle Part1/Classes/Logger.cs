using System;
using WindsorCastle_Part1.Interfaces;

namespace WindsorCastle_Part1.Classes
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(string.Format("{0} : {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), message));
        }
    }
}
