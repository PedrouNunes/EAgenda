using EAgenda.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace EAgenda.Infra.Arquivos
{
    public class RepositorioCompromissoEmArquivo : IRepositorioCompromisso
    {
        private readonly ISerializadorCompromissos serializador;
        List<Compromisso> compromissos;
        private int contador = 0;

        public RepositorioCompromissoEmArquivo(ISerializadorCompromissos serializador)
        {
            this.serializador = serializador;

            compromissos = serializador.CarregarCompromissosDoArquivo();

            if (compromissos.Count > 0)
                contador = compromissos.Max(x => x.Numero);
        }
        public List<Compromisso> SelecionarTodos()
        {
            return compromissos;
        }

        public void Inserir(Compromisso novaCompromisso)
        {
            novaCompromisso.Numero = ++contador;
            compromissos.Add(novaCompromisso);

            serializador.GravarCompromissosEmArquivo(compromissos);
        }
        public void Editar(Compromisso compromisso)
        {
            foreach (var item in compromissos)
            {
                if (item.Numero == compromisso.Numero)
                {
                    item.Assunto = compromisso.Assunto;
                    item.Local = compromisso.Local;
                    item.DataCompromisso = compromisso.DataCompromisso;
                    item.HoraInicio = compromisso.HoraInicio;
                    item.HoraTermino = compromisso.HoraTermino;
                    break;
                }
            }
            serializador.GravarCompromissosEmArquivo(compromissos);
        }
        public void Excluir(Compromisso compromisso)
        {
            compromissos.Remove(compromisso);

            serializador.GravarCompromissosEmArquivo(compromissos);
        }
        public void Adicionar(Compromisso compromissoSelecionada, List<ItemCompromisso> itens)
        {
            foreach (var item in itens)
            {
                compromissoSelecionada.AdicionarItem(item);
            }

            serializador.GravarCompromissosEmArquivo(compromissos);
        }
        public void Atualizar(Compromisso compromissoSelecionada,
            List<ItemCompromisso> itensConcluidos, List<ItemCompromisso> itensPendentes)
        {
            serializador.GravarCompromissosEmArquivo(compromissos);
       }
    }
}