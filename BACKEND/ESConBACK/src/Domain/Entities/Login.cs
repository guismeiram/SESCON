using ESCon_CrossCutting.BuildingBlocks.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCon_Domain.Entities
{
    public class Login : Entity
    {
        public Funcao Funcao { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime Adminissao { get; set; }
        public AcessoTotal AcessoTotal { get; set; }
        public Funcionario Funcionario { get; set; }

        /*-funcao: varchar
-login: varchar
-senha: varchar
-admissao: date
-acesso_total: char*/
    }
}
