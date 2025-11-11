using FacturaTx.Domain.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Financeiro
{
    public class IsencaoImposto:BaseEntity
    {
        public string Codigo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
    }
}
