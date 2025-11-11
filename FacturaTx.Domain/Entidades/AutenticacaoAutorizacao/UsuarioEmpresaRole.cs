using FacturaTx.Domain.Entidades.Institucional;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.AutenticacaoAutorizacao
{
    public class UsuarioEmpresaRole
    {
        public Guid UsuarioId { get; set; }
        public Guid EmpresaId { get; set; }
        public Guid RoleId { get; set; }
        public DateTime DataAtribuicao { get; set; } = DateTime.UtcNow;
        public DateTime? DataExpiracao { get; set; }
        public bool Ativo { get; set; } = true;

        public virtual Usuario Usuario { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }
}
