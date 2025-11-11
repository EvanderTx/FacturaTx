using FacturaTx.Domain.Entidades.Base;
using FacturaTx.Domain.Entidades.Institucional;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Stock
{
    public class CategoriaArtigo : BaseEntity
    {
        public required string Nome { get; set; }
        public string Referencia { get; set; } = string.Empty;

        public string EmpresaId { get; set; } = string.Empty;
        public string? CategoriaPaiId { get; set; } = string.Empty;

        public Empresa Empresa { get; set; }
        public List<Artigo> Artigos { get; set; } = new ();
        public CategoriaArtigo CatgoriaPai { get; set; }
        public List<CategoriaArtigo> SubCategoriasArtigo { get; set; } = new ();

    }
}
