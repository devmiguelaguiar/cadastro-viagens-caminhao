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
    public partial class ListaObras : Form
    {
        List<Obras> obras = new List<Obras>();
        public ListaObras()
        {
            InitializeComponent();
        }

        private void ListaObras_Load(object sender, EventArgs e)
        {
            obras = ObraService.Carregar();
            nomear();



        }
        private void nomear()
        {
            dataObras.DataSource = obras;
            dataObras.Columns["nomeObra"].HeaderText = "Nome da Obra";
            dataObras.Columns["caminhaoObra"].HeaderText = "Caminhão da Obra";
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataObras.CurrentRow != null) 
            {
                var caminhaoSelecionado = (Obras)dataObras.CurrentRow.DataBoundItem;
                obras.Remove(caminhaoSelecionado);
                ObraService.Salvar(obras);
                dataObras.DataSource = null;
                nomear();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
