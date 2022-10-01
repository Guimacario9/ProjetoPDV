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
    public partial class FormMenuStrip : Form
    {
        public FormMenuStrip()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente frmCliente = new FormCliente();
            frmCliente.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduto frmProduto = new FormProduto();
            frmProduto.ShowDialog();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVendaitem frmVendaitem = new FormVendaitem();
            frmVendaitem.ShowDialog();
        }
    }
}
