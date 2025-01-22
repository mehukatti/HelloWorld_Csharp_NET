// Tutorial from dotnet.microsoft https://www.youtube.com/watch?v=uytNCXw9dME&list=PLdo4fOcmZ0oUwBEC2bnwPtHqbU8Vmh_tj&index=2&ab_channel=dotnet
Console.WriteLine("What is your name?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
// The currentDate formats in the console are system formats, so they may not be exactly the same as in the video tutorial.
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}");
Console.Write($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);