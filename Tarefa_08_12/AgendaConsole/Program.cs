using Agenda.Domain;
using System;
using System.Threading;

namespace AgendaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Contatos contatos = new Contatos();
            string valor = "0";
            // contatos.Adicionar(new Contato("Anderson", "email@anderson.com", "13996969696", new Data(19, 07, 1994)));
            // contatos.Remover(new Contato("Sibraslva", "email@anderson.com", "13996969696", new Data(19, 07, 1994)));
            contatos.Adicionar(new Contato("Silva", "email@anderson.com", "13996969696", new Data(19, 07, 1994)));
            // Console.WriteLine(contatos.Pesquisar(new Contato("Anderson", "email@anderson.com", "13996969696", new Data(19, 07, 1994))));
            string nome, email, telefone;
            int dia, mes, ano;
            do
            {
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar contato");
                Console.WriteLine("2. Pesquisar contato");
                Console.WriteLine("3. Alterar contato");
                Console.WriteLine("4. Remover contato");
                Console.WriteLine("5. Listar contato \n");

                Console.Write("O que deseja fazer?: ");
                valor = Console.ReadLine();
                Console.Clear();
                switch (valor)
                {                    
                    case "1":
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Email: ");
                        email = Console.ReadLine();
                        Console.Write("Telefone: ");
                        telefone = Console.ReadLine();

                        Console.Write("Dia do Nascimento: ");
                        dia = int.Parse(Console.ReadLine());
                        Console.Write("Mes do Nascimento: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.Write("Ano do Nascimento: ");
                        ano = int.Parse(Console.ReadLine());

                        contatos.Adicionar(new Contato(nome, email, telefone, new Data(dia, mes, ano)));
                        Console.Clear();
                        Console.Write("Salvo!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;

                    case "2":
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Email: ");
                        email = Console.ReadLine();

                        var contact = contatos.Pesquisar(new Contato(nome, email, "", new Data(0, 0, 0)));
                        Console.Clear();
                        Console.WriteLine(contact);
                        Console.WriteLine("Pressiona qualquer tecla para Continuar");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Email: ");
                        email = Console.ReadLine();
                        Console.Write("Telefone: ");
                        telefone = Console.ReadLine();

                        Console.Write("Dia do Nascimento: ");
                        dia = int.Parse(Console.ReadLine());
                        Console.Write("Mes do Nascimento: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.Write("Ano do Nascimento: ");
                        ano = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine(contatos.Alterar(new Contato(nome, email, telefone, new Data(dia, mes, ano))) ? "Atualizado": "Não foi possivel atualizar.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;

                    case "4":
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Email: ");
                        email = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(contatos.Remover(new Contato(nome, email, "", new Data(0, 0, 0))) ? "Removido": "Não foi possivel remover");
                        Console.WriteLine("Pressiona qualquer tecla para Continuar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        contatos.getAllContacts().ForEach(x =>
                        {
                            Console.WriteLine(x);
                        });
                        Console.WriteLine(contatos.getAllContacts().Count < 0 ? "Não há contatos": "");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }

            } 
            while (valor != "0");

        }
    }
}
