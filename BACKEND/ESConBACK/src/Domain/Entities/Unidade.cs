using CrossCutting.BuildingBlocks.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Unidade : Entity
    {
        /*codigo: Integer
-descricao_unidade: char*/
        public int Codigo { get; set; }
        public string Descricao_Unidade { get; set; }
        public Produto Produto { get; set; }
    }
}
