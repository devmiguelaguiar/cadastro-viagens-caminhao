using CadastroDeViagens.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CadastroDeViagens.Services
{
    internal class ViagensService
    {

        static string arquivo = "Viagens.json";

        public static List<ViagensClasse> Carregar()
        {
            if (!File.Exists(arquivo))
            {
                return new List<ViagensClasse>();
            }
            string json = File.ReadAllText(arquivo);
            return JsonSerializer.Deserialize<List<ViagensClasse>>(json);
        }

        public static void Salvar(List<ViagensClasse> viagens)
        {
            string json = JsonSerializer.Serialize(viagens);
            File.WriteAllText(arquivo, json);
        }



    }
}
