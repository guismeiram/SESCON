using CrossCutting.BuildingBlocks.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BoletoBancario : Entity
    {
        public int Codigo { get; set; }
        public DateTime Date { get; set; }
        public int NossoNumero { get; set; }
        public double Valor { get; set; }
        public Venda Venda { get; set; }
    }
}
