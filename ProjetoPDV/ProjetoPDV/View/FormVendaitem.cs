using ProjetoPDV.Controller;
using ProjetoPDV.Model.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPDV.View
{
    public partial class FormVendaitem : Form
    {
        StreamWriter arquivoEscritor;
        int sequencia = 0;
        ItemDTO objItemDTO = new ItemDTO();
        public FormVendaitem()
        {
            InitializeComponent();
            //atualizar o pickerdataVenda com a data e sem a hora
            pickerDataVenda.Text = DateTime.Now.ToShortDateString();
        }
        public void gerarReciboArquivoTxt()
        {
            String CaminhoNome = @"C:\Users\Alunos\Desktop\ProjetoPDV\Recibo\" + txtCodVenda.Text + ".txt";
            arquivoEscritor = new StreamWriter(CaminhoNome, true);
            arquivoEscritor.WriteLine("CUPOM FISCAL - SYSPDV");
            arquivoEscritor.WriteLine("RAZÃO SOCIAL: SUPERMECADO VILA NOVA");
            arquivoEscritor.WriteLine("CNPJ: 11.111.111/0002-11");
            arquivoEscritor.WriteLine("VENDA: " + txtCodVenda + " - DATA:" + pickerDataVenda.Value.ToShortDateString());
            arquivoEscritor.WriteLine("CLIENTE" + txtCPF + " - " + txtNomeCliente.Text );

            string header = String.Format("{0,-12}{1,8}{2,12}{3,8}{4,12}{5,14}\n", "Item", "Codigo", "Descricao", "Qtade", "VlrUnit", "VlrParcial");

            arquivoEscritor.WriteLine(header);

            
        }
        public void gerarReciboRichTextProduto()
        {
            const string branco = "\n";
            //Limpando o RichText
            richTextProduto.AppendText("CUPOM FISCAL - SYSPDV" + branco + branco + branco);
            richTextProduto.AppendText("RAZÃO SOCIAL: SUPERMECADO VILA NOVA" + branco);
            richTextProduto.AppendText("CNPJ: 11.111.111/0002-11" + branco + branco);
            richTextProduto.AppendText("VENDA: " + txtCodVenda + " - DATA:" + pickerDataVenda.Value.ToShortDateString() + branco);
            richTextProduto.AppendText("CLIENTE" + txtCPF + " - " + txtNomeCliente.Text + branco + branco);

            string header = String.Format("{0,-12}{1,8}{2,12}{3,8}{4,12}{5,14}\n", "Item", "Codigo", "Descricao", "Qtade", "VlrUnit", "VlrParcial");

            richTextProduto.AppendText(header);

            richTextProduto.Focus();

        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //CPF do CLiente
                ClienteCTR clienteCTR = new ClienteCTR();

                if (clienteCTR.validarCpf(txtCPF.Text))
                {
                    ClienteDTO clienteDTO = new ClienteDTO();
                    clienteDTO = clienteCTR.selectClienteByCPF((txtCPF.Text));
                    //condição
                    if (clienteDTO.NomeCliente != null)
                    {
                        txtNomeCliente.Text = clienteDTO.NomeCliente; ;
                        txtCodCliente.Text = Convert.ToString(clienteDTO.CodCliente);

                        //inserir nova Venda
                        VendaCTR vendaCTR = new VendaCTR();

                        //como auto incrementar
                        txtCodVenda.Text = Convert.ToString(vendaCTR.getMaxVenda() + 1);
                        vendaCTR.insertVenda(Convert.ToInt16(txtCodVenda.Text), Convert.ToDateTime(pickerDataVenda.Value.ToShortDateString()), clienteDTO.CodCliente, Convert.ToDouble(txtPrecoTotal.Text));

                        //colocar o foco no campo txtCodBarras
                        txtCodigoBarras.Focus();


                        // gerar cabecalho para o richText
                        gerarReciboRichTextProduto();


                        //  atualizardataGrid();

                    }

                    else
                    {
                        MessageBox.Show("Cliente Não Existe:" + txtCPF.Text);
                    }

                }
            }
        }


        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // retornar o valor do campo CodBarra lido
                string codigoBarras = txtCodigoBarras.Text;
                //verificar se o codigo lido possui um Digito
                //Verificador que seja valido
                EAN13CTR eanCodBarras = new EAN13CTR();
                bool digitoValido = eanCodBarras.validarDigitoCodigoBarras(codigoBarras);

                if (digitoValido)
                {
                    ProdutoCTR produtoCTR = new ProdutoCTR();

                    ProdutoDTO produtoDTO = new ProdutoDTO();


                    produtoDTO = produtoCTR.selectProdutoByCodBarra(codigoBarras);
                    txtVlrUnitario.Text = produtoDTO.ValorUnitario.ToString();
                    txtProduto.Text = produtoDTO.Descricao;
                    txtCodProduto.Text = produtoDTO.CodProduto.ToString();

                    string barcode = txtCodigoBarras.Text;
                    Bitmap bitMap = new Bitmap(barcode.Length * 25, 100);
                    using (Graphics graphcs = Graphics.FromImage(bitMap))
                    {
                        System.Drawing.Font oFont = new System.Drawing.Font("IDAHC39M Code 39 Barcode", 16);
                        PointF point = new PointF(2f, 2f);
                        SolidBrush black = new SolidBrush(Color.Black);
                        SolidBrush white = new SolidBrush(Color.White);
                        graphcs.FillRectangle(white, 0, 0, bitMap.Width, bitMap.Height);
                        graphcs.DrawString(barcode, oFont, black, point);
                    }

                    using (MemoryStream ms = new MemoryStream())
                    {
                        bitMap.Save(ms, ImageFormat.Png);
                        pictureCodBarra.Image = bitMap;
                        pictureCodBarra.Height = bitMap.Height;
                        pictureCodBarra.Width = bitMap.Width;
                    }

                    txtQtdade.Focus();
                }

                else
                {
                    MessageBox.Show("DV Inválido");
                }
            }
        }

        private void addItemRichTextProduto(String descricao)
        {
            richTextProduto.AppendText(descricao);
        }

        private void txtQtdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //Bloco1 - Calculos Vlr Parcial e Subtotal e PrecoTotal
                txtParcial.Text = Convert.ToString(Convert.ToDecimal(txtVlrUnitario.Text) * Convert.ToDecimal(txtQtdade.Text));
                txtSubtotal.Text = Convert.ToString(Convert.ToDecimal(txtSubtotal.Text) + Convert.ToDecimal(txtParcial.Text));
                txtPrecoTotal.Text = txtSubtotal.Text;


                //atualizção da VENDA somente no final da COMPRA

                //INSERIR ITENS NA TABELA DETALHEVENDA
                //CRIAR METODO getMaxItem() COMO AUTOINCREMENTO
                ItemCTR itemCTR = new ItemCTR();
                int novoItem = itemCTR.getMaxItem() + 1;
                itemCTR.insertItem(novoItem, Convert.ToInt16(txtCodVenda.Text),
                    Convert.ToInt16(txtCodProduto.Text),
                    Convert.ToDouble(txtQtdade.Text),
                    Convert.ToDouble(txtParcial.Text));


                //BLoco 3 - Atualiza a tabela VENDA com o valor do PrecoTotal
                VendaCTR vendaCTR = new VendaCTR();
                vendaCTR.updateVenda(Convert.ToInt16(txtCodVenda.Text), Convert.ToDateTime(pickerDataVenda.Value.ToShortDateString()),
                Convert.ToInt16(txtCodCliente.Text), Convert.ToDouble(txtPrecoTotal.Text));


                //Bloco 4 - cria string CONTEUDO de acordo com os dados do cabecalhocriado para o RECIBO
                sequencia++;
                //arquivo.WriteLine("Item Codigo Descricao Qtdade VlrUnitario Vlr Parcial ")
                var valorParcial = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(txtParcial.Text));
                var valorUnitario = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(txtVlrUnitario.Text));

                string Conteudo = String.Format("{0,-12}{1,8}{2,12}{3,8}{4,12:N2}{5,14:N2}\n",
                sequencia.ToString().PadLeft(6, '0'), txtCodProduto.Text, txtQtdade.Text, valorUnitario, valorParcial);


                //Bloco 5 - Criar dois metodo ADD para inserir o conteudo abaixo dos topicos do RECIBO
                // addItemRecibo(conteudo);

                addItemRichTextProduto(Conteudo);
                addItemReciboTxt(Conteudo);
            }

        }

        private void addItemReciboTxt(String descricao )
        {
            arquivoEscritor.WriteLine(descricao);
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            var valorTotal = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}",Convert.ToDecimal(txtSubtotal.Text));
            arquivoEscritor.WriteLine(">>>>Total:"+valorTotal);
            arquivoEscritor.WriteLine();
       
            arquivoEscritor.Close();
            richTextProduto.LoadFile(@"C:\Users\Alunos\Desktop\ProjetoPDV\Recibo\" + txtCodVenda.Text + ".txt", RichTextBoxStreamType.PlainText);

        }




    }

}
    


