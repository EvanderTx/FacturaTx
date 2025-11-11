using FacturaTx.Domain.Entidades.Facturacao;
using FacturaTx.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Interfaces.Facturacao
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        Task<Cliente> BuscarPorNifAsync(string nif);
        Task<List<Cliente>> BucarPorEmpresaIdAsync(Guid empresaId);
    }
}
