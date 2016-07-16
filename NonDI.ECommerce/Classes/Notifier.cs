using System;

namespace NonDI.Commerce
{
    public class Notifier
    {
        public void SendReceipt(ClientInfo clientInfo)
        {
            Console.WriteLine(string.Format("{0} : Receipt has been sent to {1}",
                          DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                          clientInfo.DisplayName));
        }
    }
}
