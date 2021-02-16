using System;

namespace Herança
{
    class VeiculoAutoMotor
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("Veiculo acelerando..");
        }

        public void Ligar()
        {
            Console.WriteLine("Veiculo ligado.");
        }
    }

    // Neste momento a anotação : - dois pontos simboliza herança
    // neste caso nossa classe carro herda a classe veiculo auto motor sendo assim
    // todas as propriedades da classe pai sendo acessiveis serão herdadas
    class Carro: VeiculoAutoMotor
    {
        public void LigarAr()
        {
            Console.WriteLine("Ar ligado");
        }
    }

    // A classe moto segue a mesma premissa da anterior
    class Moto: VeiculoAutoMotor
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Cria um objeto ja prenchendo as propriedaddes do mesmo
            Carro carro = new Carro 
            { 
                Marca = "Chevrolet",
                Modelo = "Onix",
                Placa = "FHW-8975"
            };
            EscreverVeiculo(carro);
            // Invoca metodo especifico da classe
            carro.LigarAr();

            Console.WriteLine("-----------------------------------------------------------------------------");

            Moto moto = new Moto
            {
                Marca = "Honda",
                Modelo = "CG125",
                Placa = "FHR-2589"
            };
            EscreverVeiculo(moto);

            Console.ReadKey();
        }

        // Metodo para trabalhar com o objeto em comum
        private static void EscreverVeiculo(VeiculoAutoMotor veiculoAutoMotor)
        {
            Console.WriteLine($"Marca: {veiculoAutoMotor.Marca} | Modelo: {veiculoAutoMotor.Modelo} | Placa: {veiculoAutoMotor.Placa}");
            veiculoAutoMotor.Acelerar();
            veiculoAutoMotor.Ligar();
        }
    }
}
