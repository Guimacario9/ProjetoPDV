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
    class VendaDAO
    {
        public void insertVenda(VendaDTO vendaDTO)
        {
            SqlConnection conn = ConexaoSQL.getConexao();
            try
            {
                string sqlInsert = @"INSERT INTO VENDA (CODVENDA, DATAVENDA, CODCLIENTE, PRECOTOTAL) 
                                    VALUES(@CODVENDA, @DATAVENDA, @CODCLIENTE, @PRECOTOTAL)";

                SqlCommand sqlCmd = new SqlCommand(sqlInsert, conn);
                sqlCmd.Parameters.AddWithValue("@CODVENDA", vendaDTO.CodVenda);
                sqlCmd.Parameters.AddWithValue("@DATAVENDA", vendaDTO.DataVenda);
                sqlCmd.Parameters.AddWithValue("@CODCLIENTE", vendaDTO.CodCliente);
                sqlCmd.Parameters.AddWithValue("@PRECOTOTAL", vendaDTO.PrecoTotal);

                sqlCmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao Inserir Venda no método insertVenda: " + ex);
            }

            finally
            {
                conn.Close();
            }
        }

        //retornar o MAX de codVenda
        public int getMaxVenda()
        {
            int maxVenda = 0;
            SqlConnection conn = ConexaoSQL.getConexao();

            try
            {
                String sql = "SELECT MAX(codVenda) AS codVenda FROM Venda";
                SqlCommand sqlCmd = new SqlCommand(sql, conn);
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                if (sqlReader.Read())
                {
                    maxVenda = Convert.ToInt32(sqlReader["codVenda"].ToString());
                }
                

                sqlReader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao Selecionar MAX venda: " + ex);
            }
            return maxVenda;
        }

        public void updateVenda(VendaDTO vendaDTO)
        {
            SqlConnection conn = ConexaoSQL.getConexao();
            try
            {
                string sqlUpdate = @"UPDATE VENDA SET DATAVENDA = @DATAVENDA,
                                PRECOTOTAL = @PRECOTOTAL
                                WHERE CODVENDA = @CODVENDA";

                SqlCommand sqlCmd = new SqlCommand(sqlUpdate, conn);

                sqlCmd.Parameters.AddWithValue("@CODVENDA", vendaDTO.CodVenda);
                sqlCmd.Parameters.AddWithValue("@DATAVENDA", vendaDTO.DataVenda);
                sqlCmd.Parameters.AddWithValue("@CODCLIENTE", vendaDTO.CodCliente);
                sqlCmd.Parameters.AddWithValue("@PRECOTOTAL", vendaDTO.PrecoTotal);

                
                sqlCmd.ExecuteNonQuery();

                
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao Alterar Venda no método updateVenda: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public void deleteVenda(VendaDTO vendaDTO)
        {
            SqlConnection conn = ConexaoSQL.getConexao();
            try
            {
                string sqlDelete = @"DELETE FROM VENDA
                                        WHERE CODVENDA = @CODIGO";

                SqlCommand sqlCmd = new SqlCommand(sqlDelete, conn);
                sqlCmd.Parameters.AddWithValue("@CODIGO", vendaDTO.CodVenda);
                
                sqlCmd.ExecuteNonQuery();

                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao Excluir Venda no método deleteVenda: " + ex);
            }
            finally
            {
                conn.Close(); 
            }
        }
    }
}
        