using FacturaTx.Domain.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Financeiro
{
    public class Imposto:BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        public decimal TaxaPercentagem { get; set; }
        public decimal? ValorFixo { get; set; }
        public string TipoImpostoId { get; set; } = string.Empty;
        public TipoImposto TipoImposto { get; set; }
    }
}
