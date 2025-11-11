using FacturaTx.Domain.Entidades.Financeiro;
using FacturaTx.Domain.Entidades.Institucional;
using FacturaTx.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Interfaces.Institucional
{
    public interface IEmpresaRepository : IBaseRepository<Empresa>
    {
        Task<ContaBancaria> BuscarContaBancariaPadraoAsync(Guid empresaId);

        Task<List<ContaBancaria>> BuscarContasBancariasAsync(Guid empresaId);
    }
}
