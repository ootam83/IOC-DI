
namespace NonDI.Commerce.Classes
{
    public class ECommerce
    {
        public ECommerce(BillingProcessor billingProcessor, UpdateCustomer updateCustomer, Notifier notifier, Logger log)
        {
            _BillingProcessor = billingProcessor;
            _UpdateCustomer = updateCustomer;
            _Notifier = notifier;
            _Log = log;
        }

        private BillingProcessor _BillingProcessor;
        private UpdateCustomer _UpdateCustomer;
        private Notifier _Notifier;
        private Logger _Log;

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
