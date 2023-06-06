// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number1 = Prompt("Input M");
int number2 = Prompt("Input N");
if (number2<number1) {
(number2,number1) = (number1,number2);
}
int sum = 0;
int Sum (int current, int value)
{
    if (current > value) return 0;
    sum = sum+current;
    Sum(current+1,value);
    return sum;
}
int result = Sum(number1,number2);
Console.WriteLine(result);
Console.WriteLine();
