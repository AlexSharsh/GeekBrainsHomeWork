using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using HomeWorkAccountStruct;

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
        public static bool isValidAuthentication(string login, string password)
        {
            return ((MyLogin.Equals(login)) && (MyPassword.Equals(password))) ? true : false;
        }


        /// <summary>
        /// Проверка логина и пароля из файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="user">Аккаунт пользователя</param>
        /// <returns></returns>
        public static int isValidAuthenticationFromFile(string path, AccountStruct user)
        {
            if (!File.Exists(path))
                return -1;

            StreamReader sr = new StreamReader(path);
            string file = sr.ReadToEnd();
            sr.Close();

            bool fLogin = CheckPattern(file, "Login:", user.Login);
            bool fPassword = CheckPattern(file, "Password:", user.Password);

            if (fLogin & fPassword)
                return 1;

            return 0;
        }

        /// <summary>
        /// Проверка паттерна
        /// </summary>
        /// <param name="sourceStr">Исходная строка</param>
        /// <param name="preStr">Паттерн поиска</param>
        /// <param name="searchStr">Искомая строка</param>
        /// <returns></returns>
        private static bool CheckPattern(string sourceStr, string preStr, string searchStr)
        {
            int i;
            int idx = sourceStr.IndexOf(preStr);
            int counter = 0;

            if(idx >= 0)
            {
                for (i = 0; i < searchStr.Length; i++)
                {
                    if (sourceStr[idx + preStr.Length + i] == searchStr[i])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (counter == searchStr.Length)
                {
                    if((sourceStr.Length - idx - preStr.Length) > counter)
                    {
                        if (sourceStr[idx + preStr.Length + i] < 0x20)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if ((sourceStr.Length - idx - preStr.Length) == counter)
                        {
                            return true;
                        }
                    }
                    
                }
            }

            return false;
        }

        /// <summary>
        /// Проверка логина на соответсвие паттерну: A-Z a-z 0-9 и первый символ не цифра
        /// </summary>
        /// <param name="login">Логин</param>
        /// <returns>false/true - не соответствует/соответствует</returns>
        public static bool CheckLogin(string login)
        {
            if((2 <= login.Length) && (login.Length <= 10))
            {
                if (!(('0' <= login[0]) & (login[0] <= '9')))
                {
                    for (int i = 0; i < login.Length; i++)
                    {
                        if(!((('0' <= login[i]) & (login[i] <= '9')) || (('A' <= login[0]) & (login[0] <= 'Z')) || (('a' <= login[0]) & (login[0] <= 'z'))))
                        {
                            return false;
                        }
                    }

                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Проверка логина на соответсвие паттерну: A-Z a-z 0-9 и первый символ не цифра
        /// </summary>
        /// <param name="login">Логин</param>
        /// <returns>false/true - не соответствует/соответствует</returns>
        public static bool CheckLoginPattern(string login)
        {
            string pattern = "^[A-Za-z]{1}[0-9A-Za-z]{1,9}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(login);
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
        public static void Input(String outStr, ref double num)
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

        public static void InputPupil(String outStr, out string str)
        {
            Regex regex = new Regex(@"^[А-Яа-я]{1,20}\s[А-Яа-я]{1,15}\s[0-5]{1}\s[0-5]{1}\s[0-5]{1}$");

            Console.Write(outStr);

            while (true)
            {
                str = Console.ReadLine();

                if (regex.IsMatch(str))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введенные данные не соответсвуют формату, повторите ввод");
                }
            }
        }

        /// <summary>
        /// Запрос на ввод числа
        /// </summary>
        /// <param name="outStr">Информационная строка</param>
        /// <param name="num">Указаетль на переменную</param>
        public static void Input(String outStr, out string str)
        {
            Console.Write(outStr);
            str = Console.ReadLine();
        }

        /// <summary>
        /// Запрос на ввод символа
        /// </summary>
        /// <param name="outStr">Информационная строка</param>
        /// <param name="num">Указаетль на переменную</param>
        public static void Input(String outStr, out char ch)
        {
            string input;
            string pattern = "^[A-Za-zА-Яа-я]{1}$";
            Regex regex = new Regex(pattern);


            Console.Write(outStr);

            while(true)
            {
                input = Console.ReadLine();
                if (!regex.IsMatch(input))
                {
                    Console.WriteLine("Введен некорректный символ, повторите ввод");
                }
                else
                {
                    break;
                }
            }
            
            ch = input[0];
        }

        /// <summary>
        /// Запрос на ввод числа
        /// </summary>
        /// <param name="outStr">Информационная строка</param>
        /// <param name="num">Указаетль на переменную</param>
        public static void Input(String outStr, ref int num)
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
        /// Преобразование строки в массив слов
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Массив слов</returns>
        public static string[] StringToWordsArray(string str)
        {
            char[] separators = { ' ', '.', ',', ':', ';', '!', '?' };
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            return words;
        }

        /// <summary>
        /// Является ли одна строка перестановкой другой
        /// </summary>
        /// <param name="str1">Строка 1</param>
        /// <param name="str2">Строка 2</param>
        /// <returns></returns>
        public static bool IsPermutationOfLetters(string str1, string str2)
        {
            if(str1.Length == str2.Length)
            {
                StringBuilder sb = new StringBuilder(str1);

                int j;
                for (int i = 0; i < str1.Length; i++)
                {
                    for (j = 0; j < str2.Length; j++)
                    {
                        if(str1[i] == str2[j])
                        {
                            sb.Remove(0, 1);
                            break;
                        }
                    }

                    if (j == str2.Length)
                        return false;
                }

                if(sb.Length == 0)
                {
                    return true;
                }
            }
            
            return false;
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
        /// Печать коллекции
        /// </summary>
        /// <param name="dict">Коллекция</param>
        public static void PrintDictionary(Dictionary<int, int> dict)
        {
            Console.WriteLine("Значение:\tКол-во вхождений:");
            foreach (KeyValuePair<int, int> i in dict)
            {
                Console.WriteLine($"\t{i.Key}\t\t\t{i.Value}");
            }
        }

        /// <summary>
        /// Печать коллекции
        /// </summary>
        /// <param name="dict">Коллекция</param>
        public static void PrintDictionary(Dictionary<string, int> dict)
        {
            Console.WriteLine("Значение:\tКол-во вхождений:");
            foreach (KeyValuePair<string, int> i in dict)
            {
                Console.WriteLine($"\t{i.Key}\t\t\t{i.Value}");
            }
        }

        /// <summary>
        /// Печать коллекции
        /// </summary>
        /// <param name="dict">Коллекция</param>
        public static void PrintDictionary(Dictionary<int, string> dict)
        {
            foreach (KeyValuePair<int, string> i in dict)
            {
                Console.WriteLine($"{i.Value}");
            }
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

        public static void PrintAverageScore(Dictionary<int, string> pupils)
        {
            Dictionary<int, string> Score = new Dictionary<int, string>();
            char[] separators = { ' ', '.', ',', ':', ';', '!', '?' };
            int[,] score = new int[pupils.Count, 2];

            foreach (KeyValuePair<int, string> i in pupils)
            {
                int grade1 = i.Value[i.Value.Length - 1] - 0x30;
                int grade2 = i.Value[i.Value.Length - 3] - 0x30;
                int grade3 = i.Value[i.Value.Length - 5] - 0x30;

                score[i.Key, 0] = i.Key;
                score[i.Key, 1] = (grade1 + grade2 + grade3) / 3;
            }

            int min = score[0, 1];
            for(int i = 0; i < pupils.Count; i++)
            {
                if(min > score[i, 1])
                {
                    min = score[i, 1];
                }
            }

            int counter = 0;
            int realMin = min;
            for ( ; ; min++)
            {
                if (min > 5)
                    break;

                foreach (KeyValuePair<int, string> j in pupils)
                {
                    if (counter >= 3)
                    {
                        if (realMin != min)
                        {
                            return;
                        }
                    }

                    if (min == score[j.Key, 1])
                    {
                        string[] words = j.Value.Split(separators);
                        Console.WriteLine($"{words[0]} {words[1]} {score[j.Key, 1]}");
                        counter++;

                        if(counter == 3)
                        {
                            realMin = min;
                        }
                    }
                }
            }
        }
    }
}
