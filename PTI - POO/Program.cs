using System;

public abstract class Veiculo
{
    protected double TaxaDiaria { get; set; }

    public Veiculo(double taxaDiaria)
    {
        TaxaDiaria = taxaDiaria;
    }

    public abstract double CalcularValorTotal(int numDiarias);
}

public class Carro : Veiculo
{
    public Carro() : base(50) { }

    public override double CalcularValorTotal(int numDiarias)
    {
        return TaxaDiaria * numDiarias;
    }
}

public class Moto : Veiculo
{
    public Moto() : base(25) { }

    public override double CalcularValorTotal(int numDiarias)
    {
        return TaxaDiaria * numDiarias;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Carro carro = new Carro();
        Moto moto = new Moto();

        int numDiarias = 10;

        double valorTotalCarro = carro.CalcularValorTotal(numDiarias);
        double valorTotalMoto = moto.CalcularValorTotal(numDiarias);

        Console.WriteLine($"Valor total para 10 diárias de um carro: R${valorTotalCarro}");
        Console.WriteLine($"Valor total para 10 diárias de uma moto: R${valorTotalMoto}");
    }
}
