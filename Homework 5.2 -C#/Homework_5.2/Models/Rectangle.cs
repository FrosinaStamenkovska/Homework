namespace Models
{
    public class Rectangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public Rectangle(string name, string color, int x_coordinate, int y_coordinate, double sideA, double sideB)
        : base(name, color, x_coordinate, y_coordinate)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override void GetArea()
        {
            Console.WriteLine($"The area of the Rectangle is: {SideA * SideB}");
        }

        public override void GetPerimeter()
        {
            Console.WriteLine($"The perimeter of the Rectangle is: {SideA * 2 + SideB * 2}");
        }
    }
}
    
    

    
