namespace ProjetoPDV.View
{
    partial class FormVendaitem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRecibo = new System.Windows.Forms.Button();
            this.txtCodVenda = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtPrecoTotal = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.pickerDataVenda = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQtdade = new System.Windows.Forms.TextBox();
            this.txtVlrUnitario = new System.Windows.Forms.TextBox();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.pictureCodBarra = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextProduto = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCodBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda de Items de Produtos";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(25, 20);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data Venda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Preço Total:";
            // 
            // btnRecibo
            // 
            this.btnRecibo.Location = new System.Drawing.Point(25, 61);
            this.btnRecibo.Name = "btnRecibo";
            this.btnRecibo.Size = new System.Drawing.Size(75, 23);
            this.btnRecibo.TabIndex = 4;
            this.btnRecibo.Text = "Recibo";
            this.btnRecibo.UseVisualStyleBackColor = true;
            this.btnRecibo.Click += new System.EventHandler(this.btnRecibo_Click);
            // 
            // txtCodVenda
            // 
            this.txtCodVenda.Location = new System.Drawing.Point(86, 15);
            this.txtCodVenda.Name = "txtCodVenda";
            this.txtCodVenda.Size = new System.Drawing.Size(100, 20);
            this.txtCodVenda.TabIndex = 4;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(86, 42);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 5;
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            // 
            // txtPrecoTotal
            // 
            this.txtPrecoTotal.Location = new System.Drawing.Point(86, 68);
            this.txtPrecoTotal.Name = "txtPrecoTotal";
            this.txtPrecoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoTotal.TabIndex = 6;
            this.txtPrecoTotal.Text = "0";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(216, 40);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(267, 20);
            this.txtNomeCliente.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCodCliente);
            this.panel1.Controls.Add(this.pickerDataVenda);
            this.panel1.Controls.Add(this.txtCPF);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNomeCliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPrecoTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCodVenda);
            this.panel1.Location = new System.Drawing.Point(173, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 100);
            this.panel1.TabIndex = 9;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(514, 42);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(51, 20);
            this.txtCodCliente.TabIndex = 9;
            // 
            // pickerDataVenda
            // 
            this.pickerDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerDataVenda.Location = new System.Drawing.Point(283, 14);
            this.pickerDataVenda.Name = "pickerDataVenda";
            this.pickerDataVenda.Size = new System.Drawing.Size(200, 20);
            this.pickerDataVenda.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnInserir);
            this.panel2.Controls.Add(this.btnRecibo);
            this.panel2.Location = new System.Drawing.Point(12, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 461);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtSubtotal);
            this.panel3.Controls.Add(this.txtParcial);
            this.panel3.Controls.Add(this.txtProduto);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtQtdade);
            this.panel3.Controls.Add(this.txtVlrUnitario);
            this.panel3.Controls.Add(this.txtCodProduto);
            this.panel3.Controls.Add(this.txtCodigoBarras);
            this.panel3.Controls.Add(this.pictureCodBarra);
            this.panel3.Location = new System.Drawing.Point(173, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 339);
            this.panel3.TabIndex = 11;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtSubtotal.Location = new System.Drawing.Point(414, 303);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 13;
            this.txtSubtotal.Text = "0";
            // 
            // txtParcial
            // 
            this.txtParcial.Location = new System.Drawing.Point(414, 229);
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(100, 20);
            this.txtParcial.TabIndex = 12;
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtProduto.Location = new System.Drawing.Point(18, 303);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(355, 20);
            this.txtProduto.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(428, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "SubTotal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(428, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Parcial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(333, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(155, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(191, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(30, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor Unitário";
            // 
            // txtQtdade
            // 
            this.txtQtdade.Location = new System.Drawing.Point(194, 235);
            this.txtQtdade.Name = "txtQtdade";
            this.txtQtdade.Size = new System.Drawing.Size(100, 20);
            this.txtQtdade.TabIndex = 4;
            this.txtQtdade.Text = "1";
            this.txtQtdade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdade_KeyPress);
            // 
            // txtVlrUnitario
            // 
            this.txtVlrUnitario.Location = new System.Drawing.Point(33, 237);
            this.txtVlrUnitario.Name = "txtVlrUnitario";
            this.txtVlrUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtVlrUnitario.TabIndex = 3;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(414, 144);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(100, 20);
            this.txtCodProduto.TabIndex = 2;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtCodigoBarras.Location = new System.Drawing.Point(18, 144);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(355, 20);
            this.txtCodigoBarras.TabIndex = 1;
            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress);
            // 
            // pictureCodBarra
            // 
            this.pictureCodBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureCodBarra.Location = new System.Drawing.Point(18, 24);
            this.pictureCodBarra.Name = "pictureCodBarra";
            this.pictureCodBarra.Size = new System.Drawing.Size(522, 102);
            this.pictureCodBarra.TabIndex = 0;
            this.pictureCodBarra.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(786, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(350, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // richTextProduto
            // 
            this.richTextProduto.Location = new System.Drawing.Point(786, 220);
            this.richTextProduto.Name = "richTextProduto";
            this.richTextProduto.Size = new System.Drawing.Size(350, 305);
            this.richTextProduto.TabIndex = 13;
            this.richTextProduto.Text = "";
            // 
            // FormVendaitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 528);
            this.Controls.Add(this.richTextProduto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormVendaitem";
            this.Text = "Registro de Vendas de Produtos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCodBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRecibo;
        private System.Windows.Forms.TextBox txtCodVenda;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtPrecoTotal;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQtdade;
        private System.Windows.Forms.TextBox txtVlrUnitario;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.PictureBox pictureCodBarra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextProduto;
        private System.Windows.Forms.DateTimePicker pickerDataVenda;
        private System.Windows.Forms.TextBox txtCodCliente;
    }
}