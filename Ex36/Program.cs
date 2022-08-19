int[] array = new int[7];
int sumOfOddNumbers = 0;

int GetSumOfOddNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 != 0)
        {
           sumOfOddNumbers += array[i]; 
        }

    }
    return sumOfOddNumbers;

}

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
}

sumOfOddNumbers = GetSumOfOddNumbers(array);
Console.WriteLine($"В массиве [{String.Join(' ', array)}] сумма нечетных чисел равна {sumOfOddNumbers}");


