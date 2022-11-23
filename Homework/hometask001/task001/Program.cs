// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int numberA = 5;
int numberB = 7;

if (numberA > numberB)
{
    Console.Write("max = ");
    Console.WriteLine(numberA);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(numberB);  
}
