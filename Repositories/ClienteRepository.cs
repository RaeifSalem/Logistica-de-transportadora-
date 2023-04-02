using Logistica.Context;
using Logistica.Entities;
using Logistica.Interfaces;
using Logistica.Requests;

namespace Logistica.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public readonly ApplicationDBContext _Context;
        public ClienteRepository(ApplicationDBContext context)
        {
            _Context= context;
        }
        public Cliente include(ClienteRequest request)
        {
            var Cliente = new Cliente()
            {
                CNPJ = request.CNPJ,
                Nome = request.Nome,
            };
            _Context.Add(Cliente);
            _Context.SaveChanges();
            return Cliente; 
        }
    }
}
