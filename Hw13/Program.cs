// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

while (n > 999)
{
    n = n / 10;
}
if (n >= 100)
{
    n = n % 10;
    Console.WriteLine($"Третья цифра числа: {n}");
}
else if (n < 100)
{
    Console.WriteLine("Третьей цифры нет");
}