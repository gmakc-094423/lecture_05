string output = "3, 56, 7 8, 4, 5";

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
        subString += output[i].ToString();
        if (i >= output.Length - 1)
            break;
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
