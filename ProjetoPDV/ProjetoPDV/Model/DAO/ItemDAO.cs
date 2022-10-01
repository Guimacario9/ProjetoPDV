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
    class ItemDAO
    {
        

        //inserindo venda
        public void insertItem(ItemDTO itemDTO)
        {
            SqlConnection conn = ConexaoSQL.getConexao();
            try
            {
                string sqlInsert = @"INSERT INTO DETALHEVENDA (CODDETALHEVENDA, CODVENDA, CODPRODUTO, 
                                    QUANTIDADEVENDA, PRECODETALHE) 
                                    VALUES(@CODDETALHEVENDA, @CODVENDA, @CODPRODUTO, 
                                    @QUANTIDADEVENDA, @PRECODETALHE)";

                SqlCommand sqlCmd = new SqlCommand(sqlInsert, conn);
                sqlCmd.Parameters.AddWithValue("@CODDETALHEVENDA", itemDTO.CodDetalheVenda);
                sqlCmd.Parameters.AddWithValue("@CODVENDA", itemDTO.CodVenda);
                sqlCmd.Parameters.AddWithValue("@CODPRODUTO", itemDTO.CodProduto);
                sqlCmd.Parameters.AddWithValue("@QUANTIDADEVENDA", itemDTO.QuantidadeVenda);
                sqlCmd.Parameters.AddWithValue("@PRECODETALHE", itemDTO.PrecoDetalhe);

               
                sqlCmd.ExecuteNonQuery();

               
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao Inserir Item no método insertItem: " + ex);
            }
            
        }

        public int getMaxItem()
        {
            int maxItem = 0;
            SqlConnection conn = ConexaoSQL.getConexao();

            try
            {
                String sql = "SELECT MAX(codDetalheVenda) AS codDetalheVenda FROM DetalheVenda";
                SqlCommand sqlCmd = new SqlCommand(sql, conn);
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                if (sqlReader.Read())
                {
                    maxItem = Convert.ToInt32(sqlReader["codDetalheVenda"].ToString());
                }
               
                sqlReader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao Selecionar MAX item: " + ex);
            }
          
            return maxItem;
        }


        //deletando venda
        public void deleteVenda(ItemDTO itemDTO)
        {
            SqlConnection conn = ConexaoSQL.getConexao();
            try
            {
                string sqlDelete = @"DELETE FROM DETALHEVENDA
                                        WHERE CODDETALHEVENDA = @CODIGO";

                SqlCommand sqlCmd = new SqlCommand(sqlDelete, conn);
                sqlCmd.Parameters.AddWithValue("@CODIGO", itemDTO.CodDetalheVenda);
               
                sqlCmd.ExecuteNonQuery();

                
            
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao Excluir Item no método deleteItem: " + ex);
            }
            finally
            {
                conn.Close(); 
            }
        }


        //alterando venda
        public void updateItem(ItemDTO itemDTO)
        {
            SqlConnection conn = ConexaoSQL.getConexao();
            try
            {
                string sqlUpdate = @"UPDATE DETALHEVENDA SET QUANTIDADEVENDA = @QUANTIDADEVENDA,
                                PRECODETALHE = @PRECODETALHE
                                WHERE CODDETALHEVENDA = @CODDETALHEVENDA";

                SqlCommand sqlCmd = new SqlCommand(sqlUpdate, conn);

                sqlCmd.Parameters.AddWithValue("@CODETALHEVENDA", itemDTO.CodDetalheVenda);
                sqlCmd.Parameters.AddWithValue("@CODVENDA", itemDTO.CodVenda);
                sqlCmd.Parameters.AddWithValue("@CODPRODUTO", itemDTO.CodProduto);
                sqlCmd.Parameters.AddWithValue("@QUANTIDADEVENDA", itemDTO.QuantidadeVenda);
                sqlCmd.Parameters.AddWithValue("@PRECODETALHE", itemDTO.PrecoDetalhe);

               
                sqlCmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao Alterar Item no método updateItem: " + ex);
            }
            
        }
    }
 }

