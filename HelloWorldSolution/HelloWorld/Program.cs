// See https://aka.ms/new-console-template for more information
using HelloWorld;

Console.WriteLine("Hello, Jessica!");
Console.WriteLine("Take a break");
Console.Write("How many minutes:");
string? minutes = Console.ReadLine();

if (minutes is not null)
{
    DateUtils helper = new DateUtils();

    int mins = int.Parse(minutes);
    DateTime endOfBreak = helper.TakeABreak(mins);

    Console.WriteLine($"Alright. Come back at {endOfBreak}.");
}
else
{
    Console.WriteLine("Don't come back maybe.");
}