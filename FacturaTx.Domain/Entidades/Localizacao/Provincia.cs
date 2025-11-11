using FacturaTx.Domain.Entidades.Base;
using FacturaTx.Domain.Entidades.Facturacao;
using FacturaTx.Domain.Entidades.Institucional;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Localizacao
{
    public class Provincia:BaseEntity
    {
        public string? Codigo { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string PaisId { get; set; } = string.Empty;
        public Pais Pais { get; set; }
        public List<Cliente> Clientes { get; set; } = new ();
        public List<Empresa> Empresas { get; set; } = new ();
    }
}
