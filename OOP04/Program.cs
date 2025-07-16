using System.ComponentModel.DataAnnotations;

namespace OOP04
{
    public class Program
    {
        #region Part01
        #region Question01

        #endregion

        #region Question02

        #endregion

        #region Question03

        #endregion

        #region Question04

        #endregion

        #region Question05

        #endregion

        #region Question06

        #endregion

        #region Question07

        #endregion

        #region Question08

        #endregion

        #region Question09

        #endregion

        #region Question010

        #endregion
        #endregion

        #region Part02

        #region Question01
        //Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two interfaces, ICircle and IRectangle,
        ///that inherit from IShape. Implement these interfaces in classes Circle and Rectangle
        ///Test your implementation by creating instances of both classes and displaying their shape information.
        public interface Ishape
        {
            double area { get; }
            void DisplayShapeInfo();
        }
        //interface circle
        public interface ICircle : Ishape { }
        //interface rectangle
        public interface IRectangle : Ishape { }

        //the circle class
        public class Circle : ICircle
        {
            public double area { get; set; }
            public Circle(double area) { this.area = area; }
            public double Radius => Math.PI * area * area;
            public void DisplayShapeInfo()
            {
                Console.WriteLine($"the radius of the circle is: {Radius}, and the area of the rectangle is: {area}");
            }
        }
        //now just copy paste the circle interface and edit it and just add the width and edit the area
        public class Rectangle : IRectangle
        {
            public double Length { get; set; }
            public double Width { get; set; }
            public double area => Length * Width;

            public Rectangle(double length, double width)
            {
                this.Length = length;
                this.Width = width;
            }

            public void DisplayShapeInfo()
            {
                Console.WriteLine($"The width of the rectangle is: {Width}, the length of the rectangle is: {Length}, and the area is: {area}");
            }
        }
        public static void Main(string[] args)
        {
            #region part02
            #region Question01
            // Fix: Use the correct types instead of 'object' to call the method
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(5, 10);

            // Call the method directly on the correct types
            circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();
            #endregion
            #endregion
        }
    }
}