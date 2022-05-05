using EAgenda.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace EAgenda.Infra.Arquivos
{
    public class RepositorioContatoEmArquivo : IRepositorioContato
    {
        private readonly ISerializador serializador;
        private readonly DataContext dataContext;
        private int contador = 0;
        public RepositorioContatoEmArquivo(ISerializador serializador, DataContext dataContext)
        {
            this.serializador = serializador;
            this.dataContext = dataContext;

            //    contatos = serializador.CarregarContatosDoArquivo();
        }

        public List<Contato> SelecionarTodos()
        {
            return dataContext.Contatos;
        }
        public void Inserir(Contato novaContato)
        {
            novaContato.Numero = ++contador;
            dataContext.Contatos.Add(novaContato);

            serializador.GravarDadosEmArquivo(dataContext);
        }
        public void Editar(Contato contato)
        {
            foreach (var item in dataContext.Contatos)
            {
                if (item.Numero == contato.Numero)
                {
                    item.Nome = contato.Nome;
                    item.Email = contato.Email;
                    item.Telefone = contato.Telefone;
                    item.Empresa = contato.Empresa;
                    item.Cargo = contato.Cargo;
                    break;
                }
            }
            serializador.GravarDadosEmArquivo(dataContext);
        }
        public void Excluir(Contato contato)
        {
           dataContext.Contatos.Remove(contato);

            serializador.GravarDadosEmArquivo(dataContext);
        }
        public void Adicionar(Contato contatoSelecionada, List<ItemContato> itens)
        {
            foreach (var item in itens)
            {
                contatoSelecionada.AdicionarItem(item);
            }

            serializador.GravarDadosEmArquivo(dataContext);
        }
        public void Atualizar(Contato contatoSelecionada,
            List<ItemContato> itensConcluidos, List<ItemContato> itensPendentes)
        {
            serializador.GravarDadosEmArquivo(dataContext);
        }
    }
}