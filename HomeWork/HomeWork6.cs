using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HomeWorkHelper;
using HomeWorkStudent;

namespace Lesson6
{
    internal class HomeWork6
    {
        #region Task1Functions
        public delegate double Fun(double x, double y);

        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("------- A ------- X ------- Y ----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
        }

        // Создаем метод ParabolicFunc для передачи его в качестве параметра в Table
        public static double ParabolicFunc(double a, double x)
        {
            return a * Math.Pow(x, 2);
        }

        // Создаем метод WaveFunc для передачи его в качестве параметра в Table
        public static double WaveFunc(double a, double x)
        {
            return a * Math.Sin(x);
        }
        #endregion


        #region Task2Functions
        public delegate double Fun2(double x);


        public static double ExampleFunc1(double x)
        {
            return x;
        }

        public static double ExampleFunc2(double x)
        {
            return Math.Pow(x, 2);
        }

        public static double ExampleFunc3(double x)
        {
            return Math.Pow(x, 3);
        }

        public static double ExampleFunc4(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static void SaveFunc(Fun2 F2, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F2(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        public static double[] Load2(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            List<double> list = new List<double>();
            double d;
            min = double.MaxValue;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                list.Add(d);
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            
            return list.ToArray();
        }
        #endregion


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
            int hw = -1;
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
            // ЗАДАНИЕ 1: 
            // Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
            // Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
            #region Task1
            Console.WriteLine("ЗАДАНИЕ 1");
            Console.WriteLine("Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).");
            Console.WriteLine("Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).\n");

            
            Console.WriteLine("Таблица функции ParabolicFunc:");
            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table(new Fun(ParabolicFunc), 2, -2, 2);

            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");          
            Table(ParabolicFunc, 2, -2, 2);

            Console.WriteLine("Таблица функции a*Sin(x):");
            Table(WaveFunc, 4, -2, 2);

            Console.WriteLine("Таблица функции a*x^2:");
            Table(delegate (double a, double x) { return a * Math.Pow(x, 2); }, 5, 0, 3);


            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task2()
        {

            // ЗАДАНИЕ 2: 
            // Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
            // а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке
            //    находить минимум.Использовать массив(или список) делегатов, в котором хранятся различные функции.
            // б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.
            //    Пусть она возвращает минимум через параметр(с использованием модификатора out).
            #region Task2
            Console.WriteLine("ЗАДАНИЕ 2");
            Console.WriteLine("Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.");
            Console.WriteLine("а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке");
            Console.WriteLine("   находить минимум.Использовать массив(или список) делегатов, в котором хранятся различные функции.");
            Console.WriteLine("б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.");
            Console.WriteLine("   Пусть она возвращает минимум через параметр(с использованием модификатора out).\n");

            // б)
            #region a)
            Console.WriteLine("a):");
            string[] nameFunc = { "Выход", "Линейная", "Парабола", "Гипербола", "Квадратная" };
            Fun2[] Funcs = new Fun2[] { null, ExampleFunc1, ExampleFunc2, ExampleFunc3, ExampleFunc4 };

            Console.WriteLine("СПИСОК ДОСТУПНЫХ ФУНКЦИЙ:");
            for (int i = 0; i < nameFunc.Length; i++)
            {
                Console.WriteLine($"[{i}]. {nameFunc[i]}");
            }

            int min = 0, max = 0;
            double step = 0.0;
            Console.WriteLine();
            Helper.Input("Введите нижнюю границу диапазона поиска минимума: ", ref min);
            Helper.Input("Введите верхнюю границу диапазона поиска минимума: ", ref max);
            Helper.Input("Введите шаг поиска: ", ref step);

            int action = 0;
            while (true)
            {
                Helper.Input("Выберите функцию: ", ref action);

                if (action == 0)
                    break;

                if(action >= Funcs.Length)
                {
                    Console.WriteLine("Некорректный выбор, повторите ввод");
                    continue;
                }

                SaveFunc(Funcs[action], AppDomain.CurrentDomain.BaseDirectory + "data.bin", min, max, step);
                Console.WriteLine($"Минимум:{Load(AppDomain.CurrentDomain.BaseDirectory + "data.bin"):F2}");
            }
            #endregion

            // б)
            #region б)
            Console.WriteLine("\nб):");
            action = 0;
            while (true)
            {
                Helper.Input("Выберите функцию: ", ref action);

                if (action == 0)
                    break;

                if (action >= Funcs.Length)
                {
                    Console.WriteLine("Некорректный выбор, повторите ввод");
                    continue;
                }

                SaveFunc(Funcs[action], AppDomain.CurrentDomain.BaseDirectory + "data.bin", min, max, step);
                double minVal;
                double[] dots = Load2(AppDomain.CurrentDomain.BaseDirectory + "data.bin", out minVal);
                for (int i = 0; i < dots.Length; i++)
                {
                    Console.Write($"{dots[i]:F2} ");
                }
                Console.WriteLine();
                Console.WriteLine($"Минимум:{minVal:F2}");
            }
            #endregion


            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task3()
        {
            // ЗАДАНИЕ 3: 
            // Переделать программу Пример использования коллекций для решения следующих задач:
            // а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
            // б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
            // в) отсортировать список по возрасту студента;
            // г) *отсортировать список по курсу и возрасту студента;
            #region Task3
            Console.WriteLine("ЗАДАНИЕ 3");
            Console.WriteLine("Переделать программу Пример использования коллекций для решения следующих задач:");
            Console.WriteLine("а) Подсчитать количество студентов учащихся на 5 и 6 курсах;");
            Console.WriteLine("б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);");
            Console.WriteLine("в) отсортировать список по возрасту студента;");
            Console.WriteLine("г) *отсортировать список по курсу и возрасту студента;\n");

            // Создаем список студентов
            List<Student> list = new List<Student>();                             
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "StudentList.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], s[2], int.Parse(s[3]), int.Parse(s[4])));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();

            // а)
            Console.WriteLine("a):");
            Console.WriteLine("Кол-во студетов 5 курса: {0}", Student.GetCourse(list, 5));
            Console.WriteLine("Кол-во студетов 6 курса: {0}", Student.GetCourse(list, 6));
            Console.WriteLine("Магистров (5 и 6 курсы): {0}", Student.GetMagistrs(list));

            // б)
            Console.WriteLine("\nб):");
            Console.Write("Кол-во студентов в возрасте от {0} до {1} лет: {2}", 18, 20, Student.GetStudentInRangeAge(list, 18, 20));
            Dictionary<int, int> stat1 = Student.GetStatisticsInRangeAge(list, 18, 20);
            Dictionary<int, int> stat2 = Student.GetStatisticsInRangeAgeByCourse(list, 18, 20);
            Student.Print("лет", stat1);
            Student.Print("курс", stat2);

            // в)
            Console.WriteLine("\n\nв):");
            list.Sort(new Comparison<Student>(MyDelegatAge));
            Student.Print(list);

            // г)
            Console.WriteLine("\nг):");
            list.Sort(new Comparison<Student>(MyDelegatCourseAndAge));
            Student.Print(list);

            Console.WriteLine();
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();

            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        // Создаем метод для сравнения для экземпляров
        static int MyDelegatAge(Student st1, Student st2)          
        {
            return st1.age - st2.age;          
        }

        static int MyDelegatCourseAndAge(Student st1, Student st2)
        {
            int res = st1.course - st2.course;
            if(res == 0)
                res = st1.age - st2.age;
            return res;
        }
    }
}
