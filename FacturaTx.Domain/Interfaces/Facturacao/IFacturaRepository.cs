using FacturaTx.Domain.Entidades.Facturacao;
using FacturaTx.Domain.Entidades.Stock;
using FacturaTx.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Interfaces.Facturacao
{
    public interface IFacturaRepository : IBaseRepository<Factura>
    {
        Task<List<Factura>> BuscarPorEmpresaIdAsync(Guid empresaId);
        Task<Guid> AdicionarItem(ItemFactura itemFactura);
        Task<Guid> RemoveItem(ItemFactura itemFactura);
        Task<string> BuscarUltimaHashDeFacturaAsync(Guid empresaId);
        Task<TipoArtigo> BuscarTipoItemFacturaAsync(string nome);
    }
}
