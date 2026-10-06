using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Program28
{
        class Program
        {
            static void Main()
            {
                double w, h;

                while (true)
                {
                    Console.Write("Вес (кг): ");
                    if (double.TryParse(Console.ReadLine()?.Trim(), out w) && w > 0) break;
                    Console.WriteLine("Ошибка: введите положительное число для веса.");
                }

                while (true)
                {
                    Console.Write("Рост (м): ");
                    if (double.TryParse(Console.ReadLine()?.Trim(), out h) && h > 0 && h < 3) break;
                    Console.WriteLine("Ошибка: введите рост в метрах (меньше 3).");
                }

                Console.WriteLine($"ИМТ: {w / (h * h):F2}");
            }
        }
    }






