using ProjetoPDV.Controller;
using ProjetoPDV.Model.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPDV.View
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        // inserir cliente
        private void btnInserir_Click(object sender, EventArgs e)
        {
            // instanciar um obj da classe ClienteCTR 
            // chamar o metodo insertCliente

            ClienteCTR clienteCTR = new ClienteCTR();
            // passar todos os valores da caixa de texto
            clienteCTR.insertCliente(Convert.ToInt16(txtCodCliente.Text), txtCPF.Text, txtNome.Text, 
                txtEmail.Text, Convert.ToDouble(txtRenda.Text), txtFone.Text, 
                txtEndereco.Text, txtCidade.Text, txtEstado.Text);
            this.btnSelecionar_Click(sender, e);

        }

        // selecionar cliente
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            List<ClienteDTO> listaClienteDTO = new List<ClienteDTO>();
            ClienteCTR clienteCTR = new ClienteCTR();
            listaClienteDTO = clienteCTR.selectAllCliente();
            dataGridCliente.DataSource = listaClienteDTO;
        }

        // localizar cliente
        private void btnLocalizar_Click(object sender, EventArgs e)
        {

            ClienteCTR clienteCTR = new ClienteCTR();
            ClienteDTO clienteDTO = new ClienteDTO();
            //selecionar o cliente
            clienteDTO = clienteCTR.selectCliente(Convert.ToInt16(txtCodCliente.Text));
            if (clienteDTO != null)
            {
                txtCodCliente.Text = clienteDTO.CodCliente.ToString();
                txtNome.Text = clienteDTO.NomeCliente;
                txtEndereco.Text = clienteDTO.Endereco;
                txtCidade.Text = clienteDTO.Cidade;
                txtEstado.Text = clienteDTO.Estado;
                txtCPF.Text = clienteDTO.CPF;
                txtEmail.Text = clienteDTO.Email;
                txtFone.Text = clienteDTO.Fone;
                txtRenda.Text = clienteDTO.Renda.ToString();
            }
        }

        // limpar campos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodCliente.Text = "";
            txtNome.Text = "";
            txtCPF.Text = "";
            txtCidade.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtEstado.Text = "";
            txtFone.Text = "";
            txtRenda.Text = "";
        }

        // excluir cliente
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ClienteCTR clienteCTR = new ClienteCTR();
            clienteCTR.deleteCliente(Convert.ToInt16(txtCodCliente.Text));
            this.btnSelecionar_Click(sender, e);
        }

        // atualizar cliente
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ClienteCTR clienteCTR = new ClienteCTR();
            clienteCTR.updateCliente(Convert.ToInt16(txtCodCliente.Text), txtCPF.Text, txtNome.Text,
                txtEmail.Text, Convert.ToDouble(txtRenda.Text), txtFone.Text,
                txtEndereco.Text, txtCidade.Text, txtEstado.Text);
            this.btnSelecionar_Click(sender, e);
        }

        // atualizar campos automaticos
        private void dataGridCliente_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridCliente.Rows.Count > 0)
            {
                txtCodCliente.Text = dataGridCliente.SelectedRows[0].Cells[0].Value.ToString();
                txtCPF.Text = dataGridCliente.SelectedRows[0].Cells[1].Value.ToString();
                txtNome.Text = dataGridCliente.SelectedRows[0].Cells[2].Value.ToString();
                txtEmail.Text = dataGridCliente.SelectedRows[0].Cells[3].Value.ToString();
                txtRenda.Text = dataGridCliente.SelectedRows[0].Cells[4].Value.ToString();
                txtFone.Text = dataGridCliente.SelectedRows[0].Cells[5].Value.ToString();
                txtEndereco.Text = dataGridCliente.SelectedRows[0].Cells[6].Value.ToString();
                txtCidade.Text = dataGridCliente.SelectedRows[0].Cells[7].Value.ToString();
                txtEstado.Text = dataGridCliente.SelectedRows[0].Cells[8].Value.ToString();
            }else
            {
                MessageBox.Show("Nenhuma Linha foi Selecionada no Grid!");
            }
        }

        // preencher dados ao chamar form
        private void FormCliente_Load(object sender, EventArgs e)
        {
            this.btnSelecionar_Click(sender, e);
        }

    }
}
