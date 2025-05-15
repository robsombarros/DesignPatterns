public class AdvancedRemote : Remote
{
  public AdvancedRemote(IDevice device) : base(device) { }

  public void Mute()
  {
    Console.WriteLine("[Controle Avançado] Mutando dispositivo...");
    device.SetVolume(0);
  }
}
