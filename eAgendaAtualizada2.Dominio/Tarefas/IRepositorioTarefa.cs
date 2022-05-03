using System.Collections.Generic;

namespace EAgenda.Dominio
{
    public interface IRepositorioTarefa
    {
        void Adicionar(Tarefa tarefaSelecionada, List<ItemTarefa> itens);
        void Atualizar(Tarefa tarefaSelecionada, List<ItemTarefa> itensConcluidos, List<ItemTarefa> itensPendentes);
        void Editar(Tarefa tarefa);
        void Excluir(Tarefa tarefa);
        void Inserir(Tarefa novaTarefa);
        List<Tarefa> SelecionarTodos();

        List<Tarefa> SelecionarTarefasConcluidas();

        List<Tarefa> SelecionarTarefasPendentes();

    }
}