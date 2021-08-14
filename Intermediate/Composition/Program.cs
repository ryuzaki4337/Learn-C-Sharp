using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var tObj = new Teacher(new Person());
            var sObj = new Student(new Person());
            tObj.nameTeacher();
            sObj.nameStudent();
        }
    }
}
