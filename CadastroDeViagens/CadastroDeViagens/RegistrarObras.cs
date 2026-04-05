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
    public partial class RegistrarObras : Form
    {
        List<Caminhao> caminhoes;
        List<Obras> obras;
        public RegistrarObras()
        {
            InitializeComponent();
        }

        private void RegistrarObras_Load(object sender, EventArgs e)
        {
            caminhoes = CaminhaoService.Carregar();
            selecaoCaminhao.DataSource = caminhoes;
            selecaoCaminhao.DisplayMember = "placa";
            obras = ObraService.Carregar();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }




        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Obras novaobra = new Obras()
            {
                nomeObra = textBoxObra.Text,
                valor = decimal.Parse(textBoxValor.Text),
                caminhaoObra = ((Caminhao)selecaoCaminhao.SelectedItem).placa

            };
            obras.Add(novaobra);
            ObraService.Salvar(obras);
            foreach(Obras obra in obras)
            {
                Console.WriteLine($"Nome:{obra.nomeObra} - Valor:{obra.valor} - Caminhão: {obra.caminhaoObra}");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
