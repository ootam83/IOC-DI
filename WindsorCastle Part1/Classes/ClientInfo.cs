
namespace WindsorCastle_Part1.Classes
{
    public class ClientInfo
    {
        public ClientInfo() { }
        public string CreditCardNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string DisplayName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
    }
}
