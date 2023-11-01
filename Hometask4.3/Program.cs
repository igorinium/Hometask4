using System;

namespace Hometask4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                Console.Write("Введите длинну массива: ");
                bool isParseSuccess = int.TryParse(Console.ReadLine(), out int arrayLenght);
                if (isParseSuccess && arrayLenght > 2)
                {
                    int[] numbers = new int[arrayLenght];
                    int iWhile = 0;
                    while (iWhile < arrayLenght)
                    {
                        Console.Write($"Элемент №{iWhile + 1} = ");
                        bool isIntParseSuccess = int.TryParse(Console.ReadLine(), out numbers[iWhile]);
                        if (isIntParseSuccess)
                        {
                            iWhile++;
                        }
                    }
                    bool isUnique = true;
                    Array.Sort(numbers);
                    for (int i = 0; i < numbers.Length - 1;)
                    {
                        int countRepeats = 1;
                        while (i + countRepeats < numbers.Length && numbers[i] == numbers[i + countRepeats])
                        {
                            countRepeats++;
                        }
                        if (countRepeats != 1)
                        {
                            Console.WriteLine($"Элемент со значением {numbers[i]} повторяется {countRepeats} раз(а)");
                            isUnique = false;
                        }
                        i += countRepeats;
                    }
                    if (isUnique)
                    {
                        Console.WriteLine("В массиве нет повторений");
                    }
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
