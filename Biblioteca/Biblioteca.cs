using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Biblioteca
    {
        public int qtd_livros;
        public List<Livro> ds_catalogo;

        public Biblioteca()
        {
            qtd_livros = 0;
            ds_catalogo = new List<Livro>();
        }

        public void AdicionarLivro(Livro livro)
        {
            ds_catalogo.Add(livro);
            qtd_livros++;
        }

        public void RemoverLivro(Livro livro)
        {
            for (int i = 0; i < ds_catalogo.Count; i++)
            {
                if (ds_catalogo[i] == livro)
                {
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Livro {0} encontrado e removido", livro.titulo);
                    ds_catalogo.Remove(livro);
                    qtd_livros--;
                }
                else
                {
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Livro {0} não encontrado", livro.titulo);
                }
                   
            }
        }

        public void AlugarLivro(Livro livro, Pessoa pessoa)
        {
            if(pessoa.Nome == null & pessoa.Cpf == null)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Essa pessoa {0} tem dados incompletos", pessoa.Nome);
            }
            else if(pessoa.pegou_livro == true){
                Console.WriteLine("-----------------");
                Console.WriteLine("Essa pessoa {0} já pegou um livro",pessoa.Nome);
            } 
            else
            {
                for (int i = 0; i < ds_catalogo.Count; i++)
                {
                    if (ds_catalogo[i] == livro)
                    {
                        Console.WriteLine("-----------------");
                        Console.WriteLine("Pessoa: {0}", pessoa.Nome);
                        Console.WriteLine("Livro {0} encontrado", livro.titulo);
                        ds_catalogo.Remove(livro);
                        pessoa.pegou_livro = true;
                        qtd_livros--;
                    }
                    else
                    {
                        Console.WriteLine("-----------------");
                        Console.WriteLine("Livro {0} não encontrado", livro.titulo);
                    }
                        
                }
            }
                
        }

    }
}
