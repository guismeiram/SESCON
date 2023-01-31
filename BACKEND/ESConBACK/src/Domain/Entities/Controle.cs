using ESCon_CrossCutting.BuildingBlocks.Entitys;
using ESCon_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ESCon_Domain.Entities
{
    public class Controle : Entity
    {

        public int Quantidade { get; set; }
        public Timer Data_Hora { get; set; }
        public Timer Hora_Parada { get; set; }
        public Timer Hora_Final { get; set; }
        public DateTime Data { get; set; }
        public Double Peso { get; set; }

        public StatusControle StatusControle { get; set; }
        public Produto Produtos { get; set; }
    }
}
