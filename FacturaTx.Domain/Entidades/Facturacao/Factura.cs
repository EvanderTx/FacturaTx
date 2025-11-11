using FacturaTx.Domain.Entidades.AutenticacaoAutorizacao;
using FacturaTx.Domain.Entidades.Base;
using FacturaTx.Domain.Entidades.Financeiro;
using FacturaTx.Domain.Entidades.Institucional;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Facturacao
{
    public class Factura : BaseEntity
    {
        public int IdInt { get; set; }
        public string Numero { get; set; } = string.Empty;
        public Decimal ValorTotal { get; set; }
        public string? ClienteId { get; set; } = string.Empty;
        public string? FormaPagamentoId { get; set; } = string.Empty;
        public required string UsuarioId { get; set; }
        public required string TipoFacturaId { get; set; }
        public required string EmpresaId { get; set; }
        public required string HashBase64 { get; set; }

        public string MotivoAnulacao { get; set; } = string.Empty;
        public string ContaBancariaId { get; set; } = string.Empty;
        public string? FaturaOriginalId { get; set; }
        public DateTime? DataDeValidade { get; set; }
        public bool Convertida { get; set; }
        public bool Anulada { get; set; }


        public virtual Empresa Empresa { get; set; }
        public virtual ContaBancaria ContaBancaria { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        public virtual TipoFactura TipoFactura { get; set; }
        public virtual List<ItemFactura> ItensFacturas { get; set; } = new List<ItemFactura>();
        public virtual Factura? FaturaOriginal { get; set; }

        public virtual List<Factura> FaturasDerivadas { get; set; } = new();
    }
}
