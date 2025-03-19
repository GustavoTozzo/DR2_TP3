using System;

class Ingresso
{
        // atributos do ingresso
        private string NomeDoShow;
        private double Preco;
        private int QuantidadeDisponivel;

        // construtor para inicializar os atributos obrigatórios
        public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
        {
            NomeDoShow = nomeDoShow;
            Preco = preco;
            QuantidadeDisponivel = quantidadeDisponivel;
        }

        // métodos GET 
        public string GetNomeDoShow() => NomeDoShow;
        public double GetPreco() => Preco;
        public int GetQuantidadeDisponivel() => QuantidadeDisponivel;

        // métodos SET (para modificação direta)
        public void SetNomeDoShow(string novoNome) => NomeDoShow = novoNome;
        public void SetPreco(double novoPreco) => Preco = novoPreco;
        public void SetQuantidadeDisponivel(int novaQtd) => QuantidadeDisponivel = novaQtd;

        // atualizar o preço
        public void AlterarPreco(double novoPreco)
        {
            if (novoPreco > 0)
            {
                Preco = novoPreco;
            }
        }

        // atualizar a quantidade de ingressos.
        public void AlterarQuantidade(int novaQuantidade)
        {
            if (novaQuantidade >= 0)
            {
                QuantidadeDisponivel = novaQuantidade;
            }
             Console.WriteLine("\nINFORMAÇÃO IMPORTANTE: Com o fim do primeiro lote, o valor do ingresso será atualizado.");

    }

    // Método para exibir informações do ingresso
    public void ExibirInformacoes()
        {
            Console.WriteLine($"Show: {NomeDoShow}");
            Console.WriteLine($"Preço: R$ {Preco:F2}");
            Console.WriteLine($"Ingressos disponíveis: {QuantidadeDisponivel}");
        }
}




// classe principal para testar o construtor
class Program
{
    static void Main()
    {
        // criando um objeto Ingresso usando o construtor
        Ingresso ingresso1 = new Ingresso("Lollapalooza", 400.00, 100);

        // exibindo informações iniciais
        Console.WriteLine("--- Informações Iniciais ---");
        ingresso1.ExibirInformacoes();

        // atualizando o preço do ingresso e a quantidade
        ingresso1.AlterarPreco(500.00);
        ingresso1.AlterarQuantidade(80);

        // exibindo informações atualizadas
        Console.WriteLine("\n--- Informações Atualizadas ---");
        ingresso1.ExibirInformacoes();
    }
}
