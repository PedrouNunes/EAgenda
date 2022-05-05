using EAgenda.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAgenda.Infra.Arquivos
{
    [Serializable]
    public  class DataContext
    {
        public List<Tarefa> Tarefas { get; set; }

        public List<Contato> Contatos { get; set; }
    }
}
