using ESCon_CrossCutting.BuildingBlocks.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCon_Domain.Entities
{
    public class Pedido : Entity
    {
        /*codigo: int
-data: Date
-listaCotacao: List*/
        public int Codigo { get; set; }
        public DateTime Date { get; set; }
        public List<Cotacao> Cotacaos { get; set; }
    }
}
