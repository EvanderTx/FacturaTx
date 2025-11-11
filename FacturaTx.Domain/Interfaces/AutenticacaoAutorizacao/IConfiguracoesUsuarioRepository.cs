using FacturaTx.Domain.Entidades.AutenticacaoAutorizacao;
using FacturaTx.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Interfaces.AutenticacaoAutorizacao
{
    public interface IConfiguracoesUsuarioRepository : IBaseRepository<ConfiguracoesUsuario>
    {
        Task<ConfiguracoesUsuario?> BuscarEmpresaActivaIdAsync(Guid usuarioId);
        Task<ConfiguracoesUsuario?> ObterPorUsuarioIdAsync(Guid usuarioId);
        Task<ConfiguracoesUsuario?> ActualizarEmpresaActivaAsync(Guid usuarioId, Guid empresaId);
    }
}
