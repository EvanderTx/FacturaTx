using FacturaTx.Domain.Entidades.Financeiro;
using FacturaTx.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Interfaces.Financeiro
{
    public interface IContaBancariaRepository : IBaseRepository<ContaBancaria>
    {
        Task<List<ContaBancaria>> BuscarPorEmpresaIdAsync(string empresaId);
        Task<bool> TornarContaBancariaPadraoAsync(string contaId);
    }
}
