//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

int Print(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int firstNumber, int lastNumber)
{
    if (firstNumber > lastNumber)
    {
        return 0;
    }
    else if (firstNumber <= 0 || lastNumber <= 0)
    {
        Console.WriteLine("Одно из чисел не натуральное");
        return 0;
    }
    return firstNumber + SumNumbers(firstNumber + 1, lastNumber);
}

int number1 = Print("Введите первое натуральное число");
int number2 = Print("Введите второе натуральное число");
Console.WriteLine(SumNumbers(number1, number2));