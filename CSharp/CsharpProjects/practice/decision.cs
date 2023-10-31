// // // string value1 = " a";
// // // string value2 = "A ";

// // // Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// // Console.WriteLine("a" != "a");
// // Console.WriteLine("a" != "A");
// // Console.WriteLine(1 != 2);

// // string myValue = "a";
// // Console.WriteLine(myValue != "a");

// using System.Net.Security;

// float sale = 900;
// float discount;
// string pangram = "The quick brown fox jumps over the lazy dog";

// Console.WriteLine(!pangram.Contains("fox") == false);
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// Console.WriteLine("===================");

// discount = sale > 1000 ? 100 : 50;

// Console.WriteLine($"Discount: {discount}");

// // use conditional operator inline
// Console.WriteLine($"Discount: {(sale > 500 ? 10 : 5)}");

int hello;
string flipCoin;

Random coin = new Random();
hello = coin.Next(0, 2);

Console.WriteLine(hello);
flipCoin = hello == 0 ? "Head" : "Tail";
Console.WriteLine($"{hello} is a {flipCoin}");