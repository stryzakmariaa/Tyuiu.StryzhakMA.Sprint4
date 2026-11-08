using Tyuiu.StryzhakMA.Sprint4.Task6.V13.Lib;

namespace Tyuiu.StryzhakMA.Sprint4.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Стрыжак М. А. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Тема: Класса Array                                                      *");
            Console.WriteLine("* Вариант 13                                                              *");
            Console.WriteLine("* Выполнила: Стрыжак М. А. | АСОиУб-26-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Ford, Toyota, Honda, Chevrolet, Mercedes,  *");
            Console.WriteLine("* BMW, Audi]. используя класс Array подсчитайте количество элементов,     *");
            Console.WriteLine("*  длина которых больше 4.                                                *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var auto = new string[] { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < auto.Length; i++)
            {
                Console.WriteLine(auto[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов длина которых = 4:");

            int nums = ds.Calculate(auto);

            Console.WriteLine(nums);
            Console.ReadKey();
        }
    }
}
