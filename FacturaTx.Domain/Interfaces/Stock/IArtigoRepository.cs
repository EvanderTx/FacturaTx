using FacturaTx.Domain.Entidades.Stock;
using FacturaTx.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Interfaces.Stock
{
    public interface IArtigoRepository : IBaseRepository<Artigo>
    {
        Task<List<Artigo>> BuscarPorEmpresaIdAsync(Guid empresaId);
    }
}
