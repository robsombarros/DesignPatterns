using GenealogiaIterator.Collections;
using GenealogiaIterator.Models;

namespace GenealogiaIterator
{
  class Program
  {
    static void Main(string[] args)
    {
      var bisavo = new Pessoa("Bisavô do Fulano");
      var bisavoMae = new Pessoa("Bisavó do Fulano");
      var avo = new Pessoa("Avô do Fulano") { Pai = bisavo, Mae = bisavoMae };
      var avoh = new Pessoa("Avó do Fulano");
      var pai = new Pessoa("Pai do Fulano") { Pai = avo, Mae = avoh };
      var mae = new Pessoa("Mãe do Fulano");
      var eu = new Pessoa("Fulano") { Pai = pai, Mae = mae };

      var familia = new FamiliaCollection(eu);

      Console.WriteLine("== Todos os Ancestrais ==");
      var iteratorTodos = familia.CreateIterator(TipoIterator.TodosAncestrais);
      while (iteratorTodos.HasMore())
        Console.WriteLine(iteratorTodos.GetNext().Nome);

      Console.WriteLine("\n== Ascendência Direta (Linha Paterna) ==");
      var iteratorPai = familia.CreateIterator(TipoIterator.AscendenteDiretoPai);
      while (iteratorPai.HasMore())
        Console.WriteLine(iteratorPai.GetNext().Nome);

      Console.ReadLine();
    }
  }
}
