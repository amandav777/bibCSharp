using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Lendo o arquivo e obtendo a lista de produtos
        string arquivo = "relatorio-ti.txt";
        List<(string, double, string)> produtos = LerArquivo(arquivo);

        // Calculando e imprimindo as respostas
        Console.WriteLine("1. Média de preços dos produtos: " + MediaPrecos(produtos));
        Console.WriteLine("2. Produtos com preço maior que R$ 700,00:");
        foreach (var produto in ProdutosMaior700(produtos))
        {
            Console.WriteLine($"   Produto: {produto.Item1}, Preço: R${produto.Item2:F2}, Categoria: {produto.Item3}");
        }
        var (quantidadePerifericos, somaPerifericos) = PerifericosQuantidadeSoma(produtos);
        Console.WriteLine("3. Quantidade de produtos da categoria 'periféricos': " + quantidadePerifericos);
        Console.WriteLine("   Soma dos valores dos produtos da categoria 'periféricos': " + somaPerifericos);
        Console.WriteLine("4. Produtos com valor menor que R$ 100,00:");
        ImprimirProdutosMenor100(produtos);
    }

    // Método para ler o arquivo e converter para uma lista de tuplas
    static List<(string, double, string)> LerArquivo(string arquivo)
    {
        List<(string, double, string)> produtos = new List<(string, double, string)>();
        string[] linhas = File.ReadAllLines(arquivo);
        foreach (string linha in linhas)
        {
            string[] dados = linha.Split(',');
            produtos.Add((dados[0], Convert.ToDouble(dados[1]), dados[2]));
        }
        return produtos;
    }

    // Método para calcular a média de preços dos produtos
    static double MediaPrecos(List<(string, double, string)> produtos)
    {
        return produtos.Select(p => p.Item2).Average();
    }

    // Método para encontrar produtos com preço maior que R$ 700,00
    static IEnumerable<(string, double, string)> ProdutosMaior700(List<(string, double, string)> produtos)
    {
        return produtos.Where(p => p.Item2 > 700.00);
    }

    // Método para contar a quantidade de produtos da categoria "periféricos" e somar seus valores
    static (int, double) PerifericosQuantidadeSoma(List<(string, double, string)> produtos)
    {
        int quantidade = produtos.Count(p => p.Item3 == "periféricos");
        double soma = produtos.Where(p => p.Item3 == "periféricos").Select(p => p.Item2).Sum();
        return (quantidade, soma);
    }

    // Método para imprimir produtos com valor menor que R$ 100,00
    static void ImprimirProdutosMenor100(List<(string, double, string)> produtos)
    {
        foreach (var produto in produtos)
        {
            if (produto.Item2 < 100.00)
            {
                Console.WriteLine($"   Produto: {produto.Item1}, Preço: R${produto.Item2:F2}, Categoria: {produto.Item3}");
            }
        }
    }
}
