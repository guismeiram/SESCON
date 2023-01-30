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
        public int Condigo_Venda { get; set; }
        public decimal Valor_Total { get; set; }
        public DateTime Data_Venda { get; set; }

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
