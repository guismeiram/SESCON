using CrossCutting.BuildingBlocks.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PlanoDeConta : Entity
    {
        /*codigo: Integer
-descricao: varchar*/
        public int Codigo { get; set; }
        public string Descricao { get; set; }
    }
}
