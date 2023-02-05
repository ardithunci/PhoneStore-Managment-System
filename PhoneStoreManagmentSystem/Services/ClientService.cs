using PhoneStoreManagmentSystem.Data;
using PhoneStoreManagmentSystem.Data.Models;
using PhoneStoreManagmentSystem.Data.ViewModels;
using System.Linq;

namespace PhoneStoreManagmentSystem.Services
{
    public class ClientService: IClientService
    {
        readonly AppDbContext _dbContext;
        public ClientService(AppDbContext db)
        {
            _dbContext=db;
        }
        public string Create(ClientVM client)
        {
            _dbContext.Klientet.Add(new Client 
            {
                MjetIdentifikimi = client.MjetIdentifikimi,
                Ditelindja = client.Ditelindja,
                NumriPersonal = client.NumriPersonal,
                Name = client.EmriKlientit,
                NumriBlerjeve = client.NumriBlerjeve
            });
            _dbContext.SaveChanges();
            return "klienti u shtua me sukses!";
        }

        public string ClientUpdate(ClientVM client)
        {
            var _client = _dbContext.Klientet.FirstOrDefault(c => c.Name == client.EmriKlientit);
            _client!.NumriBlerjeve = client.NumriBlerjeve;
            _dbContext.SaveChanges();
            return "klienti u perditesua me sukses!";
        }
        public List<Client> Klientet()
        {
            return _dbContext.Klientet.ToList();
        }
        public Client MerrClientByName(string name)
        {
            var _client = _dbContext.Klientet.FirstOrDefault(c => c.Name == name);
            return _client!;
        }
        public string ClientDelete(string name)
        {
            var _client = _dbContext.Klientet.FirstOrDefault(c => c.Name == name);
            _dbContext.Klientet.Remove(_client!);
            _dbContext.SaveChanges();
            return "klienti u fshi me sukses!";
        }
    }
}
