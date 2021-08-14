namespace Composition
{
    public class Teacher
    {
        private readonly Person p;

        public Teacher(Person p)
        {
            this.p = p;
        }

        public void nameTeacher()
        {
            p.getName("Jessi");
        }
    }
}
