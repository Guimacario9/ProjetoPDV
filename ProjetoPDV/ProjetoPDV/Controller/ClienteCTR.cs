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
    class ClienteCTR
    {
        //método para inserir Cliente
        public void insertCliente(int codCliente, string CPF, 
                     string nomeCliente, string email, double renda,
                     string fone, string endereco, string cidade, 
                     string estado)
        {
            //Instanciar um objeto do tipo ClienteDTO e passar os valores
            //dos parametros a cada um dos atributos da Classe ClienteDTO
            ClienteDTO clienteDTO = new ClienteDTO();
            clienteDTO.CodCliente = codCliente;
            clienteDTO.CPF = CPF;
            clienteDTO.NomeCliente = nomeCliente;
            clienteDTO.Email = email;
            clienteDTO.Renda = renda;
            clienteDTO.Fone = fone;
            clienteDTO.Endereco = endereco;
            clienteDTO.Cidade = cidade;
            clienteDTO.Estado = estado;

            //Instanciar um objeto do tipo ClienteDAO e passar o 
            //objeto clienteDTO contendo os valores como parametro
            //ao metodo insertCliente() da classe ClienteDAO
            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.insertCliente(clienteDTO);
            MessageBox.Show("Cliente Inserido com Sucesso!!!");

        }

        public ClienteDTO selectCliente(int codCliente)
        {
            //obj instanciado para receber valor do parametro
            ClienteDTO clienteDTO = new ClienteDTO();
            clienteDTO.CodCliente = codCliente;

            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDTO = clienteDAO.selectCliente(clienteDTO);
            if (clienteDTO.NomeCliente != null)
            {
                MessageBox.Show("Cliente Localizado: "+ clienteDTO.NomeCliente);
            }
            else
            {
                MessageBox.Show("Cliente Não Existe: " + clienteDTO.CodCliente);
            }

            return clienteDTO;
                
        }

        public ClienteDTO selectClienteByCPF(String CPF)
        {
            //obj instanciado para receber valor do parametro
            ClienteDTO clienteDTO = new ClienteDTO();
            clienteDTO.CPF = CPF;

            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDTO = clienteDAO.selectClienteByCPF(clienteDTO);

            return clienteDTO;

        }

        public List<ClienteDTO> selectAllCliente()
        {
            List<ClienteDTO> listaClienteDTO = new List<ClienteDTO>();
            ClienteDAO clienteDAO = new ClienteDAO();
            listaClienteDTO = clienteDAO.selectAllCliente();
            return listaClienteDTO;
        }

        public void deleteCliente(int codCliente)
        {
            ClienteDTO clienteDTO = new ClienteDTO();
            clienteDTO.CodCliente = codCliente;
            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.deleteCliente(clienteDTO);
        }

        public void updateCliente(int codCliente, string CPF,
                     string nomeCliente, string email, double renda,
                     string fone, string endereco, string cidade,
                     string estado)
        {
            ClienteDTO clienteDTO = new ClienteDTO();
            clienteDTO.CodCliente = codCliente;
            clienteDTO.CPF = CPF;
            clienteDTO.NomeCliente = nomeCliente;
            clienteDTO.Email = email;
            clienteDTO.Renda = renda;
            clienteDTO.Fone = fone;
            clienteDTO.Endereco = endereco;
            clienteDTO.Cidade = cidade;
            clienteDTO.Estado = estado;

            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.updateCliente(clienteDTO);

        }
    }
}
