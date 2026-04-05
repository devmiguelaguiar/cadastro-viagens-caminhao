using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeViagens.Models
{
    internal class ViagensClasse
    {

        public string obra { get; set; }
        public decimal valor { get; set; }
        public string caminhao { get; set; }
        public DateTime data {  get; set; }

        public static decimal valorTotal;

        public ViagensClasse(string obra, decimal valor, string caminhao, DateTime data) 
        {
            this.obra = obra;
            this.valor = valor;
            this.caminhao = caminhao;
            this.data = data;
        }

    }
}
