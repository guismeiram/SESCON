using CrossCutting.BuildingBlocks.Entitys;

namespace Domain.Entities
{
    public class Endereco : Entity
    {
        /*-endereco: varchar
-bairro: varchar
-cidade: varchar
-uf: char
-cep: varchar*/
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public Uf Uf { get; set; }
        public string Numero { get; set; }
        

    }
}