using System.Text;
using DrawingApplication;

namespace ShapesApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set up drawing surface
            var canvas = new Canvas();
            canvas.AddRectangle(10, 10, 30, 40);
            canvas.AddSquare(15, 30, 35);
            canvas.AddEllipse(100, 150, 300, 200);
            canvas.AddCircle(1, 1, 300);
            canvas.AddTextbox(5, 5, 200, 100, "sample text");

            // Create a description of the drawing surface
            var builder = new StringBuilder();
            foreach (var widget in canvas.Widgets)
            {
                builder.AppendLine(widget.ToString());
            }

            // Output requested description from application
            var separator = new string('-', 64);
            Console.WriteLine(separator);
            Console.WriteLine("Requested Drawing");
            Console.WriteLine(separator);
            Console.Write(builder.ToString());
            Console.WriteLine(separator);
            Console.ReadKey();
        }
    }
}