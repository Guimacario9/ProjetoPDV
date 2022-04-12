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
    class ClienteDAO
    {
        //método para inserir Cliente
        public void insertCliente(ClienteDTO cliDTO)
        {
            SqlConnection conn = ConexaoSQL.getConexao();
            try
            {
                String sqlInsert = @"INSERT INTO CLIENTE (codCliente, 
                             CPF, nomeCliente, email, renda,
                             fone, endereco, cidade, estado) 
                             VALUES (@codCliente, @CPF, @nomeCliente, 
                             @email, @renda, @fone, @endereco, 
                             @cidade, @estado) ";
                SqlCommand sqlCmd = new SqlCommand(sqlInsert, conn);
                sqlCmd.Parameters.AddWithValue("@codCliente", cliDTO.CodCliente);
                sqlCmd.Parameters.AddWithValue("@CPF", cliDTO.CPF);
                sqlCmd.Parameters.AddWithValue("@nomeCliente", cliDTO.NomeCliente);
                sqlCmd.Parameters.AddWithValue("@email", cliDTO.Email);
                sqlCmd.Parameters.AddWithValue("@renda", cliDTO.Renda);
                sqlCmd.Parameters.AddWithValue("@fone", cliDTO.Fone);
                sqlCmd.Parameters.AddWithValue("@endereco", cliDTO.Endereco);
                sqlCmd.Parameters.AddWithValue("@cidade", cliDTO.Cidade);
                sqlCmd.Parameters.AddWithValue("@estado", cliDTO.Estado);

                sqlCmd.ExecuteNonQuery();
            }
            catch (SqlException erroSql)
            {
                MessageBox.Show("Erro método INSERT: " + erroSql);
            }
        }

        //método selecionar Cliente
        public ClienteDTO selectCliente(ClienteDTO cliDTO)
        {
            SqlConnection conn = ConexaoSQL.getConexao();
            //objCliente isntanciado para retorno do metodo
            ClienteDTO cliente = new ClienteDTO();
            try
            {
                string sqlSelect = @"SELECT codCliente, CPF, nomeCliente, 
                                email, renda, fone, endereco, cidade, estado 
                                FROM CLIENTE
                                WHERE codCliente = @codCliente";
                SqlCommand sqlCmd = new SqlCommand(sqlSelect, conn);
                sqlCmd.Parameters.AddWithValue("@codCliente", cliDTO.CodCliente);
                sqlCmd.ExecuteNonQuery();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                if (sqlReader.Read())
                {
                    cliente.CodCliente = Int32.Parse(sqlReader[0].ToString());
                    cliente.CPF = sqlReader[1].ToString();
                    cliente.NomeCliente = sqlReader[2].ToString();
                    cliente.Email = sqlReader[3].ToString();
                    cliente.Renda = Convert.ToDouble(sqlReader[4].ToString());
                    cliente.Fone = sqlReader[5].ToString();
                    cliente.Endereco = sqlReader[6].ToString();
                    cliente.Cidade = sqlReader[7].ToString();
                    cliente.Estado = sqlReader[8].ToString();
                } else
                {
                    cliente = null;
                }

            }
            catch (SqlException erroSql)
            {
                MessageBox.Show("Erro método SELECT: " + erroSql);
            }

            return cliente;
        }

        //método selecionar Cliente
        public ClienteDTO selectClienteByCPF(ClienteDTO cliDTO)
        {
            SqlConnection conn = ConexaoSQL.getConexao();
            //objCliente isntanciado para retorno do metodo
            ClienteDTO cliente = new ClienteDTO();
            try
            {
                string sqlSelect = @"SELECT codCliente, CPF, nomeCliente, 
                                email, renda, fone, endereco, cidade, estado 
                                FROM CLIENTE
                                WHERE CPF = @CPF";
                SqlCommand sqlCmd = new SqlCommand(sqlSelect, conn);
                sqlCmd.Parameters.AddWithValue("@CPF", cliDTO.CPF);
                sqlCmd.ExecuteNonQuery();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                if (sqlReader.Read())
                {
                    cliente.CodCliente = Int32.Parse(sqlReader[0].ToString());
                    cliente.CPF = sqlReader[1].ToString();
                    cliente.NomeCliente = sqlReader[2].ToString();
                    cliente.Email = sqlReader[3].ToString();
                    cliente.Renda = Convert.ToDouble(sqlReader[4].ToString());
                    cliente.Fone = sqlReader[5].ToString();
                    cliente.Endereco = sqlReader[6].ToString();
                    cliente.Cidade = sqlReader[7].ToString();
                    cliente.Estado = sqlReader[8].ToString();
                }

            }
            catch (SqlException erroSql)
            {
                MessageBox.Show("Erro método SELECT: " + erroSql);
            }

            return cliente;
        }

        public List<ClienteDTO> selectAllCliente()
        {
            List<ClienteDTO> listaClienteDTO = new List<ClienteDTO>();
            SqlConnection conn = ConexaoSQL.getConexao();
            string sqlSelectAll = @"SELECT codCliente, CPF, nomeCliente,
                                email, renda, fone, endereco, 
                                cidade, estado 
                                FROM CLIENTE";
            SqlCommand sqlCmd = new SqlCommand(sqlSelectAll, conn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            while (sqlReader.Read())
            {
                ClienteDTO cliente = new ClienteDTO();
                cliente.CodCliente = Int32.Parse(sqlReader[0].ToString());
                cliente.CPF = sqlReader[1].ToString();
                cliente.NomeCliente = sqlReader[2].ToString();
                cliente.Email = sqlReader[3].ToString();
                cliente.Renda = Convert.ToDouble(sqlReader[4].ToString());
                cliente.Fone = sqlReader[5].ToString();
                cliente.Endereco = sqlReader[6].ToString();
                cliente.Cidade = sqlReader[7].ToString();
                cliente.Estado = sqlReader[8].ToString();
                //add o obj cliente na listaClienteDTO
                listaClienteDTO.Add(cliente);
            }

            return listaClienteDTO;
        }

        public void deleteCliente(ClienteDTO cliDTO)
        {
            SqlConnection conn = ConexaoSQL.getConexao();
            try
            {
                string sqlDelete = @"Delete from CLiente where
                            CodCLiente = @codCLiente";
                SqlCommand sqlCmd = new SqlCommand(sqlDelete, conn);
                sqlCmd.Parameters.AddWithValue("@codCliente", cliDTO.CodCliente);
                sqlCmd.ExecuteNonQuery();
            }
            catch (SqlException erroSql)
            {
                MessageBox.Show("Erro método DELETE: " + erroSql);
            }

        }

        public void updateCliente(ClienteDTO cliDTO)
        {
            SqlConnection conn = ConexaoSQL.getConexao();
            try
            {
                string sqlUpdate = @"UPDATE CLIENTE SET 
                                    CPF=@CPF, nomeCliente=@nomeCliente, 
                                    email=@email, renda=@renda, fone=@fone, 
                                    endereco=@endereco, cidade=@cidade, 
                                    estado=@estado
                                    WHERE codCliente=@codCliente ";
                SqlCommand sqlCmd = new SqlCommand(sqlUpdate, conn);
                sqlCmd.Parameters.AddWithValue("@codCliente", cliDTO.CodCliente);
                sqlCmd.Parameters.AddWithValue("@CPF", cliDTO.CPF);
                sqlCmd.Parameters.AddWithValue("@nomeCliente", cliDTO.NomeCliente);
                sqlCmd.Parameters.AddWithValue("@email", cliDTO.Email);
                sqlCmd.Parameters.AddWithValue("@renda", cliDTO.Renda);
                sqlCmd.Parameters.AddWithValue("@fone", cliDTO.Fone);
                sqlCmd.Parameters.AddWithValue("@endereco", cliDTO.Endereco);
                sqlCmd.Parameters.AddWithValue("@cidade", cliDTO.Cidade);
                sqlCmd.Parameters.AddWithValue("@estado", cliDTO.Estado);
                sqlCmd.ExecuteNonQuery();
            }
            catch (SqlException erroSql)
            {
                MessageBox.Show("Erro método UPDATE: " + erroSql);
            }
        }
    }


}
