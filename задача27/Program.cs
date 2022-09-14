// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
int numbers = int.Parse (Console.ReadLine ()!);

int sum = 0;

while (numbers > 0) 
{ 
int digit = numbers % 10; // достать последнюю цифру
sum += digit; 
numbers = numbers / 10;
}

Console.WriteLine($"Сумма цифр в числе - {sum}");