namespace InterfaceConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Dog dog = new Dog();
            dog.Speak();
            dog.Eat();
            dog.Sleep();
            dog = null;
            Console.ReadLine();
        }
    }

    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Woof!");
        }

        public void Eat()
        {
            Console.WriteLine("The dog is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("The dog is sleeping.");
        }
    }
}
