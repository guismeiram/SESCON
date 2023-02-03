using CrossCutting.BuildingBlocks.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Recebimento : Entity
    {
        /*codigo: Integer
-codigo_banco: Integer
-codig_tipo_pgto: Integer
-codigo_cliente: Integer
-num_documento: varchar
-vlr_total_recebimento: Double
-vlr_juro_recebimento: Double
-vlr_multa_recebimento: Double
-vlr_desconto_recebimento: Double
-vlr_recebido: Double
-emissao_recebimento: date
-lancamento_recebimento: date
-vencimento_recebimento: date
-data_recebimento: date
*/
        public int Codigo { get; set; }
        public int Codigo_Banco { get; set; }
        public int Codig_Tipo_Pgmt { get; set; }
        public int Codigo_Cliente { get; set; }
        public string Num_Documento { get; set; }
        public double Vlr_Total_Recebimento { get; set; }
        public double Vlr_Juro_Recebimento { get; set; }
        public double Vlr_Multa_Recebimento { get; set; }
        public double Vlr_Recebido { get; set; }
        public DateTime Emissao_Recebimento { get; set; }
        public DateTime Lancamento_Recebimento { get; set; }
        public DateTime Vencimento_Recebimento { get; set; }
        public DateTime Data_Recebimento { get; set; }
        public Banco Banco { get; set; }
        public Tipo_Pgmt Tipo_Pgmt { get; set; }
        public Cliente Cliente { get; set; }
    }
}
