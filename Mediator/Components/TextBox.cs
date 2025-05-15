using System;

namespace MediatorPattern.Components
{
  public class TextBox : Component
  {
    public string Value { get; set; }
    public string Name { get; }

    public TextBox(string name)
    {
      Name = name;
    }

    public void EnterText(string text)
    {
      Value = text;
      Console.WriteLine($"{Name} TextBox recebeu: {Value}");
    }
  }
}
