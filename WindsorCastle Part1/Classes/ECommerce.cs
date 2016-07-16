using WindsorCastle_Part1.Interfaces;

namespace WindsorCastle_Part1.Classes
{
    public class ECommerce
    {
        public ECommerce(IBillingProcessor billingProcessor, IUpdateCustomer updateCustomer, INotifier notifier, ILogger log)
        {
            _BillingProcessor = billingProcessor;
            _UpdateCustomer = updateCustomer;
            _Notifier = notifier;
            _Log = log;
        }

        private IBillingProcessor _BillingProcessor;
        private IUpdateCustomer _UpdateCustomer;
        private INotifier _Notifier;
        private ILogger _Log;

        public void ProcessOrder(ClientInfo clientInfo)
        {
            _Log.Log("Processing Billing..");
            _BillingProcessor.ProcessBilling(clientInfo);
            _Log.Log("Updating Customer Order..");
            _UpdateCustomer.UpdateCustomerOrder(clientInfo);
            _Log.Log("Sending Receipt..");
            _Notifier.SendReceipt(clientInfo);
            _Log.Log("Order Processing completed..");
        }

    }
}
