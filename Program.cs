using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s; //Переменная, в которую пользователь вводит значение
            double x1, x2, x3, x4, y1, y2, y3, y4; // x1,x2,x3,y1,y2,y3 - координаты вершин треугольника. x4,y4 - координаты точки.

            Console.WriteLine("Введите координату x1 первой вершины треугольника");
            s = Console.ReadLine();
            if (Double.TryParse(s, out x1) == true)  // Проверяем , является ли вводимое значение, числовым типа double.
            {
                Console.WriteLine("Координата x1 - " + x1); //Если значение типа double, выводим значение в консоль.
            }
            else
            {
                Console.WriteLine("Ошибка ввода"); // Если координата, не типа double, то программа заканчивается.
                return;
            };

            Console.WriteLine("Введите координату y1 первой вершины треугольника");
            s = Console.ReadLine();
            if (Double.TryParse(s, out y1) == true)
            {
                Console.WriteLine("Координата y1 - " + y1);
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
                return;
            };

            Console.WriteLine("Введите координату x2 второй вершины треугольника");
            s = Console.ReadLine();
            if (Double.TryParse(s, out x2) == true)
            {
                Console.WriteLine("Координата x2 - " + x2);
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
                return;
            };

            Console.WriteLine("Введите координату y2 второй вершины треугольника");
            s = Console.ReadLine();
            if (Double.TryParse(s, out y2) == true)
            {
                Console.WriteLine("Координата y2 - " + y2);
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
                return;
            };

            Console.WriteLine("Введите координату x3 третьей вершины треугольника");
            s = Console.ReadLine();
            if (Double.TryParse(s, out x3) == true)
            {
                Console.WriteLine("Координата x3 - " + x3);
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
                return;
            };

            Console.WriteLine("Введите координату y3 третьей вершины треугольника");
            s = Console.ReadLine();
            if (Double.TryParse(s, out y3) == true)
            {
                Console.WriteLine("Координата y3 - " + y3);
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
                return;
            };

            if ((x1 == x2) && (x2 == x3) || (y1 == y2) && (y2 == y3)) //Проверка, является ли это треугольником, т.к в треугольнике не могут быть равны три значения x1,x2,x3, либо y1,y2,y3.
            {
                Console.WriteLine("Это не треугольник");
            }
            else
            {
                Console.WriteLine("Введите координату x4 точки");
                s = Console.ReadLine();

                if (Double.TryParse(s, out x4) == true)
                {
                    Console.WriteLine("Координата x4 - " + x4);
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                    return;
                };

                Console.WriteLine("Введите координату y4 точки");
                s = Console.ReadLine();
                if (Double.TryParse(s, out y4) == true)
                {
                    Console.WriteLine("Координата y4 - " + y4);
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                    return;
                };

                double a = (x1 - x4) * (y2 - y1) - (x2 - x1) * (y1 - y4);  // Формулы для вычесления , того , находится ли точка внутри треугольника.
                double b = (x2 - x4) * (y3 - y2) - (x3 - x2) * (y2 - y4);
                double c = (x3 - x4) * (y1 - y3) - (x1 - x3) * (y3 - y4);
                if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0)) // Если все три значения одинакового знака, то точка внутри треугольника. Если значение равно нулю, значит точка лежит на стороне треугольника. В ином случание, точка вне треугольника.
                {
                    Console.WriteLine("Точка внутри треугольника");
                }
                else
                {
                    Console.WriteLine("Точка не внутри треугольника");

                };









            }
        }
    }
}

