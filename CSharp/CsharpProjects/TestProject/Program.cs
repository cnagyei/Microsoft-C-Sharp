/* Declare an array
string[] fraudulentOrderIDs = new string[3];

Assign values
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

// Initialize an array directly
string[] fraudulentOrderIDs = {"C12", "C13", "C14"};

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine(fraudulentOrderIDs[1]);
Console.WriteLine(fraudulentOrderIDs[2]);

Console.WriteLine($"We currently have {fraudulentOrderIDs.Length} fraudulent orders.");