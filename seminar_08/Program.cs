// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int m = InputNumbers("Введите m:");
int n = InputNumbers("Введите n:");

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

Console.WriteLine();

ReverseLineArray(array);
Console.Write("замена 1 и последней строки.\n");
WriteArray(array);

void ReverseLineArray(int[,] array)
{
  int[] tempArray = new int[n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      if (i == 0)
      {
        tempArray[j] = array[i,j];
        array[i,j] = array[m-1, j];
      }
      if(i == m-1)
    {
      array[i,j] = tempArray[j];
    }
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().Next(100);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Write("\nMассив возьмем из предыдущей задачи (№ 53).\n");

if(array.GetLength(0) == array.GetLength(1))
{
  int[,] arrayReverse = new int[array.GetLength(1), array.GetLength(0)];

  ReverseArray(array, arrayReverse);
  WriteArray(arrayReverse);

  void ReverseArray(int[,] array, int[,] arrayReverse )
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        arrayReverse[i,j] = array[j,i];
      }
    }
  }
}

else Console.Write("\nСоздать нельзя.\n");