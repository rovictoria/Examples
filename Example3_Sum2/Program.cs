int numberA = new Random().Next(1,101); // целое число из диапазона [1...100]
Console.WriteLine(numberA);
int numberB = new Random().Next(1,101); // также;;
Console.WriteLine(numberB);
int result = numberA + numberB;
// Можно обойтись без result, тогда в выводе написать действие numberA + numberB
Console.WriteLine(result);
