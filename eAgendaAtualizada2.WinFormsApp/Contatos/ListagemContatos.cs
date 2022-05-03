using EAgenda.Dominio;
using EAgenda.Infra.Arquivos;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EAgenda.WinApp
{
    public partial class ListagemContatos : Form
    {
        private IRepositorioContato repositorioContato;

        public ListagemContatos()
        {
            SerializadorContatosEmJsonDotnet serializador = new SerializadorContatosEmJsonDotnet();

            repositorioContato = new RepositorioContatoEmArquivo(serializador);

            InitializeComponent();
            CarregarContatos();
        }

        public void CarregarContatos()
        {
            List<Contato> contatosCadastrados = repositorioContato.SelecionarTodos();

            listContatos.Items.Clear();

            foreach (Contato t in contatosCadastrados)
            {
                listContatos.Items.Add(t);
            }

        }

        private void btnInserir_Click(object sender, System.EventArgs e)
        {
            CadastroContatos tela = new CadastroContatos();
            tela.Contato = new Contato();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (tela.Contato.ValidarContatos() == false)
                {
                    MessageBox.Show("O seu telefone extrapolou o limite de numero, ou seu email é inválido!",
                "Inserir Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    repositorioContato.Inserir(tela.Contato);
                    CarregarContatos();
                }
            }
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {

            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Edição de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroContatos tela = new CadastroContatos();

            tela.Contato = contatoSelecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Editar(tela.Contato);
                CarregarContatos();
            }
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Exclusão de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o contato?",
                "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Excluir(contatoSelecionado);
                CarregarContatos();
            }
        }
        
    }
}
