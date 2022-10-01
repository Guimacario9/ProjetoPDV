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
    class ItemCTR
    {
       

        public void insertItem(int codDetalheVenda, int codVenda, int codProduto,
                                double quantidadeVenda, double precoDetalhe)
        {
            ItemDTO itemDTO = new ItemDTO();

            itemDTO.CodDetalheVenda = codDetalheVenda;
            itemDTO.CodVenda = codVenda;
            itemDTO.CodProduto = codProduto;
            itemDTO.QuantidadeVenda = quantidadeVenda;
            itemDTO.PrecoDetalhe = precoDetalhe;

            
                ItemDAO itemDAO = new ItemDAO();
                itemDAO.insertItem(itemDTO);
                
        }


        public void deleteItem(int codDetalheVenda)
        {
            ItemDTO itemDTO = new ItemDTO();
            itemDTO.CodDetalheVenda = codDetalheVenda;

            try
            {
                ItemDAO itemDAO = new ItemDAO();
                itemDAO.deleteVenda(itemDTO);
                MessageBox.Show("Item Excluído com Sucesso: " + itemDTO.CodDetalheVenda);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro deleteItemCTR");
            }
        }


        public void updateItem(int codDetalheVenda, int codVenda, int codProduto,
                                double quantidadeVenda, double precoDetalhe)
        {
            ItemDTO itemDTO = new ItemDTO();

            itemDTO.CodDetalheVenda = codDetalheVenda;
            itemDTO.CodVenda = codVenda;
            itemDTO.CodProduto = codProduto;
            itemDTO.QuantidadeVenda = quantidadeVenda;
            itemDTO.PrecoDetalhe = precoDetalhe;

            try
            {
                ItemDAO itemDAO = new ItemDAO();
                itemDAO.updateItem(itemDTO);
                MessageBox.Show("Item Alterado com Sucesso: " + itemDTO.CodDetalheVenda);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro updateItemCTR");
            }
        }

        public int getMaxItem()
        {
            int maxItem = 0;

            ItemDAO itemDAO = new ItemDAO();
            maxItem = itemDAO.getMaxItem();
            return maxItem;
        }
    }
    }

