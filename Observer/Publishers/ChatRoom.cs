using ChatObserverPattern.Interfaces;

namespace ChatObserverPattern.Subjects
{
  public class ChatRoom
  {
    private readonly List<IChatMember> _members = new List<IChatMember>();

    public void Join(IChatMember member)
    {
      _members.Add(member);
      Console.WriteLine($"[Sistema]: Novo membro entrou na sala.");
    }

    public void Leave(IChatMember member)
    {
      _members.Remove(member);
      Console.WriteLine($"[Sistema]: Um membro saiu da sala.");
    }

    public void SendMessage(string message, string sender)
    {
      Console.WriteLine($"\n[{sender}] enviou: {message}");
      NotifyMembers(message, sender);
    }

    private void NotifyMembers(string message, string sender)
    {
      foreach (var member in _members)
      {
        member.Update(message, sender);
      }
    }
  }
}
