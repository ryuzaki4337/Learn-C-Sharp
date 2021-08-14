namespace Composition
{
    public class Student
    {
        private readonly Person p;

        public Student(Person p)
        {
            this.p = p;
        }

        public void nameStudent()
        {
            p.getName("Charlie");
        }
    }
}
