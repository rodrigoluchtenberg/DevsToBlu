using System;

public class Produto
{
    private string nome;
    private decimal preco;

    public Produto(string nome, decimal preco)
    {
        this.nome = nome;
        SetPreco(preco);
    }

    public void AlterarNome(string novoNome)
    {
        this.nome = novoNome;
    }

    public void AlterarPreco(decimal novoPreco)
    {
        SetPreco(novoPreco);
    }

    private void SetPreco(decimal novoPreco)
    {
        if (novoPreco < 0)
        {
            throw new ArgumentException("O preço não pode ser negativo.");
        }
        this.preco = novoPreco;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do Produto: {nome}");
        Console.WriteLine($"Preço do Produto: R$ {preco}");
    }

    public string GetNome()
    {
        return nome;
    }

    public decimal GetPreco()
    {
        return preco;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto("Notebook", 2500.00m);
        produto.ExibirDetalhes();
        produto.AlterarNome("Mesa Gamer");
        produto.AlterarPreco(3000.00m);
        produto.ExibirDetalhes();
    }
}
