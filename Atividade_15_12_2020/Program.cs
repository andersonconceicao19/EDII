using System;

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
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        Console.Write("Ibsn do bgl: ");
                        int bla = int.Parse(Console.ReadLine());
                        var result = livros.getLivroPorISBN(bla);
                        // result.adicionarExemplar(this);
                        break;
                    case "5":
                        
                        break;
                    case "6":
                        break;
                }
            } 
            while (valor != "0");

            
        }
    }
}
