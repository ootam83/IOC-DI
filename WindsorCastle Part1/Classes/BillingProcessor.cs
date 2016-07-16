using System;
using WindsorCastle_Part1.Interfaces;

namespace WindsorCastle_Part1.Classes
{
    public class BillingProcessor : IBillingProcessor
    {
        public void ProcessBilling(ClientInfo clientInfo)
        {
            Console.WriteLine(string.Format("{0} : Billing processed for customer {1}", 
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), 
                        clientInfo.DisplayName));
        }
    }
}
