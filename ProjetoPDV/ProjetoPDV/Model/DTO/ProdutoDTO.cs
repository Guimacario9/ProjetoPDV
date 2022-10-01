using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDV.Model.DTO
{
    class ProdutoDTO
    {
        public int CodProduto { get; set; }
        public string Descricao { get; set; }
        public double ValorUnitario { get; set; }
        public double EstoqueMinimo { get; set; }
        public double QuantidadeEstoque { get; set; }
        public string CodBarra { get; set; }
    }
}
