using System.Linq;

namespace WhereClauseLing101
{
    public class MyLinqExample
    {
        public void MyMethod()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            // Using the where clause to filter numbers greater than 3
            var filteredNumbers = numbers.Where(n => n > 2);
            
            foreach (var num in filteredNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinqExample myLinqExample = new MyLinqExample();
            myLinqExample.MyMethod();
        }
    }


}
