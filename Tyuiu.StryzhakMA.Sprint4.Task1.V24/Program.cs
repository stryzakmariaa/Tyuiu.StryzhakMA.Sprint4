using System.ComponentModel.DataAnnotations;
using Tyuiu.StryzhakMA.Sprint4.Task1.V24.Lib;

namespace Tyuiu.StryzhakMA.Sprint4.Task1.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Стрыжак М. А. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Вариант 24                                                              *");
            Console.WriteLine("* Выполнила: Стрыжак М. А. | АСОиУб-26-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 5 подсчитать произведение   *");
            Console.WriteLine("* нечетных элементов массива. С клавиатуры:                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 2, 2, 2, 5, 5, 3, 4, 2, 5, 2, 5, 3, 4, 3, 5, 2                          *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len = 16;
            int[] numsArray = new int[len];

            for (int i = 0; i < len; i++)
            { 
                Console.Write("Введите значение " + i + " элемента массива: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i < len; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Произведение нечетных элементов массива равно: " + res);

            Console.ReadKey();
        }
    }
}
