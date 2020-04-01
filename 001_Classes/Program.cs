using System;

namespace _001_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
