/* Урок 4. Функции
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*Console.Write("Видите число A;");
Console.Write("Видите число B;");
int A=Convert.ToInt32(Console.ReadLine());
int B=Convert.ToInt32(Console.ReadLine());
int rezult=1;
for (int i = 0; i <= B; i++)
{
    rezult=rezult*A;
}

Console.WriteLine ("rezult(A,B)");
*/
/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/* int size = 8;
int[] array = new int[8]; // Массив из 8 элементов: в массиве изначально 
Random rand = new Random();
for (int i = 0; i < size; i++)
{
   array[i] = rand.Next(8);
    
}
Console.WriteLine($"Массив: [ {String.Join("; ",array)} ]");
*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
/*Console.Write("Введите число: ");
int number= Convert.ToInt32(Console.ReadLine());
int digit=0;
int sum=0;
while (number !=0)
{
digit = number % 10;
sum += digit;
number = number / 10;
}
Console.WriteLine($"Сумма  {number} = {sum}");
*/


