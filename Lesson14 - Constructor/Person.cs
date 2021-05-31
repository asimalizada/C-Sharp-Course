namespace Lesson14___Constructor
{
    public class Person
    {
        public Person(int age, string firstName, string lastName)
        {
            this.Age = age;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person(string fatherName, string firstName, string lastName)
        {
            this.FatherName = fatherName;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person(int age, string firstName, string lastName, string fatherName) : this(age, firstName, lastName)
        {
            this.FatherName = fatherName;
        }

        public Person()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }

        public int Age { get; set; }
    }
}