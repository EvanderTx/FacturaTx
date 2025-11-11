using FacturaTx.Domain.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Facturacao
{
    public class TipoFactura : BaseEntity
    {
        public required string Nome { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public required string Sigla { get; set; } = string.Empty;
        public List<Factura> Facturas { get; set; } = new List<Factura>();

    }
}
