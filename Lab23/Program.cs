using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Определяем факториал числа:");
            int n = Convert.ToInt32(Console.ReadLine());
            FactAsync(n);

            Console.ReadKey();
        }

        static void Fact(int n)// метод для определения факториала
        {
            int s = 1;// факториал нуля и единицы это 1.
            for (int i = 1; i < n+1; i++) 
            {
                s *= i;// произведение всех чисел
                Thread.Sleep(10);// задержка
            }
            Console.WriteLine(s);
        }
        static async void FactAsync(int n)// асинхронный метод
        {
            await Task.Run(() => Fact(n));// создаем задачу
        }
    }
}
