using System.Collections.Generic;

namespace EAgenda.Dominio
{
    public interface IRepositorioContato
    {
        void Adicionar(Contato contatoSelecionada, List<ItemContato> itens);
        void Atualizar(Contato contatoSelecionada, List<ItemContato> itensConcluidos, List<ItemContato> itensPendentes);
        void Editar(Contato contato);
        void Excluir(Contato contato);
        void Inserir(Contato novoContato);
        List<Contato> SelecionarTodos();
    }
}