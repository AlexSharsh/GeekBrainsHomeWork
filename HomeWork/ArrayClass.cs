using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWorkArrayClass
{
    internal class ArrayClass
    {
        #region Поля
        private int[] arr;


        #endregion


        #region Конструкторы
        public ArrayClass(int[] arr)
        {
            this.arr = arr;
        }

        public ArrayClass(int arraySize, int arrayStartVal, int arrayStep)
        {
            this.arr = new int[arraySize];

            arr[0] = arrayStartVal;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i-1] + arrayStep;
            }
        }

        public ArrayClass(string fileName)
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
                for(int i = 0; i < arr.Length; i++)
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
                return 0;
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
