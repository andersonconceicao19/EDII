﻿using System;

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
                        Console.Write("ISBN DO EXEMPLAR: ");
                        int isbnPartial = int.Parse(Console.ReadLine());
                        var result = livros.getLivroPorISBN(isbnPartial);
                        if (result == null) break;
                        Console.Clear();
                    
                        result.adicionarExemplar();

                        // Console.WriteLine($"IBSN {result.Titulo}");
                        break;
                    case "5":
                        Console.Write("ISBN DO EXEMPLAR: ");
                        int isbnPartial1 = int.Parse(Console.ReadLine());
                        var result1 = livros.getLivroPorISBN(isbnPartial1);
                        var n =  result1.emprestar();
                        Console.WriteLine(n ? "Emprestado" : "Livro não disponivel!");
                        break;
                    case "6":
                        break;
                }
            } 
            while (valor != "0");

            
        }
    }
}
