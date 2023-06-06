// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задача 68: Напишите программу вычисления функции Аккермана с помощью
//рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number1 = Prompt("Input N");
int number2 = Prompt("Input M");
int A(int m, int n){
    if(m==0){
    return n+1;
    } else if (n==0){
        return A(m-1,1);
    }else{
        return A(m-1,A(m,n-1));
    } 
}
int result = A(number1,number2);
Console.WriteLine(result);