using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Person
    {

        //private String name;
        //public String Name { get { return name; } }
        //public void Name { set { Name = value } }
        protected string Name { get; set; }
        protected Gender gender { get; set; }
        protected int BirthDate { get; set; }
        

       public enum Gender
        {
            Male,
            Female
        }



        public Person(string name, int birthDate, Gender gender)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.gender = gender;
        }

 
        public override string ToString()
        {
            string Ppronoun = getPronoun();
            String s = Ppronoun + "'s called: " + Name + " and " + Ppronoun + " was born in " + BirthDate + ".";
            return s;
        }

        protected string getPronoun()
        {
            String Ppronoun = "";
            switch (gender)
            {
                case Gender.Male:
                    Ppronoun = "He";
                    break;
                case Gender.Female:
                    Ppronoun = "She";
                    break;
            }

            return Ppronoun;
        }

        static void Main(string[] args)
        {
            Room room1 = new Room(1);
            Room room2 = new Room(2);
            Person person = new Person("Béla", 1900, Gender.Male);
            Console.WriteLine(person.ToString());
            Employee employee = new Employee("Béla", 1901, Gender.Male, 500, "Bészisztens", room1);
            
            Console.WriteLine(employee.ToString());
            
            Employee employee2 = new Employee("Anna", 1950, Gender.Female, 500, "Asszisztens", room2);
            Console.WriteLine(employee2.ToString());
            Person person2 = employee2;
           
            Console.WriteLine(person2.ToString());


            Room room3 = new Room(111);
            Employee Kovacs = new Employee("Géza", 1972, Gender.Male, 1000, "léhűtő", room3);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            room3.RoomNumber = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }

    }
}
