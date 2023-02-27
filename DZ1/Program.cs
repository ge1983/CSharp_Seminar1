//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Ввелите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Ввелите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine()); 

if (Number1 < Number2)
{
    Console.WriteLine($"{Number1} - минимальное");
    Console.WriteLine($"{Number2} - максимальное");
}
else
{
    Console.WriteLine($"{Number1} - максимальное");
    Console.WriteLine($"{Number2} - минимальное");
}