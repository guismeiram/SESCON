using ESCon_CrossCutting.BuildingBlocks.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCon_Domain.Entities
{
    public class PlanoDeConta : Entity
    {
        /*codigo: Integer
-descricao: varchar*/
        public int Codigo { get; set; }
        public string Descricao { get; set; }
    }
}
