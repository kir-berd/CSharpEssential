using System;

namespace _002_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("RE1F", "Kir", "B", "25");
            user1.OutputUserData();
        }
    }

    #region Additional task

    class User
    {
        private string login;
        public string Login 
        { 
            get { return login; }
        }

        private string firstName;
        public string FirstName 
        { 
            get { return firstName; }
        }

        private string lastName;
        public string LastName 
        { 
            get { return lastName; } 
        }

        private string age;
        public string Age
        {
            get { return age; }
        }

        private readonly DateTime dateFill;
        public DateTime DateFill
        {
            get { return dateFill; }
        }

        public User(string login, string firstName, string lastName, string age)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;

            DateTime dateFill = DateTime.Now;
            this.dateFill = dateFill;
        }

        public void OutputUserData()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Login: {0}", login);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Firstname: {0}", firstName);
            Console.WriteLine("Lastname: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Date of the created: {0}", dateFill);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    #endregion
}
