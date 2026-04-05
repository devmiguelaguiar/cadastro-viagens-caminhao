using CadastroDeViagens.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace CadastroDeViagens.Services
{
    internal class ObraService
    {
        static string arquivo = "Obras.json";



        public static List<Obras> Carregar() 
        {
            if (!File.Exists(arquivo))
            {
                return new List<Obras>();
            }
            string json = File.ReadAllText(arquivo);

            return JsonSerializer.Deserialize<List<Obras>>(json);

        }
        public static void Salvar(List<Obras> obras) 
        {
            string json = JsonSerializer.Serialize(obras);

            File.WriteAllText(arquivo, json);
        }
    }
}
