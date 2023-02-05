using Microsoft.AspNetCore.Mvc;
using PhoneStoreManagmentSystem.Data.Models;
using PhoneStoreManagmentSystem.Data.ViewModels;
using PhoneStoreManagmentSystem.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoneStoreManagmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        readonly IClientService _clientService;
        public ClientsController(IClientService service)
        {
            _clientService = service;
        }

        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _clientService.Klientet();
        }

        [HttpGet("GetClientByName/{name}")]
        public Client Get(string name)
        {
            return _clientService.MerrClientByName(name);
        }

        [HttpPost]
        public string Post([FromBody] ClientVM value)
        {
            return _clientService.Create(value);
        }

        [HttpPut]
        public string Put([FromBody] ClientVM value)
        {
            return _clientService.ClientUpdate(value);
        }

        [HttpDelete("{name}")]
        public string Delete(string name)
        {
            return _clientService.ClientDelete(name);
        }
    }
}
