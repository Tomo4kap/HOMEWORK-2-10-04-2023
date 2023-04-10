Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int Mmax = number1;
if (number2 > Mmax)
    Mmax = number2;

if (number3 > Mmax)
    Mmax = number3;
Console.WriteLine($"Max = {Mmax}");


