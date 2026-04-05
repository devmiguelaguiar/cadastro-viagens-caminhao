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
    public partial class ListaViagens : Form
    {
        private BindingList<ViagensClasse> viagensPorDatas;
        private void Carregamento()
        {
            var viagens = ViagensService.Carregar();
            viagensPorDatas = new BindingList<ViagensClasse>(viagens.OrderBy(v => v.data).ToList());
            dataViagens.DataSource = viagensPorDatas;
            var viagensPorMes = viagens.GroupBy(v => new { v.data.Year, v.data.Month });
            foreach (var grupo in viagensPorMes)
            {
                decimal totalMes = grupo.Sum(v => v.valor);
                textvalor.Text = totalMes.ToString();

            }
        }



        public ListaViagens()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaViagens_Load(object sender, EventArgs e)
        {
            Carregamento();




        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataViagens.CurrentRow != null) 
            {

                var viagemSelecionada = (CadastroDeViagens.Models.ViagensClasse)dataViagens.CurrentRow.DataBoundItem;
                viagensPorDatas.Remove(viagemSelecionada);
                ViagensService.Salvar(viagensPorDatas.ToList());
                dataViagens.DataSource = null;
                Carregamento();


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
