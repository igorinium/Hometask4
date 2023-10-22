using System;

namespace Hometask4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите длинну массива");
                bool isParseSuccess = int.TryParse(Console.ReadLine(), out int arrayLenght);
                if (isParseSuccess && arrayLenght > 2)
                {
                    int sumArrayNumbers = 0;
                    int[] numbers = new int[arrayLenght];
                    for (int i = 0; i < arrayLenght; i++)
                    {
                        Console.Write($"Элемент {i + 1} = ");
                        numbers[i] = int.Parse(Console.ReadLine());
                        sumArrayNumbers += numbers[i];
                    }
                    Console.WriteLine($"Сумма элементов массива = {sumArrayNumbers}");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильное число");
                }
            }
            Console.ReadLine();
        }
    }
}