using FacturaTx.Domain.Entidades.Base;
using FacturaTx.Domain.Entidades.Institucional;
using FacturaTx.Domain.Entidades.Localizacao;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Facturacao
{
    public class Cliente : BaseEntity
    {
        public int IdInt { get; set; }
        public string FotoUrl { get; set; } = "~/images/no-image.jpg";
        public string NIF { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string TipoClienteId { get; set; } = string.Empty;
        public string EmpresaId { get; set; } = string.Empty;
        public string ProvinciaId { get; set; } = string.Empty;
        public Empresa Empresa { get; set; }
        public Provincia Provincia { get; set; }
        public TipoCliente TipoCliente { get; set; }
        public List<Factura> Facturas { get; set; } = new List<Factura>();
    }
}
