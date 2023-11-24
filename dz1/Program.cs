//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Print(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int number)
{
    if (number <= 0)
    {
        Console.WriteLine("Число не натуральное");
        return 0;
    }
    else if (number == 1)
    {
        return 1;
    }
    Console.Write(number + " ");
    return SumNumbers(number - 1);
}

int number = Print("Введите четное число");
Console.WriteLine(SumNumbers(number));