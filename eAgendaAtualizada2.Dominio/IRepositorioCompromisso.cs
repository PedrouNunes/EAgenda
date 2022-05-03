using System.Collections.Generic;

namespace EAgenda.Dominio
{
    public interface IRepositorioCompromisso
    {
        void Adicionar(Compromisso compromissoSelecionada, List<ItemCompromisso> itens);
        void Atualizar(Compromisso compromissoSelecionada, List<ItemCompromisso> itensConcluidos, List<ItemCompromisso> itensPendentes);
        void Editar(Compromisso compromisso);
        void Excluir(Compromisso compromisso);
        void Inserir(Compromisso novoCompromisso);
        List<Compromisso> SelecionarTodos();
    }
}