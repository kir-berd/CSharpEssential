using System;
using System.Collections.Generic;
using System.Text;

namespace _001_Classes
{
    class Address
    {
        private int index;
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

        public int Index
        {
            set
            {
                index = value;
            }
            get
            {
                return index;
            }
        }
    }
}
