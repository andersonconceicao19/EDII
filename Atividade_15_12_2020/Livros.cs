using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_15_12_2020
{
    public class Livros
    {
        public Livros()
        {
            Acervo = new List<Livro>();
        }
        public List<Livro> Acervo { get; private set; }

        public void adicionar(Livro livro)
        {
            Acervo.Add(livro);
        }
        public Livro pesquisar()
        {
            var livros = new Livro();
            return livros;
        }
        public Livro getLivroPorISBN(int ibsn)
        {
            foreach (var item in Acervo)
            {
               if(item.ISBN == ibsn)
                {
                    
                    return item;
                }
            }
            return null;
        }
    }
    /*
     
------------------------------------
| Livros                           |
|----------------------------------|
| - acervo: List<Livro>            |
|----------------------------------|
| + adicionar(Livro livro): void   |
| + pesquisar(Livro livro): Livro  |
------------------------------------
     */
}
