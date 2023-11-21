Random random = new Random();
int current;
int hero = 10, monster = 10;

do
{
    // hero attack
    current = random.Next(1, 10);
    monster -= current;
    Console.WriteLine($"Monster was damaged and lost {current} health and now has {monster} health.");
    if (monster <= 0)
    {
        Console.WriteLine("Hero wins!");
        break;
    }
    // monster attack
    current = random.Next(1, 10);
    hero -= current;
    Console.WriteLine($"Hero was damaged and lost {current} health and now has {hero} health.");
    if (hero <= 0)
    {
        Console.WriteLine("Monster wins!");
        break;
    }
} while (hero > 0 || monster > 0);
