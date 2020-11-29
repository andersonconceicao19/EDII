using System;
using System.Threading;

namespace Tarefa01
{
    class Program
    {
        public static int idGenerate = 0;
        public static Vendedor gerarVendedor()
        {            
            Console.Write("Nome do Vendedor: ");
            string Nome = Console.ReadLine();
            Vendedor vendedor = new Vendedor(idGenerate ,Nome);
            idGenerate++;
            return vendedor;
        }

        public static Venda gerarVenda()
        {            
            Console.Write("Quantidade vendido?: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Valor da venda?: ");
            double y = double.Parse(Console.ReadLine());
            
            int dia;
            do
            {
                Console.Write("Qual dia da venda?: ");
                dia = int.Parse(Console.ReadLine());
                Thread.Sleep(1000);
            } while (dia < 1 || dia > 30);
            Venda venda = new Venda(x, y, dia);

            return venda;

        }
        static void Main(string[] args)
        {
            Vendedores vendedores = new Vendedores();
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
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("IDentificação do funcionario: ");
                        int vendedorId   = int.Parse(Console.ReadLine());
                        var vend = vendedores.searchVendedor(vendedorId);
                        if(vend != null)
                        {
                            Console.Clear();
                            Console.WriteLine($"\nId: {vend.Id}, Nome: {vend.Nome} \n");
                            foreach (var item in vend.AsVendas)
                            {
                                Console.WriteLine(item.Dia != 0 ? $"Dia da venda: {item.Dia}, Quantidade: {item.Quantidade}, Valor: {item.Valor}" : "");
                            }
                            Console.Write("Pressione Enter Para voltar.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        Console.Write("Id do vendedor que deseja excluir: ");
                        vendedorId = int.Parse(Console.ReadLine());
                        result = vendedores.delVendedor(vendedorId);
                        Console.Clear();
                        Console.Write(result ? "Removido com Sucesso!" : "Não foi possivel remover, o Vendedor possui vendas!");
                        Thread.Sleep(1000);
                        Console.Clear();                        
                        break;
                    case 4:
                        if(count < 3)
                        {
                            Console.Write("ID do vendedor?: ");
                            int idvendedor = int.Parse(Console.ReadLine());
                            vendedores.registrarVenda(idvendedor, gerarVenda());
                        }                        
                        Console.Clear();
                        count++;
                        Console.WriteLine(count > 3 ? "Execedeu o limite máximo de regitro" : "Registrado com Sucesso!!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case 5:
                        var getVendedor = vendedores.PegarTodosVendores();
                        Console.Clear();
                        for (int i = 0; i < getVendedor.Length; i++)
                        {
                            if (getVendedor[i].Id > -1)
                            {
                                Console.WriteLine($"ID: {getVendedor[i].Id}, Nome: {getVendedor[i].Nome}");
                            }
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
            while( exit != 0); 

        }
    }
}
