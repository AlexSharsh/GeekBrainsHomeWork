using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkHelper;

namespace Lesson1
{
    public class HomeWork1
    {
        public static void Run()
        {
            while (true)
            {
                int Task = GetTasksMenu();

                switch (Task)
                {
                    case 1:
                        Task1();
                        break;

                    case 2:
                        Task2();
                        break;

                    case 3:
                        Task3();
                        break;

                    case 4:
                        Task4();
                        break;

                    case 5:
                        Task5();
                        break;
                }

                if (Task == 0)
                    break;
            }
        }

        private static int GetTasksMenu()
        {
            int hw = -1;
            int taskAccess = 5;

            Console.WriteLine("СПИСОК ЗАДАНИЙ:");
            Console.WriteLine("[0]. Выход");
            for(int i = 1; i <= taskAccess; i++)
            {
                Console.WriteLine($"[{i}]. Задание {i}");
            }
            
            Console.WriteLine("\nВыберите задание: ");

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out hw))
                {
                    hw = -1;
                }

                if ((0 <= hw) && (hw <= taskAccess))
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("недопустимый номер, попробуйте ещё раз");
                }
            }

            return hw;
        }

        private static void Task1()
        {
            //Console.Title = "Анкета";

            // ЗАДАНИЕ 1: 
            // Написать программу «Анкета». 
            // Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
            // В результате вся информация выводится в одну строчку.
            #region Task1
            Console.WriteLine("ЗАДАНИЕ 1");
            Console.WriteLine("Написать программу «Анкета».");
            Console.WriteLine("Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).");
            Console.WriteLine("В результате вся информация выводится в одну строчку.\n");

            Console.WriteLine("ВВЕДИТЕ ВАШИ ДАННЫЕ: ");
            Console.Write("Имя: ");
            string Name = Console.ReadLine();

            Console.Write("Фамилия: ");
            string Surname = Console.ReadLine();

            Console.Write("Возраст: ");
            string Age = Console.ReadLine();

            Console.Write("Рост(см): ");
            string Growth = Console.ReadLine();

            Console.Write("Вес(кг): ");
            string Weight = Console.ReadLine();

            Console.Write("\n");

            // Выводим введенные параметры
            Console.WriteLine("Имя: " + Name + "  " + "Фамилия: " + Surname + "  " + "Возраст: " + Age + "  " + "Рост(см): " + Growth + "  " + "Вес(кг): " + Weight);
            Console.WriteLine("Имя: {0}  Фамилия: {1}  Возраст: {2}  Рост(см): {3}  Вес(кг): {4}", Name, Surname, Age, Growth, Weight);
            Console.WriteLine($"Имя: {Name}  Фамилия: {Surname}  Возраст: {Age}  Рост(см): {Growth}  Вес(кг): {Weight}");

            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task2()
        {

            // ЗАДАНИЕ 2: 
            // Ввести вес и рост человека. 
            // Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах. 
            #region Task2
            Console.WriteLine("ЗАДАНИЕ 2");
            Console.WriteLine("Ввести вес и рост человека.");
            Console.WriteLine("Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.\n");

            Console.WriteLine("ВВЕДИТЕ ВАШИ ДАННЫЕ: ");

            Console.Write("Вес(кг): ");
            int iWeight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Рост(см): ");
            int iGrowth = Convert.ToInt32(Console.ReadLine());

            double BodyMassIndex = Helper.GetBodyMassIndex(iWeight, iGrowth);

            Console.Write("\n");

            // Выводим "Индекс массы тела"
            Console.WriteLine($"Индекс массы тела(кг/м2): {BodyMassIndex:F2}");

            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task3()
        {
            // ЗАДАНИЕ 3: 
            // Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).   
            // Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой) 
            #region Task3
            Console.WriteLine("ЗАДАНИЕ 3");
            Console.WriteLine("Написать программу, которая подсчитывает расстояние между точками с координатами\nx1, y1 и x2, y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).");
            Console.WriteLine("Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой)\n");

            Console.WriteLine("ВВЕДИТЕ КООРДИНАТЫ ДВУХ ТОЧЕК: ");

            Console.WriteLine("Координаты Точки 1:");
            Console.Write("X1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine("Координаты Точки 2:");
            Console.Write("X2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");

            // Получим расстояние между двумя точками
            double r = Helper.GetDistance(x1, y1, x2, y2);

            // Выводим "Индекс массы тела"
            Console.WriteLine($"Расстояние между двумя точками: {r:F2}");

            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task4()
        {
            // ЗАДАНИЕ 4: 
            // Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
            #region Task4
            Console.WriteLine("ЗАДАНИЕ 4");
            Console.WriteLine("Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.\n");

            Console.WriteLine("СПОСОБ 1: (с использовнием третьей переменной)");
            Console.WriteLine("ВВЕДИТЕ ДВА ЦЕЛЫХ ЧИСЛА: ");

            Console.Write("Число 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Число 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            // Обменяем значения с использованием третьей переменной
            int num3 = num1;
            num1 = num2;
            num2 = num3;

            // Выводим числа после обмена
            Console.WriteLine($"Число 1: {num1}");
            Console.WriteLine($"Число 2: {num2}");

            Console.Write("\n\n");

            Console.WriteLine("СПОСОБ 2: (без использовнием третьей переменной)");
            Console.WriteLine("ВВЕДИТЕ ДВА ЦЕЛЫХ ЧИСЛА: ");

            Console.Write("Число 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Число 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            // Обменяем значения с использованием третьей переменной
            num1 += num2;
            num2 = num2 - num1;
            num2 = -num2;
            num1 = num1 - num2;

            // Выводим "Индекс массы тела"
            Console.WriteLine($"Число 1: {num1}");
            Console.WriteLine($"Число 2: {num2}");

            Console.Write("\n\n");

            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task5()
        {
            // ЗАДАНИЕ 5: 
            // Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            #region Task5
            Console.WriteLine("ЗАДАНИЕ 5");
            Console.WriteLine("Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.\n");

            Console.WriteLine("ВВЕДИТЕ ВАШИ ДАННЫЕ: ");
            Console.Write("Имя: ");
            string Name5 = Console.ReadLine();

            Console.Write("Фамилия: ");
            string Surname5 = Console.ReadLine();

            Console.Write("Город проживания: ");
            string City5 = Console.ReadLine();

            Console.Write("\n");

            // Выводим данные по центру экрана
            int CursorX = (Console.WindowWidth - Name5.Length) / 2;
            int CursorY = (Console.WindowHeight) / 2;
            Console.SetCursorPosition(CursorX, CursorY);
            Console.WriteLine(Name5);

            Console.SetCursorPosition(CursorX, CursorY + 1);
            Console.WriteLine(Surname5);

            Console.SetCursorPosition(CursorX, CursorY + 2);
            Console.WriteLine(City5);

            Console.Write("\n\n");

            Helper.Print(Name5, CursorX, CursorY + 4);
            Helper.Print(Surname5, CursorX, CursorY + 5);
            Helper.Print(City5, CursorX, CursorY + 6);

            Console.Write("\n\n");

            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
