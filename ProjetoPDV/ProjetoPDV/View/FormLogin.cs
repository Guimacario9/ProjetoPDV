using ProjetoPDV.Controller;
using ProjetoPDV.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPDV
{
    public partial class FormLogin : Form
    {
        FormSplash formSplash;
        UsuarioCTR userCTR;

        public FormLogin()
        {
            InitializeComponent();
            userCTR = new UsuarioCTR();
            formSplash = new FormSplash();
            this.Hide();
            formSplash.ShowDialog();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void timerPrincipal_Tick(object sender, EventArgs e)
        {
            formSplash.progressBar1.Increment(50);
            if (formSplash.progressBar1.Value == 100)
            {
                timerPrincipal.Stop();
                formSplash.Close();
                this.Show();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //chmar o metodo selectUsuario da classe UsuarioCTR (controller)
            if (userCTR.selectUsuario(txtUsername.Text, txtPassword.Text))
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                this.Hide();
                FormMenuStrip formPcp = new FormMenuStrip();
                formPcp.ShowDialog();
            }
            else 
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Usuario Não Localizado!!!");
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOk_Click(this, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
