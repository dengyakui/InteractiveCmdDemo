// See https://aka.ms/new-console-template for more information
Console.WriteLine($"arg length: {args.Length}");
for (var i = 0; i < args.Length; i++)
{
    Console.WriteLine($"args[{i}] is: {args[i]}");
}
Console.WriteLine("input your name:");
var userName = Console.ReadLine();
Console.WriteLine($"got user name: {userName}");

Console.WriteLine("input your email:");
var email = Console.ReadLine();
Console.WriteLine($"got email: {email}");

Console.WriteLine($"user name: {userName}, email: {email}");


