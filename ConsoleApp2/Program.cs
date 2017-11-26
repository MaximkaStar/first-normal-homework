using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Веди пожалуйста первое число:");
            int FirstNumber = int.Parse(Console.ReadLine());
            Console.Write("Веди пожалуйста второе число:");
            int SecondNumber = int.Parse(Console.ReadLine());
            Console.Write("Веди пожалуйста третье число:");
           int ThirdNumber = int.Parse(Console.ReadLine());
            /*Console.WriteLine(FirstNumber, SecondNumber, ThirdNumber);*/
            Console.Clear();

            Console.WriteLine("Второе задание: Вывести три числа (5,15,21) одно под другим.");
            const int number = 5, scndnumber = 15, thrdnumber = 21;
            Console.WriteLine(number);
            Console.WriteLine(scndnumber);
            Console.WriteLine(thrdnumber);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Третье задание: Посчитать сколько сантиметров в метре. (полных)");
            Console.Write("Ведите пожалуйста сантиметры:");
            int Santimeters = int.Parse(Console.ReadLine());
            Console.Write("В процессе...");
            double Meters = Santimeters / 100;
            Console.Write("Ответ:");
            Console.WriteLine(Meters);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Четвертое задание: Прошло 234 дня. Сколько полных недель прошло с того момента?");
            const int Days = 234;
            int Weeks = Days / 7;
            Console.Write("Ответ:");
            Console.WriteLine(Weeks);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Пятое задание.");
            const int Dicker = 10;
            Console.WriteLine("Введи двухзначное число");
            int Number = int.Parse(Console.ReadLine());
            int dickers = Number / Dicker;
            int Units = Number - Dicker * dickers;
            int Value = dickers * Units;
            int Variable = dickers + Units;
            int Composition = dickers * Units;
            Console.Write("Единичек:");
            Console.WriteLine(Units);
            Console.Write("Десятков:");
            Console.WriteLine(dickers);
            Console.Write("Сумма:");
            Console.WriteLine(Variable);
            Console.Write("Произведение:");
            Console.WriteLine(Composition);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Шестое задание.");
            const bool A = true;
            const bool B = false;
            const bool C = false;
            Console.Write("Введи A:");
            Console.WriteLine(A);
            Console.Write("Введи B:");
            Console.WriteLine(B);
            Console.Write("Введи C:");
            Console.WriteLine(C);

            Console.Write("A||B:");
            Console.WriteLine(A || B);
            Console.Write("A&&B:");
            Console.WriteLine(A && B);
            Console.Write("B||C:");
            Console.WriteLine(B || C);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Седьмое задание");
            Console.Write("Введи радиус круга: ");
            double Radius = double.Parse(Console.ReadLine());
            Console.Write("Введи сторону квадрата");
            double SideSquare = double.Parse(Console.ReadLine());
            if (Radius > SideSquare)
            {
                Console.Write("Радиус круга больше.");
            }
            else
            {
                Console.Write("Сторона квадрата больше.");
            }
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Восьмое задание");
            Console.Write("Введи массу первого обьекта:");
            double FirstHeft = double.Parse(Console.ReadLine());
            Console.Write("Введи массу второго обьекта:");
            double SecondHeft = double.Parse(Console.ReadLine());
            Console.Write("Введи обьем первого обьекта:");
            double FirstScope = double.Parse(Console.ReadLine());
            Console.Write("Введи обьем второго обьекта:");
            double SecondScope = double.Parse(Console.ReadLine());
            double FirstDenisty = FirstHeft / FirstScope;
            double SecondDenisty = SecondHeft / SecondScope;
            if (FirstDenisty > SecondDenisty)
            {
                Console.Write("Плотность первого больше.");
            }
            else
            {
                Console.Write("Плотность второго больше.");
            }

            Console.WriteLine("Девятое задание.");
            Console.Write("Введи сопротивление первого:");
            double FirstResist = double.Parse(Console.ReadLine());
            Console.Write("Введи сопротивление второго:");
            double SecondResist = double.Parse(Console.ReadLine());
            Console.Write("Введи напряжение первого:");
            double FirstVoltage = double.Parse(Console.ReadLine());
            Console.Write("Введи напряжение второго:");
            double SecondVoltage = double.Parse(Console.ReadLine());
            double FirstAmperage = FirstVoltage / FirstResist;
            double SecondAmperage = SecondVoltage / SecondResist;
            if (FirstAmperage>SecondAmperage)
            {
                Console.Write("Побежит по второму.");
            }
            else
            {
                Console.Write("Побежит по первому.");
            }

            
        }
    }
}
