﻿using System;

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

            #region Task 2

            Rectangle rect = new Rectangle(10.0, 10.0);
            Console.WriteLine($"Площадь прямоугольника со сторонами 10 и 10 = {rect.Area}");
            Console.WriteLine($"Периметр прямоугольника со сторонами 10 и 10 = {rect.Perimeter}");

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
