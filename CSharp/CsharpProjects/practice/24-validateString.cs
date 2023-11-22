string? readLine;
string? roleEntry;
string[] role = {"administrator", "manager", "user"};

Console.WriteLine($"Enter your role name ({role[0]}, {role[1]}, or {role[2]})");

do
{
    readLine = Console.ReadLine();
    roleEntry = readLine.Trim().ToLower();
    
    if (roleEntry == role[0] || roleEntry == role[1] || roleEntry == role[2])
        break;
    
    else
        Console.WriteLine($"The role name you entered, \"{readLine}\" is not valid. Enter your role name ({role[0]}, {role[1]}, or {role[2]})");
    
} while (roleEntry != role[0] || roleEntry != role[1] || roleEntry != role[2]);

Console.WriteLine($"Your input value ({readLine}) has been accepted");