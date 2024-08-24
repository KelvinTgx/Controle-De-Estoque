
Estoque estoque = new Estoque();
int opcao;

do
{   
    Console.WriteLine("");
    Console.WriteLine("---------------------------");
    Console.WriteLine("Controle de Estoque Mercado Do João");
    Console.WriteLine("---------------------------");
    Console.WriteLine("[1] Novo Produto ");
    Console.WriteLine("[2] Listar Produto");
    Console.WriteLine("[3] Remover Produto");
    Console.WriteLine("[4] Entrada Estoque");
    Console.WriteLine("[5] Saída Estoque");
    Console.WriteLine("[0] Sair");
    Console.WriteLine("---------------------------");
    Console.Write("Escolha uma opção:");
    opcao = int.Parse(Console.ReadLine()??"");
    Console.WriteLine("---------------------------");


    switch (opcao)
    {

        case 1:
            // Adicionar um novo produto
            Console.Write("Novo: ");
            string? nome = Console.ReadLine();
            Console.Write("Preço: ");
            decimal preco = decimal.Parse(Console.ReadLine()??"");
            Console.Write("Categoria: ");
            string? categoria = Console.ReadLine();
            Console.Write("Codigo Do Produto:");
            string? codigoproduto = Console.ReadLine();
            Console.Write("Fabricante: ");
            string? fabricante = Console.ReadLine();
            Console.Write("Data de Validade (yyyy-mm-dd):");
            DateTime dataValidade = DateTime.Parse(Console.ReadLine()??"");

             Produto novoProduto = new Produto(nome, preco, categoria, codigoproduto, fabricante, dataValidade);
            estoque.AdicionarProduto(novoProduto);
            break;

        case 2:
            //listar os produtos
            estoque.ListarProdutos();
            break;

        case 3:
            //remover produto
            Console.Write("Digite o código do produto que deseja remover: ");
            string? codigoRemover = Console.ReadLine();
            estoque.RemoverProduto(codigoRemover);
            break;

        case 4:
            //Estrada de estoque
            Console.Write("Digite o código do produto: ");
            string? codigoEntrada = Console.ReadLine();
            Console.Write("Quantidade a ser adicionada: ");
            int quantidadedeEntrada = int.Parse(Console.ReadLine());
            estoque.EntradaEstoque(codigoEntrada, quantidadedeEntrada);
            break;

        case 5:
            // Saída de estoque
            Console.WriteLine("Digite o código do produto: ");
            string? codigoSaida = Console.ReadLine();
            Console.Write("Quantidade a ser removida: ");
            int quantidadeSaida = int.Parse(Console.ReadLine());
            estoque.SaidaEstoque(codigoSaida, quantidadeSaida);
            break;

        case 0:
            Console.WriteLine("Saindo...");
            break;

        default:
            Console.WriteLine("Opção invalida!");
            break;








    }


} while (opcao != 0);



