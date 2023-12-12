namespace WhereClause101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.MyGenericMethod(new MyParentClass());
            
            Console.WriteLine("Hello, World in Main method!");
        }
    }

    public class MyClass
    {
        // This method accepts a generic type T, but with a constraint that T must be a subclass of MyParentClass
        public void MyGenericMethod<T>(T myParameter) where T : MyParentClass
        {
            myParameter.MyProperty = "Hello, World in MyGenericMethod!";
            // Method implementation
            Console.WriteLine(myParameter.MyProperty);
        }
    }
    
    public class MyParentClass
    {
        // Class implementation
        public string MyProperty { get; set; }
    }
}
