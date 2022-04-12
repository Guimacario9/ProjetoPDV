using ProjetoPDV.Model.DAO;
using ProjetoPDV.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPDV.Controller
{
    class VendaCTR
    {
        //metodo INSERT VENDA
        public void insertVenda(int codVenda, DateTime dataVenda, int codCliente, double precoTotal)
        {
            VendaDTO vendaDTO = new VendaDTO();
            vendaDTO.CodVenda = codVenda;
            vendaDTO.DataVenda = dataVenda;
            vendaDTO.CodCliente = codCliente;
            vendaDTO.PrecoTotal = precoTotal;

            VendaDAO vendaDAO = new VendaDAO();
            vendaDAO.insertVenda(vendaDTO);
        }

        //metodo getMAXCodVenda
        public int getMaxVenda()
        {
            int maxVenda = 0;
            VendaDAO vendaDAO = new VendaDAO();
            maxVenda = vendaDAO.getMaxCodVenda();
            return maxVenda;
        }
    }
}
