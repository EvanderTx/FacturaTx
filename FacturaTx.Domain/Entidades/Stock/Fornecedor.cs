using FacturaTx.Domain.Entidades.Base;
using FacturaTx.Domain.Entidades.Institucional;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Stock
{
    public class Fornecedor : BaseEntity
    {
        public int IdInt { get; set; }
        public string FotoUrl { get; set; } = "~/images/no-image.jpg";
        public string Nome { get; set; } = string.Empty;
        public required string NIF { get; set; }
        public string? Email { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public string EmpresaId { get; set; } = string.Empty;

        public Empresa Empresa { get; set; }
        public List<Artigo> Artigos { get; set; } = new ();
    }
}
