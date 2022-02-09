using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkHelper;
using HomeWorkMessage;

namespace Lesson5
{
    class HomeWork5
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
                }

                if (Task == 0)
                    break;
            }
        }

        private static int GetTasksMenu()
        {
            int hw = -1;
            int taskAccess = 4;

            Console.WriteLine("СПИСОК ЗАДАНИЙ:");
            Console.WriteLine("[0]. Выход");
            for (int i = 1; i <= taskAccess; i++)
            {
                Console.WriteLine($"[{i}]. Задание {i}");
            }

            Console.WriteLine("\nВыберите задание: ");

            while (true)
            {
                if(!int.TryParse(Console.ReadLine(), out hw))
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
            // Создать программу, которая будет проверять корректность ввода логина. 
            // Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, 
            // при этом цифра не может быть первой:
            // а) без использования регулярных выражений;
            // б) **с использованием регулярных выражений.
            #region Task1
            Console.WriteLine("ЗАДАНИЕ 1");
            Console.WriteLine("Создать программу, которая будет проверять корректность ввода логина.");
            Console.WriteLine("Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,");
            Console.WriteLine("при этом цифра не может быть первой:");
            Console.WriteLine("а) без использования регулярных выражений;");
            Console.WriteLine("б) **с использованием регулярных выражений.\n");

            string login;
            Helper.Input("Введите логин: ", out login);

            Console.WriteLine("а)");
            if (Helper.CheckLogin(login))
            {
                Console.WriteLine("Логин СООТВЕТСВУЕТ требуемому паттерну!");
            }
            else
            {
                Console.WriteLine("Логин НЕ СООТВЕТСВУЕТ требуемому паттерну!");
            }

            Console.WriteLine("\nб)");
            if (Helper.CheckLoginPattern(login))
            {
                Console.WriteLine("Логин СООТВЕТСВУЕТ требуемому паттерну!");
            }
            else
            {
                Console.WriteLine("Логин НЕ СООТВЕТСВУЕТ требуемому паттерну!");
            }


            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task2()
        {

            // ЗАДАНИЕ 2: 
            // Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            // а) Вывести только те слова сообщения, которые содержат не более n букв.
            // б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            // в) Найти самое длинное слово сообщения.
            // г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            // д) ***Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и
            //    текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. 
            //    Здесь требуется использовать класс Dictionary.
            #region Task2
            Console.WriteLine("ЗАДАНИЕ 2");
            Console.WriteLine("Разработать статический класс Message, содержащий следующие статические методы для обработки текста:");
            Console.WriteLine("а) Вывести только те слова сообщения, которые содержат не более n букв.");
            Console.WriteLine("б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.;");
            Console.WriteLine("в) Найти самое длинное слово сообщения.");
            Console.WriteLine("г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.");
            Console.WriteLine("д) ***Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и");
            Console.WriteLine("   текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.");
            Console.WriteLine("   Здесь требуется использовать класс Dictionary.\n");


            string str;
            Helper.Input("Введите строку текста: ", out str);
            Message msg = new Message(str);

            int num = 0;
            Helper.Input("\nа) Введите n (число букв в слове). Слова с кол-ом букв больше n выведены не будут: ", ref num);
            msg.PrintWordsWithLessLetters(5);

            char ch;
            Helper.Input("\nб) Введите \"символ\", слова оканчивающиеся на который будут удалены: ", out ch);
            str = msg.RemoveWordsEndsTo(ch);
            Console.WriteLine(str);

            Console.WriteLine("\nв) Самое длинное слово(а): ");
            Dictionary<int, string> LongWords = msg.GetLongWords();
            Helper.PrintDictionary(LongWords);

            Console.WriteLine($"\nг) Строка из самых длиных слов: ");
            Console.WriteLine($"{msg.GetStringFromLongWords()}");

            Console.WriteLine($"\nд) Статистика, введите слова для поиска (0-Прервать ввод): ");
            StringBuilder sb = new StringBuilder();
            string word;
            int i = 0;

            while (true)
            {
                Helper.Input("", out word);

                if (word.Equals("0"))
                {
                    break;
                }
                else
                {
                    sb.Append(word + " ");
                }

                i++;
            }

            string[] words = Helper.StringToWordsArray(sb.ToString());
            Helper.PrintDictionary(msg.GetStatistics(msg.String, words));



            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task3()
        {
            // ЗАДАНИЕ 3: 
            // *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
            // Например: badc являются перестановкой abcd.
            #region Task3
            Console.WriteLine("ЗАДАНИЕ 3");
            Console.WriteLine("*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.");
            Console.WriteLine("Например: badc являются перестановкой abcd.\n");

            string str1, str2;

            Helper.Input("Введите Строку 1: ", out str1);
            Helper.Input("Введите Строку 2: ", out str2);

            if (Helper.IsPermutationOfLetters(str1, str2))
            {
                Console.WriteLine($"\nСтрока \"{str1}\" ЯВЛЯЕТСЯ перестановкой строки \"{str2}\"");
            }
            else
            {
                Console.WriteLine($"\nСтрока \"{str1}\" НЕ ЯВЛЯЕТСЯ перестановкой строки \"{str2}\"");
            }


            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        private static void Task4()
        {
            // ЗАДАНИЕ 4: 
            // *Задача ЕГЭ.
            // На вход программе подаются сведения о сдаче экзаменов учениками 9 - х классов некоторой средней школы. 
            // В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, 
            // каждая из следующих N строк имеет следующий формат: < Фамилия > < Имя > < оценки >, где
            // < Фамилия > — строка, состоящая не более чем из 20 символов, 
            // < Имя > — строка, состоящая не более чем из 15 символов, 
            // < оценки > — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. 
            // < Фамилия > и <Имя>, а также < Имя > и < оценки > разделены одним пробелом. Пример входной строки: Иванов Петр 4 5 3
            // Требуется написать как можно более эффективную программу, 
            // которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
            // Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, 
            // следует вывести и их фамилии и имена.
            #region Task4
            Console.WriteLine("ЗАДАНИЕ 4");
            Console.WriteLine("*Задача ЕГЭ.");
            Console.WriteLine("На вход программе подаются сведения о сдаче экзаменов учениками 9 - х классов некоторой средней школы.");
            Console.WriteLine("В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100,");
            Console.WriteLine("каждая из следующих N строк имеет следующий формат: < Фамилия > < Имя > < оценки >, где");
            Console.WriteLine("< Фамилия > — строка, состоящая не более чем из 20 символов,");
            Console.WriteLine("< Имя > — строка, состоящая не более чем из 15 символов,");
            Console.WriteLine("< оценки > — через пробел три целых числа, соответствующие оценкам по пятибалльной системе.");
            Console.WriteLine("< Фамилия > и <Имя>, а также < Имя > и < оценки > разделены одним пробелом. Пример входной строки: Иванов Петр 4 5 3");
            Console.WriteLine("Требуется написать как можно более эффективную программу,");
            Console.WriteLine("которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. ");
            Console.WriteLine("Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших,");
            Console.WriteLine("следует вывести и их фамилии и имена.\n");

            int n = 0;
            Helper.Input("Введите кол-во учеников:\n", ref n);
            while (true)
            {
                if ((10 <= n) && (n <= 100))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введено число вне диапазона 10 - 100, повторите ввод");
                    Helper.Input("", ref n);
                }
            }

            int counter = 0;
            string str;
            Dictionary<int, string> pupils = new Dictionary<int, string>();
            Helper.InputPupil("Введите ФИ ученика и три оценки в формате <Фамилия> <Имя> <Оценка 1> <Оценка 2> <Оценка 3>:\n", out str);
            while (true)
            {
                pupils.Add(key: counter, value: str);

                counter++;
                if (counter == n)
                    break;

                Helper.InputPupil("", out str);
            }

            Console.WriteLine("\nСамые слабые ученики:");
            Helper.PrintAverageScore(pupils);


            Console.WriteLine("\n\n\n" + "ДЛЯ ВЫХОДА ИЗ ЗАДАНИЯ НАЖМИТЕ ЛЮБУЮ КНОПКУ");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
