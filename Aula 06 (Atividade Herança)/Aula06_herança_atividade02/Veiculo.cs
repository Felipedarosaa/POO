namespace Aula06_herança_atividade02
{
    // Classe veiculo
    public class Veiculo
    {
        public string Modelo { get; set; }

        public virtual void Acelerar()
        {
            Console.WriteLine("*Selecione um veículo (Carro ou Moto)*");
        }
    }

    // Classe Carro
    public class Carro : Veiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine($"Modelo: {Modelo}. Acelerando o Carro!");
        }
    }

    // Classe Moto
    public class Moto : Veiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine($"Modelo: {Modelo}. Acelerando a Moto!");
        }
    }

}