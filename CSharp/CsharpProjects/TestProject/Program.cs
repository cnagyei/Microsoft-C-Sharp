using System.Globalization;

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

Console.WriteLine("=====");

int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

Random toss = new Random();
int roll1 = toss.Next();
int roll2 = toss.Next(101);
int roll3 = toss.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");