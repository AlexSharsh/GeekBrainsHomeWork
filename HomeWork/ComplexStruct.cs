using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexStruct
{
    public struct Complex
    {
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        public double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public double im;

        /// <summary>
        /// Вычисление суммы комплексных чисел
        /// </summary>
        /// <param name="re">Де</param>
        /// <param name="im"></param>
        /// <returns></returns>
        public Complex Plus(Complex y)
        {
            Complex sum;
            sum.re = re + y.re;
            sum.im = im + y.im;
            return sum;
        }

        /// <summary>
        /// Вычисление разности комплексных чисел
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public Complex Minus(Complex y)
        {
            Complex minus;
            minus.re = re - y.re;
            minus.im = im - y.im;
            return minus;
        }

        /// <summary>
        /// Переопределение функции ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            String str = "";
            if(re != 0)
            {
                str += $"{re}";
            }

            if((re != 0) && (im != 0))
            {
                str += " + ";
            }

            if (im != 0)
            {
                str += $"{im}i";
            }
            return str;
        }
    }
}
