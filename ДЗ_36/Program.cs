// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
int sum = 0;

for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-10, 10);
Console.Write(array[i] + " ");

if(array[i] % 2 != 0)
{
  sum = sum + array[i];  
} 
}

Console.WriteLine();
Console.WriteLine(sum);