using System;

namespace Atividade_15_12_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "0";
         
            do
            {
                Console.WriteLine(
                    "0. Sair \n" +
                    "1. Adicionar livro \n" +
                    "2. Pesquisar livro (sintético) \n" +
                    "3. Pesquisar livro (analítico) \n" +
                    "4. Adicionar exemplar \n" +
                    "5. Registrar empréstimo \n" +
                    "6. Registrar devolução \n" +
                    "\n" +
                    "O que deseja fazer??");
               valor = Console.ReadLine();
                switch (valor)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
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
