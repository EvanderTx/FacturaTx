using FacturaTx.Domain.Entidades.AutenticacaoAutorizacao;
using FacturaTx.Domain.Entidades.Institucional;
using FacturaTx.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Interfaces.AutenticacaoAutorizacao
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Task<Usuario> BuscarPorNomeDeUsuarioAsync(string name);
        Task<Empresa> BuscarEmpresaActivaAsync(Guid usuarioId);
        Task<Guid> ActualizarEmpresaActiva(Guid usuarioId, Guid empresaId);
    }
}
