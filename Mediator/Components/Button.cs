namespace MediatorPattern.Components
{
  public class Button : Component
  {
    public void Click()
    {
      Console.WriteLine("Botão clicado.");
      mediator.Notify(this, "Click");
    }
  }
}
