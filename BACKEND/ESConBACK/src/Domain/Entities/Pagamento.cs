using CrossCutting.BuildingBlocks.Entitys;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pagamento : Entity
    {
        public int Codigo_Pgmt { get; set; }
        public string Nome_Pgmt { get; set; }
        public int Codigo_Plano_Conta { get; set; }
        public int Codigo_Banco { get; set; }
        public int Codigo_Fornecedor { get; set; }
        public string Num_Doc_Pgto { get; set; }
        public double Vlr_Total_Pagmt { get; set; }
        public double Vlr_Juro_pgmt { get; set; }
        public double Vlr_Multa_Pgmt { get; set; }
        public double Vlr_Desconto_Pgmt { get; set; }
        public int Num_Cheque_Pgmt { get; set; }
        public string Nominal_Pgmt { get; set; }
        public DateTime Emissao_Pgmt { get; set; }
        public DateTime LancamentoPgmt { get; set; }
        public DateTime VencimentoPgmt { get; set; }
        public DateTime DataPgmt { get; set; }
        public DateTime Data_Cheque_Pgmt { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Tipo_Pgmt Tipo_Pgmt { get; set; }
        public PlanoDeConta PlanoDeConta { get; set; }
        public Banco Banco { get; set; }
        public StatusPagamento StatusPagamento{ get; set; }


        /*codigo: Integer
-codigo_plano_conta: Integer
-codigo_tipo_pgto: Integer
-codigo_banco: Integer
-codigo_fornecedor: Integer
-num_doc_pgto: varchar
-vlr_total_pgto: Double
-vlr_juro_pgto: Double
-vlr_multa_pgto: Double
-vlr_desconto_pgto: Double
-num_cheque_pgto: Integer
-nominal_pgto: varchar
-emissao_pgto: date
-lancamento_pgto: date
-vencimento_pgto: date
-data_pgto: date
-data_cheque_pgto: date
*/
    }
}
