// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sum the odd numbers");

// Implement an algorithm to sum together all the odd numbers in a collection. 

int[] lista = {1, 2, 3, 4, 5};
int sum = 0;

foreach(var n in lista)
{
sum += n % 2 != 0 ? n : 0;
}
System.Console.WriteLine(sum);
