//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Ввелите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Ввелите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Ввелите третье число: ");
int Number3 = Convert.ToInt32(Console.ReadLine());

int max=1;

if (Number1 > Number2)
{
    max = Number1;
}
else
{
    max = Number2;
}

if (Number3 > max)
{
    max = Number3;
}

Console.WriteLine($"{max} - максимальное из трех чисел");