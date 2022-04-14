using System;
using SistemaClientes.Entidade;
using SistemaClientes.Entidade.Enum;

namespace SistemaClientes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados do cliente:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Cliente cliente = new Cliente(1, nome, email, telefone);
            
            Console.WriteLine();

            Console.Write("Digite quantos Contatos deseja incluir: ");
            int quant = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quant; i++)
            {
                bool aprovado = false;
                do
                {
                    Console.WriteLine($"Digite os dados do Contato #{i + 1}:");
                    Console.Write("Nome do Contato: ");
                    string nomeContato = Console.ReadLine();
                    Console.Write("Numero de Telefone: ");
                    string numeroTelefone = Console.ReadLine();
                    Console.Write("Tipo de relacionamento: ");
                    TipoRelacionamento tipoRelacionamento = Enum.Parse<TipoRelacionamento>(Console.ReadLine());

                    bool retorno = cliente.AdicionarContato(new Contato(i + 1, nomeContato, numeroTelefone, tipoRelacionamento));
                    if (!retorno)
                    {
                        Console.WriteLine("Contato com telefone e tipo de relacionamento ja existente");
                        aprovado = false;
                    }
                    else
                    {
                        aprovado = true;
                    }
                } while (!aprovado);
            }

            Console.WriteLine();
            Console.WriteLine(cliente);
        }
    }
}
