using FacturaTx.Domain.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Facturacao
{
    public class FormaPagamento : BaseEntity
    {
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public List<Factura> Facturas { get; set; } = new List<Factura>();
    }
}
