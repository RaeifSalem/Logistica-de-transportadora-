using Logistica.Context;
using Logistica.Entities;
using Logistica.Interfaces;
using Logistica.Requests;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Logistica.Repositories
{
    public class ResponsavelRepository : IResponsavelRepository
    {
        public readonly ApplicationDBContext _context;

        public ResponsavelRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public Responsavel Include(ResponsavelResquest request)
        {                       
            var responsavel = new Responsavel()
            {
                Nome = request.Nome,
                Email = request.Email,
            };

            _context.Add(responsavel);
            _context.SaveChanges();
            return responsavel;

        }

    }
}
