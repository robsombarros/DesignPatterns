using ChatObserverPattern.Observers;
using ChatObserverPattern.Subjects;

namespace ChatObserverPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      var chatRoom = new ChatRoom();

      var fernanda = new ChatMember("Fernanda");
      var bob = new ChatMember("Bob");
      var charlie = new ChatMember("Charlie");

      chatRoom.Join(fernanda);
      chatRoom.Join(bob);
      chatRoom.Join(charlie);

      chatRoom.SendMessage("Olá a todos!", "Fernanda");
      chatRoom.SendMessage("Oi Fernanda!", "Bob");

      Console.ReadLine();
    }
  }
}
