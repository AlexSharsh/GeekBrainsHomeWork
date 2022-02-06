using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplexStruct;
using MyComplexClass;
using HomeWorkHelper;
using MyFractionClass;

namespace Lesson3
{
    class HomeWork3
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
                }

                if (Task == 0)
                    break;
            }
        }

        private static int GetTasksMenu()
        {
            int hw = 0;
            int taskAccess = 3;

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
            // а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
            // б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
            // в) Добавить диалог с использованием switch демонстрирующий работу класса.
            #region Task1
            int Item = 0;
            Complex complex1;
            complex1.re = 0;
            complex1.im = 0;

            Complex complex2;
            complex2.re = 0;
            complex2.im = 0;

            while (true)
            {
                Console.WriteLine("ЗАДАНИЕ 1");
                Console.WriteLine("а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.");
                Console.WriteLine("б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.");
                Console.WriteLine("в) Добавить диалог с использованием switch демонстрирующий работу класса.\n");
                 
                switch (Item)
                {
                    case 0: // a)

                        Item++;
                        Console.WriteLine("a):");
                        Console.WriteLine("Введите комплексное число 1:");
                        Helper.Input("действительная часть: ", ref complex1.re);
                        Helper.Input("комплексная часть: ", ref complex1.im);
                        Console.WriteLine($"{complex1}\n");

                        Console.WriteLine("Введите комплексное число 2:");
                        Helper.Input("действительная часть: ", ref complex2.re);
                        Helper.Input("комплексная часть: ", ref complex2.im);
                        Console.WriteLine($"{complex2}\n");

                        Console.WriteLine($"Сумма комплексных чисел: {(complex1.Plus(complex2))}");
                        Console.WriteLine($"Разность комплексных чисел: {(complex1.Minus(complex2))}");

                        Console.WriteLine("\n\n\n" + "ДЛЯ ПРОДОЛЖЕНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 1: // б)

                        Item++;
                        Console.WriteLine("\nб):");
                        Console.WriteLine("Введите комплексное число 1:");
                        Helper.Input("действительная часть: ", ref complex1.re);
                        Helper.Input("комплексная часть: ", ref complex1.im);
                        Console.WriteLine($"{complex1}\n");

                        Console.WriteLine("Введите комплексное число 2:");
                        Helper.Input("действительная часть: ", ref complex2.re);
                        Helper.Input("комплексная часть: ", ref complex2.im);
                        Console.WriteLine($"{complex2}\n");
                        ComplexClass cs1 = new ComplexClass(complex1.re, complex1.im);
                        ComplexClass cs2 = new ComplexClass(complex2.re, complex2.im);

                        Console.WriteLine($"Сумма комплексных чисел: {(cs1.Plus(cs2))}");
                        Console.WriteLine($"Разность комплексных чисел: {(cs1.Minus(cs2))}");
                        Console.WriteLine($"Умножение комплексных чисел: {(cs1.Mul(cs2))}");

                        Console.WriteLine("\n\n\n" + "ДЛЯ ПРОДОЛЖЕНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2: // в)

                        Item++;
                        Console.WriteLine("\nв):");
                        Console.WriteLine("СПИСОК ДОСТУПНЫХ ОПЕРАЦИЙ:");
                        Console.WriteLine("[0]-Выход");
                        Console.WriteLine("[1]-Сложение");
                        Console.WriteLine("[2]-Вычитание");
                        Console.WriteLine("[3]-Умножение");

                        Console.WriteLine("\nВведите комплексное число 1:");
                        Helper.Input("действительная часть: ", ref complex1.re);
                        Helper.Input("комплексная часть: ", ref complex1.im);
                        Console.WriteLine($"{complex1}\n");

                        Console.WriteLine("Введите комплексное число 2:");
                        Helper.Input("действительная часть: ", ref complex2.re);
                        Helper.Input("комплексная часть: ", ref complex2.im);
                        Console.WriteLine($"{complex2}\n");
                        ComplexClass cs3 = new ComplexClass(complex1.re, complex1.im);
                        ComplexClass cs4 = new ComplexClass(complex2.re, complex2.im);

                        int Op = 0;

                        while (true)
                        {
                            Helper.Input("Выберите действие: ", ref Op);

                            switch (Op)
                            {
                                case 1:
                                    Console.WriteLine($"Сумма: {(cs3.Plus(cs4))}\n");
                                    break;

                                case 2:
                                    Console.WriteLine($"Разность: {(cs3.Minus(cs4))}\n");
                                    break;

                                case 3:
                                    Console.WriteLine($"Перемножение: {(cs3.Mul(cs4))}\n");
                                    break;
                            }

                            if (Op == 0)
                            {
                                break;
                            }
                        }
                        
                        break;
                }
                
                if (Item == 3)
                {
                    break;
                }
            }
            


            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task2()
        {

            // ЗАДАНИЕ 2: 
            // С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
            // Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
            #region Task2
            Console.WriteLine("ЗАДАНИЕ 2");
            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). ");
            Console.WriteLine("Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.\n");

            Console.WriteLine("Начните ввод чисел (0 - Выход):");
            int Num;
            int Summ = 0;
            while (true)
            {
                if(!int.TryParse(Console.ReadLine(), out Num))
                {
                    Console.WriteLine("Введено не число");
                    continue;
                }

                if ((Num > 0) && Helper.IsOdd(Num))
                {
                    Summ += Num;
                }

                if (Num == 0)
                {
                    break;
                }
            }

            Console.WriteLine($"Сумма нечетных положительных чисел: {Summ}\n");

            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task3()
        {
            // ЗАДАНИЕ 3: 
            // *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
            // Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
            // Добавить свойства типа int для доступа к числителю и знаменателю;
            // Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; 
            // **Добавить проверку, чтобы знаменатель не равнялся 0.Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); 
            // ***Добавить упрощение дробей. 
            #region Task3
            Console.WriteLine("ЗАДАНИЕ 3");
            Console.WriteLine("*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.");
            Console.WriteLine("Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.");
            Console.WriteLine("Добавить свойства типа int для доступа к числителю и знаменателю;");
            Console.WriteLine("Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;");
            Console.WriteLine("**Добавить проверку, чтобы знаменатель не равнялся 0.Выбрасывать исключение ArgumentException(\"Знаменатель не может быть равен 0\");");
            Console.WriteLine("***Добавить упрощение дробей.\n");

            Console.WriteLine("СПИСОК ДОСТУПНЫХ ОПЕРАЦИЙ НАД ДРОБЯМИ:");
            Console.WriteLine("[0]-Выход");
            Console.WriteLine("[1]-Сложение");
            Console.WriteLine("[2]-Вычитание");
            Console.WriteLine("[3]-Умножение");
            Console.WriteLine("[4]-Деление");

            int num = 0, den = 0;

            Console.WriteLine("\nВведите дробь 1:");
            Helper.Input("числитель: ", ref num); 
            Helper.InputDenominator("знаменатель: ", ref den);
            FractionClass f1 = new FractionClass(num, den);
            Console.WriteLine($"{f1}\n");

            Console.WriteLine("\nВведите дробь 2:");
            Helper.Input("числитель: ", ref num);
            Helper.InputDenominator("знаменатель: ", ref den);
            FractionClass f2 = new FractionClass(num, den);
            Console.WriteLine($"{f2}\n");

            int Op = 0;
            FractionClass f = new FractionClass(0, 1);

            while (true)
            {
                Helper.Input("Выберите действие: ", ref Op);

                switch (Op)
                {
                    case 1:
                        f = f1.Plus(f2);
                        Console.WriteLine($"Сумма: {(f)} ({f.Dec})\n");
                        break;

                    case 2:
                        f = f1.Minus(f2);
                        Console.WriteLine($"Разность: {(f)} ({f.Dec})\n");
                        break;

                    case 3:
                        f = f1.Mul(f2);
                        Console.WriteLine($"Перемножение: {(f)} ({f.Dec})\n");
                        break;

                    case 4:
                        f = f1.Div(f2);
                        Console.WriteLine($"Деление: {(f)} ({f.Dec})\n");
                        break;
                }

                if (Op == 0)
                {
                    break;
                }
            }

            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
