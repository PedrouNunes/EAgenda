using System;
using System.Windows.Forms;

namespace EAgenda.WinApp
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();

            //Iserializador
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
