using CrossCutting.BuildingBlocks.Entitys;
using ESCon_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Fornecedor : Entity
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Orgao_Rg { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }
        public NotaFiscalEntrada NotaFiscalEntrada { get; set; }

    }
}
