
namespace AbstractClass101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入半徑：");
            double radius = double.Parse(Console.ReadLine());

            Circle circle = new Circle(radius);
            Console.WriteLine("圓面積：" + circle.CalculateArea());
            Console.WriteLine("圓周長：" + circle.CalculatePerimeter());

            Console.WriteLine("輸入寬：");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("輸入高：");
            double height = double.Parse(Console.ReadLine());
            
            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine("矩形面積：" + rectangle.CalculateArea());
            Console.WriteLine("矩形周長：" + rectangle.CalculatePerimeter());
        }
    }

    /// <summary>
    /// Circle class
    /// </summary>
    class Circle : Shape
    {
        public double Radius { get; set; }

        /// <summary>
        /// Constructor for Circle
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// implementation of abstract method
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        /// <summary>
        /// implementation of abstract method
        /// </summary>
        /// <returns></returns>
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
