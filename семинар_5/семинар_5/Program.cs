/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*int size = 5;
int[] array = new int [size]; 
Random rand = new Random();
for (int i = 0; i < size; i++)
{
array[i] = rand.Next(100,1000);
if (array[i] % 2 == 0)
{
    Console.WriteLine($"{array[i]} - Четное");
}
else

Console.WriteLine($"{array[i]} - Нечетное");
}
*/
/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
/*
int size=5;
int[] array = new int [size]; 
Random rand = new Random();
int sum = 0;

for (int i = 0; i < size; i++)
{
array[i] = rand.Next(100,1000);
if ( i % 2!=0)
{
sum = sum + array[i];
}

}Console.WriteLine($"Созданный массив:[{string.Join("; ",array)}]");

Console.WriteLine($"Сумма  {sum}");
/*

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

*/
int size;
Console.Write("Введите кол-во элементов: ");
size = Convert.ToInt32(Console.ReadLine()); // считываем размер массива
double [] array = new double [size];
Random rand = new Random();
void GetArray(double[] array) // метод заполнения массива 
{
     for (int i = 0; i < size; i++)
     array[i] = Math.Round(rand.NextDouble()*10, 2);
}  

GetArray(array); 
Console.WriteLine($"Созданный массив:[{string.Join("; ",array)}]"); 

double dev = 0;
double min = array[0];
double max = array[0];

for (int i = 0; i < size; i++) 
{ 
  if(array[i] < min) min = array[i];

  if (array[i] > max) max = array[i];
} 
dev = Math.Round(max - min, 2);

Console.WriteLine($"Мин {min} Макс {max} Разница  {dev}");
















