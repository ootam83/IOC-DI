using System;
using WindsorCastle_Part1.Interfaces;

namespace WindsorCastle_Part1.Classes
{
    public class Notifier: INotifier
    {
        public void SendReceipt(ClientInfo clientInfo)
        {
            Console.WriteLine(string.Format("{0} : Receipt has been sent to {1}",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        clientInfo.DisplayName));
        }
    }
}
