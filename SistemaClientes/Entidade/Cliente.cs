using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaClientes.Entidade
{
    class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public List<Contato> ListaContatos { get; set; } = new List<Contato>();

        public Cliente() { }

        public Cliente(int codigo, string nome, string email, string telefone)
        {
            Codigo = codigo;
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
        public bool AdicionarContato(Contato contato)
        {
            List<Contato> retorno = ListaContatos.FindAll(x => x.NumeroTelefone == contato.NumeroTelefone && x.TipoRelacionamento == contato.TipoRelacionamento);
            if (retorno.Count == 0)
            {
                ListaContatos.Add(contato);
                OrdenarLista();
                return true;
            }
            return false;
        }
        public void RemoverContato(Contato contato)
        {
            ListaContatos.Remove(contato);
            OrdenarLista();
        }
        private void OrdenarLista()
        {
            ListaContatos = ListaContatos.OrderBy(x => x.Codigo).ToList<Contato>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Cliente:");
            sb.Append("Codigo do cliente: ");
            sb.AppendLine(Codigo.ToString());
            sb.Append("Nome do cliente: ");
            sb.AppendLine(Nome);
            sb.Append("Email do cliente: ");
            sb.AppendLine(Email);
            sb.AppendLine("");

            foreach (Contato contato in ListaContatos)
            {
                sb.AppendLine($"Contato #{contato.Codigo}:");
                sb.Append("Nome do contato: ");
                sb.AppendLine(contato.Nome);
                sb.Append("Numero de telefone: ");
                sb.AppendLine(contato.NumeroTelefone.ToString());
                sb.Append("Tipo relacionamento: ");
                sb.AppendLine(contato.TipoRelacionamento.ToString());
                sb.AppendLine("");
            }

            return sb.ToString();
        }
    }
}
