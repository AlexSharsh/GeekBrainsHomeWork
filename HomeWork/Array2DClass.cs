using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWorkArray2DClass
{
    internal class Array2DClass
    {
        #region Поля
        private int[,] arr;


        #endregion


        #region Конструкторы
        public Array2DClass(int[,] arr)
        {
            this.arr = arr;
        }


        public Array2DClass(int arraySize1, int arraySize2, int min, int max)
        {
            this.arr = new int[arraySize1, arraySize2];
            Random r = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(min, max);
                } 
            }
        }
        #endregion


        #region Свойства
        /// <summary>
        /// Доступ у элементам массива по индексу
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <returns></returns>
        public int this[int index1, int index2]
        {
            get
            {
                return arr[index1, index2];
            }

            set
            {
                arr[index1, index2] = value;
            }
        }

        public int MinValue
        {
            get
            {
                int minVal = arr[0, 0];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if(minVal > arr[i, j])
                        {
                            minVal = arr[i, j];
                        }
                    }
                }
                return minVal;
            }
        }

        public int MaxValue
        {
            get
            {
                int maxVal = arr[0, 0];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (maxVal < arr[i, j])
                        {
                            maxVal = arr[i, j];
                        }
                    }
                }
                return maxVal;
            }
        }
        #endregion


        #region Скрытые методы

        #endregion


        #region Публичные методы
        public void GetMaxElementNumber(out int iMax, out int jMax)
        {
            int maxVal = arr[0, 0];
            iMax = 0;
            jMax = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (maxVal < arr[i, j])
                    {
                        maxVal = arr[i, j];
                        iMax = i;
                        jMax = j;
                    }
                }
            }
        }

        public int Sum()
        {
            int Sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Sum += arr[i, j];
                }
            }

            return Sum;
        }

        public int SumOfMoreThenElement(int idx1, int idx2)
        {
            int Sum = 0;

            for (int j = idx2 + 1; j < arr.GetLength(1); j++)
            {
                Sum += arr[idx1, j];
            }

            for (int i = idx1 + 1; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Sum += arr[i, j];
                }
            }

            return Sum;
        }

        public void PrintArray()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if(i != 0)
                    Console.Write(", ");

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(j == 0)
                        Console.Write("{");

                    Console.Write($"{arr[i,j]}");

                    if ((j + 1) < arr.GetLength(1))
                        Console.Write(" ");

                    if ((j + 1) == arr.GetLength(1))
                        Console.Write("}");
                }
                //Console.WriteLine();
            }
        }
        #endregion
    }
}
