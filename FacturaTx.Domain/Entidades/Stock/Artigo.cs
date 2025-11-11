using FacturaTx.Domain.Entidades.Base;
using FacturaTx.Domain.Entidades.Facturacao;
using FacturaTx.Domain.Entidades.Institucional;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Stock
{
    public class Artigo : BaseEntity
    {
        public int IdInt { get; set; }
        public string FotoUrl { get; set; } = "~/images/no-image.jpg";
        public string? CodigoDeBarras { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public decimal? ValorAquisicao { get; set; }
        public string? Descricao { get; set; }
        public string CategoriaArtigoId { get; set; }
        public string TipoArtigoId { get; set; }
        public string ImpostoId { get; set; }
        public bool IsentoDeImposto { get; set; }
        public string? IsencaoImpostoId { get; set; }

        public string EmpresaId { get; set; } = string.Empty;
        public string? FornecedorId { get; set; } = string.Empty;

        public int Quantidade { get; set; }
        public Empresa Empresa { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public List<ItemFactura> ItensFacturas { get; set; } = new List<ItemFactura>();
        public TipoArtigo TipoArtigo { get; set; }
        public CategoriaArtigo CategoriaArtigo { get; set; }
        public ImpostoIsencao ImpostoIsencao { get; set; }

    }
}
