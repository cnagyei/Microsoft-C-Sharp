string permission = "Admin|Manager";
int level = 15;

Console.WriteLine(permission.Contains("Admin") && level > 55 ? "Welcome, Super Admin" : 
                    permission.Contains("Admin") && level <= 55 ? "Welcome, Admin User" :
                    permission.Contains("Manager") && level < 20 ? "You do not have sufficient privileges." :
                    !permission.Contains("Admin") && !permission.Contains("Manager") ? "You do not have sufficient privileges" :
                    "You do not have sufficient privileges");  