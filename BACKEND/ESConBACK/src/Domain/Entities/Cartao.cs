using ESCon_CrossCutting.BuildingBlocks.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCon_Domain.Entities
{
    public class Cartao : Entity
    {
        public int Codigo { get; set; }
        public string Nome_Cartao { get; set; }
        public double Taxa_Cartao { get; set; }
        public Venda Venda { get; set; }
    }
}
