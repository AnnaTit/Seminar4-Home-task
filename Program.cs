// Задача 25
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " in degree " + b + " = " + result);
}

int numA = ReadInt("Input 1st number: ");
int numB = ReadInt("Input 2nd number: ");
Degree(numA, numB);
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
//
// Задача 27 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void SumNum(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Sum of numbers is {sum}");
}
int NumLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}
int number = ReadInt("Input a number: ");
int len = NumLen(number);
SumNum(number, len);
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Задача 29 
// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.


int lenArray = ReadInt("Input lenght of array: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(-999,999);
    Console.Write(randomArray[i] + " ");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}