namespace Lesson15___Interface_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // public private internal protected

            Student student = new Student();
            student.Id = 9;

            Teacher teacher = new Teacher();
            //teacher.FirstName = "Ramiz";

            Person person = new Person();
            //person.Add(new Teacher(), new NewTeachable());

            ITeachable[] teachables = new ITeachable[2] { new Teachable(), new NewTeachable() };

            foreach (var teachable in teachables)
            {
                teachable.GiveScholarship();
            }
        }
    }
}

