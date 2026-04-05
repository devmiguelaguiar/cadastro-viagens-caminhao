using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace CadastroDeViagens.Services
{
    internal static class CaminhaoService
    {
        static string arquivo = "caminhoes.json";

        public static List<Caminhao> Carregar()
        {
            if (!File.Exists(arquivo))
            {
                return new List<Caminhao>();
            }
            string json = File.ReadAllText(arquivo);
            return JsonSerializer.Deserialize<List<Caminhao>>(json);


        }
        public static void Salvar(List<Caminhao> caminhoes)
        {
            string json = JsonSerializer.Serialize(caminhoes);
            File.WriteAllText(arquivo, json);
        }

    }
}
