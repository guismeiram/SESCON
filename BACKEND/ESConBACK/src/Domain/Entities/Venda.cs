using ESCon_CrossCutting.BuildingBlocks.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCon_Domain.Entities
{
    public class Venda : Entity
    {
        public int Codigo { get; set; }
        public int Codigo_Funcionario { get; set; }
        public int Codigo_Cartao { get; set; }
        public int Codigo_Tipo_Pgmt { get; set; }
        public int Codigo_Cfop { get; set; }
        public DateTime Date { get; set; }
        public Cliente Cliente { get; set; }
        public List<Produto> Produtos { get; set; }
        public List<BoletoBancario> BoletoBancarios { get; set; }
        public double Valor { get; set; }
        public double Desconto { get; set; }
        public DateTime Pri_Venc_Venda { get; set; }
        public double Total { get; set; }
        public int Num_Parcelas { get; set; }
        public double Vlr_Unit_Venda { get; set; }
        public int Quantidade { get; set; }
        /*codigo: int
-codigo_funcionario: Integer
-codigo_cartao: Integer
-codigo_tipo_pgto: void
-codigo_cfop: Integer
-data: Date
-vendedor: int
-cliente: Cliente
-listaProduto: List
-listaNF: List
-listaBoleto: List
-valor: Double
-desconto: Double
-pri_venc_venda: date
-total: Double
-num_parcelas: Integer
-vlr_unit_venda: Double
-quantidade: integer
*/

    }
}
