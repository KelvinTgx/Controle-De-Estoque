using System;
using System.Collections.Generic;

public class Estoque
{
    private List<Produto> produtos;

    public Estoque()
    {
        produtos = new List<Produto>();
    }

    // Adicionar produto ao estoque
    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
        Console.WriteLine("Produto adicionado com sucesso!");
    }

    // Listar todos os produtos
    public void ListarProdutos()
    {
        foreach (var produto in produtos)
        {
            Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco}, Quantidade: {produto.QuantidadeEstoque}");
        }

    }


    //Remover um produto do estoque
    public void RemoverProduto(string codigoproduto)
    {
        var produto = produtos.Find(p => p.CodigoProduto == codigoproduto);
        if (produto != null)
        {
            produtos.Remove(produto);
            Console.WriteLine("Produto removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Produto não encontrado!");
        
        }
    }

    // Adicionar quantidade no estoque
    public void EntradaEstoque(string codigoproduto, int quantidade)
    {
        var produto = produtos.Find(p => p.CodigoProduto == codigoproduto);
        if (produto != null)
        {
            produto.QuantidadeEstoque += quantidade;
            Console.WriteLine("Estrada de estoque realizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Produto não encontrado!");
        
        }
    }

    // REmover quantidade
    public void SaidaEstoque(string CodigoProduto, int quantidade)
    {
        var produto = produtos.Find(p => p.CodigoProduto == CodigoProduto);
        if (produto != null && produto.QuantidadeEstoque >= quantidade)
        {
            produto.QuantidadeEstoque -= quantidade;
            Console.WriteLine("Saída de estoque realizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Produto não encontrado ou quantidade insuficiente!");
        }
    }
}