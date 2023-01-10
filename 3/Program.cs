// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце 


Console.WriteLine (" Нахождение среднего в столбцах двумерного массива");

// Создаем метод для ввода числа пользователем

int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

// Создаем метод заполнения случайного двумерного массива

int [,] SetArray2DInt (int line, int column)
{
    int [,] numArr2D = new int [line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            numArr2D [i, j] = new Random ().Next (0, 10); // заполняем массив 
        }
    }
    return numArr2D;
}

// Создаем метод вывода двумерного массива

void PrintArray2DInt (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength (0); i++)
    {
        for (int j = 0; j < array2D.GetLength (1); j++)
        {
            Console.Write (array2D [i, j] + " ");
        }
        Console.WriteLine ();
    }
}

// Создаем метод нахождения среднего в столбцах двумерного массива

double [] FindAvrArr (int [,] array2D)
{
    double [] avrArr = new double [array2D.GetLength (1)];
    for (int i = 0; i < array2D.GetLength (1); i++)
    {
        for (int j = 0; j < array2D.GetLength (0); j++)
        {
            avrArr [i] += array2D [j, i];
        }
        avrArr [i] = avrArr [i] / array2D.GetLength (0);
    }
    return avrArr;
};

// Создаем метод вывода вещественного массива с усреднением

void PrintArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = Math.Round (array [i], 1);
        Console.Write (array [i] + " ");
    }
        Console.WriteLine ();
}

int m = InputNum ("Задайте кол-во строк: ");
int n = InputNum ("Задайте кол-во столбцов: ");

int [,] array2D = SetArray2DInt (m, n);

Console.WriteLine ($"Ваш массив {m}x{n}:");
PrintArray2DInt (array2D);

double [] arrayAvr = FindAvrArr (array2D);

Console.WriteLine ($"Среднее арифметическое элементов столбцов:");
PrintArray (arrayAvr);