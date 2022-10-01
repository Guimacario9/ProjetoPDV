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
    class ProdutoCTR
    {
        public void insertProduto(int codProduto, string descricao, double valorUnitario,
            double estoqueMinimo, double quantidadeEstoque, string codBarra)
        {
            // Instaciar um obj tipo ClienteDTO e passar os valores dos parametros a cada um dos atributos da classe ClienteDTO

            ProdutoDTO produtoDTO = new ProdutoDTO();
            produtoDTO.CodProduto = codProduto;
            produtoDTO.Descricao = descricao;
            produtoDTO.ValorUnitario = valorUnitario;
            produtoDTO.EstoqueMinimo = estoqueMinimo;
            produtoDTO.QuantidadeEstoque = quantidadeEstoque;
            produtoDTO.CodBarra = codBarra;


            // Instanciar um obj do tipo ClienteDao e passar o obj ClienteDTO contendo os valores como parametros ao metodo InsertCliente() da classe ClienteDAO

            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoDAO.insertProduto(produtoDTO);
            MessageBox.Show("Produto inserido com Sucesso!!!");

        }

        public ProdutoDTO selectProduto(int codProduto)
        {
            //onj instanciado para receber valor do parametro
            ProdutoDTO produtoDTO = new ProdutoDTO();
            produtoDTO.CodProduto = codProduto;

            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoDTO = produtoDAO.selectProduto(produtoDTO);
            if (produtoDTO.Descricao != null)
            {
                MessageBox.Show("Produto Localizado:" + produtoDTO.Descricao);
            }
            else
            {
                MessageBox.Show("Produto Não Existe:" + produtoDTO.CodProduto);
            }
            return produtoDTO;
        }

        public List<ProdutoDTO> selectAllProduto()
        {
            List<ProdutoDTO> listaProdutoDTO = new List<ProdutoDTO>();
            ProdutoDAO produtoDAO = new ProdutoDAO();
            listaProdutoDTO = produtoDAO.selectAllProduto();
            return listaProdutoDTO;
        }

        public void deleteProduto(int codProduto)
        {
            ProdutoDTO produtoDTO = new ProdutoDTO();
            produtoDTO.CodProduto = codProduto;
            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoDAO.deleteProduto(produtoDTO);
        }

        public void updateProduto(int codProduto, string descricao, double valorUnitario,
           double estoqueMinimo, double quantidadeEstoque, string codBarra)
        {
            ProdutoDTO produtoDTO = new ProdutoDTO();
            produtoDTO.CodProduto = codProduto;
            produtoDTO.Descricao = descricao;
            produtoDTO.ValorUnitario = valorUnitario;
            produtoDTO.EstoqueMinimo = estoqueMinimo;
            produtoDTO.QuantidadeEstoque = quantidadeEstoque;
            produtoDTO.CodBarra = codBarra;


            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoDAO.updateProduto(produtoDTO);
        }

        public ProdutoDTO selectProdutoByCodBarra(string codBarra)
        {

            ProdutoDTO produtoDTO = new ProdutoDTO();

            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoDTO.CodBarra = codBarra;


            produtoDTO = produtoDAO.selectProdutoByCodBarra(codBarra);



            return produtoDTO;
        }






    }
}



