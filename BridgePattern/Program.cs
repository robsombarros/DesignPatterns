class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("=== Testando TV com Controle Simples ===");
    IDevice tv = new TV();
    Remote tvRemote = new Remote(tv);
    tvRemote.TogglePower();
    tvRemote.VolumeUp();
    tvRemote.ChannelUp();
    tvRemote.TogglePower();

    Console.WriteLine("\n=== Testando Rádio com Controle Avançado ===");
    IDevice radio = new Radio();
    AdvancedRemote radioRemote = new AdvancedRemote(radio);
    radioRemote.TogglePower();
    radioRemote.VolumeDown();
    radioRemote.Mute();
    radioRemote.ChannelDown();
    radioRemote.TogglePower();

    Console.WriteLine("\nPressione qualquer tecla para sair...");
    Console.ReadKey();
  }
}
