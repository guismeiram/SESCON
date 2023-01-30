using ESCon_CrossCutting.BuildingBlocks.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCon_Domain.Entities
{
    public class Requisicao : Entity
    {
        /*codigo: Integer
-codigo_funcionario: Integer
-data: Date
-solicitante: Integer
-listaProdutos: List
-vlr_unit: Double
-vlr_total: Double
-quantidade: Integer
*/
        public int Codigo { get; set; }
        public int Condigo_Funcionario { get; set; }
        public DateTime Date { get; set; }
        public int Solicitacao { get; set; }
        public List<Produto> Produtos { get; set; }
        public double Vlr_Unit { get; set; }
        public double Vlr_Total { get; set; }
        public int Quantidade { get; set; }
        public Cotacao Cotacao { get; set; }
    }
}
