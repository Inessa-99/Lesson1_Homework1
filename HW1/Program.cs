// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите первое число" );
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число" );
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Resoult: " + a);
}
else
{
    Console.WriteLine("Resoult: " + b);
}
