using System;

namespace Polimorfismo
{
    class VeiculoAutoMotor
    {
        protected int Velocidade  = 40;

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }

        public virtual void Acelerar()
        {
            Velocidade += 5;
            Console.WriteLine($"Veiculo acelerando á {Velocidade} Km/h..");
        }

        public virtual void Ligar()
        {
            Console.WriteLine("Veiculo ligado.");
        }

        // O metodo com o mesmo nome porem com parametros diferentes cria um overload
        // Adicionando um metodo a mais na classe com o mesmo nome porem com compartamento diferente
        public void Acelerar(int Velocidade)
        {
            this.Velocidade = this.Velocidade + Velocidade;
            Console.WriteLine($"Veiculo acelerando á {this.Velocidade} Km/h..");
        }
    }

    class Carro : VeiculoAutoMotor
    {
        // A anotação override - faz a reescrita do metodo mudando seu comportamento do metodo da classe pai
        // para o novo comportamento implementado
        public override void Acelerar()
        {
            base.Acelerar();
            Console.WriteLine($"Carro {this.Marca} - {this.Modelo} Acelerando á {Velocidade}");
        }

        public override void Ligar()
        {
            Console.WriteLine($"Carro {this.Marca} - {this.Modelo} ligado");
        }
    }

    class Moto : VeiculoAutoMotor
    {
        public override void Acelerar()
        {
            this.Velocidade += 20;
            Console.WriteLine($"Moto {this.Marca} - {this.Modelo} Acelerando á {Velocidade}");
        }

        public override void Ligar()
        {
            Console.WriteLine($"Moto {this.Marca} - {this.Modelo} ligado");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro
            {
                Marca = "Chevrolet",
                Modelo = "Onix",
                Placa = "FHW-8975"
            };

            Moto moto = new Moto
            {
                Marca = "Honda",
                Modelo = "CG125",
                Placa = "FHR-2589"
            };

            EscreverVeiculo(carro);
            EscreverVeiculo(moto);

            Console.ReadKey();
        }

        private static void EscreverVeiculo(VeiculoAutoMotor veiculoAutoMotor)
        {
            Console.WriteLine($"Marca: {veiculoAutoMotor.Marca} | Modelo: {veiculoAutoMotor.Modelo} | Placa: {veiculoAutoMotor.Placa}");
            veiculoAutoMotor.Acelerar();
            veiculoAutoMotor.Acelerar(20);
            veiculoAutoMotor.Ligar();
            Console.WriteLine("-----------------------------------------------------------------------------");
        }
    }
}
