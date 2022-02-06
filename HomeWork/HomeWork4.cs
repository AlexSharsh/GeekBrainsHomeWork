using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkHelper;
using HomeWorkStaticClass;
using HomeWorkArrayClass;
using HomeWorkArrayClassLib;

namespace Lesson4
{
    class HomeWork4
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
            int hw = 0;
            int taskAccess = 5;

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
            // Дан целочисленный массив из 20 элементов.
            // Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
            // Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, 
            // в которых только одно число делится на 3. 
            // В данной задаче под парой подразумевается два подряд идущих элемента массива.
            #region Task1
            Console.WriteLine("ЗАДАНИЕ 1");
            Console.WriteLine("Дан целочисленный массив из 20 элементов.");
            Console.WriteLine("Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.");
            Console.WriteLine("Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива,");
            Console.WriteLine("в которых только одно число делится на 3.");
            Console.WriteLine("В данной задаче под парой подразумевается два подряд идущих элемента массива.\n");

            int div = 3;
            int[] arr = new int[20];
            Helper.RandomFillArray(-10000, 10000, arr);
            Helper.PrintArrayAndHighlight(arr, div, ConsoleColor.Green);
            int counterPairs = Helper.GetPairs(arr, div);
            Console.WriteLine($"Кол-во пар: {counterPairs}");

            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task2()
        {

            // ЗАДАНИЕ 2: 
            // Реализуйте задачу 1 в виде статического класса StaticClass;
            // а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
            // б) Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
            // в)*Добавьте обработку ситуации отсутствия файла на диске.
            #region Task2
            Console.WriteLine("ЗАДАНИЕ 2");
            Console.WriteLine("Реализуйте задачу 1 в виде статического класса StaticClass;");
            Console.WriteLine("а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;");
            Console.WriteLine("б) Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;");
            Console.WriteLine("в)*Добавьте обработку ситуации отсутствия файла на диске.\n");

            string filePath = AppDomain.CurrentDomain.BaseDirectory + "HomeWork4.txt";
            int arraySize = 20;

            StaticClass sc = new StaticClass(filePath, arraySize, -10000, 10000);

            int[] arr = new int[arraySize];
            if(sc.FillArrayFormFile(arr, filePath))
            {
                int counterPairs = sc.PrintArrayAndGetPairs(arr, 3, ConsoleColor.Green);
            }
            else
            {
                Console.WriteLine("Отсутсвует файл с данными!!!");
            }
            

            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task3()
        {
            // ЗАДАНИЕ 3: 
            // а) Дописать класс для работы с одномерным массивом. 
            //    Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами 
            //    от начального значения с заданным шагом. 
            //    Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, 
            //    возвращающий новый массив с измененными знаками у всех элементов массива
            //    (старый массив, остается без изменений), метод Multi, умножающий каждый элемент массива на определённое число, 
            //    свойство MaxCount, возвращающее количество максимальных элементов.
            // б)**Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
            // в) ***Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int, int>)
            #region Task3
            Console.WriteLine("ЗАДАНИЕ 3");
            Console.WriteLine("а) Дописать класс для работы с одномерным массивом.");
            Console.WriteLine("   Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами");
            Console.WriteLine("   от начального значения с заданным шагом.");
            Console.WriteLine("   Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse,");
            Console.WriteLine("   возвращающий новый массив с измененными знаками у всех элементов массива");
            Console.WriteLine("   (старый массив, остается без изменений), метод Multi, умножающий каждый элемент массива на определённое число,");
            Console.WriteLine("   свойство MaxCount, возвращающее количество максимальных элементов.");
            Console.WriteLine("б)**Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки");
            Console.WriteLine("в) ***Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int, int>)\n");

            int arraySize = 20;
            int arrayStartVal = 10;
            int arrayStep = 5;

            #region a)
            Console.Write("\nа)РАБОТА ИЗ КЛАССА:\n");
            ArrayClass ac = new ArrayClass(arraySize, arrayStartVal, arrayStep, 0);
            ac.PrintArray();
            Console.Write($"Сумма элементов массива: {ac.Sum}\n");

            Console.WriteLine("\nИнверсия элементов массива:");
            int[] arrInv = ac.Inverse();
            Helper.PrintArrayAndHighlight(arrInv, 0, 0);

            Console.WriteLine("\nУмножение элементов массива на заданное число (3):");
            int[] arгMul = ac.Multi(3);
            Helper.PrintArrayAndHighlight(arгMul, 0, 0);

            Console.WriteLine($"\nMaxCount: {ac.MaxCount}");
            #endregion

            #region б)
            Console.Write("\n\nб)РАБОТА ИЗ БИБЛИОТЕКИ:\n");
            ArrayClassLib acl = new ArrayClassLib(arraySize, arrayStartVal, arrayStep, 0);
            acl.PrintArray();
            Console.Write($"Сумма элементов массива: {acl.Sum}\n");

            Console.WriteLine("\nИнверсия элементов массива:");
            int[] aclArrInv = acl.Inverse();
            Helper.PrintArrayAndHighlight(aclArrInv, 0, 0);

            Console.WriteLine("\nУмножение элементов массива на заданное число (3):");
            int[] aclArгMul = acl.Multi(3);
            Helper.PrintArrayAndHighlight(aclArгMul, 0, 0);
            #endregion

            #region в)
            Console.Write("\n\nв)ПОДСЧЁТ:\n");
            ArrayClass ac2 = new ArrayClass(arraySize, 0, 10, 1);
            Console.Write("Исходный массив:\t");
            ac2.PrintArray();
            int[] arr = ac2.Sort();
            Console.Write("Отсортированный массив:\t");
            Helper.PrintArrayAndHighlight(arr, 0, 0);
            Console.WriteLine($"MaxCount: {ac2.MaxCount}");
            Helper.PrintDictionary(ac2.GetStatistics());
            #endregion


            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task4()
        {
            // ЗАДАНИЕ 4: 
            // Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. 
            // Создайте структуру Account, содержащую Login и Password. 
            #region Task4
            Console.WriteLine("ЗАДАНИЕ 4");
            Console.WriteLine("Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. ");
            Console.WriteLine("Создайте структуру Account, содержащую Login и Password.\n");



            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task5()
        {
            // ЗАДАНИЕ 5: 
            //  а) Реализовать библиотеку с классом для работы с двумерным массивом. 
            //     Реализовать конструктор, заполняющий массив случайными числами. 
            //     Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного,
            //     свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, 
            //     метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
            // *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
            //**в) Обработать возможные исключительные ситуации при работе с файлами.
            #region Task5
            Console.WriteLine("ЗАДАНИЕ 5");
            Console.WriteLine("а) Реализовать библиотеку с классом для работы с двумерным массивом.");
            Console.WriteLine("   Реализовать конструктор, заполняющий массив случайными числами. ");
            Console.WriteLine("   Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного,");
            Console.WriteLine("   свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива,");
            Console.WriteLine("   метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).");
            Console.WriteLine("*б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.");
            Console.WriteLine("**в) Обработать возможные исключительные ситуации при работе с файлами.\n");



            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
