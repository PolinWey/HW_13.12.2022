/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] GetArray()
{
    Console.Write("Выберите длину массива: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 20);
        Console.Write(" " + array[i] + " ");
    }
    return array;
}
void sumElement(int[] array)
{
    int sumElement = 0;
    int size = array.Length;
    for (int i = 1; i < size; i++)
    {
        if (i % 2 != 0)
        {
            sumElement += array[i];
        }
    }
    Console.WriteLine("Сумма нечетных элементов = " + sumElement);
}
int[] array = GetArray();
Console.WriteLine();
sumElement(array);