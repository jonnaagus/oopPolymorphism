using System.Drawing;

// Elev: Jonna Gustafsson 
// Klass: .NET23

namespace oopPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry geometryObject;

            // Creates an instance of Circle and lets the object reference point to it
            Circle circle = new Circle();
            geometryObject = circle;

            // Calls the Area method through the object reference to calculate and print the area of the Circle
            double circleArea = geometryObject.Area();
            Console.WriteLine("Arean på denna Cirkel är: " + circleArea);

            // Creates an instance of Ellipse and lets the object reference point to it
            Ellipse ellipse = new Ellipse();
            geometryObject = ellipse;

            // Calls the Area method through the object reference to calculate and print the area of the Ellipse
            double ellipseArea = geometryObject.Area();
            Console.WriteLine("Arean på denna Ellips är: " + ellipseArea);

            // Creates an instance of Square and lets the object reference point to it
            Square square = new Square();
            geometryObject = square;

            // Calls the Area method through the object reference to calculate and print the area of the Square
            double squareArea = geometryObject.Area();
            Console.WriteLine("Arean på Fyrkanten är: " + squareArea);

            //Creates an instance of Parallellogram and lets the object reference point to it
            Parallellogram parallellogram = new Parallellogram();
            geometryObject = parallellogram;

            // Calls the Area method through the object reference to calculate and print the area of the Parallellogram
            double parallellogramArea = geometryObject.Area();
            Console.WriteLine("Arean på detta Parallellogram är: " + parallellogramArea);

            // Creates an instance of Rectangle and lets the object reference point to it
            Rectangle rectangle = new Rectangle();
            geometryObject = rectangle;

            // Calls the Area method through the object reference to calculate and print the area of the Rectangle
            double rectangleArea = geometryObject.Area();
            Console.WriteLine("Arean på Rektangeln är: " + rectangleArea);

        }
 
    }

}