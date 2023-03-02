// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели ");
int digit = int.Parse(Console.ReadLine());

if (digit > 5 & digit < 8)
{
   Console.WriteLine($"Ура! Выходной!");
}

else 
{
    Console.WriteLine("К сожалению, еще придется поработать");
}
