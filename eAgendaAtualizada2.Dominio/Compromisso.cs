using System;
using System.Collections.Generic;
using System.Linq;

namespace EAgenda.Dominio
{
    [Serializable]
    public class Compromisso
    {
        private List<ItemCompromisso> itens = new List<ItemCompromisso>();

        public Compromisso()
        {
            DataCadastro = DateTime.Now;
        }

        public Compromisso(string assunto, string local, string dataCompromisso, string horaInicio, string horaTermino, string contato) : this()
        {
            Assunto = assunto;
            Local = local;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
            DataCompromisso = dataCompromisso;
            Contato = contato;
            DataCadastro = null;
        }

        public List<ItemCompromisso> Itens { get { return itens; } }
        public int Numero { get; set; }
        public string Assunto { get; set; }
        public string Local { get; set; }
        public string DataCompromisso { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string HoraInicio { get; set; }
        public string HoraTermino { get; set; }
        public string Contato { get; set; }

        public override string ToString()
        {
            return $"Número: {Numero}, Assunto: {Assunto}, Local: {Local}," +
                $" Data do compromisso: {DataCompromisso}, Hora de ínicio: {HoraInicio}, Hora de término: {HoraTermino}, " +
                $"Contato: {Contato}";
        }

        public void AdicionarItem(ItemCompromisso item)
        {
            if (Itens.Exists(x => x.Equals(item)) == false)
                itens.Add(item);
        }

        public bool ValidarCompromissos()
        {
            if (String.IsNullOrEmpty(Assunto) || String.IsNullOrEmpty(Local) || String.IsNullOrEmpty(DataCompromisso) )
            {
                return false;
            }
            else
            {
                //int horaInicio = Convert.ToInt32(HoraInicio);
                //int horaFinal = Convert.ToInt32(HoraInicio);
                //if (horaFinal < horaInicio)
                //{
                //    return false;
                //}
                return true;
            }
        }
    }
}
