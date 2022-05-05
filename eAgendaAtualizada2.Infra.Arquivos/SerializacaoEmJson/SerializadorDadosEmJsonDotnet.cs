using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAgenda.Infra.Arquivos.SerializacaoEmJson
{
    public class SerializadorDadosEmJsonDotnet : ISerializador
    {
        private const string arquivo = @"C:\temp\dados.json";
        public DataContext CarregarDadosDoArquivo()
        {
            if (File.Exists(arquivo) == false)
                return new DataContext();

            string arquivoJson = File.ReadAllText(arquivo);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            return JsonConvert.DeserializeObject<DataContext>(arquivoJson, settings);
        }

        public void GravarDadosEmArquivo(DataContext dados)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string arquivoJson = JsonConvert.SerializeObject(dados, settings);

            File.WriteAllText(arquivo, arquivoJson);
        }
    }
}
