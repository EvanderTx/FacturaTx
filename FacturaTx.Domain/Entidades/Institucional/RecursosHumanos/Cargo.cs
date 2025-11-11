using FacturaTx.Domain.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Institucional.RecursosHumanos
{
    public class Cargo : BaseEntity
    {
        public required string Nome { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public required string DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
        public List<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();

    }
}
