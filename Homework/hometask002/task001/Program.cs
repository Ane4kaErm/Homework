// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = 918;

if (number >= 100)
{
    Console.WriteLine (number / 10 % 10);
}
else
{
    Console.WriteLine("Error, incorrect number");
}