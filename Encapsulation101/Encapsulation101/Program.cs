namespace Encapsulation101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John");

            Console.WriteLine(person.Name);// Access via public property

            person.Name = "Jane";
            Console.WriteLine(person.Name);// Modify the value via public property
        }
    }

    public class Person
    {
        // Private field
        private string _name;

        // Public property
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }

        // Constructor
        public Person(string name)
        {
            Name = name;
        }
    }
}