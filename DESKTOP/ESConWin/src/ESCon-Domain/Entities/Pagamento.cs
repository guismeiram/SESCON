using CrossCurting.BuildingBlocks.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCon_Domain.Entities
{
    public class Pagamento : Entity
    {
        public int Condigo_Pgmt { get; set; }

        public string Nome_Pgmt { get; set; }
    }
}
