using Logistica.Entities.Base;

namespace Logistica.Entities
{
    public class Ticket : BaseModelo
    {
        public Cliente Cliente { get; set; }
        public int IdCliente { get; set; }
        public NotaFiscal NotaFiscal { get; set; }
        public int IdNotaFiscal { get; set; }
        public Servico Servico { get; set; }
        public int IdServico { get; set; }
        public int IdStatus { get; set; }
        public Status Status { get; set; }
        public double ValorFrete { get; set; }
        public DateTime DataEntrega { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataConhecimento { get; set; }
        public DateTime DataRetorno { get; set; }
        public int CodigoFatura { get; set; }
        public int CTE { get; set; }
        public int CTRC { get; set; }
     
    }
}
