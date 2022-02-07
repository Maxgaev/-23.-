using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Задание_23.Асинхронное
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            //FacAsync(n);
            repeat:
            Console.WriteLine("Введите число\n");
            int n1 = Convert.ToInt32(Console.ReadLine()); // Факториал числа
            FacAsync(n1);
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nНажмите <Enter>, если хотите сбросить результат и начать заново\nДля выхода, нажмите любую клавишу...");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                goto repeat;
            }
        }
        static void Fac(int n1)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"\nFactorial числа {n1}!:\t");  // Factorial! число
            int n2 = 1;
            do
            {
                n2 = n2 * n1;
                n1 = n1 - 1;
            }
            while (n1 > 1);
            Console.Write("{0}", n2); // результат
        }

        static async void FacAsync(int n1)
        {
            await Task.Run(() => Fac(n1));
        }

        //static void Fac(int n)
        //{
        //    Console.WriteLine("\nМетод Factorial: end\n");
        //    int s = 1;
        //    for (int i = 1; i < n; i++)
        //    {
        //        s*=i;
        //        Thread.Sleep(10);
        //    }
        //    Console.WriteLine(s);

        //    Console.ForegroundColor = ConsoleColor.DarkGreen;
        //    Console.WriteLine($"\nФакториал числа:\t\t {n-1}! = {s}");

        //}


        //static async void FacAsync(int n)
        //{
        //    await Task.Run(()=> Fac(n));
        //}
    }
}
