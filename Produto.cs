public class Produto
{
    public string Nome { get; set;}
    public decimal Preco {get; set;}
    public int QuantidadeEstoque {get; set;} = 0;
    public string Categoria {get; set;}
    public string CodigoProduto {get; set;}
    public string Fabricante {get; set;}
    public DateTime DataValidade {get; set;}
    
    public Produto(string nome, decimal preco, string categoria, 
    string codigoproduto, string fabricante, DateTime dataValidade)    

    {
        Nome = nome;
        Preco = preco;
        Categoria = categoria;
        CodigoProduto = codigoproduto;
        Fabricante = fabricante;
        DataValidade = dataValidade;
    }
}