using FacturaTx.Domain.Entidades.Institucional.RecursosHumanos;
using FacturaTx.Domain.Interfaces.Base;

namespace FacturaTx.Domain.Interfaces.Institucional.RecursosHumanos
{
    public interface IFuncionarioRepository:IBaseRepository<Funcionario>
    {
        Task<List<Funcionario>> BuscarPorDepartamentoIdAsync(Guid departamentoId);
        Task<List<Funcionario>> BuscarPorCargoIdAsync(Guid cargoId);
        Task<List<Funcionario>> GetByUsuarioId(Guid usuarioId);
    }
}
