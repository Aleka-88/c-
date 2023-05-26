/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/*
Console.Write("трехзначное число:");

int Value = Convert.ToInt32(Console.ReadLine());
int Length = Value.ToString().Length;
if (Length == 3) 
		{int result = ( Value/10 ) % 10;
		Console.WriteLine($" показывает вторую цифру");
	} 
    else 
		Console.WriteLine ("не трехзначное число");
        */
        /*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
Console.Write("трехзначное число:");

int Value = Convert.ToInt32(Console.ReadLine());
int Length = Value.ToString().Length;
if (Length == 3) 
		{int result = ( Value/10 ) % 10;
		Console.WriteLine($" показывает вторую цифру");
	} 
    else 
		Console.WriteLine ("не трехзначное число");
        */
       /*
    Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*Console.Write("третью цифру заданного числа:");
int Value2 = Convert.ToInt32(Console.ReadLine());
int Length2 = Value2.ToString().Length;
if (Length2 >= 3) {
	while (Value2 > 999)
	{
		Value2 = Value2 / 10;
	}
	int result = Value2 % 10;
	Console.WriteLine("выводит третью цифру заданного числа " +  result );
if (Length2 > 2)
  Console.WriteLine("третья цифра -> " + Length2);
}
else 
  Console.WriteLine("-> третьей цифры нет");
  */

  /*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

/*Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}
CheckingTheDayOfTheWeek(dayNumber);
*/


   

    

	
