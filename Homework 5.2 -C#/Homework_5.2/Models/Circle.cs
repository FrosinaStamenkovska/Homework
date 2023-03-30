
namespace Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(string name, string color, int x_coordinate, int y_coordinate, double radius)
            :base(name, color, x_coordinate, y_coordinate)
        {
            Radius = radius;
        }

        public override void GetArea()
        {
            double pi = 3.14;
            double area = Radius * Radius * pi;
            Console.WriteLine($"The area of the circle is: {area}");
        }
        public override void GetPerimeter() 
        {
            double pi = 3.14;
            double perimeter = Radius * 2 * pi;
            Console.WriteLine($"The perimeter of the circle is: {perimeter}");
        }

    }
}
