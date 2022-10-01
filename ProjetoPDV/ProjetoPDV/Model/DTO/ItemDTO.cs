using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDV.Model.DTO
{
    class ItemDTO
    {
        public int CodDetalheVenda { get; set; }
        public int CodVenda { get; set; }
        public int CodProduto { get; set; }
        public double QuantidadeVenda { get; set; }
        public double PrecoDetalhe { get; set; }   
    }
}
