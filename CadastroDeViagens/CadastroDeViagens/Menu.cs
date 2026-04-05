using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeViagens
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonCaminhao_Click(object sender, EventArgs e)
        {
            Form1 caminhoes = new Form1();

            caminhoes.ShowDialog();
        }

        private void buttonObra_Click(object sender, EventArgs e)
        {
            RegistrarObras registroObras = new RegistrarObras();
            registroObras.ShowDialog();
        }

        private void buttonViagem_Click(object sender, EventArgs e)
        {
            Viagens viagens = new Viagens();
            viagens.ShowDialog();

        }

        private void buttonListC_Click(object sender, EventArgs e)
        {
            ListaCaminhoes listaCaminnhoes = new ListaCaminhoes();
            listaCaminnhoes.Show();

        }

        private void buttonListO_Click(object sender, EventArgs e)
        {
            ListaObras listaObras = new ListaObras();
            listaObras.Show();

        }

        private void buttonListV_Click(object sender, EventArgs e)
        {
            ListaViagens listaViagens = new ListaViagens();
            listaViagens.ShowDialog();
            
        }
    }
}
