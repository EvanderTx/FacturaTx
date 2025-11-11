using FacturaTx.Domain.Entidades.Base;
using FacturaTx.Domain.Entidades.Financeiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Localizacao
{
    public class Pais:BaseEntity
    {
        public string BandeiraUrl { get; set; } = "~/images/no-image.jpg";
        public string? Codigo { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;

        public List<Provincia> Provincias { get; set; } = new();
        public List<Banco> Bancos { get; set; } = new();
    }
}
