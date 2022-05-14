//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12



Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(-10, 101);
    }
}


WriteArray(array);
Console.WriteLine();
int sumMassive = 0;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
      if(i==j) 
      {
        sumMassive = sumMassive + array[i, j];
        Console.Write($"{array[i, j]}");
      }
      else Console.Write($"__");
    }
    Console.WriteLine();
}


Console.Write($"Cумма главной диагонали: {sumMassive}");


void WriteArray (int[,] array){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
          Console.Write(array[i, j] + " ");
      }
      Console.WriteLine();
  }
}