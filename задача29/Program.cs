// Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.
Console.WriteLine("Введите 8 чисел через пробел");
string numbers = Console.ReadLine()!;
string[] parts = numbers.Split(" ");
int[] array = new int[8];

for (int i = 0; i < 8; i++)
{
    array[i] = int.Parse(parts[i]);
}

Console.WriteLine($"[{string.Join(", ", array)}]");

