using WindsorCastle_Part1.Classes;

namespace WindsorCastle_Part1.Interfaces
{
    public interface INotifier
    {
        void SendReceipt(ClientInfo clientInfo);
    }
}
