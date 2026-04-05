using CadastroDeViagens.Models;
using CadastroDeViagens.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeViagens
{
    public partial class Viagens : Form
    {
        List<Obras> obras = new List<Obras>();
        List<ViagensClasse> viagem = new List<ViagensClasse>();
        CultureInfo brasil = new CultureInfo("pt-BR");
        public Viagens()
        {
            InitializeComponent();
        }




        private void Viagens_Load(object sender, EventArgs e)
        {
            viagem = ViagensService.Carregar();
            obras = ObraService.Carregar();
            listObras.DataSource = obras;
            listObras.DisplayMember = "nomeObra";

            if (listObras.SelectedItem != null)
            {

                textNome.Text = ((Obras)listObras.SelectedItem).nomeObra;
                textCaminhao.Text = ((Obras)listObras.SelectedItem).caminhaoObra;
                textValor.Text = ((Obras)listObras.SelectedItem).valor.ToString("C", brasil);
            }

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViagensClasse novaviagem = new ViagensClasse
            (
                textNome.Text,
                decimal.Parse(textValor.Text,NumberStyles.Currency, brasil),
                textCaminhao.Text,
                monthCalendar.SelectionStart
            );

            viagem.Add(novaviagem);
            ViagensService.Salvar(viagem);
            foreach (ViagensClasse v in viagem)
            {
                Console.WriteLine($"Nome:{v.obra} - Valor:{v.valor} - Caminhão: {v.caminhao} - Data:{v.data}");
            }
            var viagensPorMes = viagem.GroupBy(v => new { v.data.Year, v.data.Month });
            foreach (var grupo in viagensPorMes) 
            {
                decimal totalMes = grupo.Sum(v => v.valor);
                Console.WriteLine($"Mês {grupo.Key.Month}/{grupo.Key.Year} - Total: {totalMes:C}");

            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
