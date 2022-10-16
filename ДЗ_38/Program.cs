// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
int result = 0;
for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + " ");
}
int j = 0;
int max = array[j];
int min = array[j];
    while(j < size)
    {
        if(array[j] > max)
        {
            max = array[j];
        }
        else if(array[j] < min)
        {
            min = array[j];
        }
        j++;
    }    
Console.WriteLine();
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");    
result = max - min;
Console.WriteLine($"Разница между max и min: {result}");

