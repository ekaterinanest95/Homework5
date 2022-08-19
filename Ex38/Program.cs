double[] array = new double[5];

for(int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToUInt32(Console.ReadLine());
}

double min = array[0];
double max = array[3];

double FindMin(double[] array)
{
    for(int i = 0; i < 4; i++)
    {
        if(array[i] < min) min = array[i];
    }
    return min;

}

double FindMax(double[] array)
{
    for(int i = 0; i < 4; i++)
    {
        if(array[i] > max) max = array[i];
    }
    return max;

}

Console.WriteLine($"В массиве [{String.Join(' ', array)}] разность минимального и максимального элементов равна {FindMax(array) - FindMin(array)}");



