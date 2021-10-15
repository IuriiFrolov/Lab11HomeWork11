using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11HomeWork11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {//Ввод данных
                Console.WriteLine("Программа для решения линейного типа 0=kx+b");
                Console.Write("Введите коэффиициент k = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите коэффиициент b = ");
                double f = Convert.ToDouble(Console.ReadLine());
                // Программа на основе структуры LinearEquation
                LinearEquation linearEquation = new LinearEquation { K = a, b = f };
                Console.WriteLine();
                linearEquation.Root();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message);}
            Console.ReadKey();
        }
        struct LinearEquation
        {//Поля
            public const int a = 0;
            double k;
            public double b { get; set; }
            #region Свойство K
            public double K
            {
                set
                {
                    if (value!=0)
                    {
                        k = value;
                    }
                    else
                    {
                        Console.WriteLine("Коэффициент k не может быть равен 0 !");
                    }
                }
                get
                {
                    return k;
                }
            }
            #endregion
            //Конструктор ?

            //Метод Root
            public void Root()
            {
                double x = -b / k;
                Console.WriteLine("Решение уравнения х = {0:f2}", x);
            }



        }
    }
}
