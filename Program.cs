/*
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//Создадим рекурсивный метод, который будет выводить натуральные число в промежутке от n до 1.
//Рекурсия это метод, процесс, который вызывает сам себя.
void rec (int n)
{
    if (n <= 0)
        Console.WriteLine("Введено не натуральное число");

    if (n > 0)
    {
        if (n > 1)
        {
            Console.WriteLine(n);
            rec(n - 1);
        }
        else
        {
            Console.WriteLine(n);
        }
    }
    
}
Console.WriteLine("Введите натуральное число N ");
int num=Convert.ToInt32(Console.ReadLine());//переменная, хранящая число N
rec(num); //вызов метода
*/

/*
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите начальное значение M = ");
int M = Convert.ToInt32(Console.ReadLine()); //переменная которая хранит значение M
Console.Write("Введите начальное значение N = ");
int N = Convert.ToInt32(Console.ReadLine()); //переменная которая хранит значение N
Console.WriteLine($"Сумма = {Sum(M, N)}"); //вызов метода 

//целочисленный рекурсионный метод, который ищет сумму натуральных элементов  в промежутке от M до N
int Sum(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            // Если M равно нулю
    else if (N == 0) return (M * (M + 1)) / 2;       // Если N равно нулю
    else if (M == N) return M;                       // Если M=N
    else if (M < N) return N + Sum(M, N - 1); // Если M<N
    else return N + Sum(M, N + 1);            // Если M>N
}
*/

/*
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.WriteLine("Введите число M = ");
int M = Convert.ToInt32(Console.ReadLine()); //переменная которая хранит значение M

Console.WriteLine("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine()); //переменная которая хранит значение N

///Метод вычисления функции Аккермана:
int Ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Ack(m - 1, 1);
    }
    else
    {
        return (Ack(m - 1, Ack(m, n - 1)));
    }
}

Console.WriteLine($"Функция Аккермана для чисел A(m,n) = {Ack(M,N)}"); //вызов метода
*/

