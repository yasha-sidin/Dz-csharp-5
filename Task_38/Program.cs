// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Создаем и заполняем массив вещественными числами
double[] GetFillRandomDoubleArray(int arraySize, int startRange, int endRange)
{
    double[] array = new double[arraySize];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(startRange, endRange + 1);
    }

    return array;
}

// -----------------------------------------------------------------------------------

// Напечатать массив
void PrintDoubleArray(double[] array)
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

// Поиск максимального элемента массива double
double CheckMaxDouble(double[] array)
{
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }

    return max;
}

// -----------------------------------------------------------------------------------

// Поиск минимального элемента массива double
double CheckMinDouble(double[] array)
{
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }

    return min;
}

// -----------------------------------------------------------------------------------

double[] arrayD = GetFillRandomDoubleArray(8, 4, 150);
PrintDoubleArray(arrayD);

Console.WriteLine($"Разница между максимальным и минимальным значением " + 
$"элементов массива = {CheckMaxDouble(arrayD) - CheckMinDouble(arrayD)}");
