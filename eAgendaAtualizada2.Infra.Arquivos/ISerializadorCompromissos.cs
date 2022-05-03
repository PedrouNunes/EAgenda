using EAgenda.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAgenda.Infra.Arquivos
{
    public interface ISerializadorCompromissos
    {
        List<Compromisso> CarregarCompromissosDoArquivo();
        void GravarCompromissosEmArquivo(List<Compromisso> compromissos);
    }
}
