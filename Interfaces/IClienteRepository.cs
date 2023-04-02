using Logistica.Entities;
using Logistica.Requests; 

namespace Logistica.Interfaces
{
    public interface IClienteRepository
    {
        Cliente include(ClienteRequest request);  
    }
}
