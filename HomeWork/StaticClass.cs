using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HomeWorkHelper;

namespace HomeWorkStaticClass
{
    internal class StaticClass
    {
        #region Поля

        #endregion


        #region Свойства

        #endregion


        #region Конструкторы
        public StaticClass()
        {

        }

        public StaticClass(string path, int size, int min, int max)
        {            
            Random r = new Random();

            StreamWriter sw = new StreamWriter(path);

            for(int i = 0; i < size; i++)
            {
                sw.WriteLine(r.Next(min, max));
            }

            sw.Close();
        }
        #endregion


        #region Методы
        public bool FillArrayFormFile(int[] arr, string path)
        {
            if (!File.Exists(path))
                return false;

            StreamReader sr = new StreamReader(path);

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(sr.ReadLine());
            }

            sr.Close();

            return true;
        }

        public int PrintArrayAndGetPairs(int[] arr, int div, ConsoleColor color)
        {
            Helper.PrintArrayAndHighlight(arr, div, color);
            int counterPairs = Helper.GetPairs(arr, div);
            Console.WriteLine($"Кол-во пар: {counterPairs}");

            return counterPairs;
        }
        #endregion
    }
}
