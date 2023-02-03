using CrossCutting.BuildingBlocks.Entitys;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Login : Entity
    {
        public Funcao Funcao { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime Adminissao { get; set; }
        public AcessoTotal AcessoTotal { get; set; }
        public Funcionario Funcionario { get; set; }
        public StatusLogin StatusLogin { get; set; }

        /*-funcao: varchar
-login: varchar
-senha: varchar
-admissao: date
-acesso_total: char*/
    }
}
