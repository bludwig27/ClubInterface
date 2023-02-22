using System;

namespace ClubInterface {
    class Program
    {

        interface IClub
        {
            //Properties
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            //Methods
            public string Fullname();
        }

        class Student : IClub
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string BirthDate;
            public int Credits;
            public string Major;

            public Student()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
                BirthDate = string.Empty;
                Credits = 0;
                Major = string.Empty;
            }

            public Student(int id, string firstName, string lastName, string birthDate, int credits, string major)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                BirthDate = birthDate;
                Credits = credits;
                Major = major;
            }

            public string Fullname()
            {
                return FirstName + " " + LastName;
            }

            public void Display()
            {
                Console.WriteLine("Student ID: " + Id);
                Console.WriteLine("Student Name: " + Fullname());
                Console.WriteLine("DOB: " + BirthDate);
                Console.WriteLine("Credits: " + Credits);
                Console.WriteLine("Major: " + Major);
            }
        }

        static void Main(string[] args)
        {
            Student ludwig22 = new Student();
            ludwig22.Id = 27;
            ludwig22.FirstName = "Benjamin";
            ludwig22.LastName = "Ludwig";
            ludwig22.BirthDate = "1/5/78";
            ludwig22.Credits = 15;
            ludwig22.Major = "Computer Information Technology";

            Console.WriteLine("Student Profile (ludwig22):");
            ludwig22.Display();
        }

    }

}