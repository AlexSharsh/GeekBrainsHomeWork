using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkHelper;
using Lesson1;
using Lesson2;
using Lesson3;
using Lesson4;


namespace HomeWorkMain
{
    internal class HomeWorkMain
    {
        public static int GetHomeWork()
        {
            int hw = 0;
            int hwAccess = 4;

            Helper.PrintStudentInfo();

            Console.WriteLine("\nСПИСОК ДОСТУПНЫХ ДОМАШНИХ РАБОТ:");
            Console.WriteLine("[0]. Выход из приложения");
            Console.WriteLine("[1]. Домашняя работа 1 (проверена преподавателем)");
            Console.WriteLine("[2]. Домашняя работа 2 (проверена преподавателем)");
            Console.WriteLine("[3]. Домашняя работа 3");
            Console.WriteLine("[4]. Домашняя работа 4");

            Console.WriteLine("\n\nВведите номер домашней работы: ");

            while (true)
            {
                hw = int.Parse(Console.ReadLine());

                if ((0 <= hw) && (hw <= hwAccess))
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

        static void Main(string[] args)
        {
            Helper.PrintTitle();

            while (true)
            {
                int HomeWork = GetHomeWork();

                switch(HomeWork)
                {
                    case 0:

                        break;

                    case 1:
                        HomeWork1.Run();
                        break;

                    case 2:
                        HomeWork2.Run();
                        break;

                    case 3:
                        HomeWork3.Run();
                        break;

                    case 4:
                        HomeWork4.Run();
                        break;

                    default:

                        break;
                }

                if (HomeWork == 0)
                    break;
            }
        }
    }
}
