using AdapterPattern.Adapter;
using AdapterPattern.ClientInterface;
using AdapterPattern.Services;

Adaptee adaptee = new Adaptee();
ITarget target = new Adapter(adaptee);

Console.WriteLine("A interface do Adaptee é incompatível com o cliente.");
Console.WriteLine("Mas com o Adapter, o cliente pode chamar seu método.");
Console.WriteLine();

Console.WriteLine(target.GetRequest());
Console.ReadLine();