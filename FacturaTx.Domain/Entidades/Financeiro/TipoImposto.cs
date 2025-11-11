using FacturaTx.Domain.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Financeiro
{
    public class TipoImposto:BaseEntity
    {
        public string Codigo { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; } = string.Empty;

        public List<Imposto> Impostos { get; set; } = new List<Imposto>();


        //IVA – Imposto sobre o valor acrescentado;
        //IS – Imposto do selo;
        //NS – Não sujeição a IVA ou IS.
    }
}
