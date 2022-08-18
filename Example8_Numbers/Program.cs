Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int value = numberB * numberB;

if(value == numberA)
{
    Console.WriteLine(numberA + " является квадратом " + numberB);
}
else
{
    Console.WriteLine(numberA + " НЕ является квадратом " + numberB);
}