using System.Threading.Channels;

int num1 = 5;
int num2 = 4;
num1 = num1 + num2;
num2 = num1 - num2;
num1 = num1 - num2;

Console.WriteLine(num1);
Console.WriteLine(num2);