// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.Write("введите число a: ");

int a=int.Parse(Console.ReadLine());

System.Console.Write("введите число b: ");

int b=int.Parse(Console.ReadLine());

System.Console.Write("введите число c: ");

int c=int.Parse(Console.ReadLine());

int max=a;

if(b>max)
{
    max=b;
}
if(c>max)
{
    max=c;
}
Console.Write("максимальное - ");
Console.WriteLine(max);