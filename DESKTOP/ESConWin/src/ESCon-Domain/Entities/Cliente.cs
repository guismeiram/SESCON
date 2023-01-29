using ESCon_CrossCutting.BuildingBlocks.Entitys;
using ESCon_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCon_Domain.Entities
{
    public class Cliente : Entity
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Orgao_Rg { get; set; }
        public DateTime Dt_Nascimento { get; set; }
        public string Nascimento { get; set; }
        public string NomeEmpresa { get; set; }
        public string Fone { get; set; }
        public string Renda { get; set; }
        public TipoUser TipoUsers { get; set; }
        public string Cnpj { get; set; }
        public string Referencia { get; set; }
        public string Email { get; set; }
        public string Fone_Referencia { get; set; }
        public Recebimento Recebimentos {get;set;}
        public Cartao Cartao { get; set; }
        public Venda Venda { get; set; }
    }
}
