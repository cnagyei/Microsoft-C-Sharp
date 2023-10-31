using System.ComponentModel;

string[] orders = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

Console.WriteLine("Fraudulent Orders");
Console.WriteLine("=================");

foreach (string order in orders)
{
    if (order.StartsWith("B"))
    {
        Console.WriteLine(order);
    }
}