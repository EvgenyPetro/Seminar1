Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    if (numberA > numberC)
    {
        Console.WriteLine("max = " + numberA);
    }
    else
    {
        Console.WriteLine("max = " + numberC);
    }
}
else if (numberB > numberA)
{
    if (numberB > numberC)
    {
        Console.WriteLine("max = " + numberB);
    }
    else
    {
        Console.WriteLine("max = " + numberC);
    }

}
else
{
    Console.WriteLine("Числа равны");
}
