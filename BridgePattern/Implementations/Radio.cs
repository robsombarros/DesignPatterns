public class Radio : IDevice
{
  private bool _enabled = false;
  private int _volume = 20;
  private int _channel = 90;

  public bool IsEnabled() => _enabled;

  public void Enable()
  {
    _enabled = true;
    Console.WriteLine("Rádio ligado.");
  }

  public void Disable()
  {
    _enabled = false;
    Console.WriteLine("Rádio desligado.");
  }

  public int GetVolume() => _volume;

  public void SetVolume(int percent)
  {
    _volume = Math.Clamp(percent, 0, 100);
    Console.WriteLine($"Rádio volume ajustado para {_volume}%.");
  }

  public int GetChannel() => _channel;

  public void SetChannel(int channel)
  {
    _channel = channel;
    Console.WriteLine($"Rádio mudou para o canal {_channel}.");
  }
}
