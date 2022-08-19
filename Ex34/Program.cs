int[] Array = new int[8];
int count = 0;

for(int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(100, 1000);
    if(Array[i] % 2 == 0) count +=1;

}

Console.WriteLine($"В массиве [{String.Join(' ', Array)}] {count} положительных чисел");



