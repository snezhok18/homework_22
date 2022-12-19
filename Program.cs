/*
Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/



Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше, а число {num2} меньше");
}
else
{
    Console.WriteLine($"Число {num2} больше, а число {num1} меньше");
}



/*
Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число: ");
int arg1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int arg2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число:");
int arg3 = int.Parse(Console.ReadLine()!);
if (arg1 > arg2)
{
    Console.WriteLine($"Число {arg1} - максимальное из введенных");
}
if (arg2 > arg3)
{
    Console.WriteLine($"Число {arg2} - максимальное из введенных");
}
else
{
    Console.WriteLine($"Число {arg3} - максимальное из введенных");
}



/*
Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).
4 -> да
3 -> нет
7 -> нет
*/

Console.WriteLine("Ведите число: ");
int numb1 = int.Parse(Console.ReadLine()!);
if(numb1 % 2 == 0)
{
    Console.WriteLine($"Введенное число {numb1} является четным");
}
else
{
    Console.WriteLine($"Введенное число {numb1} не является четным");
}



/*
Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе
показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.WriteLine("Введите число: ");
int numberN = int.Parse(Console.ReadLine()!);
int numberA = 1;
while (numberA <= numberN)
{
    if (numberA % 2 == 0)
    {
        Console.Write($"{numberA}|");
    }
    numberA++;
}
