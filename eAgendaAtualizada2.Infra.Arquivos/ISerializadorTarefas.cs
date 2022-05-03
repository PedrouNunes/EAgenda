using EAgenda.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAgenda.Infra.Arquivos
{
    public interface ISerializadorTarefas
    {
        List<Tarefa> CarregarTarefasDoArquivo();
        void GravarTarefasEmArquivo(List<Tarefa> tarefas);
    }
}
