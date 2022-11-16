// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();

int[] CreateRandomArray(int size, int start, int end)
{
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(start, end);
    }
    return RandomArray;
}
 
 void ShowArray(int[] Array)
 {
   for (int i = 0; i < Array.Length; i++)
   {
    Console.WriteLine(Convert.ToString(Array[i]));
   } 
 }

int[] Array = new int[4];
Array = CreateRandomArray(4, 100, 999);
ShowArray(Array);

int count = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] % 2 == 0)
    {
      count++;
    }
}
Console.WriteLine("Количество четных чисел в массиве: " + count);











