using FacturaTx.Domain.Entidades.Facturacao;
using FacturaTx.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Interfaces.Facturacao
{
    public interface IFormaPagamentoRepository : IBaseRepository<FormaPagamento>
    {
        Task<FormaPagamento> BuscarPorNomeAsync(string nome);
    }
}
