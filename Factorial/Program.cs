// See https://aka.ms/new-console-template for more information
Console.WriteLine("Factorial");
// Input of the number of the factorial

System.Console.WriteLine("Hey mofo, input the fact number");
int input = int.Parse(Console.ReadLine());
int fact = 1;

if (input < 0) {
    System.Console.WriteLine("Asshole!... Input a number");}
if (input == 0){
    System.Console.WriteLine("mofo... 0! is 1");
}
else
{
    for (int i = 1; i <= input; i++){
        fact *= i;
    }
    System.Console.WriteLine(fact);

}

