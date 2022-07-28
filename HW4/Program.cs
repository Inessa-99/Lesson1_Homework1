//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число" );
int a = int.Parse(Console.ReadLine());
int i = 2;

while (i <= a) {
    if (a % 2 == 0)
    {
        
        Console.Write(i + " ");
        i = i+2;
    }
    else
    {
        i = i+2;
        Console.Write(i + " ");
    }
}