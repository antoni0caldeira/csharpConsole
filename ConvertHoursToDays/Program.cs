// See https://aka.ms/new-console-template for more information
Console.WriteLine("Convert hours to days");


// convert hours into days. Here is the basic formula: days = h / 24.

System.Console.WriteLine("Please insert the number of hours to convert");
int hours = int.Parse(Console.ReadLine());

int days = hours / 24; // get the number of whole days
int remainingHours = hours % 24; // get the remaining hours

Console.WriteLine($"{days} day(s) and {remainingHours} hour(s)");