using System;

public class Matricula
{
    public string NomeDoAluno;
    public string Curso;
    public int NumeroMatricula;
    public string Situacao;
    public string DataInicial;

    // construtor para inicializar uma matrícula
    public Matricula(string nomeDoAluno, string curso, int numeroMatricula, string situacao, string dataInicial)
    {
        NomeDoAluno = nomeDoAluno;
        Curso = curso;
        NumeroMatricula = numeroMatricula;
        Situacao = situacao;
        DataInicial = dataInicial;
    }

    // método para trancar a matrícula
    public void Trancar()
    {
        Situacao = "Trancada";
        Console.WriteLine("A matrícula foi trancada com sucesso.");
    }

    // método para reativar a matrícula
    public void Reativar()
    {
        Situacao = "Ativa";
        Console.WriteLine("A matrícula foi reativada com sucesso.");
    }

    // método para exibir detalhes da matrícula
    public void ExibirInformacoes()
    {
        Console.WriteLine("- Dados da Matrícula -");
        Console.WriteLine($"Nome do Aluno: {NomeDoAluno}");
        Console.WriteLine($"Curso: {Curso}");
        Console.WriteLine($"Número da Matrícula: {NumeroMatricula}");
        Console.WriteLine($"Situação: {Situacao}");
        Console.WriteLine($"Data Inicial: {DataInicial}");
        Console.WriteLine("-----------------------------------------\n");
    }
}

public class TestaMatricula
{
    public static void Main()
    {
        Matricula matricula = new Matricula("Gustavo Tozzo", "Análise e Desenvolvimento de Sistemas", 12345, "Ativa", "01/01/2021");

        matricula.ExibirInformacoes();

        // trancando a matrícula
        matricula.Trancar();
        matricula.ExibirInformacoes();

        // reativando a matrícula
        matricula.Reativar();
        matricula.ExibirInformacoes();
    }
}
