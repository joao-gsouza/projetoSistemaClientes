using SistemaClientes.Entidade.Enum;

namespace SistemaClientes.Entidade
{
    class Contato
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string NumeroTelefone { get; set; }
        public TipoRelacionamento TipoRelacionamento { get; set; }

        public Contato() { }

        public Contato(int codigo, string nome, string numeroTelefone, TipoRelacionamento tipoRelacionamento)
        {
            Codigo = codigo;
            Nome = nome;
            NumeroTelefone = numeroTelefone;
            TipoRelacionamento = tipoRelacionamento;
        }
    }
}