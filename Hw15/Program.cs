// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.

Console.WriteLine("Введите день недели:");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 1 && n <= 5)
{
    Console.WriteLine("Этот день не выходной");
}
else if (n == 6 || n == 7)
{
    Console.WriteLine("Это выходной");
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}