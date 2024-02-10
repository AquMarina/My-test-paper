// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine();
        string[] orArray = input.Split(' ');

        string[] resArray = NewArreyCreated(orArray);

        Console.WriteLine("Новый(ые) массив(ы) строк с длиной не более 3 символов:");
        Console.WriteLine(string.Join(", ", resArray));
    }

    static string[] NewArreyCreated(string[] orArray)
    {
        int count = 0;
        for (int i = 0; i < orArray.Length; i++)
        {
            if (orArray[i].Length <= 3)
            {
                count++;
            }
        }

        string[] resArray = new string[count];
        int item = 0;
        for (int i = 0; i < orArray.Length; i++)
        {
            if (orArray[i].Length <= 3)
            {
                resArray[item] = orArray[i];
                item++;
            }
        }
        return resArray;
    }
}