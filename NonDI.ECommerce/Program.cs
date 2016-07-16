using System;
using NonDI.Commerce.Classes;

namespace NonDI.Commerce
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ClientInfo
            {
                CreditCardNumber = "123556546",
                EmailAddress = "ootam@centerpoint.mu",
                FirstName = "Ootam",
                LastName = "Seewoogoolam",
                PhoneNumber = "1234567"
            };

            //Instantiating dependent objects
            var _BillingProcessor = new BillingProcessor();
            var _UpdateCustomer = new UpdateCustomer();
            var _Notifier = new Notifier();
            var _Logger = new Logger();

            //Instantiating ECommerce objet
            var ecommerce = new ECommerce(_BillingProcessor, _UpdateCustomer, _Notifier, _Logger);
            ecommerce.ProcessOrder(client);

            _Logger.Log("Please Press [Enter] to exit..");
            Console.ReadLine();
        }
    }
}
