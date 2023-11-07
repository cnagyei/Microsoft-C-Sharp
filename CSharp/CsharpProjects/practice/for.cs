string[] names = {"Alex", "Eddie", "David", "Michael"};
int i;

for (i = names.Length - 1; i >= 0; i--)
{
    if (names[i] == "David")
        names[i] = "Sammy";
}

foreach (var name in names)
{
    Console.WriteLine(name);
}