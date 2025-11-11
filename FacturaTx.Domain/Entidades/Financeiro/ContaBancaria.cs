using FacturaTx.Domain.Entidades.Base;
using FacturaTx.Domain.Entidades.Facturacao;
using FacturaTx.Domain.Entidades.Institucional;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Financeiro
{
    public class ContaBancaria : BaseEntity
    {
        public string BancoId { get; set; } = string.Empty;
        public string EmpresaId { get; set; } = string.Empty;

        public string Iban { get; set; } = string.Empty;
        public string NumeroConta { get; set; } = string.Empty;
        public string Titular { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string Dependencia { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public bool BancoPadrao { get; set; }

        public Banco Banco { get; set; }

        public Empresa Empresa { get; set; }


        public List<Factura> Facturas { get; set; } = new List<Factura>();

    }
}
