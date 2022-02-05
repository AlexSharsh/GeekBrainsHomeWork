using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComplexClass
{
    public class ComplexClass
    {
        /// <summary>
        /// Минмая часть комплексного числа
        /// </summary>
        private double im;

        /// <summary>
        /// Действительная часть  комплексного числа
        /// </summary>
        private double re;

        public double Re
        {
            get
            {
                return re;
            }

            set
            {
                re = value;
            }
        }

        public double Im
        {
            get
            {
                return im;
            }

            set
            {
                im = value;
            }
        }

        public ComplexClass()
        {

        }

        public ComplexClass(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public ComplexClass Plus(ComplexClass x)
        {
            return new ComplexClass(re + x.re, im + x.im);
        }

        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public ComplexClass Minus(ComplexClass x)
        {
            return new ComplexClass(re - x.re, im - x.im);
        }

        /// <summary>
        /// Умножение комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public ComplexClass Mul(ComplexClass x)
        {
            // z1= a1 + b1i
            // z2= a2 + b2i
            // z = z1 * z2 = (a1a2 + b1b2) + (a1b2 + b1a2)i
            return new ComplexClass(re * x.re + im * x.im, re * x.im + im * x.re);
        }

        /// <summary>
        /// Переопределение функции ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            String str = "";
            if (re != 0)
            {
                str += $"{re}";
            }

            if ((re != 0) && (im != 0))
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
