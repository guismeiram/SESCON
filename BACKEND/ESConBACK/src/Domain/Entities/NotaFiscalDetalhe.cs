using ESCon_CrossCutting.BuildingBlocks.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCon_Domain.Entities
{
    public class NotaFiscalDetalhe :Entity
    {
        public int CodigoProduto { get; set; }
        /*codigo_produto: varchar
-numero_nfe_cab: Integer
-qtde_nfe_det: Integer
-vlr_unit_nfe_det: Double
-vlr_total_nfe_det: Double*/
    }
}
