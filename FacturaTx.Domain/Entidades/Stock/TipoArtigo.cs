using FacturaTx.Domain.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Stock
{
    public class TipoArtigo : BaseEntity
    {
        public string Nome { get; set; }
        public List<Artigo> Artigos { get; set; } = new List<Artigo>();

        //Produto ou Serviço
    }
}
