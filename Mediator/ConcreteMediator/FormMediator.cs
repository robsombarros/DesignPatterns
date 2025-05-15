using MediatorPattern.Components;
using System;

namespace MediatorPattern.Mediators
{
  public class FormMediator : IMediator
  {
    public TextBox NameTextBox { get; set; }
    public TextBox EmailTextBox { get; set; }
    public Button SubmitButton { get; set; }

    public void Notify(Component sender, string eventCode)
    {
      if (sender == SubmitButton && eventCode == "Click")
      {
        ValidateForm();
      }
    }

    private void ValidateForm()
    {
      bool isValid = true;

      if (string.IsNullOrWhiteSpace(NameTextBox.Value))
      {
        Console.WriteLine("Nome é obrigatório.");
        isValid = false;
      }

      if (string.IsNullOrWhiteSpace(EmailTextBox.Value))
      {
        Console.WriteLine("Email é obrigatório.");
        isValid = false;
      }

      if (isValid)
      {
        Console.WriteLine("Formulário enviado com sucesso!");
      }
    }
  }
}
