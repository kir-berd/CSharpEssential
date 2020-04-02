using System;

namespace _001_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Additional task

            Address addr1 = new Address
            {
                Index = 293057,
                Country = "USA",
                City = "Los Santos",
                Street = "Groove",
                House = "13",
                Apartment = "1"
            };

            Console.WriteLine(addr1.Index);
            Console.WriteLine(addr1.Country);
            Console.WriteLine(addr1.City);
            Console.WriteLine(addr1.Street);
            Console.WriteLine(addr1.House);
            Console.WriteLine(addr1.Apartment);

            #endregion

            Console.WriteLine();

            #region Task 2

            Rectangle rect = new Rectangle(10.0, 10.0);
            Console.WriteLine($"Площадь прямоугольника со сторонами 10 и 10 = {rect.Area}");
            Console.WriteLine($"Периметр прямоугольника со сторонами 10 и 10 = {rect.Perimeter}");

            #endregion

            Console.WriteLine();

            #region Task 3

            Book book = new Book();
            book.Author = "Vasily Pupkin";
            book.Title = "Fish text";
            book.Body = "Lorem ipsum dolor sit amet";
            book.Show();

            Book book2 = new Book();
            book2.Author = "Ivanov Ivan Ivanovich";
            book2.Title = "My book";
            book2.Body = "Cool content";
            book2.Show();

            Book book3 = new Book();
            book3.Show();

            #endregion
        }
    }

    // Task 2
    class Rectangle
    {
        double side1, side2;
        private double area;
        private double perimeter;

        public double Area
        {
            get
            {
                return area;
            }
        }
        public double Perimeter
        {
            get
            {
                return perimeter;
            }
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;

            this.area = AreaCalculate();
            this.perimeter = PerimeterCalculate();
        }

        double AreaCalculate()
        {
            return side1 * side2;
        }

        double PerimeterCalculate()
        {
            return (side1 + side2) * 2;
        }
    }
}
