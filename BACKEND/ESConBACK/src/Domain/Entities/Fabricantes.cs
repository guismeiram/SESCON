using CrossCutting.BuildingBlocks.Entitys;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Fabricantes : Entity
    {
        public long Cod_Fab { get; set; }
        public string Nome_Fab { get; set; }

        public StatusFabricante StatusFabricante { get; set; }
    }
}
