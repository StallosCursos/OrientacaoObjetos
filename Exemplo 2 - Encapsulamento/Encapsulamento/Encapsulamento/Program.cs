using System;

namespace Encapsulamento
{
    // Declaramos a classe usuario
    class Usuario
    {        
        private bool _maiorDeIdade;
        private int _idade;

        // Metodo get e set é utilizado para encapsular os dados da classe
        // get busca valor de algum apontamento
        // set atribui valo a um apontamento
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        // Esta propriedade expoem o dado ja trabalhando pelo polimorfismo
        public bool MaiorDeIdade { get => _maiorDeIdade; }

        // Quando receber a idade por meio de encapsulamento a propriedade Maior de Idade
        // é praparada ficando disponivel para uso.
        public int Idade 
        { 
            get => _idade;
            set 
            {
                _idade = value;
                _maiorDeIdade = value > 18;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuarioJose  = new Usuario();
            usuarioJose.Nome = "José";
            usuarioJose.Sobrenome = "Silva";
            usuarioJose.Idade = 25;

            Usuario usuarioJoao = new Usuario();
            usuarioJoao.Nome = "João";
            usuarioJoao.Sobrenome = "Silva";
            usuarioJoao.Idade = 17;

            ImprimirUsuario(usuarioJose);
            ImprimirUsuario(usuarioJoao);

            Console.ReadKey();
        }

        private static void ImprimirUsuario(Usuario usuario)
        {
            Console.WriteLine($"Usuario : {usuario.Nome} {usuario.Sobrenome}");

            if (usuario.MaiorDeIdade)
                Console.WriteLine("É maior de Idade.");
            else
                Console.WriteLine("É menor de Idade.");

            Console.WriteLine("----------------------------------------------");
        }
    }
}
