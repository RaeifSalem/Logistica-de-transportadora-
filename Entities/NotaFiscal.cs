using Logistica.Entities.Base;

namespace Logistica.Entities
{
    public class NotaFiscal : BaseModelo
    {
        public long codigo { get; set; }
        public TipoNotaFiscal TipoNotaFiscal { get; set; }
        public int IdTipoNotaFiscal { get; set; }
    
    
    
    }


    

}
