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
    class UsuarioDAO
    {
        // criar os metodos CRUD
        public UsuarioDTO selectUsuario(UsuarioDTO usuario)
        {
            SqlConnection conn = ConexaoSQL.getConexao();
            UsuarioDTO userDTO = new UsuarioDTO();
            try
            {
                String sqlSelect = @"SELECT NOMEUSUARIO, SENHAUSUARIO FROM USUARIO WHERE NOMEUSUARIO =@USERNAME AND
                                    SENHAUSUARIO = @PASSWORD";
                SqlCommand sqlCmd = new SqlCommand(sqlSelect, conn);
                //PAR NomeDoParametro e o valor
                sqlCmd.Parameters.AddWithValue("@USERNAME", usuario.NomeUsuario);
                sqlCmd.Parameters.AddWithValue("@PASSWORD", usuario.SenhaUsuario);
                sqlCmd.ExecuteNonQuery();
                SqlDataReader sqlLeitor = sqlCmd.ExecuteReader();
                if (sqlLeitor.Read())
                {
                    //0 e 1 são indices da numeração que foi passada no select
                    userDTO.NomeUsuario = sqlLeitor[0].ToString();
                    userDTO.SenhaUsuario = sqlLeitor[1].ToString();
                }
                else
                {
                    userDTO = null;
                }
            }
            catch (SqlException erroSQL)
            {
                MessageBox.Show("Erro no metodo Select Usuario:" + erroSQL.Message);
            }
            finally
            {
                conn.Close();
            }
            return userDTO;
        }
    }
}
