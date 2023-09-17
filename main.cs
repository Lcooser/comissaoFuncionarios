using System;

class Funcionario
{
    public string Nome { get; }
    public double ValorVenda { get; }

    public Funcionario(string nome, double valorVenda)
    {
        Nome = nome;
        ValorVenda = valorVenda;
    }

    public virtual double CalcularComissao() => ValorVenda * 0.05;

    public override string ToString() => $"Nome: {Nome}, Comissão: {CalcularComissao():C}";
}

class AssistenteComercial : Funcionario
{
    public AssistenteComercial(string nome, double valorVenda) : base(nome, valorVenda) { }
}

class AnalistaDeVendas : Funcionario
{
    public AnalistaDeVendas(string nome, double valorVenda) : base(nome, valorVenda) { }

    public override double CalcularComissao() => base.CalcularComissao() + ValorVenda * 0.10;
}

class Especialista : Funcionario
{
    public Especialista(string nome, double valorVenda) : base(nome, valorVenda) { }

    public override double CalcularComissao() => ValorVenda * 0.30;
}

class Program
{
    static void Main()
    {
        var assistente = new AssistenteComercial("João", 5000);
        var analista = new AnalistaDeVendas("Maria", 8000);
        var especialista = new Especialista("Carlos", 10000);

        Console.WriteLine(assistente);
        Console.WriteLine(analista);
        Console.WriteLine(especialista);
    }
}
