using MediatorPattern.Components;

namespace MediatorPattern.Mediators
{
  public interface IMediator
  {
    void Notify(Component sender, string eventCode);
  }
}