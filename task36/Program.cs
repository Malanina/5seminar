// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int[] MyArray = new int[6];
MyArray = CreateRandomArray(6, -10, 10);
ShowArray(MyArray);

int sum = 0;
for (int i = 0; i < MyArray.Length; i++)
{
    if (i % 2 != 0)
    {
      sum = sum + MyArray[i];
    }
}
Console.WriteLine("Сумма элементов,стоящих на нечетных позициях: " + sum);