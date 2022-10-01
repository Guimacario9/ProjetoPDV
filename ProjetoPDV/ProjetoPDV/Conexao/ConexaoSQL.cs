using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPDV.Conexao
{
    class ConexaoSQL
    {
        //string de conexao
        private static string connString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProjetoPDV";
        //atributo de conexao com BD SQLServer
        private static SqlConnection conn = null;
        
        //metodo que permite obter uma conexao com o BD
        public static SqlConnection getConexao()
        {
            //criar conexao 
            conn = new SqlConnection(connString);
            //a conexao foi estabelecida com sucesso??
            //try (trayf) + tab + tab
            try
            {
                //abrir a conexao com o BD
                conn.Open();
            }
            catch (SqlException sqlerro)
            {
                conn = null;
                MessageBox.Show("Erro de Conexao:  " + sqlerro.Message);
            }

            return conn;
            
        }
    }
}
