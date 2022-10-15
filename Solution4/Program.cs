Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int count = 2;

while (count <= numberA)
{
    Console.Write(count + " ");
    count += 2;
}