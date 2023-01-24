using CrossCurting.BuildingBlocks.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCon_Domain.Entities
{
    public class Fabricantes : Entity
    {
        public long Cod_Fab { get; set; }
        public string Nome_Fab { get; set; }
    }
}
