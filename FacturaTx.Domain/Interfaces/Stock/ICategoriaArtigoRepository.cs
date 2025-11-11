using FacturaTx.Domain.Entidades.Stock;
using FacturaTx.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Interfaces.Stock
{
    public interface ICategoriaArtigoRepository : IBaseRepository<CategoriaArtigo>
    {
        Task<List<CategoriaArtigo>> BuscarPorEmpresaIdAsync(Guid empresaId);
    }
}
