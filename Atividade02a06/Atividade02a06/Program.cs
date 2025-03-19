class Ingresso
{
        public string NomeDoShow;         // nome do evento
        public double Preco;              // preço do ingresso
        public int QuantidadeDisponivel;  // número de ingressos disponíveis

    // método para alterar o preço do ingresso
    public void AlterarPreco(double novoPreco)
    {
        Preco = novoPreco;
        Console.WriteLine($"O preço do ingresso para '{NomeDoShow}' foi atualizado para R$ {Preco:F2}.");
    }

    // método para alterar a quantidade disponível de ingressos
    public void AlterarQuantidade(int novaQuantidade)
    {
        QuantidadeDisponivel = novaQuantidade;
        Console.WriteLine($"A quantidade disponível para '{NomeDoShow}' agora é {QuantidadeDisponivel} ingressos.");
    }

    // métodos GET 
    public string GetNomeDoShow()
    {
        return NomeDoShow;
    }

    public double GetPreco()
    {
        return Preco;
    }

    public int GetQuantidadeDisponivel()
    {
        return QuantidadeDisponivel;
    }

    // métodos SET
    public void SetNomeDoShow(string novoNome)
    {
        NomeDoShow = novoNome;
    }

    public void SetPreco(double novoPreco)
    {
        Preco = novoPreco;
    }

    public void SetQuantidadeDisponivel(int novaQtd)
    {
        QuantidadeDisponivel = novaQtd;
    }

    // método para exibir as informações do ingresso
    public void ExibirInformacoes()
    {
        Console.WriteLine("-- Informações sobre os ingressos --");
        Console.WriteLine($"Show: {NomeDoShow}");
        Console.WriteLine($"Preço: R$ {Preco:F2}");
        Console.WriteLine($"Ingressos disponíveis: {QuantidadeDisponivel}");
    }

    public void ExibirInformacoesAtualizadas()
    {
        Console.WriteLine("-- Informações sobre os ingressos atualizadas --");
        Console.WriteLine($"Show: {NomeDoShow}");
        Console.WriteLine($"Preço: R$ {Preco:F2}");
        Console.WriteLine($"Ingressos disponíveis: {QuantidadeDisponivel}");
    }
}

// uso da classe
class Program
{
    static void Main()
    {
        // criando um ingresso
        Ingresso ingresso1 = new Ingresso();

        ingresso1.NomeDoShow = "Lollapalooza";
        ingresso1.Preco = 350.00;
        ingresso1.QuantidadeDisponivel = 100;

        ingresso1.ExibirInformacoes();

        ingresso1.AlterarPreco(400.00);
        ingresso1.AlterarQuantidade(80);

        ingresso1.ExibirInformacoesAtualizadas();

        // utilizando GET e SET para alterar os valores 
        Ingresso ingresso2 = new Ingresso();

        ingresso2.NomeDoShow = "Rock in Rio";
        ingresso2.Preco = 550.00;
        ingresso2.QuantidadeDisponivel = 80;

        ingresso2.ExibirInformacoes();
     
        ingresso2.SetPreco(680.00);
        ingresso2.SetQuantidadeDisponivel(50);

        ingresso2.ExibirInformacoesAtualizadas();


    }
}