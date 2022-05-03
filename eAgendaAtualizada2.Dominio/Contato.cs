using System;
using System.Collections.Generic;
using System.Linq;

namespace EAgenda.Dominio
{
    [Serializable]
    public class Contato
    {
        private List<ItemContato> itens = new List<ItemContato>();

        public Contato()
        {
            DataCadastro = DateTime.Now;
        }
        public Contato(string nome, string email, string telefone, string empresa, string cargo) : this()
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Empresa = empresa;
            Cargo = cargo;
            DataCadastro = null;
        }
        public int Numero { get; set; }
        public List<ItemContato> Itens { get { return itens; } }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }
        public DateTime? DataCadastro { get; set; }

        public override string ToString()
        {
            return $"Número: {Numero}, Nome: {Nome}, Email: {Email}, " +
                $"Telefone: {Telefone}, Empresa: {Empresa}, Cargo: {Cargo}";
        }

        public void AdicionarItem(ItemContato item)
        {
            if (Itens.Exists(x => x.Equals(item)) == false)
                itens.Add(item);
        }
    }
}
