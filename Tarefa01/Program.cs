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

        public static Venda gerarVenda()
        {            
            Console.Write("Quantidade vendido?: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Valor da venda?: ");
            double y = double.Parse(Console.ReadLine());

            Venda venda = new Venda(x, y);

            return venda;

        }
        static void Main(string[] args)
        {
            Vendedores vendedores = new Vendedores();
            Vendedor vendedor = new Vendedor();
            int exit;
            int count = 0; 
            do
            {
              
                Console.WriteLine("0 - SAIR");
                Console.WriteLine("1 - Cadastrar Vendedor");
                Console.WriteLine("2 - Consultar vendedor");
                Console.WriteLine("3 - Excluir vendedor");
                Console.WriteLine("4 - Registrar venda");
                Console.WriteLine("5 - Listar vendedores \n");

                Console.Write("O que deseja fazer? ");
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
                    case 4:
                        if(count < 3)
                        {
                            Console.Write("Qual dia da venda?: ");
                            int dia = int.Parse(Console.ReadLine());
                            vendedor.registrarVenda(dia, gerarVenda());
                        }                        
                        Console.Clear();
                        count++;
                        Console.WriteLine(count > 3 ? "Execedeu o limite máximo de regitro" : "Salvo!");
                        Thread.Sleep(3000);
                        
                        Console.Clear();
                        break;
                }
            }
            while( exit != 0); 

        }
    }
}
