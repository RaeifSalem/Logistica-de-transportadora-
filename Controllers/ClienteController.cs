using Logistica.Interfaces;
using Logistica.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

namespace Logistica.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ClienteController : ControllerBase
    {
        public readonly IClienteRepository _clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        [HttpPost]
        [Route("/Cliente")]
        public ActionResult<int> CriaCliente(ClienteRequest request)
        { 
        var Cliente = _clienteRepository.include(request);
            return Ok(Cliente.Id);
         }
    }


}
