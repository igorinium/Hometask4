using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask4._3
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
                        Console.Write($"Элемент №{i + 1} = ");
                        numbers[i] = int.Parse(Console.ReadLine());
                    }

                    bool isUnique = true;
                    int[,] repeatsArray = new int[numbers.Length, 2];
                    int indexRepeatsArray = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        bool hasAlready = false;
                        for (int n = 0; n < numbers.Length; n++)
                        {
                            if (repeatsArray[n, 0] == numbers[i])
                            {
                                hasAlready = true;
                            }

                        }
                        if (hasAlready)
                        {
                            break;
                        }

                        else
                        {
                            for (int y = 0; y < arrayLenght; y++)
                            {
                                if (i != y && numbers[i] == numbers[y])
                                {
                                    repeatsArray[indexRepeatsArray, 0] = numbers[i];
                                    repeatsArray[indexRepeatsArray, 1]++;
                                }
                            }
                        }

                        if (repeatsArray[indexRepeatsArray, 1] > 0)
                        {
                            isUnique = false;
                            indexRepeatsArray++;
                        }

                    }
                    if (isUnique)
                    {
                        Console.WriteLine("Данный массив не имеет повторяющихся элементов");
                    }
                    else
                    {
                        for (int i = 0; i < repeatsArray.GetLength(0); i++)
                        {
                            if (repeatsArray[i, 1] > 0)
                            {
                                Console.WriteLine($"Число {repeatsArray[i, 0]} встречается в массиве {repeatsArray[i, 1] + 1} раз(а)");
                            }
                        }
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
