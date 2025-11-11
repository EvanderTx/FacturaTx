using FacturaTx.Domain.Entidades.Base;
using FacturaTx.Domain.Entidades.Localizacao;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Financeiro
{
    public class Banco : BaseEntity
    {
        public string LogotipoUrl { get; set; } = "~/images/no-image.jpg";
        public required string Nome { get; set; }
        public string Referencia { get; set; } = string.Empty;
        public string PaisId { get; set; } = string.Empty;
        public Pais Pais { get; set; }
        public List<ContaBancaria> ContasBancarias { get; set; } = new ();
    }
}
