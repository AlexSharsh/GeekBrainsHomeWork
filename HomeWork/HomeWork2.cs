using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkHelper;

namespace Lesson2
{
    public class HomeWork2
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

                    case 6:
                        Task6();
                        break;

                    case 7:
                        Task7();
                        break;
                }

                if (Task == 0)
                    break;
            }
        }

        private static int GetTasksMenu()
        {
            int hw = 0;
            int taskAccess = 7;

            Console.WriteLine("СПИСОК ЗАДАНИЙ:");
            Console.WriteLine("[0]. Выход");
            for (int i = 1; i <= taskAccess; i++)
            {
                Console.WriteLine($"[{i}]. Задание {i}");
            }

            Console.WriteLine("\nВыберите задание: ");

            while (true)
            {
                hw = int.Parse(Console.ReadLine());

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
            // ЗАДАНИЕ 1: 
            // Написать метод, возвращающий минимальное из трёх чисел. 
            #region Task1
            Console.WriteLine("ЗАДАНИЕ 1");
            Console.WriteLine("Написать метод, возвращающий минимальное из трёх чисел.\n");

            Console.WriteLine("Введите три любых числа:");
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            int c = int.Parse(Console.ReadLine());

            int minVal = Helper.MIN(a, b, c);
            char minValLetter;

            minValLetter = minVal == a ? minValLetter = 'a' : minVal == b ? minValLetter = 'b' : minValLetter = 'c';

            Console.WriteLine("Минимальное значение " + $"{minValLetter}" + " = " + $"{minVal}");

            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task2()
        {
            // ЗАДАНИЕ 2: 
            // Написать метод подсчета количества цифр числа.
            #region Task2
            Console.WriteLine("ЗАДАНИЕ 2");
            Console.WriteLine("Написать метод подсчета количества цифр числа.\n");

            Console.Write("Введите целое число: ");
            string InputString = Console.ReadLine();

            int counter = 0;
            for(int i = 0; i < InputString.Length; i++)
            {
                if (Helper.IsNumber(InputString[i]))
                {
                    counter++;
                }
            }

            Console.WriteLine("Кол-во цифр: {0}", counter);


            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task3()
        {
            // ЗАДАНИЕ 3: 
            // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            #region Task3
            Console.WriteLine("ЗАДАНИЕ 3");
            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.\n");

            Console.WriteLine("Введите несколько чисел и 0 для завершения: ");

            int InputVal;
            int OddSumm = 0;

            while(true)
            {
                InputVal = int.Parse(Console.ReadLine());

                if (InputVal == 0)
                    break;

                if (Helper.IsOdd(InputVal))
                {
                    OddSumm += InputVal;
                }
            }

            Console.WriteLine($"Сумма нечетных чисел: {OddSumm}");
            

            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task4()
        {
            // ЗАДАНИЕ 4: 
            // Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
            // На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            // Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
            // С помощью цикла do while ограничить ввод пароля тремя попытками.
            #region Task4
            Console.WriteLine("ЗАДАНИЕ 4");
            Console.WriteLine("Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. ");
            Console.WriteLine("На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).");
            Console.WriteLine("Используя метод проверки логина и пароля, написать программу:\nпользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.");
            Console.WriteLine("С помощью цикла do while ограничить ввод пароля тремя попытками.\n\n");

            int Counter = 3;
            Console.WriteLine($"АУТЕНТИФИКАЦИЯ ПОЛЬЗОВАТЕЛЯ (кол-во попыток {Counter}):");

            do
            {
                Counter--;

                Console.Write("Логин: ");
                string Login = Console.ReadLine();
                Console.Write("Пароль: ");
                string Password = Console.ReadLine();

                if (Helper.isValidAuthentication(Login, Password))
                {
                    Console.Write("\n\n\nВЫ УСПЕШНО АВТОРИЗОВАЛИСЬ");
                    break;
                }
                else
                {
                    Console.Write($"Логин или Пароль не совпадают, повторите попытку ещё раз\n(кол-во оставшихся попыток {Counter})\n\n");
                    
                    if(Counter == 0)
                    {
                        Console.WriteLine("\n\n\nЛИМИТ ПОПЫТОК ИЗЧЕРПАН");
                    }
                }

            } while (Counter > 0);

            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task5()
        {
            // ЗАДАНИЕ 5: 
            // а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            // б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса
            #region Task5
            Console.WriteLine("ЗАДАНИЕ 5");
            Console.WriteLine("а) Написать программу, которая запрашивает массу и рост человека,\nвычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.");
            Console.WriteLine("б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса\n");

            Console.WriteLine("ВВЕДИТЕ ВАШИ ДАННЫЕ: ");

            Console.Write("Вес(кг): ");
            int iWeight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Рост(см): ");
            int iGrowth = Convert.ToInt32(Console.ReadLine());

            double BodyMassIndex = Helper.GetBodyMassIndex(iWeight, iGrowth);

            Console.Write("\n");

            // Выводим "Индекс массы тела"
            Console.WriteLine($"Индекс массы тела(кг/м2): {BodyMassIndex:F2}");
            Console.WriteLine($"Диагноз: {(Helper.GetBodyMassIndexDiagnosis(BodyMassIndex))}");

            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task6()
        {
            // ЗАДАНИЕ 6: 
            // Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
            // «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
            #region Task6
            Console.WriteLine("ЗАДАНИЕ 6");
            Console.WriteLine("Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.");
            Console.WriteLine("«Хорошим» называется число, которое делится на сумму своих цифр.\nРеализовать подсчёт времени выполнения программы, используя структуру DateTime.\n");

            DateTime StartTime = DateTime.Now;

            Console.WriteLine("Введите целое число в диапазоне от 1 до 1000 000 000. (0 - Выход): ");

            int Number = 0;
            int CounterGoodNumbers = 0;

            for (;;)
            {
                string strNumber = Console.ReadLine();

                if (!Helper.IsNumberString(strNumber))
                {
                    Console.WriteLine("Введённая строка не является целым числом, попробуйте ещё раз");
                    continue;
                }

                Number = Convert.ToInt32(strNumber);
                if (Number == 0)
                {
                    break;
                }

                if (Number < 0)
                {
                    Console.WriteLine("Введённо отрицательное число, попробуйте ещё раз");
                    continue;
                }

                if (!((1 <= Number) && (Number <= 1000000000)))
                {
                    Console.WriteLine("Введенное число вне диапазона, попробуйте ещё раз");
                    continue;
                }

                if (Helper.IsGoodNumber(Number))
                {
                    CounterGoodNumbers++;
                    Console.WriteLine("Хорошее число");
                }
                else
                {
                    Console.WriteLine("Число не относится к Хорошим");
                }
            }

            Console.WriteLine("\n\n\n" + "Кол-во хороших чисел: {0}", CounterGoodNumbers);
            Console.WriteLine("Время выполнения подпрограммы: {0}", DateTime.Now - StartTime);
            Console.WriteLine("ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task7()
        {
            // ЗАДАНИЕ 7: 
            // a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
            // б) *Разработать рекурсивный метод, который считает сумму чисел от a до b
            #region Task7
            Console.WriteLine("ЗАДАНИЕ 7");
            Console.WriteLine("a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).");
            Console.WriteLine("б) *Разработать рекурсивный метод, который считает сумму чисел от a до b\n");

            Console.WriteLine("Введите два целых числа A и B с условием, что A < B:");
            Console.Write("A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nРекурсивно выводим числа в диапазоне от {A} до {B}:");
            Helper.PrintRange(A, B);
            Console.WriteLine($"\nРекурсивно подсчитываем сумму чисел в диапазоне от {A} до {B}: {(Helper.GetSummInRange(A, B))}");


            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
