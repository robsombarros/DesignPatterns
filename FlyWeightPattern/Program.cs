using FlyWeightPattern;

Game game = new Game();

Console.Write("Informe o número de jogadores: ");
int numPlayers = int.Parse(Console.ReadLine());

Console.Write("Informe o número de inimigos: ");
int numEnemies = int.Parse(Console.ReadLine());

List<Unit> players = new();
List<Unit> enemies = new();

// Criar jogadores dinamicamente
for (int i = 0; i < numPlayers; i++)
{
  players.Add(new Unit { Coords = $"X={10 + i * 10},Y={20}" });
  Console.WriteLine($"Player {i + 1} criado em {players[i].Coords}");
}

// Criar inimigos dinamicamente
for (int i = 0; i < numEnemies; i++)
{
  enemies.Add(new Unit { Coords = $"X={50 + i * 10},Y={20}" });
  Console.WriteLine($"Enemy {i + 1} criado em {enemies[i].Coords}");
}

// Cada player atira em cada inimigo
foreach (var player in players)
{
  foreach (var enemy in enemies)
  {
    player.FireAt(enemy, game, weaponPower: 5.0f);
  }
}

game.Draw("MainCanvas");

Console.ReadLine();


//// Arquivo: Program.cs
//using FlyWeightPattern;
//using FlyWeightPattern.Context;
//using FlyWeightPattern.FlyWeightFactory;

//class Program
//{
//  static void Main()
//  {
//    Game game = new Game();

//    Unit player1 = new Unit { Coords = "X=10,Y=20" };
//    Unit player2 = new Unit { Coords = "X=40,Y=10" };
//    Unit enemy = new Unit { Coords = "X=50,Y=20" };

//    player1.FireAt(enemy, game, weaponPower: 5.0f);
//    player2.FireAt(enemy, game, weaponPower: 6.0f);

//    game.Draw("MainCanvas");

//    Console.ReadLine();
//  }
//}