// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ") ;
int number = Convert.ToInt32(Console.ReadLine()) ;
if (number >= 100)
{
    while (number >= 1000)
    {
        number /= 10 ;
    }
int thirdDigit = number % 10 ;
Console.WriteLine($"Третья цифра в числе {number} -> {thirdDigit}") ;
}
else
{ 
    Console.WriteLine("Число не лежит в нужном нам диапазоне") ;
}
