using EAgenda.Dominio;
using EAgenda.Infra.Arquivos;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EAgenda.WinApp
{
    public partial class ListagemCompromissos : Form
    {
        private IRepositorioCompromisso repositorioCompromisso;

        public ListagemCompromissos()
        {
            SerializadorCompromissosEmJsonDotnet serializador = new SerializadorCompromissosEmJsonDotnet();

            repositorioCompromisso = new RepositorioCompromissoEmArquivo(serializador);

            InitializeComponent();
            CarregarCompromissos();
        }

        public void CarregarCompromissos()
        {
            List<Compromisso> compromissosCadastrados = repositorioCompromisso.SelecionarTodos();

            listCompromissos.Items.Clear();

            foreach (Compromisso t in compromissosCadastrados)
            {
                listCompromissos.Items.Add(t);
            }

        }

        private void btnInserir_Click(object sender, System.EventArgs e)
        {
            CadastroCompromissos tela = new CadastroCompromissos();
            tela.Compromisso = new Compromisso();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Inserir(tela.Compromisso);
                CarregarCompromissos();
            }
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {

            Compromisso compromissoSelecionado = (Compromisso)listCompromissos.SelectedItem;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro",
                "Edição de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroCompromissos tela = new CadastroCompromissos();

            tela.Compromisso = compromissoSelecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Editar(tela.Compromisso);
                CarregarCompromissos();
            }
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listCompromissos.SelectedItem;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro",
                "Exclusão de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o compromisso?",
                "Exclusão de Compromissos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromissoSelecionado);
                CarregarCompromissos();
            }
        }

    }
}
