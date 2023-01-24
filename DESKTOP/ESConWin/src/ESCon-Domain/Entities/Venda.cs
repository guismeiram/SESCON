using CrossCurting.BuildingBlocks.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCon_Domain.Entities
{
    public class Venda : Entity
    {
        public int Condigo_Venda { get; set; }
        public decimal Valor_Total { get; set; }
        public DateTime Data_Venda { get; set; }
        
    }
}
