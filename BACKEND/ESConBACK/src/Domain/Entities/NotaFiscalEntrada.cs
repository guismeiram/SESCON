using CrossCutting.BuildingBlocks.Entitys;
using System;

namespace Domain.Entities
{
    public class NotaFiscalEntrada : Entity
    {
        /*emissao: date
-codigo_ fornecedor: INteger
-entrada: date
-total: Double
*/
        public DateTime Emissao { get; set; }
        public int Codigo_Fornecedor { get; set; }
        public DateTime Entrada { get; set; }
        public double Total { get; set; }

        public Produto Produto { get; set; }

    }
}