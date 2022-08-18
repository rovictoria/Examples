Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

switch(number)

{
  case 1: Console.WriteLine(number + " Понедельник"); break;
  case 2: Console.WriteLine(number + " Вторник"); break;
  case 3: Console.WriteLine(number + " Среда"); break;
  case 4: Console.WriteLine(number + " Четверг"); break;
  case 5: Console.WriteLine(number + " Пятница"); break;
  case 6: Console.WriteLine(number + " Суббота"); break;
  case 7: Console.WriteLine(number + " Воскресенье"); break;
  default: Console.WriteLine("Нужно ввести число от 1 до 7, попробуйте снова :)"); break;
}