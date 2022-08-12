/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
 
 
 Console.Write("Введи любое число: ");
 
int anyNumber = Convert.ToInt32(Console.ReadLine());                                                // Любые цыфры
string anyNumberText = Convert.ToString(anyNumber);                                                  // номера строки
if (anyNumberText.Length > 2)                                          // если в строке есть цифра по порядковому номеру больше 2, то..
{                      
  Console.WriteLine($"в числе: {anyNumber} - третья по счету цифра это: " + anyNumberText[2]); //  написать ее
}
else {                                                                                        // иначе
  Console.WriteLine($"в числе: {anyNumber}, нет третьего по счету числа");                  // написать что ее нет
}
