// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
//натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 6, 7, 8"
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
void Print (int current, int value)
{
    
    if (current > value) return;
    Console.Write($"{current} ");
    Print(current+1,value);
}
Print(number1,number2);
Console.WriteLine();
