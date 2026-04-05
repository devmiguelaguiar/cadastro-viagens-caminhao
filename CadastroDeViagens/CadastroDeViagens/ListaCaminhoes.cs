using CadastroDeViagens.Models;
using CadastroDeViagens.Services;
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
    public partial class ListaCaminhoes : Form
    {
        List<Caminhao> caminhoes = new List<Caminhao>();
        public ListaCaminhoes()
        {
            InitializeComponent();
        }

        private void ListaCaminhoes_Load(object sender, EventArgs e)
        {
            caminhoes = CaminhaoService.Carregar();
            dataCaminhao.DataSource = caminhoes;

        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataCaminhao.CurrentRow != null) 
            {
                var caminhaoSelecionado = (Caminhao)dataCaminhao.CurrentRow.DataBoundItem;
                caminhoes.Remove(caminhaoSelecionado);
                CaminhaoService.Salvar(caminhoes);
                dataCaminhao.DataSource = null;
                dataCaminhao.DataSource = caminhoes;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
