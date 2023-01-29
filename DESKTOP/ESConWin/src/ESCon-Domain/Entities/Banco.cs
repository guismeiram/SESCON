using ESCon_CrossCutting.BuildingBlocks.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCon_Domain.Entities
{
    public class Banco : Entity
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Agencia { get; set; }
        public int Conta_Banco { get; set; }
        public int Gerente_Banco { get; set; }
        public int Fone_Banco { get; set; }
        public Pagamento Pagamento { get; set; }
        public Recebimento Recebimento { get; set; }

    }
}
