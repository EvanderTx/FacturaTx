using FacturaTx.Domain.Entidades.Base;
using FacturaTx.Domain.Entidades.Institucional;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.AutenticacaoAutorizacao
{
    public class ConfiguracoesUsuario: BaseEntity
    {
        public Guid? EmpresaActivaId { get; set; }
        public Guid UsuarioId { get; set; }
        public Empresa Empresa { get; set; }
        public Usuario Usuario { get; set; }
    }
}
