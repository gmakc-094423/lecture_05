// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = i+j;
    }
}

WriteArray(array);

// int[] array = RandomArray(m, n);
// WriteArray(array);



// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


Console.WriteLine();

int[,] arraySqare = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
      if(i % 2 == 0 && j % 2 == 0){
        arraySqare[i, j] = array[i, j]*array[i, j];
      }
      else arraySqare[i, j] = array[i, j];
        
    }
}

WriteArray(arraySqare);


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


// int[] RandomArray(int[] array, int m, int n){
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i, j] = new Random().Next(-10, 101);
//     }
// }
// return array;
// }