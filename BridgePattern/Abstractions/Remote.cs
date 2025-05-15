public class Remote
{
  protected IDevice device;

  public Remote(IDevice device)
  {
    this.device = device;
  }

  public void TogglePower()
  {
    if (device.IsEnabled())
    {
      Console.WriteLine("[Controle] Desligando dispositivo...");
      device.Disable();
    }
    else
    {
      Console.WriteLine("[Controle] Ligando dispositivo...");
      device.Enable();
    }
  }

  public void VolumeDown()
  {
    Console.WriteLine("[Controle] Diminuindo volume...");
    int volume = device.GetVolume();
    device.SetVolume(volume - 10);
  }

  public void VolumeUp()
  {
    Console.WriteLine("[Controle] Aumentando volume...");
    int volume = device.GetVolume();
    device.SetVolume(volume + 10);
  }

  public void ChannelDown()
  {
    Console.WriteLine("[Controle] Canal anterior...");
    int channel = device.GetChannel();
    device.SetChannel(channel - 1);
  }

  public void ChannelUp()
  {
    Console.WriteLine("[Controle] Próximo canal...");
    int channel = device.GetChannel();
    device.SetChannel(channel + 1);
  }
}
