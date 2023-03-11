// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Создаем и заполняем массив числами
int[] GetFillRandomIntArray(int arraySize, int startRange, int endRange)
{
    int[] array = new int[arraySize];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(startRange, endRange + 1);
    }
    return array;
}

// -----------------------------------------------------------------------------------

// Напечатать массив
void PrintIntArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1)
        {
            Console.WriteLine($"{array[i]}]");
            break;
        }
        Console.Write($"{array[i]}, ");
    }
}

// -----------------------------------------------------------------------------------

// Находим сумму нечетных позиций в массиве
int GetSumOddPositions(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }

    return sum;
}

// -----------------------------------------------------------------------------------

int[] arrayInt = GetFillRandomIntArray(7, 100, 1000);
PrintIntArray(arrayInt);

Console.WriteLine($"Сумма нечетных элементов массива = {GetSumOddPositions(arrayInt)}");


