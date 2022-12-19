/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

/*int[] GetArray(int size);
int[] array = GetArray(8);
PrintArray(array);
Console.WriteLine();
int res = 0;
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
while (int i = 0; i < array.Length; i++)
{

    if (res[i] % 2 == 0)
    {
        Console.WriteLine("Четное");
    }
    else
    {
        Console.WriteLine("Не кратно");
    }
    return res;
}

Console.WriteLine($"Количество элементов = {res}");*/

int[] GetArray()
{
    Console.Write("Выберите длину массива: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(" " + array[i] + " ");
    }
    return array;
}
void SearchEven(int[] array)
{   int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;   
        }
    }
    Console.WriteLine("Четных элиментов в массиве = "+count);
}
int[] array = GetArray();
Console.WriteLine();
SearchEven(array);