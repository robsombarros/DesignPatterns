namespace GenealogiaIterator.Models
{
  public class Pessoa
  {
    public string Nome { get; set; }
    public Pessoa? Pai { get; set; }
    public Pessoa? Mae { get; set; }

    public Pessoa(string nome)
    {
      Nome = nome;
    }

    public List<Pessoa> GetAncestrais()
    {
      var ancestrais = new List<Pessoa>();
      if (Pai != null) ancestrais.Add(Pai);
      if (Mae != null) ancestrais.Add(Mae);
      return ancestrais;
    }
  }
}
