// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Write(" Каждая цифра обозночает день недели. Введи цифру, от одного до семи: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(этот день выходной)");

  }
  else Console.WriteLine("(этот день не выходной)");
}
CheckingTheDayOfTheWeek(dayNumber);
