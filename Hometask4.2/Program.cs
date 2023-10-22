using System;

namespace Hometask4._2
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
                    int[] numbers = new int[arrayLenght];
                    for (int i = 0; i < arrayLenght; i++)
                    {
                        Console.Write($"Элемент {i + 1} = ");
                        numbers[i] = int.Parse(Console.ReadLine());
                    }

                    int maxValue = numbers[0];
                    int minValue = numbers[0];
                    for (int i = 0; i < arrayLenght; i++)
                    {
                        if (numbers[i] > maxValue)
                        {
                            maxValue = numbers[i];
                        }
                        if (numbers[i] < minValue)
                        {
                            minValue = numbers[i];
                        }
                    }

                    Console.WriteLine($"Разница максимального и минимального значения массива = {maxValue - minValue}");
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
