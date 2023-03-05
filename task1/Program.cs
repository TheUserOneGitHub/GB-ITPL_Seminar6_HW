// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Array(double[] array)
{
    Console.WriteLine("Enter a number (press enter after each)");

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
}

void PrintArray(double[] array)
{
    Console.Write("Your numbers: ");
    int i = 0;
    while (i < array.Length)
    {
        Console.Write($"{array[i]}");
        i++;
        if (i < array.Length)
        {
            Console.Write($", ");
        }
        else
        {
            Console.Write($".");
        }
    }
}

void TotalPos(double[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
        else
        {
            count = count;
        }
    }
    Console.WriteLine($"");
    Console.Write($"Total of numbers greater than zero is {count}");
}


Console.WriteLine("How many numbers you will enter?");
int n = Convert.ToInt32(Console.ReadLine());

double[] array = new double[n];

Array(array);
PrintArray(array);
TotalPos(array);