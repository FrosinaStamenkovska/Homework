
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Models
{
    public class Shape
    {
        private string _name;
        private string _color;

        public string Name {
            get { return _name; }  
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    _name = value;
                } 
            }
        }
       
        public string Color
        {
            get { return _color; }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    _color = value;
                }
            }
        }
        public int[] Position { get; set; }

        public Shape(string name, string color, int x_coordinate, int y_coordinate) 
        {
            _name = name;
            _color = color;
            Position = new int[] { x_coordinate, y_coordinate };
        }

        public virtual void GetArea()
        {
            Console.WriteLine("There is no special implementation for area");
        }

        public virtual void GetPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter");
        }

        public void Move()
        {
            Position[0] += 5;
            Position[1] += 5;
            Console.WriteLine($"Coordinate x new position: {Position[0]}");
            Console.WriteLine($"Coordinate y new position: {Position[1]}");
        }

    }
}
