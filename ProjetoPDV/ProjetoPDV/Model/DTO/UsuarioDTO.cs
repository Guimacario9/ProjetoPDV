using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDV.Model.DTO
{
    class UsuarioDTO
    {
        //property - propriedades
        //prop + tab + tab
        public int CodUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string MD5Senha { get; set; }
    }
}
