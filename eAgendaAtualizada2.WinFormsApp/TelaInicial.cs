using EAgenda.Dominio;
using EAgenda.Infra.Arquivos;
using EAgenda.Infra.Arquivos.SerializacaoEmJson;
using System;
using System.Windows.Forms;

namespace EAgenda.WinApp
{
    public partial class TelaInicial : Form
    {
        private IRepositorioTarefa repositorioTarefa;
        private IRepositorioContato repositorioContato;

        public TelaInicial()
        {
            InitializeComponent();

            ISerializador serializador = new SerializadorDadosEmJsonDotnet();

            DataContext contextoDados = new DataContext();

            repositorioTarefa = new RepositorioTarefaEmArquivo(serializador, contextoDados);

            repositorioContato = new RepositorioContatoEmArquivo(serializador, contextoDados);
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            ListagemTarefas tela = new ListagemTarefas();

            DialogResult resultado = tela.ShowDialog();
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            ListagemContatos tela = new ListagemContatos();

            DialogResult resultado = tela.ShowDialog();
        }

        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            ListagemCompromissos tela = new ListagemCompromissos();

            DialogResult resultado = tela.ShowDialog();
        }
    }
}
