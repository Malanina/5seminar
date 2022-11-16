// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
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

int[] Array = new int[5];
Array = CreateRandomArray(5, -100, 100);
ShowArray(Array);

int max = Array[0];
int min = Array[0];
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] > max) max = Array[i];
    if (Array[i] < min) min = Array[i];
}
int Difference = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементами массива:" + Difference);
