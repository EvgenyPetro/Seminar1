Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("max = " + numberA);
}
else if (numberA < numberB)
{
    Console.WriteLine("max = " + numberB);
}
else
{
Console.WriteLine("Числа равны");
}
