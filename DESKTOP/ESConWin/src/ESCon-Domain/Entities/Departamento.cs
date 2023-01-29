using ESCon_CrossCutting.BuildingBlocks.Entitys;
using ESCon_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCon_Domain.Entities
{
    public class Departamento : Entity
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public StatusDepartamento StatusDepartamento { get; set; }
        public Funcionario Funcionarios { get; set; }
    }
}
