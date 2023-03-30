using Models;

namespace Homework_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape unknownShape = new Shape("UnknownShape", "pink", -2, -2);
            Rectangle rectangle = new Rectangle("Rectangle", "red", 0, 0, 15, 10);
            Circle circle = new Circle("Circle", "green", 5, 5, 20);

            unknownShape.GetArea();
            unknownShape.GetPerimeter();
            unknownShape.Move();

            rectangle.GetArea();
            rectangle.GetPerimeter();
            rectangle.Move();

            circle.GetArea();
            circle.GetPerimeter();
            circle.Move();

            // Testing the getter and setter on the Name - property:
            Console.WriteLine($"The name before changing: {unknownShape.Name}");

            unknownShape.Name = "1"; // Trying to set a new name, but it won't pass the validation because it's a number
            Console.WriteLine($"The name after trying it to be changed with numbers: {unknownShape.Name}");

            unknownShape.Name = "NewName"; // Successful setting
            Console.WriteLine($"The name after changing: {unknownShape.Name}");


            // Testing the getter and setter on the Color - property:
            Console.WriteLine($"The color before changing: {rectangle.Color}");

            rectangle.Color = "/"; // Trying to set a new color, but it won't pass the validation because it's not only with letters
            Console.WriteLine($"The color after trying it to be changed with /: {rectangle.Color}");

            rectangle.Color = "White"; // Successful setting
            Console.WriteLine($"The color after changing: {rectangle.Color}");


        }
    }
}