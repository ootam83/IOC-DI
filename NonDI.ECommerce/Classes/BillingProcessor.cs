using System;

namespace NonDI.Commerce.Classes
{
    public class BillingProcessor 
    {
        public void ProcessBilling(ClientInfo clientInfo)
        {
            Console.WriteLine(string.Format("{0} : Billing processed for customer {1}",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), 
                        clientInfo.DisplayName));
        }
    }
}
