// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());

while (number > 1000)
{
    number = (number /10);
}

if (number > 99 & number < 1000)
{
    number = number % 10;
    Console.WriteLine($"3 цифра: {number}");
}
else if (number < 99)
{
    Console.WriteLine("Число не является трехзначным");
}