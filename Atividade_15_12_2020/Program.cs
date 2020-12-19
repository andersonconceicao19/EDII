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
            int isbn;
            Livro result;
         
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
                        try
                        {
                            Console.Write("IBSN: ");
                            isbn = int.Parse(Console.ReadLine());
                            Console.Write("Titulo: ");
                            string titulo = Console.ReadLine();
                            Console.Write("Autor: ");
                            string autor = Console.ReadLine();
                            Console.Write("Editora: ");
                            string editora = Console.ReadLine();
                            livros.adicionar(new Livro(isbn, titulo, autor, editora));
                            Console.Clear();

                            Console.Write("Cadastrado!");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Thread.Sleep(2000);
                            Console.Write("TENTE OUTRA VEZ");
                            Console.Clear();

                        }
                        break;
                    case "2":
                        try
                        {
                            Console.Write("ISBN DO EXEMPLAR QUE DESEJA: ");
                            isbn = int.Parse(Console.ReadLine());
                            result = livros.getLivroPorISBN(isbn);

                            Console.Clear();
                            Console.WriteLine(result.sintetico());
                            Console.WriteLine($" \n \n \n Pressione qualquer tecla para continuar");
                            Console.ReadLine();
                            Console.Clear();
                           
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.Write("Verifique se ha algo registrado ne fio");
                            Console.Clear();
                        }
                        break;
                    case "3":
                        try
                        {
                            Console.Write("ISBN DO EXEMPLAR QUE DESEJA: ");
                            isbn = int.Parse(Console.ReadLine());
                            result = livros.getLivroPorISBN(isbn);
                            Console.Clear();
                            Console.WriteLine(result.analitico());
                            Console.WriteLine($" \n \n \n Pressione qualquer tecla para continuar");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Thread.Sleep(2000);
                            Console.Write("TENTE OUTRA VEZ");
                            Console.Clear();
                        }
                        break;
                    case "4":
                        try
                        {
                            Console.Write("ISBN DO EXEMPLAR: ");
                            isbn = int.Parse(Console.ReadLine());
                            result = livros.getLivroPorISBN(isbn);
                            if (result == null)
                            {
                                Console.Clear();

                                Console.Write("ISBN do livro não cadastrado! ");
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

                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Thread.Sleep(2000);
                            Console.Write("TENTE OUTRA VEZ");
                            Console.Clear();
                        }
                        break;
                    case "5":
                        try
                        {
                            Console.Write("ISBN DO EXEMPLAR: ");
                            isbn = int.Parse(Console.ReadLine());
                            result = livros.getLivroPorISBN(isbn);
                            var n = result.emprestar();
                            Console.Clear();
                            Console.WriteLine(n ? "Emprestado" : "Livro não disponivel!");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Thread.Sleep(2000);
                            Console.Write("TENTE OUTRA VEZ");
                            Console.Clear();
                        }
                        break;
                    case "6":
                        try
                        {
                            Console.Write("ISBN DO EXEMPLAR: ");
                            isbn = int.Parse(Console.ReadLine());
                            result = livros.getLivroPorISBN(isbn);

                            var n1 = result.devolver();
                            Console.Clear();
                            Console.WriteLine(n1 ? "Devolução efetuada com sucesso" : "O livro já foi devolvido");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Thread.Sleep(2000);
                            Console.Write("TENTE OUTRA VEZ");
                            Console.Clear();
                        }
                        break;
                }
            } 
            while (valor != "0");


        }
    }
}
