using ProjetoPDV.Conexao;
using ProjetoPDV.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPDV.Model.DAO
{
    class ProdutoDAO
    {
        public void insertProduto(ProdutoDTO prodDTO) 
    {
            SqlConnection conn = ConexaoSQL.getConexao();
            try
            {
                String sqlInsert = @"INSERT INTO PRODUTO (codProduto, descricao, valorUnitario, estoqueMinimo, 
                                    quantidadeEstoque, codBarra) 
                                   VALUES (@codProduto, @descricao, @valorUnitario, @estoqueMinimo,
                                    @quantidadeEstoque, @codBarra)";

                SqlCommand sqlCmd = new SqlCommand(sqlInsert, conn);
                sqlCmd.Parameters.AddWithValue("@codProduto", prodDTO.CodProduto);
                sqlCmd.Parameters.AddWithValue("@descricao", prodDTO.Descricao);
                sqlCmd.Parameters.AddWithValue("@valorUnitario", prodDTO.ValorUnitario);
                sqlCmd.Parameters.AddWithValue("@estoqueMinimo", prodDTO.EstoqueMinimo);
                sqlCmd.Parameters.AddWithValue("@quantidadeEstoque", prodDTO.QuantidadeEstoque);
                sqlCmd.Parameters.AddWithValue("@codBarra", prodDTO.CodBarra);
             
                sqlCmd.ExecuteNonQuery();
            }
            catch (SqlException erroSql)
            {
                MessageBox.Show("Erro método INSERT:" + erroSql);
            }
        }


        public ProdutoDTO selectProduto(ProdutoDTO prodDTO)
       
    {
            SqlConnection conn = ConexaoSQL.getConexao();
            // objCliente instaciado para retorno do metodo 
            ProdutoDTO produto = new ProdutoDTO();

            try
            {
                string sqlSelect = @"SELECT codProduto, descricao, valorUnitario, estoqueMinimo, 
                                        quantidadeEstoque, codBarra
                                        FROM PRODUTO 
                                        WHERE codProduto = @codProduto";

                SqlCommand sqlCmd = new SqlCommand(sqlSelect, conn);
                sqlCmd.Parameters.AddWithValue("@codProduto", prodDTO.CodProduto);
                sqlCmd.ExecuteNonQuery();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
               
                if (sqlReader.Read())
                {
                    produto.CodProduto = Int32.Parse(sqlReader[0].ToString());
                    produto.Descricao = sqlReader[1].ToString();
                    produto.ValorUnitario = Convert.ToDouble(sqlReader[2].ToString());;
                    produto.EstoqueMinimo = Convert.ToDouble(sqlReader[3].ToString());
                    produto.QuantidadeEstoque = Convert.ToDouble(sqlReader[4].ToString());
                    produto.CodBarra = sqlReader[5].ToString();
                    
                }
                
                else 
                {
                    produto = null;
                }
            }
            catch (SqlException erroSql)
            {
                MessageBox.Show("Erro método SELECT:" + erroSql);
            }
            return produto;
        }

        public List<ProdutoDTO> selectAllProduto()
        {
            List<ProdutoDTO> listaProdutoDTO = new List<ProdutoDTO>();
            SqlConnection conn = ConexaoSQL.getConexao();
            string sqlSelectAll = @"SELECT codProduto, descricao, valorUnitario, estoqueMinimo, 
                                        quantidadeEstoque, codBarra
                                        FROM PRODUTO ";

            SqlCommand sqlCmd = new SqlCommand(sqlSelectAll, conn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            while(sqlReader.Read())
            {
                ProdutoDTO produto = new ProdutoDTO();
                produto.CodProduto = Int32.Parse(sqlReader[0].ToString());
                produto.Descricao = sqlReader[1].ToString();
                produto.ValorUnitario = Convert.ToDouble(sqlReader[2].ToString());;
                produto.EstoqueMinimo = Convert.ToDouble(sqlReader[3].ToString());
                produto.QuantidadeEstoque = Convert.ToDouble(sqlReader[4].ToString());
                produto.CodBarra = sqlReader[5].ToString();
                // add o obj cliente na listaClienteDTO
                listaProdutoDTO.Add(produto);
            }

            return listaProdutoDTO;
        }

        public void deleteProduto(ProdutoDTO prodDTO)
        {
            SqlConnection conn = ConexaoSQL.getConexao();
            try
            {
                string sqlDelete = @"Delete from Produto WHERE CodProduto = @codProduto";
                SqlCommand sqlCmd = new SqlCommand(sqlDelete, conn);
                sqlCmd.Parameters.AddWithValue("@codProduto", prodDTO.CodProduto);
                sqlCmd.ExecuteNonQuery();
            }
            catch (SqlException erroSql)
            {
                MessageBox.Show("Erro método DELETE:" + erroSql);
            }
        }

        public void updateProduto(ProdutoDTO prodDTO)
        {
            SqlConnection conn = ConexaoSQL.getConexao();
            try
            {
                string sqlUpdate = @"UPDATE Produto SET
                                    descricao = @descricao, valorUnitario = @valorUnitario, estoqueMinimo = @estoqueMinimo,
                                    quantidadeEstoque = @quantidadeEstoque, codBarra = @codBarra
                                    WHERE codProduto = @codProduto";
               
                SqlCommand sqlCmd = new SqlCommand(sqlUpdate, conn);
                sqlCmd.Parameters.AddWithValue("@codProduto", prodDTO.CodProduto);
                sqlCmd.Parameters.AddWithValue("@descricao", prodDTO.Descricao);
                sqlCmd.Parameters.AddWithValue("@valorUnitario", prodDTO.ValorUnitario);
                sqlCmd.Parameters.AddWithValue("@estoqueMinimo", prodDTO.EstoqueMinimo);
                sqlCmd.Parameters.AddWithValue("@quantidadeEstoque", prodDTO.QuantidadeEstoque);
                sqlCmd.Parameters.AddWithValue("@codBarra", prodDTO.CodBarra);

                sqlCmd.ExecuteNonQuery();
            }
            catch (SqlException erroSql)
            {
                MessageBox.Show("Erro método UPDATE:" + erroSql);
            }
        }

        //seleciona produto pelo codigo de barras
        public ProdutoDTO selectProdutoByCodBarra(string codBarra)
        {

            {
                
                SqlConnection conn = ConexaoSQL.getConexao();
                ProdutoDTO produto = new ProdutoDTO();

                try
                {
                    string sqlCodBarra = @"SELECT CODPRODUTO, DESCRICAO, VALORUNITARIO, ESTOQUEMINIMO,
                                     QUANTIDADEESTOQUE, CODBARRA
                                     FROM PRODUTO
                                     WHERE CODBARRA = @CODBARRA";

                    
                    SqlCommand sqlCmd = new SqlCommand(sqlCodBarra, conn);
                    sqlCmd.Parameters.AddWithValue("@CODBARRA", codBarra);
                    sqlCmd.ExecuteNonQuery();
                    
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                    
                    if (sqlReader.Read())
                    {
                        
                        produto.CodProduto = Convert.ToInt16(sqlReader[0].ToString());
                        produto.Descricao = sqlReader[1].ToString();
                        produto.ValorUnitario = Convert.ToDouble(sqlReader[2].ToString());
                        produto.EstoqueMinimo = Convert.ToDouble(sqlReader[3].ToString());
                        produto.QuantidadeEstoque = Convert.ToDouble(sqlReader[4].ToString());
                        produto.CodBarra = sqlReader[5].ToString();
                    }
                    else
                    {
                        produto = null;
                        MessageBox.Show("Produto NÃO cadastrado no Sistema!");
                    }
                    sqlReader.Close();

                }
                catch (SqlException ex)
                {
                    
                    MessageBox.Show("Erro ao Selecionar Produto no método selectProdutoByCodBarra: " + ex);
                }
               

                return produto;
            }

        }

    }
}
