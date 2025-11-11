using FacturaTx.Domain.Entidades.Base;
using FacturaTx.Domain.Entidades.Stock;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Facturacao
{
    public class ItemFactura : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        //public string Descricao { get; set; } = string.Empty;
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public int Quantidade { get; set; }
        public string FacturaId { get; set; }
        public string? ArtigoId { get; set; }
        public decimal PorcentagemDesconto { get; set; }
        public Artigo Artigo { get; set; }
        public Factura Factura { get; set; }

    }
}
