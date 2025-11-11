using FacturaTx.Domain.Entidades.Facturacao;
using FacturaTx.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Interfaces.Facturacao
{
    public interface ITipoFacturaRepository : IBaseRepository<TipoFactura>
    {
        TipoFactura GetByName(string nome);
    }
}
