string output = "3, 56, 78, 4, 5";

int countNumbers = 1;
for (int i = 0; i < output.Length; i++)
{
    if (output[i] == ',')
        countNumbers++;
}

int[] numbers = new int[countNumbers];

int numberIndex = 0;
for(int i = 0; i < output.Length; i++)
{
    string subString = String.Empty;

    while (output[i] != ',')
    {
        if (i >= output.Length - 1)
            break;

        subString += output[i].ToString();
        i++;
    }
    
    if(subString == "" || subString == " ")
        continue;

    numbers[numberIndex] = Convert.ToInt32(subString);
    numberIndex++;
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}


// перемешивание 
int[] numbersRand = { 1, 2, 3, 4, 5, 6};

for (int i = 0; i < numbersRand.Length; i++)
{
    int randomIndex = new Random().Next(0, numbersRand.Length);
    int temp = numbersRand[i];
    numbersRand[i] = numbersRand[randomIndex];
    numbersRand[randomIndex] = temp;
}

for (int i = 0; i < numbersRand.Length; i++)
{
    Console.Write(numbersRand[i] + " ");
}

// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

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

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
