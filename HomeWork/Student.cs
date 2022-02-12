using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStudent
{
    internal class Student
    {
        #region Поля
        public string name;
        public string surname;
        public string university;
        public int age;
        public int course;
        #endregion

        #region Конструкторы
        public Student(string name, string surname, string university, int age, int course)
        {
            this.name = name;
            this.surname = surname;
            this.university = university;
            this.age = age;
            this.course = course;
        }
        #endregion

        #region Свойства
        
        #endregion

        #region Публичные методы
        /// <summary>
        /// Получение кол-ва магистров: магистр - если курс >= 5
        /// </summary>
        /// <param name="students">Список студентов</param>
        /// <returns>Кол-во магистров</returns>
        public static int GetMagistrs(List<Student> students)
        {
            int magistrs = 0;

            for(int i = 0; i < students.Count; i++)
            {
                if(students[i].course >= 5)
                {
                    magistrs++;
                }
            }

            return magistrs;
        }

        /// <summary>
        /// Получить кол-во студентов учащихся на запрошенном курсе
        /// </summary>
        /// <param name="students">Список студентов</param>
        /// <param name="course">Курс</param>
        /// <returns>Кол-во студентов</returns>
        public static int GetCourse(List<Student> students, int course)
        {
            int count = 0;

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].course == course)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Получить кол-во студентов в диапазоне возрастов
        /// </summary>
        /// <param name="students">Список студентов</param>
        /// <param name="minAge">Минимальный возраст</param>
        /// <param name="maxAge">Максимальный возраст</param>
        /// <returns></returns>
        public static int GetStudentInRangeAge(List<Student> students, int minAge, int maxAge)
        {
            int count = 0;

            for (int i = 0; i < students.Count; i++)
            {
                if ((minAge <= students[i].age) && (students[i].age <= maxAge))
                {
                    count++;
                }
            }

            return count;
        }


        public static Dictionary<int, int> GetStatisticsInRangeAge(List<Student> students, int minAge, int maxAge)
        {
            Dictionary<int, int> Statistics = new Dictionary<int, int>();

            for (int i = minAge; i <= maxAge; i++)
            {
                    Statistics.Add(key:i, value:0);
            }

            for (int i = 0; i < students.Count; i++)
            {
                if ((minAge <= students[i].age) && (students[i].age <= maxAge))
                {
                    Statistics[students[i].age]++;
                }
            }

            return Statistics;
        }

        public static Dictionary<int, int> GetStatisticsInRangeAgeByCourse(List<Student> students, int minAge, int maxAge)
        {
            Dictionary<int, int> Statistics = new Dictionary<int, int>();

            for (int i = 0; i < students.Count; i++)
            {
                if ((minAge <= students[i].age) && (students[i].age <= maxAge))
                {
                    try
                    {
                        Statistics[students[i].course]++;
                    }
                    catch (Exception e)
                    {
                        Statistics.Add(students[i].course, 1);
                    }
                }
            }

            return Statistics;
        }

        public static void Print(string str, Dictionary<int, int> stat)
        {
            int i = 0;
            Console.Write(" (");
            foreach (KeyValuePair<int, int> item in stat)
            {
                if(i++ != 0)
                    Console.Write("; ");
                Console.Write($"{item.Key}{str}:{item.Value}");
            }
            Console.Write(")");
        }

        public static void Print(List<Student> list)
        {
            Console.WriteLine("*      Имя      *     Фамилия   *     Университет    * Возраст * Курс");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{list[i].name,15} {list[i].surname,15} {list[i].university,20} {list[i].age,7} {list[i].course,6}");
            }
        }
        #endregion
    }
}
