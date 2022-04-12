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
        //metodo INSERT
        public void insertVenda(VendaDTO vendaDTO)
        {
            SqlConnection conn = ConexaoSQL.getConexao();
            try
            {
                String sqlInsert = @"INSERT INTO Venda (codVenda, dataVenda, codCliente, precoTotal  ) 
                                VALUES (@codVenda, @dataVenda, @codCliente, @precoTotal  ) ";
                SqlCommand sqlCmd = new SqlCommand(sqlInsert, conn);
                sqlCmd.Parameters.AddWithValue("@codVenda", vendaDTO.CodVenda);
                sqlCmd.Parameters.AddWithValue("@dataVenda", vendaDTO.DataVenda);
                sqlCmd.Parameters.AddWithValue("@codCliente", vendaDTO.CodCliente);
                sqlCmd.Parameters.AddWithValue("@precoTotal", vendaDTO.PrecoTotal);
                sqlCmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao Inserir Venda: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //retornar o MAX de codvenda
        public int getMaxCodVenda()
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
                    maxVenda = Convert.ToInt16(sqlReader["codVenda"].ToString());
                }
                sqlReader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao Selecionar MAX Venda: " + ex);
            }
            return maxVenda;
        }
    }
}
