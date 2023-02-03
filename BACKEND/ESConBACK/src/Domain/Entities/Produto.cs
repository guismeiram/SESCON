using CrossCutting.BuildingBlocks.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Produto : Entity
    {
        /*codigo: int
-codigo_unidade: Integer
-codigo_fornecedor: Integer
-descricao: String
-nome: int
-valor_compra: Double
-valor_venda: Double
-estoque_produto: int
-critico_produto: int*/

        public int Codigo { get; set; }
        public Guid Codigo_Unidade { get; set; }
        public Guid Codigo_Fornecedor { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public double Valor_Compra { get; set; }
        public double Valor_Venda { get; set; }
        public int Estoque_Produto { get; set; }
        public int Critico_Produto { get; set; }
        public NotaFiscalDetalhe NotaFiscalDetalhe { get; set; }
        public Unidade Unidade { get; set; }
        public Requisicao Requisicao { get; set; }
        public Controle Controle { get; set; }
        public Venda Venda { get; set; }
        public Orcamento Orcamento { get; set; }

    }
}
