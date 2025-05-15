public class Produto : ProdutoComponent
{
  public decimal Preco { get; set; }

  public Produto(string nome, decimal preco)
  {
    Nome = nome;
    Preco = preco;
  }

  public override decimal GetPreco()
  {
    Console.WriteLine($"[LOG] Calculando preço do produto '{Nome}': R${Preco}");
    return Preco;
  }
}
