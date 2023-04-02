using Logistica.Entities;
using Logistica.Requests;

namespace Logistica.Interfaces
{
    public interface IResponsavelRepository
    {
        Responsavel Include(ResponsavelResquest request);
        
    }
}
