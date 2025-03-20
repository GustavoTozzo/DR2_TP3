using System;

public class Circulo
{
    public double Raio; // O raio de um círculo é a distância entre o centro da figura e qualquer ponto da sua borda

    public Circulo(double raio)
    {
        Raio = raio;
    }

    // método para calcular a área do círculo
    public double CalcularArea()
    {
        return Math.PI * (Raio * Raio);
    }
}

public class Esfera
{
    public double Raio; // O raio de um círculo é a distância entre o centro da figura e qualquer ponto da sua borda

    public Esfera(double raio)
    {
        Raio = raio;
    }

    // método para calcular o volume da esfera
    public double CalcularVolume()
    {
        return (4.0 / 3.0) * Math.PI * (Raio * Raio * Raio);
    }
}

public class TestaFiguras
{
    public static void Main()
    {
        // criando um círculo com raio 3
        Circulo circulo = new Circulo(3);
        Console.WriteLine($"Área do Círculo (raio = 3): {circulo.CalcularArea():F2}");

        // criando uma esfera com raio 5
        Esfera esfera = new Esfera(5);
        Console.WriteLine($"Volume da Esfera (raio = 5): {esfera.CalcularVolume():F2}");
    }
}