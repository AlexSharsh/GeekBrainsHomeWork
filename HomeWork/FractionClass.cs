using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFractionClass
{
    class FractionClass
    {
        /// <summary>
        /// Числитель (numerator) числа
        /// </summary>
        private int num;

        /// <summary>
        /// Знаменатель (denominator) числа
        /// </summary>
        private int den;

        public int Num
        {
            get
            {
                return num;
            }

            set
            {
                num = value;
            }
        }

        public int Den
        {
            get
            {
                return den;
            }

            set
            {
                if(den == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }

                den = value;
            }
        }

        public double Dec
        {
            get
            {
                return (double)num / (double)den;
            }
        }

        public FractionClass()
        {

        }

        public FractionClass(int num, int den)
        {
            this.Num = num;
            this.den = den;
            //this.Den = den;
        }

        /// <summary>
        /// Сложение дробей
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public FractionClass Plus(FractionClass x)
        {
            return new FractionClass((num * x.den) + (x.num * den), den * x.den);
        }

        /// <summary>
        /// Вычитание дробей
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public FractionClass Minus(FractionClass x)
        {
            return new FractionClass((num * x.den) - (x.num * den), den * x.den);
        }

        /// <summary>
        /// Умножение дробей
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public FractionClass Mul(FractionClass x)
        {
            return new FractionClass(num * x.num, den * x.den);
        }

        /// <summary>
        /// Деление дробей
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public FractionClass Div(FractionClass x)
        {
            return new FractionClass(num * x.den, x.num * den); ;
        }

        /// <summary>
        /// Переопределение функции ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{num}/{den}";
        }
    }
}
