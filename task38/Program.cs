/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

int[] GetArray()
{
    Console.Write("Длина массива = ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 20);
        Console.Write(" " + array[i] + " ");
    }
    return array;
}
void minMax(int[] array)
{
    int min = minimal();
    int max = maximal();
    Console.WriteLine("Минимальное число в массиве = " + min);
    Console.WriteLine("Максимальное число в массиве =  " + max);
    int diff = max - min;
    Console.WriteLine("Разница между минимальным и максимальным значением = " + diff, 2);

}
int[] array = GetArray();
Console.WriteLine();
minMax(array);

//ПОЧЕМУ НЕ ПОЛУЧАЕТСЯ??????????????????????????????????????????????????????????????????????????????????????