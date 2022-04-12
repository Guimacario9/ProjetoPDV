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
        //declaracao de um obj formSplash da classe FormSplash
        FormSplash formSplash;

        public FormLogin()
        {
            InitializeComponent();
            //inicializacao (ou instanciar) do obj formSplash dentro do construtor
            //da classe FormLogin
            formSplash = new FormSplash();
            //esconde o FormLogin
            this.Hide();
            //mostra (exibe) o formSplash
            formSplash.ShowDialog();
        }

        private void timerPrincipal_Tick(object sender, EventArgs e)
        {
            formSplash.progressBar1.Increment(20);
            if (formSplash.progressBar1.Value == 100)
            {
                timerPrincipal.Stop();
                formSplash.Close();
                this.Show();
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
