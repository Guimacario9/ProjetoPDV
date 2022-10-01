using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDV.Model.DTO
{
    class VendaDTO
    {
        public int CodVenda { get; set; }
        public DateTime DataVenda { get; set; }
        public int CodCliente { get; set; }
        public double PrecoTotal { get; set; }

    }
}
