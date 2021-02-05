using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_UML { 

public enum ShapeType { LINE, CIRCLE, RECTANGLE, TRIANGLE };

public class ShapeFactory
{

        public IGeometricShape GetShape(ShapeType type) {
            if (ShapeType.CIRCLE == type) { Circle shape = new Circle(); shape.draw(); }
            if (ShapeType.RECTANGLE == type) { Rectangle shape = new Rectangle(); shape.draw(); }
            if (ShapeType.LINE == type) { Line shape = new Line(); shape.draw(); }
            if (ShapeType.TRIANGLE == type) { Console.WriteLine("We can't make that shape"); }
            return null;
    }
    
}
public interface IGeometricShape
{
    void draw();
}
    class Line : IGeometricShape
    {
        public void draw()
        {
        Console.WriteLine("Line is drawn");
        }
    }
    class Circle : IGeometricShape
    {
        public void draw()
        {
            Console.WriteLine("Circle is drawn");
        }
    }
    class Rectangle : IGeometricShape
    {
        public void draw()
        {
        Console.WriteLine("Rectangle is drawn");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory Shape = new ShapeFactory();
            Shape.GetShape(ShapeType.LINE);
            Shape.GetShape(ShapeType.CIRCLE);
            Shape.GetShape(ShapeType.RECTANGLE);
            Shape.GetShape(ShapeType.TRIANGLE);
            Console.ReadKey();
        }
    }
}
