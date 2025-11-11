using FacturaTx.Domain.Entidades.AutenticacaoAutorizacao;
using FacturaTx.Domain.Entidades.Base;
using FacturaTx.Domain.Entidades.Facturacao;
using FacturaTx.Domain.Entidades.Financeiro;
using FacturaTx.Domain.Entidades.Localizacao;
using FacturaTx.Domain.Entidades.Stock;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Institucional
{
    public class Empresa : BaseEntity
    {
        public int IdInt { get; set; }
        public string LogotipoUrl { get; set; } = "~/images/no-image.jpg";
        public required string NIF { get; set; }
        public required string Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Telefone { get; set; }
        public string? TelefoneAlternativo { get; set; }
        public string? Email { get; set; }
        public string? Endereco { get; set; }
        public string? Website { get; set; }
        public string ProvinciaId { get; set; }

        public Provincia Provincia { get; set; }
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public List<Factura> Facturas { get; set; } = new List<Factura>();
        public List<Departamento> Departamentos { get; set; } = new List<Departamento>();
        public List<ConfiguracoesUsuario> ConfiguracoesUsuario { get; set; } = new List<ConfiguracoesUsuario>();
        public List<Fornecedor> Fornecedores { get; set; } = new List<Fornecedor>();
        public List<Artigo> Produtos { get; set; } = new List<Artigo>();
        public List<ContaBancaria> Contas { get; set; } = new List<ContaBancaria>();
        public List<CategoriaArtigo> CategoriaArtigos { get; set; } = new List<CategoriaArtigo>();

    }
}
