using System;

namespace NonDI.Commerce
{
    public class UpdateCustomer 
    {
        public void UpdateCustomerOrder(ClientInfo clientInfo)
        {
            Console.WriteLine(string.Format("{0} : Customer record for {1} has been updated", 
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), 
                        clientInfo.DisplayName));
        }
    }
}
