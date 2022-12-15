// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел 
// в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] CreateArray(int arraySize)
{
    int[] array = new int [arraySize];
    for(int i = 0; i < arraySize; i++)
    {
        array[i] = new Random().Next(100,1000);
        Console.Write(array[i] + " ");
    }
    return array;
}
Console.WriteLine(CreateArray(size));