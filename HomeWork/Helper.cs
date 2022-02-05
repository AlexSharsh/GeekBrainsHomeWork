using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkHelper
{
    public class Helper
    {
        const string title = "Домашняя работа";
        const string fio = "Шаршуков Александр Сергеевич";
        const string MyLogin = "root";
        const string MyPassword = "GeekBrains";

        static bool fIsInitRecursiveSumm = false;
        static int ValueForRecursiveSumm;

        public static void PrintTitle()
        {
            Console.Title = title;
        }

        public static void PrintStudentInfo()
        {
            Console.WriteLine(fio);
        }

        /// <summary>
        /// Получить индекс массы тела (кг/м2)
        /// </summary>
        /// <param name="WeightInKg">Вес в килограммах</param>
        /// <param name="GrowthInCm">Рост в сантиметрах</param>
        /// <returns></returns>
        public static double GetBodyMassIndex(int WeightInKg, int GrowthInCm)
        {
            double dWeight = Convert.ToDouble(WeightInKg);
            double dGrowth = Convert.ToDouble(GrowthInCm) / 100;

            return dWeight / (dGrowth * dGrowth);
        }

        /// <summary>
        /// Получить диагноз по индексу массы тела
        /// </summary>
        /// <param name="BodyMassIndex">Индекс массы тела (кг/м2)</param>
        /// <returns></returns>
        public static string GetBodyMassIndexDiagnosis(double BodyMassIndex)
        {
            // Интерпретация индекса массы тела:
            // ИМТ < 18.5:	Ниже нормального веса
            // ИМТ >= 18.5 И < 25:	Нормальный вес
            // ИМТ >= 25 И < 30:	Избыточный вес
            // ИМТ >= 30 И < 35:	Ожирение I степени
            // ИМТ >= 35 И < 40:	Ожирение II степени
            // ИМТ >= 40:	Ожирение III степени

            string Diagnosis;

            if (BodyMassIndex < 18.5f)
            {
                Diagnosis = "Вес ниже нормального";
            }
            else if ((18.5f <= BodyMassIndex) && (BodyMassIndex < 25.0f))
            {
                Diagnosis = "Вес в норме";
            }
            else if ((25.0f <= BodyMassIndex) && (BodyMassIndex < 30.0f))
            {
                Diagnosis = "Избыточный вес";
            }
            else if ((30.0f <= BodyMassIndex) && (BodyMassIndex < 35.0f))
            {
                Diagnosis = "Ожирение I степени";
            }
            else if ((35.0f <= BodyMassIndex) && (BodyMassIndex < 40.0f))
            {
                Diagnosis = "Ожирение II степени";
            }
            else //if (BodyMassIndex >= 40.0f)
            {
                Diagnosis = "Ожирение III степени";
            }

            return Diagnosis;
        }

        /// <summary>
        /// Вычисление расстояния между двумя точками
        /// </summary>
        /// <param name="x1">Точка 1: координата X</param>
        /// <param name="y1">Точка 1: координата Y</param>
        /// <param name="x2">Точка 2: координата X</param>
        /// <param name="y2">Точка 2: координата Y</param>
        /// <returns></returns>
        public static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        /// <summary>
        /// Печать строки с заданными координатами
        /// </summary>
        /// <param name="str">Строка для печати</param>
        /// <param name="CursorX">Координаты курсора по горизонтали</param>
        /// <param name="CursorY">Координаты курсора по вертикали</param>
        public static void Print(string str, int CursorX, int CursorY)
        {
            Console.SetCursorPosition(CursorX, CursorY + 1);
            Console.WriteLine(str);
        }

        /// <summary>
        /// Проверка логина и пароля
        /// </summary>
        /// <param name="Login">Логин</param>
        /// <param name="Password">Пароль</param>
        /// <returns></returns>
        public static bool isValidAuthentication(string Login, string Password)
        {
            return ((MyLogin.Equals(Login)) && (MyPassword.Equals(Password))) ? true : false;
        }

        /// <summary>
        /// Получение минмального значения из трёх
        /// </summary>
        /// <param name="a">Значение 1</param>
        /// <param name="b">Значение 2</param>
        /// <param name="c">Значение 3</param>
        /// <returns></returns>
        public static int MIN(int a, int b, int c)
        {
            return a > b ? (c > b ? b : c) : (a < c ? a : c);
        }

        /// <summary>
        /// Проверка символа на число
        /// </summary>
        /// <param name="Ch">Символ для проверки</param>
        /// <returns></returns>
        public static bool IsNumber(char Ch)
        {
            return (('0' <= Ch) && (Ch <= '9')) ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Ch"></param>
        /// <returns></returns>
        public static bool IsNumberString(string Str)
        {
            for(int i = 0; i < Str.Length; i++)
            {
                if(!IsNumber(Str[i]))
                {
                    if (!((i == 0) && (Str[i] == '-')))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Проверка числа на нечетность
        /// </summary>
        /// <param name="Val"></param>
        /// <returns></returns>
        public static bool IsOdd(int Val)
        {
            return (Val % 2 > 0) ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static bool IsGoodNumber(int Number)
        {
            int Summ = GetSummDigitsOfNumber(Number);

            return (Number % Summ > 0) ? false : true;
        }

        /// <summary>
        /// Подсчет суммы чисел переданного числа
        /// </summary>
        /// <param name=""></param>
        public static int GetSummDigitsOfNumber(int Number)
        {
            string strNumber = Convert.ToString(Number);
            int Summ = 0;

            for(int i = 0; i < strNumber.Length; i++)
            {
                Summ += (strNumber[i] - '0');
            }

            return Summ;
        }

        /// <summary>
        /// Рекурсивный вывода чисел в диапазоне от Head до Tail
        /// </summary>
        /// <param name="Head">Начало диапазона</param>
        /// <param name="Tail">Конец диапазона</param>
        public static void PrintRange(int Head, int Tail)
        {
            Console.Write(Head + " ");

            if (Head == Tail)
            {
                return;
            }

            PrintRange(Head + 1, Tail);
        }

        /// <summary>
        /// Рекрсивный подсчет суммы чисел в диапазоне  от Head до Tail
        /// </summary>
        /// <param name="Head">Начало диапазона</param>
        /// <param name="Tail">Конец диапазона</param>
        /// <returns></returns>
        public static int GetSummInRange(int Head, int Tail)
        {
            if (!fIsInitRecursiveSumm)
            {
                fIsInitRecursiveSumm = true;
                ValueForRecursiveSumm = 0;
            }

            if (Head <= Tail)
            {
                ValueForRecursiveSumm += Head;
                Head = GetSummInRange(Head + 1, Tail);
            }

            fIsInitRecursiveSumm = false;
            return ValueForRecursiveSumm;
        }

        /// <summary>
        /// Запрос на ввод числа
        /// </summary>
        /// <param name="outStr">Информационная строка</param>
        /// <param name="num">Указаетль на переменную</param>
        public static void InputNumber(String outStr, ref double num)
        {
            Console.Write(outStr);
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Введено некорректное число, повторите ввод");
                }
                else
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Запрос на ввод числа
        /// </summary>
        /// <param name="outStr">Информационная строка</param>
        /// <param name="num">Указаетль на переменную</param>
        public static void InputNumber(String outStr, ref int num)
        {
            Console.Write(outStr);
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Введено некорректное число, повторите ввод");
                }
                else
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Запрос на ввод делителя
        /// </summary>
        /// <param name="outStr">Информационная строка</param>
        /// <param name="den">Указаетль на переменную</param>
        public static void InputDenominator(String outStr, ref int den)
        {
            Console.Write(outStr);
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out den))
                {
                    Console.WriteLine("Введено некорректное число, повторите ввод");
                    
                }
                else if (den == 0)
                {
                    Console.WriteLine("Знаменатель не может быть равен 0, повторите ввод");
                }
                else
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Заполнение массива случайными числами в заданном диапазоне
        /// </summary>
        /// <param name="min">Нижняя граница диапазона</param>
        /// <param name="max">Верхняя граница диапазона</param>
        /// <param name="arr">Массив для заполнения</param>
        public static void RandomFillArray(int min, int max, int[] arr)
        {
            Random r = new Random();

            for (int i = 0; i < arr.Length; i ++)
            {
                arr[i] = r.Next(min, max);
            }
        }

        /// <summary>
        /// Вывод массива на печать
        /// </summary>
        /// <param name="arr">Массив для печати</param>
        /// <param name="arr">Массив для печати</param>
        public static void PrintArrayAndHighlight(int[] arr, int div, ConsoleColor color)
        {
            ConsoleColor currentColor = Console.ForegroundColor;

            for (int i = 0; i < arr.Length; i++)
            {
                if (div != 0)
                {
                    if(IsIntegerDivision(arr[i], div))
                    {
                        Console.ForegroundColor = color;
                    }
                }
                
                Console.Write($"{arr[i]} ");
                Console.ForegroundColor = currentColor;
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Проверка делимости числа нацело на div
        /// </summary>
        /// <param name="num">Проверяемое число</param>
        /// <param name="div">Делитель</param>
        /// <returns></returns>
        public static bool IsIntegerDivision(int num, int div)
        {
            if ((num % div) == 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Подстчёт кол-ва пар чисел в массиве, где в паре только одно число делиться на divider
        /// </summary>
        /// <param name="arr">Массив для поиска</param>
        /// <param name="div">Делитель при деление на который ищем пары</param>
        /// <returns></returns>
        public static int GetPairs(int[] arr, int div)
        {
            int counterPairs = 0;
            bool fPrev, fNext;

            fPrev = IsIntegerDivision(arr[0], div);

            for (int i = 1; i < (arr.Length - 1); i++)
            {
                fNext = IsIntegerDivision(arr[i], div);

                if ((fPrev && !fNext) || (!fPrev && fNext))
                {
                    counterPairs++;
                }

                fPrev = fNext;
            }

            return counterPairs;
        }
    }
}
