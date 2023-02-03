using CrossCutting.BuildingBlocks.Entitys;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Departamento : Entity
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public StatusDepartamento StatusDepartamento { get; set; }
        public Funcionario Funcionarios { get; set; }
    }
}
