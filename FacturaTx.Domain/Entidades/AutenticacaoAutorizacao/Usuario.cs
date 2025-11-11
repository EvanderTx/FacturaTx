using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FacturaTx.Domain.Entidades.AutenticacaoAutorizacao
{
    public class Usuario : IdentityUser<Guid>
    {
        // Relacionamentos
        //public Guid? AssinaturaActivaId { get; set; }
        //[ForeignKey("AssinaturaActivaId")]
        //public virtual AssinaturaUsuario AssinaturaAtiva { get; set; }
        //public virtual List<EmpresaUsuario> EmpresasUsuarios { get; set; } = new();
        //public virtual List<Empresa> EmpresasProprietario { get; set; } = new(); // Empresas que criou
        //public virtual List<AssinaturaUsuario> HistoricoAssinaturas { get; set; } = new();
        //public virtual List<Funcionario> Funcionarios { get; set; } = new();
        //public virtual List<ConfiguracoesUsuario> ConfiguracoesUsuarios { get; set; } = new();

        //// Novo relacionamento para roles por empresa
        //public virtual List<UsuarioEmpresaRole> UsuariosEmpresasRoles { get; set; } = new();
        //public virtual List<Diretorio> Diretorios { get; set; } = new();
        //public virtual List<Ficheiro> Ficheiros { get; set; } = new();

    }
}
