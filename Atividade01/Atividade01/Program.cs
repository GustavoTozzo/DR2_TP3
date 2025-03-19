using System;

class Carro
{
    // atributos 
    public string Modelo;
    public int Velocidade;

    // método que acelera o carro
    public void Acelerar(int incremento)
    {
        Velocidade += incremento;
        Console.WriteLine($"{Modelo} acelerou para {Velocidade} km/h.");
    }
}

class Program
{
    static void Main()
    {
        // criando um objeto da classe "Carro"
        Carro meuCarro = new Carro();
        meuCarro.Modelo = "Fusca";
        meuCarro.Velocidade = 0;

        // chamando o método "Acelerar"
        meuCarro.Acelerar(20);

    }
}
