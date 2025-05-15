public class TV : IDevice
{
  private bool _enabled = false;
  private int _volume = 30;
  private int _channel = 1;

  public bool IsEnabled() => _enabled;

  public void Enable()
  {
    _enabled = true;
    Console.WriteLine("TV ligada.");
  }

  public void Disable()
  {
    _enabled = false;
    Console.WriteLine("TV desligada.");
  }

  public int GetVolume() => _volume;

  public void SetVolume(int percent)
  {
    _volume = Math.Clamp(percent, 0, 100);
    Console.WriteLine($"TV volume ajustado para {_volume}%.");
  }

  public int GetChannel() => _channel;

  public void SetChannel(int channel)
  {
    _channel = channel;
    Console.WriteLine($"TV mudou para o canal {_channel}.");
  }
}
