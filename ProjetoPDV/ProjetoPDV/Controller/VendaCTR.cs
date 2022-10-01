using ProjetoPDV.Model.DAO;
using ProjetoPDV.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPDV.Controller
{
    class VendaCTR
    {
        public void insertVenda(int codVenda, DateTime dataVenda, int codCliente,
                                double precoTotal)
        {
            VendaDTO vendaDTO = new VendaDTO();

            vendaDTO.CodVenda = codVenda;
            vendaDTO.DataVenda = dataVenda;
            vendaDTO.CodCliente = codCliente;
            vendaDTO.PrecoTotal = precoTotal;
            
            VendaDAO vendaDAO = new VendaDAO();
            vendaDAO.insertVenda(vendaDTO);
               
        }

        public int getMaxVenda()
        {
            int maxVenda = 0;
            VendaDAO vendaDAO = new VendaDAO();
            
            maxVenda = vendaDAO.getMaxVenda();
            
            return maxVenda;
        }

        public void updateVenda(int codVenda, DateTime dataVenda, int codCliente,
                                double precoTotal)
        {
            VendaDTO vendaDTO = new VendaDTO();
            vendaDTO.CodVenda = codVenda;
            vendaDTO.DataVenda = dataVenda;
            vendaDTO.CodCliente = codCliente;
            vendaDTO.PrecoTotal = precoTotal;

            try
            {
                VendaDAO vendaDAO = new VendaDAO();
                vendaDAO.updateVenda(vendaDTO);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Erro updateVendaCTR");
            }
        }

        public void deleteVenda(int codVenda)
        {
            VendaDTO vendaDTO = new VendaDTO();
            vendaDTO.CodVenda = codVenda;

            try
            {
                VendaDAO vendaDAO = new VendaDAO();
                vendaDAO.deleteVenda(vendaDTO);
                MessageBox.Show("Venda Excluída com Sucesso: " + vendaDTO.CodVenda);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro deleteVendaCTR");
            }
        }
    }
}
