using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.AutenticacaoAutorizacao
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public string? Descricao { get; set; }
        public string Cor { get; set; } = "#6366f1"; // Para UI
        public bool EhRoleCore { get; set; } = false; // Roles do sistema que não podem ser excluídas

        // Relacionamentos customizados
        //public virtual List<RolePermissao> RolesPermissoes { get; set; } = new();
        public virtual List<UsuarioEmpresaRole> UsuariosEmpresasRoles { get; set; } = new();

        // Construtores
        public ApplicationRole() : base()
        {
        }

        public ApplicationRole(string roleName) : base(roleName)
        {
        }

        public ApplicationRole(string roleName, string descricao) : base(roleName)
        {
            Descricao = descricao;
        }
    }
}
