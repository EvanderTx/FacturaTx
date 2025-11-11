using FacturaTx.Domain.Entidades.Institucional.RecursosHumanos;
using FacturaTx.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Interfaces.Institucional.RecursosHumanos
{
    public interface ICargoRepository:IBaseRepository<Cargo>
    {
        Task<List<Cargo>> BuscarPorDepartamentoIdAsync(Guid departamentoId);
    }
}
