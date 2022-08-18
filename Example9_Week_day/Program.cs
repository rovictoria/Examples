Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
// && и
if(number >= 1 && number <=7)
{
  if(number == 1) Console.WriteLine(number + " Понедельник");
  if(number == 2) Console.WriteLine(number + " Вторник");
  if(number == 3) Console.WriteLine(number + " Среда");
  if(number == 4) Console.WriteLine(number + " Четверг");
  if(number == 5) Console.WriteLine(number + " Пятница");
  if(number == 6) Console.WriteLine(number + " Суббота");
  if(number == 7) Console.WriteLine(number + " Воскресенье");
}
else
{
    Console.WriteLine("Нужно ввести число от 1 до 7, попробуйте снова :)");
}