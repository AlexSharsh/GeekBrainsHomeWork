using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStudent
{
    internal class Student
    {
        public string name;
        public string surname;
        public string university;
        int age;
        public int course;

        // Создаем конструктор
        public Student(string firstName, string lastName, string university, string faculty, string department, int course, int age, int group, string city)
        {
            this.name = lastName;
            this.surname = firstName;
            this.university = university;
            this.age = age;
            this.course = course;
        }
    }
}
