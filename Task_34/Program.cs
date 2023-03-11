// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

// Посчитать количество четных чисел в массиве
int CountEvenNumbersInArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

// -----------------------------------------------------------------------------------

int[] arrayInt = GetFillRandomIntArray(6, 100, 999);
PrintIntArray(arrayInt);

Console.WriteLine($"Количество четных чисел = {CountEvenNumbersInArray(arrayInt)}");