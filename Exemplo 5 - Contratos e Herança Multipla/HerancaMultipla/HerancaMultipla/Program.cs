using System;

namespace HerancaMultipla
{
    public interface MovimentacaoHorizontal
    {
        public void Esquerda();
        public void Direita();
    }

    public interface MovimentacaoVertical
    {
        public void Frente();
        public void Atraz();
    }

    public class Maquina : MovimentacaoHorizontal, MovimentacaoVertical
    {
        public void Atraz()
        {
            Console.WriteLine("Movendo-se para traz");
        }

        public void Direita()
        {
            Console.WriteLine("Movendo-se para direita");
        }

        public void Esquerda()
        {
            Console.WriteLine("Movendo-se para esquerda");
        }

        public void Frente()
        {
            Console.WriteLine("Movendo-se para frente");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Maquina maquina = new Maquina();

            Console.WriteLine("Movimentação por overload e interfaces");

            ExecutarMovimentos(maquina as MovimentacaoHorizontal);
            ExecutarMovimentos(maquina as MovimentacaoVertical);

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Movimentação por intancia de classe");
            maquina.Direita();
            maquina.Esquerda();
            maquina.Frente();
            maquina.Atraz();

            Console.ReadKey();
        }

        public static void ExecutarMovimentos(MovimentacaoHorizontal movimentacaoHorizontal)
        {
            movimentacaoHorizontal.Direita();
            movimentacaoHorizontal.Esquerda();
        }

        public static void ExecutarMovimentos(MovimentacaoVertical movimentacaoVertical)
        {
            movimentacaoVertical.Frente();
            movimentacaoVertical.Atraz();
        }
    }
}
