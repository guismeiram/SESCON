using CrossCutting.BuildingBlocks.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Funcionario : Entity
    {
        public int Codigo { get; set; }
        public Guid Codigo_Departamento { get; set; }
        public string Nome { get; set; }
        public Login Login { get; set; }
        public Venda Venda { get; set; }

        /*codigo_departamento: Integer
-nome: varchar
-funcao: varchar
-login: varchar
-senha: varchar
-admissao: date
-acesso_total: char*/
    }
}
