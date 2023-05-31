// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
int [] CreateArray (int size)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Input element: ");
        int element = Convert.ToInt32(Console.ReadLine());
        newArray[i] = element;
    }
    return newArray;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write (array[i]);
    Console.WriteLine();
}

int CountOfNum (int [] Array)
{
    int i = 0;
    int count = 0;

    while (i < Array.Length)
    {
        if(Array[i] > 0)
        count++;
        i++;
    }
    return count;
}

Console.WriteLine("Input count of elements: ");
int countOfElem = Convert.ToInt32(Console.ReadLine());

if (countOfElem < 0)
{
    while (countOfElem < 0)
    {
    Console.WriteLine("Impossible value");
    Console.WriteLine("Input count of elements: ");
    countOfElem = Convert.ToInt32(Console.ReadLine());
    }
}

int [] elementsOfM = CreateArray(countOfElem);
PrintArray(elementsOfM);
int count = CountOfNum (elementsOfM);
Console.WriteLine($"Count of negative elements: {count} ");

*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
y = k1*x + b1        <-|
y = k2*x + b2        <-|
                       |
k1*x + b1 = k2*x + b2  |
k1*x - k2*x = b2 - b1  |
x*(k1 - k2) = b2 - b1  |
x = (b2 - b1)/(k1 - k2) -------------

*/

/*
Console.WriteLine("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

int x = (b2 - b1)/(k1 - k2);
int y = k1 * x + b1;

Console.WriteLine($"Point is ({x}; {y}) ");

*/
