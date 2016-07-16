using System;

namespace NonDI.Commerce
{
    public class Logger 
    {
        public void Log(string message)
        {
            Console.WriteLine(string.Format("{0} : {1}",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),message));
        }
    }
}
