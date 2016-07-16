using System;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using WindsorCastle_Part1.Interfaces;
using WindsorCastle_Part1.Classes;

namespace WindsorCastle_Part1
{
    class WindsorCastle
    {
        static void Main(string[] args)
        {
            //Instantiating the container
            var container = new WindsorContainer();
            

            //Registering interfaces 
            container.Register(Component.For<IBillingProcessor>().ImplementedBy<BillingProcessor>());
            container.Register(Component.For<IUpdateCustomer>().ImplementedBy<UpdateCustomer>());
            container.Register(Component.For<INotifier>().ImplementedBy<Notifier>());
            container.Register(Component.For<ILogger>().ImplementedBy<Logger>());

            //Registering Concrete class as well
            container.Register(Component.For<ECommerce>());

            //Resolving interface Ilog implemented by class Logger
            var logger = container.Resolve<Interfaces.ILogger>();

            logger.Log("Hello World!");

            var client = new ClientInfo
            {
                CreditCardNumber = "123556546",
                EmailAddress = "ootam@centerpoint.mu",
                FirstName = "Ootam",
                LastName = "Seewoogoolam",
                PhoneNumber = "1234567"
            };

            //Resolving concrete class Ecommerce and all its dependencies in the constructor
            var ecommerce = container.Resolve<ECommerce>();
            ecommerce.ProcessOrder(client);

            logger.Log("Please Press [Enter] to exit..");
            Console.ReadLine();
        }
    }
}
