using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWorkArrayClassLib
{
    public class ArrayClassLib
    {
        #region Поля
        private int[] arr;


        #endregion


        #region Конструкторы
        public ArrayClassLib(int[] arr)
        {
            this.arr = arr;
        }

        /// <summary>
        /// Конструктор класса: заполняет массив значениями в зависимости от режима mode
        /// </summary>
        /// <param name="arraySize"></param>
        /// <param name="Val1">При mode = 0 - начальное значения заполнения; при mode = 1 - минимальное значение случайного заполнения</param>
        /// <param name="Val2">При mode = 0 - шаг заполнения; при mode = 1 - максимальное значение случайного заполнения</param>
        /// <param name="mode">Режим работы конструктора: 0 - заполнение массива от заданного начального значения с заданным шагом
        ///                                               1 - заполнение случайными числами в заданном диапазоне</param>
        public ArrayClassLib(int arraySize, int Val1, int Val2, int mode)
        {
            this.arr = new int[arraySize];

            if (mode == 0)
            {
                arr[0] = Val1;
                for (int i = 1; i < arr.Length; i++)
                {
                    arr[i] = arr[i - 1] + Val2;
                }
            }
            else if (mode == 1)
            {
                Random r = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = r.Next(Val1, Val2);
                }
            }
        }

        public ArrayClassLib(string fileName)
        {
            this.arr = LoadArrayFromFile(fileName);
        }
        #endregion


        #region Свойства
        /// <summary>
        /// Доступ у элементам массива по индексу
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <returns></returns>
        public int this[int index]
        {
            get
            {
                return arr[index];
            }

            set
            {
                arr[index] = value;
            }
        }

        /// <summary>
        /// Сумма элементов массива
        /// </summary>
        public int Sum
        {
            get
            {

                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }
        }


        public int MaxCount
        {
            get
            {
                int MaxVal = 0, Counter = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > MaxVal)
                    {
                        MaxVal = arr[i];
                        Counter = 1;
                    }
                    else if (arr[i] == MaxVal)
                    {
                        Counter++;
                    }
                }
                return Counter;
            }
        }
        #endregion


        #region Скрытые методы
        /// <summary>
        /// Считать массив из файла
        /// </summary>
        /// <param name="fileName">Путь к файлу</param>
        /// <returns></returns>
        private int[] LoadArrayFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                return null;

            int[] arr = new int[1000];
            int counter = 0;

            StreamReader sr = new StreamReader(fileName);

            while (!sr.EndOfStream)
            {
                int number = int.Parse(sr.ReadLine());
                arr[counter] = number;
                counter++;
                if (counter >= arr.Length)
                    break;
            }

            int[] buf = new int[counter];
            Array.Copy(arr, buf, counter);

            sr.Close();

            return buf;
        }
        #endregion


        #region Публичные методы
        /// <summary>
        /// Получить элемент массива
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <returns></returns>
        public int GetElement(int index)
        {
            return arr[index];
        }

        /// <summary>
        /// Установить элемент массива
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <param name="value">Значение</param>
        public void SetElement(int index, int value)
        {
            arr[index] = value;
        }

        /// <summary>
        /// Распечатать массив
        /// </summary>
        public void PrintArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Получение статистики по кол-ву вхождений чисел в массив
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, int> GetStatistics()
        {
            Dictionary<int, int> Statistics = new Dictionary<int, int>();
            int[] arrSort = Sort();
            int lastVal = 0;
            int counter = 1;
            int key = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    Statistics.Add(key: arrSort[i], value: counter);
                    key = arrSort[i];
                }
                else
                {
                    if (lastVal == arrSort[i])
                    {
                        counter++;
                        Statistics[key] = counter;
                    }
                    else
                    {
                        counter = 1;
                        key = arrSort[i];
                        Statistics.Add(key: arrSort[i], value: counter);
                    }
                }

                lastVal = arrSort[i];
            }

            return Statistics;
        }

        /// <summary>
        /// Сортировка массива
        /// </summary>
        /// <returns></returns>
        public int[] Sort()
        {
            int[] arrSort = new int[arr.Length];

            arr.CopyTo(arrSort, 0);
            Array.Sort(arrSort);

            return arrSort;
        }

        /// <summary>
        /// Инверсия массива
        /// </summary>
        /// <returns></returns>
        public int[] Inverse()
        {
            return Multi(-1);
        }

        /// <summary>
        /// Умножение элементов массива на заданное число
        /// </summary>
        /// <param name="mul">Множитель</param>
        /// <returns></returns>
        public int[] Multi(int mul)
        {
            int[] arrInv = new int[arr.Length];

            for (int i = 0; i < arrInv.Length; i++)
            {
                arrInv[i] = arr[i];
                arrInv[i] *= mul;
            }

            return arrInv;
        }
        #endregion
    }
}
