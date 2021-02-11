using System;

namespace Abstracao
{
    /*
        Exemplo 1 - Imagine um ambiente em que controlamos livros de uma biblioteca apesar dos mesmos terem 
        (Autor, Editora, Nome, Número de Páginas, Cor da Capa, etc..), para nosso ambiente necessitamos 
        somente de Autor, Editora e Nome.
    */

    // Classe Livro abstraida e criada
    // Isto é uma classe ainda representa o que será o objeto apos criado
    public class Livro
    {
        public string Autor { get; set; }
        public string Nome { get; set; }
        public string Editora { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Neste momento eu crio a instancia de livro após o new terei um novo objeto.
            Livro livro = new Livro();
            livro.Autor = "Stallos";
            livro.Editora = "Stallos Editora";
            livro.Nome = "Stallos Orientação a Objetos";

            // Imprimo na tela os dados do livro
            Console.WriteLine("Livro : " + livro.Nome);
            Console.WriteLine("Autor: " + livro.Autor);
            Console.WriteLine("Editora: " + livro.Editora);

            // Paro o console para que o mesmo não feche automaticamente.
            Console.ReadKey();
        }
    }
}
