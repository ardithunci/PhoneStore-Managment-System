using PhoneStoreManagmentSystem.Data.Models;
using PhoneStoreManagmentSystem.Data.ViewModels;

namespace PhoneStoreManagmentSystem.Services
{
    public interface IClientService
    {
        public string ClientUpdate(ClientVM client);
        public string ClientDelete(string name);
        public Client MerrClientByName(string name);
        public List<Client> Klientet();
        public string Create(ClientVM client);
    }
}
