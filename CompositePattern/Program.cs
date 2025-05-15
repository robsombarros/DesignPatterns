class Program
{
  static void Main()
  {
    // Produtos simples
    var celular = new Produto("Celular", 1500.00m);
    var carregador = new Produto("Carregador", 150.00m);
    var fone = new Produto("Fone de Ouvido", 200.00m);
   
    // Caixa com celular e carregador
    var caixaCelular = new Caixa("Kit Celular");
    caixaCelular.Adicionar(celular);
    caixaCelular.Adicionar(carregador);
    Console.WriteLine();

    // Caixa com kit celular + fone
    var caixaPresente = new Caixa("Caixa de Presente");
    caixaPresente.Adicionar(caixaCelular);
    caixaPresente.Adicionar(fone);

    Console.WriteLine($"\nValor Total da Caixa Presente: R${caixaPresente.GetPreco()}");

    Console.ReadLine();    
  }
}
