public class Animal
{
    public string Nome { get; set; }

public virtual void Falar()
    {
        Console.WriteLine("*Selecione um animal (Cachorro ou Gato)*");
    }
}

public class Cachorro : Animal
{
    public override void Falar()
    {
        Console.WriteLine($"{Nome}: Au au!");
    }
}

public class Gato : Animal
{
    public override void Falar()
    {
        Console.WriteLine($"{Nome}: Miau!");
    }
}