using Logistica.Entities;
using Microsoft.EntityFrameworkCore;

namespace Logistica.Context
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<NotaFiscal> NotasFiscais { get; set; }
        public DbSet<Responsavel> Responsaveis { get; set; }
        public DbSet<Servico> servicos { get; set; }
        public DbSet<Status> status { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TipoNotaFiscal> TiposNotasFiscais { get; set; }

    }
}
