using System;
using System.Collections.Generic;
using System.Text;

namespace FacturaTx.Domain.Entidades.Base
{
    public class BaseEntity
    {

        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
        public string ModificadoPor { get; set; } = "Sistema";
        public bool Activo { get; set; } = true;
        public int Ordem { get; set; }
    }
}
