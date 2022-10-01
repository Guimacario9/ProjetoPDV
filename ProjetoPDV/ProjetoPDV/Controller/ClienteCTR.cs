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
        // metodo para inserir cliente
        public void insertCliente(int codCliente, string CPF, string nomeCliente,
            string email, double renda, string fone, string endereco, 
            string cidade, string estado)
        {
            // Instaciar um obj tipo ClienteDTO e passar os valores dos parametros a cada um dos atributos da classe ClienteDTO
           
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

            // Instanciar um obj do tipo ClienteDao e passar o obj ClienteDTO contendo os valores como parametros ao metodo InsertCliente() da classe ClienteDAO

            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.insertCliente(clienteDTO);
            MessageBox.Show("Cliente inserido com Sucesso!!!");

        }

        // metodo para selecionar cliente
        public ClienteDTO selectCliente(int codCliente)
        {
            //onj instanciado para receber valor do parametro
            ClienteDTO clienteDTO = new ClienteDTO();
            clienteDTO.CodCliente = codCliente;

            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDTO = clienteDAO.selectCliente(clienteDTO);
            if (clienteDTO.NomeCliente != null)
            {
                MessageBox.Show("Cliente Localizado:" + clienteDTO.NomeCliente);
            }else
            {
                MessageBox.Show("Cliente Não Existe:" + clienteDTO.CodCliente);
            }
            return clienteDTO;
        }

        // metodo para selecionar cliente por CPF
        public ClienteDTO selectClienteByCPF(string CPF)
        {
            //onj instanciado para receber valor do parametro
            ClienteDTO clienteDTO = new ClienteDTO();
            clienteDTO.CPF = CPF;

            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDTO = clienteDAO.selectClienteByCPF(clienteDTO);
            
            return clienteDTO;
        }

        // metodo para selecionar no grid
        public List<ClienteDTO> selectAllCliente()
        {
            List<ClienteDTO> listaClienteDTO = new List<ClienteDTO>();
            ClienteDAO clienteDAO = new ClienteDAO();
            listaClienteDTO = clienteDAO.selectAllCliente();
            return listaClienteDTO;
        }

        // metodo para deletar o cliente
        public void deleteCliente(int codCliente)
        {
            ClienteDTO clienteDTO = new ClienteDTO();
            clienteDTO.CodCliente = codCliente;
            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.deleteCliente(clienteDTO);
        }

        // metodo para atualizar cliente
        public void updateCliente(int codCliente, string CPF, string nomeCliente,
            string email, double renda, string fone, string endereco,
            string cidade, string estado)
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

        public bool validarCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }

}
