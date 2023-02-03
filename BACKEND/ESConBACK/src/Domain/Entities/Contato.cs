using CrossCutting.BuildingBlocks.Entitys;

namespace Domain.Entities
{
    public class Contato : Entity
    { 
        public string Email { get; set; }
        public string Fone_Referencia { get; set; }
    }
}