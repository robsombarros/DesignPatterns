using MediatorPattern.Components;
using MediatorPattern.Mediators;
using System;

namespace MediatorPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      var nameTextBox = new TextBox("Nome");
      var emailTextBox = new TextBox("Email");
      var submitButton = new Button();

      var mediator = new FormMediator
      {
        NameTextBox = nameTextBox,
        EmailTextBox = emailTextBox,
        SubmitButton = submitButton
      };

      nameTextBox.SetMediator(mediator);
      emailTextBox.SetMediator(mediator);
      submitButton.SetMediator(mediator);

      // Simulando entrada de dados
      nameTextBox.EnterText("Robson Barros");
      emailTextBox.EnterText("robsonbarros@totvs.com.br");

      // Clicando no botão
      submitButton.Click();

      // Simulando entrada de dados inválidos
      nameTextBox.EnterText("");
      emailTextBox.EnterText("");
      submitButton.Click();

      Console.ReadLine();
    }
  }
}