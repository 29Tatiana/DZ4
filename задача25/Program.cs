// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите числа А и В через пробел:");
string AB = Console.ReadLine()!;
string[] parts_AB = AB.Split(' ');
int numA = int.Parse(parts_AB[0]);
int numB = int.Parse(parts_AB[1]);

double result = 1;
for (int i = 0; i < numB; i++)
{
    result *= numA;
}

Console.WriteLine($"A в степени В = {result}");