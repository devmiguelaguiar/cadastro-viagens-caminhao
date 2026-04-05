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
    public partial class Form1 : Form
    {
        List<Caminhao> caminhoes;

        public Form1()
        {
            InitializeComponent();
        }

  

        private void label1_Click(object sender, EventArgs e)
        {

        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            
            Caminhao novocaminhao = new Caminhao();
            novocaminhao.motorista = TextBoxCaminhao.Text;
            novocaminhao.placa = TextBoxPlaca.Text;
            novocaminhao.observacao = TextBoxObservacao.Text;

            caminhoes.Add(novocaminhao);

            foreach(Caminhao caminhao in caminhoes)
            {
                Console.WriteLine($"Motorista:{caminhao.motorista} - Placa: {caminhao.placa} - Observação:{caminhao.observacao}");
            }
            CaminhaoService.Salvar(caminhoes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            caminhoes = CaminhaoService.Carregar();
            foreach (Caminhao caminhao in caminhoes)
            {
                {
                    Console.WriteLine($"Motorista:{caminhao.motorista} - Placa: {caminhao.placa} - Observação:{caminhao.observacao}");
                }
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
