// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Console.Clear();
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int[] counter = new int[10];
int tempNumber = 0;

for (int i = 0; i < counter.GetLength(0); i++)
{
  tempNumber = 0;
  for (int j = 0; j < array.GetLength(0); j++)
  {
    for (int k = 0; k < array.GetLength(1); k++)
    {
      if(i == array[j, k])
      {
        tempNumber += 1;
      }
    }
  }
  counter[i] = tempNumber;
}

WriteCounter(counter);

void WriteCounter(int[] counter)
{
  for (int l = 0; l < counter.GetLength(0); l++)
  {
    if (counter[l] != 0) 
    {
      Console.Write($"{l} встречается {counter[l]} раз \n");
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
      array[i, j] = new Random().Next(10);
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


 