// Loop through array of names
string[] names = {"Rowena", "Robin", "Bao"};

foreach (string name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine();

// Create running sum of inventory
int[] inventory = {200, 450, 700, 175, 250};
int sum = 0, bin = 0;

Console.WriteLine("Bin no.\tQuantity\tRunning total");
Console.WriteLine("======\t=========\t============");
foreach (int quantity in inventory)
{
    sum += quantity;
    bin++;
    Console.WriteLine($"{bin}\t{quantity}\t\t{sum}");
}

Console.WriteLine($"We have {sum} items in inventory from {bin} bins");