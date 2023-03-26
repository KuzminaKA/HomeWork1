//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
System.Console.Write("введите число a: ");

int a=int.Parse(Console.ReadLine());

System.Console.Write("введите число b: ");

int b=int.Parse(Console.ReadLine());

if(a>b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}