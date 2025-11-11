using FacturaTx.Domain.Entidades.AutenticacaoAutorizacao;
using FacturaTx.Domain.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Institucional.RecursosHumanos
{
    public class Funcionario : BaseEntity
    {
        public string? FotoPerfilUrl { get; set; } = "~/images/no-images.jpg";
        public string? BilheteIdentidade { get; set; }
        public required string Nome { get; set; }
        public string? Telefone { get; set; }
        public string? TelefoneAlternativo { get; set; }
        public string Email { get; set; }
        public string? LocalResidencia { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool ChefeDepartamento { get; set; }
        public required string CargoId { get; set; }
        public required string UsuarioId { get; set; }
        public Cargo Cargo { get; set; }
        public Usuario Usuario { get; set; }

    }
}
