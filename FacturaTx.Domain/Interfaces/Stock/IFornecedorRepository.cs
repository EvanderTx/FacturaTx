using FacturaTx.Domain.Entidades.Stock;
using FacturaTx.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Interfaces.Stock
{
    public interface IFornecedorRepository : IBaseRepository<Fornecedor>
    {
        Task<List<Fornecedor>> BuscarPorEmpresaIdAsync(Guid empresaId);
    }
}
