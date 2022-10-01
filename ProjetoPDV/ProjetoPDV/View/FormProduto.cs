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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            ProdutoCTR produtoCTR = new ProdutoCTR();
            // passar todos os valores da caixa de texto
            produtoCTR.insertProduto(Convert.ToInt16(txtCodigo.Text), txtDescricao.Text,
                Convert.ToDouble(txtValor.Text), Convert.ToDouble(txtEstoque.Text),
                 Convert.ToDouble(txtQtdEstoque.Text), txtCodBarra.Text);
            this.btnSelecionar_Click(sender, e);

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            List<ProdutoDTO> listaProdutoDTO = new List<ProdutoDTO>();
            ProdutoCTR produtoCTR = new ProdutoCTR();
            listaProdutoDTO = produtoCTR.selectAllProduto();
            dgvProduto.DataSource = listaProdutoDTO;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ProdutoCTR produtoCTR = new ProdutoCTR();
            ProdutoDTO produtoDTO = new ProdutoDTO();
            //selecionar o produto
            produtoDTO = produtoCTR.selectProduto(Convert.ToInt16(txtCodigo.Text));
            if (produtoDTO != null)
            {
                txtCodigo.Text = produtoDTO.CodProduto.ToString();
                txtDescricao.Text = produtoDTO.Descricao;
                txtValor.Text = produtoDTO.ValorUnitario.ToString();
                txtEstoque.Text = produtoDTO.EstoqueMinimo.ToString();
                txtQtdEstoque.Text = produtoDTO.QuantidadeEstoque.ToString();
                txtCodBarra.Text = produtoDTO.CodBarra;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ProdutoCTR produtoCTR = new ProdutoCTR();
            produtoCTR.deleteProduto(Convert.ToInt16(txtCodigo.Text));
            this.btnSelecionar_Click(sender, e);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ProdutoCTR produtoCTR = new ProdutoCTR();
            produtoCTR.updateProduto(Convert.ToInt16(txtCodigo.Text), txtDescricao.Text,
                Convert.ToDouble(txtValor.Text), Convert.ToDouble(txtEstoque.Text),
                 Convert.ToDouble(txtQtdEstoque.Text), txtCodBarra.Text);
            this.btnSelecionar_Click(sender, e);
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
             txtCodigo.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "";
            txtEstoque.Text = "";
            txtQtdEstoque.Text = "";
            txtCodBarra.Text = "";
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            this.btnSelecionar_Click(sender, e);
        }

        private void dgvProduto_MouseClick(object sender, MouseEventArgs e)
        {
            //SelectModem - FullRowSelect
            if (dgvProduto.Rows.Count > 0)
            {
                txtCodigo.Text = dgvProduto.SelectedRows[0].Cells[0].Value.ToString();
                txtDescricao.Text = dgvProduto.SelectedRows[0].Cells[1].Value.ToString();
                txtValor.Text = dgvProduto.SelectedRows[0].Cells[2].Value.ToString();
                txtEstoque.Text = dgvProduto.SelectedRows[0].Cells[3].Value.ToString();
                txtQtdEstoque.Text = dgvProduto.SelectedRows[0].Cells[4].Value.ToString();
                txtCodBarra.Text = dgvProduto.SelectedRows[0].Cells[5].Value.ToString();

            }

            else
            {
                MessageBox.Show("Nenhuma Linha foi Selecionada no Grid!");
            }

        }
      }

        
}
