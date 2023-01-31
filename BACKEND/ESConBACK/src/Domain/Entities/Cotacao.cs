using ESCon_CrossCutting.BuildingBlocks.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCon_Domain.Entities
{
    public class Cotacao : Entity
    {
        public int Codigo { get; set; }
        public DateTime Date { get; set; }
        public List<Requisicao> Requisicaos { get; set; }
    }
}
