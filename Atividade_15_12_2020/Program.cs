using System;
using System.Threading;

namespace Atividade_15_12_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Livros livros = new Livros();
            string valor = "0";
         
            do
            {
                Console.Write(
                    "0. Sair \n" +
                    "1. Adicionar livro \n" +
                    "2. Pesquisar livro (sintético) \n" +
                    "3. Pesquisar livro (analítico) \n" +
                    "4. Adicionar exemplar \n" +
                    "5. Registrar emprestimo \n" +
                    "6. Registrar devolução \n" +
                    "\n" +
                    "O que deseja fazer? : ");
               valor = Console.ReadLine();
                switch (valor)
                {
                    case "1":
                        Console.Write("IBSN: ");
                        int ibsn = int.Parse(Console.ReadLine());
                        Console.Write("Titulo: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Autor: ");
                        string autor = Console.ReadLine();
                        Console.Write("Editora: ");
                        string editora = Console.ReadLine();
                        livros.adicionar(new Livro(ibsn,titulo, autor, editora));
                        Console.Clear();

                        Console.Write("Cadastrado");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case "2":

                        break;
                    case "3":
                        break;
                    case "4":
                        Console.Write("ISBN DO EXEMPLAR: ");
                        int isbnPartial = int.Parse(Console.ReadLine());
                        var result = livros.getLivroPorISBN(isbnPartial);
                        if (result == null)
                        {
                            Console.Clear();
                            
                            Console.Write("ISBN do livronão cadastrado! ");
                            Thread.Sleep(1000);
                            Console.Clear();
                            break;
                        }
                        Console.Clear();
                    
                        result.adicionarExemplar();
                        Console.Clear();
                        
                        Console.Write("ISBN Cadastrado!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case "5":
                        Console.Write("ISBN DO EXEMPLAR: ");
                        int isbnPartial1 = int.Parse(Console.ReadLine());
                        var result1 = livros.getLivroPorISBN(isbnPartial1);
                        var n =  result1.emprestar();
                        Console.Clear();
                        Console.WriteLine(n ? "Emprestado" : "Livro não disponivel!");
                        Thread.Sleep(1000);
                        break;
                    case "6":
                        Console.Write("ISBN DO EXEMPLAR: ");
                        int isbnPartial2 = int.Parse(Console.ReadLine());
                        var result2 = livros.getLivroPorISBN(isbnPartial2);

                        var n1 = result2.devolver();
                        Console.Clear();
                        Console.WriteLine(n1 ? "Devolução efetuada com sucesso" : "O livro já foi devolvido");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
            } 
            while (valor != "0");

            
        }
    }
}
