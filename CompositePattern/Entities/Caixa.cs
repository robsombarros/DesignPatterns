public class Caixa : ProdutoComponent
{
  private readonly List<ProdutoComponent> _itens = new();

  public Caixa(string nome)
  {
    Nome = nome;
  }

  public void Adicionar(ProdutoComponent componente)
  {
    _itens.Add(componente);
    Console.WriteLine($"[LOG] Adicionado '{componente.Nome}' à caixa '{Nome}'");
  }

  public override decimal GetPreco()
  {
    Console.WriteLine($"[LOG] Calculando preço total da caixa '{Nome}'...");
    decimal total = 0;
    foreach (var item in _itens)
    {
      total += item.GetPreco();
    }
    Console.WriteLine($"[LOG] Total da caixa '{Nome}': R${total}\n");
    return total;
  }
}
