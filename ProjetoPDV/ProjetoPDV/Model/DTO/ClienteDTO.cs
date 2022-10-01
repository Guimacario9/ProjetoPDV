using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDV.Model.DTO
{
    class ClienteDTO
    {
        public int CodCliente { get; set; }
        public String CPF { get; set; }
        public String NomeCliente { get; set; }
        public String Email { get; set; }
        public double Renda { get; set; }
        public String Fone { get; set; }
        public String Endereco { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
    }
}
