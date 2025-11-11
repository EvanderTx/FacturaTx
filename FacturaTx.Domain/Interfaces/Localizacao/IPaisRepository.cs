using FacturaTx.Domain.Entidades.Localizacao;
using FacturaTx.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Interfaces.Localizacao
{
    public interface IPaisRepository:IBaseRepository<Pais>
    {
        Task<List<Provincia>> BuscarProvinciasAsync(Guid paisId);
    }
}
