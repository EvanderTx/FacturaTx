using FacturaTx.Domain.Entidades.Base;
using FacturaTx.Domain.Entidades.Institucional.RecursosHumanos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Institucional
{
    public class Departamento : BaseEntity
    {
        public required string Nome { get; set; }
        public required string Abreviatura { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public required string EmpresaId { get; set; }
        public string? DepartamentoPaiId { get; set; }
        public Empresa Empresa { get; set; }
        public Departamento DepartamentoPai { get; set; }
        public List<Departamento> SubDepartamentos { get; set; } = new List<Departamento>();
        public List<Cargo> Cargos { get; set; } = new List<Cargo>();

    }
}
