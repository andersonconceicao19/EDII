using System;
using System.Threading;

namespace Tarefa01
{
    class Program
    {
        
        public static Vendedor gerarVendedor()
        {            
            Console.Write("Nome do Vendedor: ");
            string Nome = Console.ReadLine();
            Vendedor vendedor = new Vendedor(1, Nome, 0, null);
            return vendedor;
            
        }
        static void Main(string[] args)
        {
            Vendedores vendedores = new Vendedores();
            int exit;
            do
            {
                 //Console.Clear();

                Console.WriteLine("0 - SAIR");
                Console.WriteLine("1 - Cadastrar Vendedor");
                Console.WriteLine("2 - Consultar vendedor");
                Console.WriteLine("3 - Excluir vendedor");
                Console.WriteLine("4 - Registrar venda");
                Console.WriteLine("5 - Listar vendedores ");

                Console.Write("\n O que deseja fazer? ");
                exit = int.Parse(Console.ReadLine());

                switch (exit)
                {
                    case 1:
                        bool result =  vendedores.addVendedor(gerarVendedor());
                        Console.Clear();
                        Console.WriteLine(result ? "Salvo": "Não foi possivel cadastrar. Excedeu o limite de Cadastro");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break; 
                }
            }
            while( exit != 0);
            
       

        }
    }
}
