// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Ввелите число N: ");
int N = Convert.ToInt32(Console.ReadLine()); 

int index=2;

while (index <= N)
{
    Console.Write($"{index} ");
    index = index + 2;
}